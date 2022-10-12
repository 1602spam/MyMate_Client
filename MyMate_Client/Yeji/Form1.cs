using Yeji.Chatting;
using Yeji.MyControls;
using Yeji.View.Controls;


namespace Yeji
{
    public partial class Form1 : Form
    {
        List<Chat> chatting = new();

        List<OtherChetting> otherchettings = new List<OtherChetting>();
        List<MyChetting> mychettings = new List<MyChetting>();
        public Form1()
        {
            InitializeComponent();
        }

        private string ?checkItem = null;
        public string ?CheckItem { get; set; }

        public int ChettingPanelSize { get; set; }

        List<Button> MsgListBtns = new List<Button>();

        // 채팅방 추가
        private void AddMsgListBtn_Click(object sender, EventArgs e)
        {
            FriendListPopup friendListPopup = new FriendListPopup();
            friendListPopup.StartPosition = FormStartPosition.CenterScreen;
            friendListPopup.ShowDialog();
            this.CheckItem = friendListPopup.CheckItem;
            if (CheckItem != null)
            {
                string name = CheckItem;
                //MsgListBtn msgListBtn = new MsgListBtn(name, );
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MsgListBtns.Add(AddMsgListBtn);
        }

        // Send 버튼 클릭
        private void SendBtn_Click(object sender, EventArgs e)
        {
            Send();
        }

        void Send()
        {
            if (TxtMsg.Text.Trim().Length == 0)
                return;

            AddOtherChetting(TxtMsg.Text);

			Chat chat = new(true, TxtMsg.Text, "goguma", "goguma", DateTime.Now);
			this.chatting.Add(chat);

			TxtMsg.Text = String.Empty;
        }
        int curTop = 10;


        void AddOtherChetting(string message)
        {
            this.ChettingPanelSize = Chettingpanel1.Width;
            var bubble = new MyControls.OtherChetting(ChettingPanelSize);
            otherchettings.Add(bubble);
            Chettingpanel1.Controls.Add(bubble);
            //bubble.Top = curTop;
            //bubble.Width = Chettingpanel.Width - 10;
            //bubble.Message = message;

            //curTop += bubble.Height;

            bubble.BringToFront();
            bubble.Dock = DockStyle.Top;
            bubble.Message = message;

        }
        void AddMyChetting(string message)
        {
            var bubble = new MyControls.MyChetting();
            mychettings.Add(bubble);
            Chettingpanel1.Controls.Add(bubble);
            //bubble.Top = curTop;
            //bubble.Width = Chettingpanel.Width - 10;
            //bubble.Message = message;

            //curTop += bubble.Height;
            bubble.BringToFront();
            bubble.Dock = DockStyle.Top;
            bubble.Message = message;

        }

        private void TxtMsg_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Return)
            {
                Send();
            }
        }

        private void chattingLoad()
        {
            foreach(var chat in chatting)
            {
                if (chat.isMe)
                    AddMyChetting(chat.context);
                else
                    AddOtherChetting(chat.context);
			}
        }

        private void Chettingpanel1_SizeChanged(object sender, EventArgs e)
        {
            
            
        }

        private void Chettingpanel1_Resize(object sender, EventArgs e)
        {
            this.ChettingPanelSize = Chettingpanel1.Width;
            foreach (var i in otherchettings)
            {
                i.AdjustHeight();
            }
        }

        private void MsgBtn_Click(object sender, EventArgs e)
        {
            chattingLoad();
        }
    }
}