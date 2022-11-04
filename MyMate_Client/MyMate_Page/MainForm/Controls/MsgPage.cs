using ClientModules.Containers;
using ClientModules.Models;
using ClientModules.Models.Chat;
using ClientModules.Services;
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

namespace MainForm.Controls
{
	public partial class MsgPage : UserControl
	{
		public MdlChatroom? Chatroom { get; set; }
		public List<Lchat> lchats = new();
		public List<Rchat> rchats = new();

		public MsgPage()
		{
			InitializeComponent();
			this.Dock = DockStyle.Fill;
			this.Visible = false;
		}

		void RSend()
		{
			if (chatTxt.Text.Trim().Length == 0)
				return;

			//RChat(chatTxt.Text);
			chatTxt.Text = String.Empty;
		}

		void LSend()
		{
			if (chatTxt.Text.Trim().Length == 0)
				return;

			AddRChat(chatTxt.Text);
			chatTxt.Text = String.Empty;
		}

		private void MsgPage_Load(object sender, EventArgs e)
		{
			//테스트용 서버 1과 그 안의 채팅방 1, 메시지 1~5를 생성
			SvcDistributor.Instance.PutServer(new(1, true, "테스트용 서버", 1));
			SvcDistributor.Instance.PutChatroom(new(1, 1, "테스트용 채팅방 1"));
			int i;
			for (i = 0; i < 5; i++)
            {
                SvcDistributor.Instance.PutMessage(new MdlMessage(i,1,1,1,"메시지"+i.ToString(),DateTime.Now));
            }

			//이 채팅방 객체를 속성으로 가져옴
			Chatroom = ServerContainer.Instance.GetChatroom(1, 1);
			if (Chatroom == null)
				return;

			//최초 메시지 개수(최대 20개) 만큼 불러옴
			List<MdlMessage>? Messages_ = new();
			i = Chatroom.Messages.Items.Count;
			if (i >= 20)
				i = 20;
			
			//해당 채팅방 안의 메시지 컨테이너로부터 정보를 리스트로 반환하고 각 항목에 대해 추가 처리
			Messages_ = ServerContainer.Instance.GetMessages(1, 1, i);
			if (Messages_ != null)
			{	
				foreach (MdlMessage mdl in Messages_)
				{
					AddOrUpdateMessage(mdl);
				}
			}
			
			//해당 채팅방 안의 메시지 컨테이너 이벤트로 메시지 갱신 메서드를 등록
			Chatroom.Messages.DataDistributedEvent += AddOrUpdateMessage;
		}

		private void AddOrUpdateMessage(object v)
		{
            if (Chatroom == null)
                return;

            MdlMessage? m = v as MdlMessage;
			if (m == null)
				return;

			//자기 자신이 보낸 메시지라면
			if (m.SenderCode == MdlMyself.Instance.Code)
			{
				//이미 있는 메시지인지 확인
                MdlMessage? message = Chatroom.Messages.Items.LastOrDefault(MdlMessage => MdlMessage.Code == m.Code);
				if (message == null)
					return;
				
			}
			else
			//아니라면
			{

			}
			return;
		}

		private void sendBtn_Click(object sender, EventArgs e)
		{
			LSend();
		}

		void AddRChat(string message)
		{
			var rchat = new Rchat(chatPanel.Width, message);
			chatPanel.Controls.Add(rchat);
			rchat.BringToFront();
			rchat.Dock = DockStyle.Top;
			rchats.Add(rchat);
		}

		void AddLChat(string message)
		{
			var lchat = new Lchat(chatPanel.Width, message);
			chatPanel.Controls.Add(lchat);
			lchat.BringToFront();
			lchat.Dock = DockStyle.Top;
			lchats.Add(lchat);
		}

		
	}
}
