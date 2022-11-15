using ABI.Windows.ApplicationModel.Activation;
using ClientModules.Containers;
using ClientModules.Models.Chat;
using MainForm.PopupControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm.Controls
{
    public partial class ServerChatList : UserControl
    {
        //서버에 대한 정보
        public MdlServer server = new();
        public List<MdlChatroom> chatrooms = new();
        public List<ServerChatListItem> chatTitles = new List<ServerChatListItem>();

        public ServerChatList(MdlServer s)
        {
            InitializeComponent();
            this.server = s;
            serverNameLabel.Text = "- "+ s.Title;
            this.server.Chatrooms.DataDistributedEvent += AddChannel;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void addChatBtn_Click(object sender, EventArgs e)
        {
            ServerChatAddPopup serverChatAddPopup = new ServerChatAddPopup(this.server.Code);
            serverChatAddPopup.ShowDialog();
        }

        public void AddChannel(object v)
        {
            if (v == null)
                return;
            MdlChatroom? chatroom = v as MdlChatroom;
            if (chatroom != null) {
            ServerChatListItem chatTitle = new ServerChatListItem(chatroom);
            chatTitles.Add(chatTitle);
            chatTitle.BringToFront();
            chatTitle.Dock = DockStyle.Top;
            panel3.Controls.Add(chatTitle);
            }
        }
    }
}
