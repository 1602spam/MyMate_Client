using ClientModules.Containers;
using ClientModules.Models;
using ClientModules.Models.Chat;
using ClientModules.Services;
using ClientToServer;
using Protocol;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static Protocol.ServerProtocol;

namespace MainForm.Controls
{
    public partial class MsgPage : UserControl
    {
        public MdlServer? Server { get; set; }
        public MdlChatroom? Chatroom { get; set; }
        public List<Lchat> lchats = new();
        public List<Rchat> rchats = new();
        public List<UserChatListItem> UserChatListItems = new();
        public int Count { get; set; }
        public MsgPage()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            this.Visible = false;

            ServerContainer.Instance.DataDistributedEvent += AddOrUpdateUserChat;
            //테스트용 서버 1과 그 안의 채팅방 1을 생성
            MdlServer s = new(ServerContainer.Instance.Items.Count + 1, true, "테스트용 서버", 1);
            SvcDistributor.Instance.PutServer(s);
            SvcDistributor.Instance.PutChatroom(new(s.Chatrooms.Items.Count + 1, s.Code, "테스트용 채팅방 1"));

            this.Server = s;

            DateTime d = DateTime.Now;
            SvcDistributor.Instance.PutMessage(new MdlMessage(0, 1, 1, 1, "메시지 1", new DateTime(d.Year - 1, d.Month, d.Day, d.Hour, d.Minute, d.Second)));
            SvcDistributor.Instance.PutMessage(new MdlMessage(1, 1, 1, 1, "메시지 1", new DateTime(d.Year, d.Month, d.Day - 2, d.Hour, d.Minute, d.Second)));
            SvcDistributor.Instance.PutMessage(new MdlMessage(2, 1, 1, 1, "메시지 1", new DateTime(d.Year, d.Month, d.Day - 1, d.Hour, d.Minute, d.Second)));
            SvcDistributor.Instance.PutMessage(new MdlMessage(3, 1, 1, 1, "메시지 1", d));
            SvcDistributor.Instance.PutMessage(new MdlMessage(4, 1, 1, MdlMyself.Instance.Code, "메시지 1", d));
            SvcDistributor.Instance.PutMessage(new MdlMessage(5, 1, 1, MdlMyself.Instance.Code, "메시지 1", d));

            SwitchChat(s.Code);
        }

        void Send()
        {
            if (Chatroom == null)
                return;

            if (chatTxt.Text.Trim().Length == 0)
                return;

            MdlMyself me = MdlMyself.Instance;

            MessageProtocol.MESSAGE msg = new();
            msg.Set(this.Chatroom.Messages.Items.Count + 1, this.Server.Code, this.Chatroom.Code, me.Code, chatTxt.Text, DateTime.Now, false);
            ClientToServer.Server.Instance.Send(Generater.Generate(msg));
            SvcDistributor.Instance.PutMessage(new(msg));
            chatTxt.Text = String.Empty;
        }

        private void MsgPage_Load(object sender, EventArgs e)
        {
        }

        public void ClearChat()
        {
            if (Chatroom != null)
                Chatroom.Messages.DataDistributedEvent -= AddOrUpdateMessage;
            chatPanel.Controls.Clear();
            lchats.Clear();
            rchats.Clear();
            Count = 0;
        }

        private void LoadMessageUpToN(int n)
        {
            int i;
            //최대 n개만큼 불러옴
            List<MdlMessage>? Messages_ = new();
            i = Chatroom.Messages.Items.Count - (lchats.Count + rchats.Count);
            i = i >= n ? n : i;

            Messages_ = ServerContainer.Instance.GetMessages(Server.Code, Chatroom.Code, i);

            //해당 채팅방 안의 메시지 컨테이너로부터 정보를 리스트로 반환하고 각 항목에 대해 추가 혹은 갱신 처리
            if (Messages_ != null)
            {
                Messages_.Reverse();
                foreach (MdlMessage mdl in Messages_)
                {
                    AddOrUpdateMessage(mdl);
                }
            }
        }

