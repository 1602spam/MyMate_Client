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
        public ServerPage(string Sname, List<string> chatMember) //List<string> chatMember 추가
        {
            InitializeComponent();
            this.Name = Sname;
            var SChatList = new ServerChatList(Sname);            
            var SChat = new ServerChat();
            var SFriends = new ServerFriends(Sname, chatMember); // chatMember 추가
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
