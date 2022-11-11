using MainForm.PopupControls;
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
    public partial class ServerFriends : UserControl
    {
        public string SName;
        public List<string> ChatMember = new List<string>();        // ChatMember 추가
        public List<Friendprofile> friendprofiles = new List<Friendprofile>();
        public ServerFriends(string Sname, List<string> chatMember) //List<string> chatMember 추가
        {
            InitializeComponent();
            this.SName = Sname;
            this.ChatMember = chatMember;
            for (int i = 0; i < ChatMember.Count; i++)
            {
                Friendprofile friendprofile = new Friendprofile(ChatMember[i]);
                friendprofiles.Add(friendprofile);
                friendprofile.SendToBack();
                friendprofile.Dock = DockStyle.Top;
                panel2.Controls.Add(friendprofile);
            }
            
        }

        // 서버에 친구 추가히기 버튼
        private void button3_Click(object sender, EventArgs e)
        {
            ServerFriendAddPopup serverFriendAdd = new ServerFriendAddPopup();
            serverFriendAdd.ShowDialog();
        }

        public void AddFriend()
        {

        }
    }
}