        private void AddOrUpdateMessage(object v)
        {
            //채팅방 정보가 없을 경우 리턴
            if (Chatroom == null)
                return;

            //메시지 정보가 없을 경우 리턴
            MdlMessage? m = v as MdlMessage;
            if (m == null)
                return;
            //자기 자신이 보낸 메시지라면 Rchat에 대해 처리
            if (m.Creator == MdlMyself.Instance.Code)
            {
                //이미 있는 메시지인지 확인해서 없다면 추가, 있다면 갱신
                MdlMessage? message = Chatroom.Messages.Items.LastOrDefault(MdlMessage => MdlMessage.Code == m.Code);
                AddOrUpdateRChat(m);
                return;
            }
            else
            //아니라면 Lchat에 대해 처리
            {
                MdlMessage? message = Chatroom.Messages.Items.LastOrDefault(MdlMessage => MdlMessage.Code == m.Code);
                AddOrUpdateLChat(m);
                return;
            }
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            Send();
            this.chatTxt.Focus();
        }

        void AddRChat(MdlMessage message)
        {
            var rchat = new Rchat(chatPanel.Width, message);
            chatPanel.Controls.Add(rchat);
            rchat.BringToFront();
            rchat.Dock = DockStyle.Top;
            rchats.Add(rchat);
        }

        void AddLChat(MdlMessage message)
        {
            var lchat = new Lchat(chatPanel.Width, message);
            chatPanel.Controls.Add(lchat);
            lchat.BringToFront();
            lchat.Dock = DockStyle.Top;
            lchats.Add(lchat);
        }

        void AddOrUpdateLChat(MdlMessage message)
        {
            Lchat? l;
#pragma warning disable CS8602 // null 가능 참조에 대한 역참조입니다.
            l = lchats.FirstOrDefault(Lchat => Lchat.mdlMessage.Code == message.Code);
#pragma warning restore CS8602 // null 가능 참조에 대한 역참조입니다.
            if (l == null)
            {
                AddLChat(message);
                return;
            }
            l.Initialize(message);
        }

        void AddOrUpdateRChat(MdlMessage message)
        {
            Rchat? r;
#pragma warning disable CS8602 // null 가능 참조에 대한 역참조입니다.
            r = rchats.FirstOrDefault(Rchat => Rchat.mdlMessage.Code == message.Code);
#pragma warning restore CS8602 // null 가능 참조에 대한 역참조입니다.
            if (r == null)
            {
                AddRChat(message);
                return;
            }
            r.Initialize(message);
        }

        private void addChatBtn_Click(object sender, EventArgs e)
        {
            UserChatAddPopup friendList = new UserChatAddPopup();
            friendList.ShowDialog();

        }

        public void AddOrUpdateUserChat(object s)
        {
            if (s == null)
                return;
            MdlServer? server = s as MdlServer;
            if (server == null)
                return;
            //compact server가 아니라면 리턴
            if (server.IsCompact == false)
                return;
            //UserChat의 count가 0이 아니라면
            if (UserChatListItems.Count != 0)
            {
                //이미 있는 userChat 중 서버 속성의 코드가 동일한 것을 찾았다면 업데이트 후 리턴, 아니면 추가
                UserChatListItem? uc = UserChatListItems.FirstOrDefault(UserChat => UserChat.Server.Code == server.Code);
                if (uc != null)
                {
                    uc.Server = server;
                    return;
                }
            }
            AddUserChat(server);
        }

        private void AddUserChat(MdlServer s)
        {
            if (s.IsDeleted == true)
            {
                return;
            }
            UserChatListItem userChat = new UserChatListItem(s);
            UserChatListItems.Add(userChat);
            userChat.BringToFront();
            userChat.Dock = DockStyle.Top;
            panel1.Controls.Add(userChat);
        }

        public void SwitchChat(int serverCode)
        {
            ClearChat();

            this.Server = ServerContainer.Instance.GetServer(serverCode);
            this.Chatroom = ServerContainer.Instance.GetChatroom(serverCode, 1);

            if (Server == null || Chatroom == null)
                return;

            foreach (UserChatListItem v in UserChatListItems)
            {
                v.Initialize();
            }

            LoadMessageUpToN(10);
            //해당 채팅방 안의 메시지 컨테이너 이벤트로 메시지 갱신 메서드를 등록
            Chatroom.Messages.DataDistributedEvent += AddOrUpdateMessage;
        }

        /*
		private void chatTxt_KeyDown(object sender, KeyEventArgs e)
		{            
			if (e.KeyCode == Keys.Enter && chatTxt.Text.Trim().Length != 0)
			{
				Send();
				this.chatTxt.Focus();
				return;
			}
			else if (e.KeyCode == Keys.ShiftKey)
			{
				chatTxt.Text += "\r\n";
				chatTxt.ScrollToCaret();
			}
		}
		*/

    }
}