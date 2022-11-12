using ClientModules.Models.Chat;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm.Controls
{
    public partial class ServerPage : UserControl
    {
        public ServerChatList SCL;
        public ServerFriends SF;
        public ServerChat SC;
        public MdlServer server { get; set; }

        public ServerPage(MdlServer s) //List<string> chatMember 추가
        {
            InitializeComponent();
            this.server = s;
            this.Name = server.Title;
            var SChatList = new ServerChatList(server.Title);            
            var SChat = new ServerChat();
            var SFriends = new ServerFriends(server); // chatMember 추가
            
            SF = SFriends;
            SCL = SChatList;
            SC = SChat;

            SChatList.Dock = DockStyle.Fill;
            SChat.Dock = DockStyle.Fill;
            SFriends.Dock = DockStyle.Fill;
            SChatListPanel.Controls.Add(SChatList);
            SChatPanel.Controls.Add(SChat);
            SFriendsPanel.Controls.Add(SFriends);

            this.Visible = false;
            this.Dock = DockStyle.Fill;
        }
    }
}
