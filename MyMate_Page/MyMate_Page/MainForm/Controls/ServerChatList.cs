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
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm.Controls
{
    public partial class ServerChatList : UserControl
    {
        //서버에 대한 정보
        private MdlServer server;
        public MdlServer Server
        {
            get
            {
                if (server != null)
                {
                    return server;
                }
                else return new();
            }
            set
            {
                server = value;
                serverNameLabel.Text = "- " + server.Title;
            }
        }
        public List<MdlChatroom> chatrooms = new();
        public List<ServerChatListItem> chatTitles = new List<ServerChatListItem>();

        public ServerChatList(MdlServer s)
        {
            InitializeComponent();
            this.Server = s;

            chatTitles.Clear();
            panel3.Controls.Clear();

            foreach(MdlChatroom item in Server.Chatrooms.Items) {
                ServerChatListItem chatTitle = new ServerChatListItem(item);
                chatTitles.Add(chatTitle);
                chatTitle.BringToFront();
                chatTitle.Dock = DockStyle.Top;
                panel3.Controls.Add(chatTitle);
            }

            this.Server.Chatrooms.DataDistributedEvent += AddChannel;
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
            if (chatroom != null)
            {
                ServerChatListItem chatTitle = new ServerChatListItem(chatroom);
                chatTitles.Add(chatTitle);
                chatTitle.BringToFront();
                chatTitle.Dock = DockStyle.Top;
                panel3.Controls.Add(chatTitle);
            }
        }
    }
}
