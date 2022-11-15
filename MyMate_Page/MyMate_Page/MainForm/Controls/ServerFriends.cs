using ClientModules.Containers;
using ClientModules.Models;
using ClientModules.Models.Chat;
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
        public MdlServer server;
        public List<int> ChatMember = new();        // ChatMember 추가
        public List<UserProfile> friendprofiles = new List<UserProfile>();

        public ServerFriends(MdlServer s)
        {
            InitializeComponent();
            this.server = s;
            this.ChatMember = server.Users;
            foreach(var item in ChatMember)
            {
                MdlUser? user = UserContainer.Instance.Items.Values.FirstOrDefault(MdlUser => MdlUser.Code == item);
                if (user == null) {
                    continue;
                }
                UserProfile friendprofile = new UserProfile(user);
                friendprofiles.Add(friendprofile);
                friendprofile.SendToBack();
                friendprofile.Dock = DockStyle.Top;
                panel2.Controls.Add(friendprofile);
            }
            //ServerContainer.Instance.DataDistributedEvent += AddFriend;
        }

        // 서버에 친구 초대하기 버튼
        private void button3_Click(object sender, EventArgs e)
        {
            ServerFriendAddPopup serverFriendAdd = new ServerFriendAddPopup(server.Code);
            serverFriendAdd.ShowDialog();
        }

        public void AddFriend()
        {

        }
    }
}
