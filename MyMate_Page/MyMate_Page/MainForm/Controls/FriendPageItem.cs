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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm.Controls
{
    public partial class FriendPageItem : UserControl
    {
        public MdlFriend friend { get; set; }
        public FriendPageItem(MdlFriend f)
        {
            InitializeComponent();
            friend = f;
            Initialize(f);
        }

        public void Initialize(MdlFriend f)
        {
            friend = f;
            this.lblUsername.Text = friend.Nickname;
            return;
        }

        private void rbtnRemove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("정말로 삭제하시겠습니까?", "친구 삭제", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                SvcDistributor.Instance.PutFriend(new MdlFriend(friend.FriendCode, true));
            }
        }

        private void rbtnChat_Click(object sender, EventArgs e)
        {
            if (friend == null)
            {
                MessageBox.Show("친구 정보가 유효하지 않습니다.", "안내");
                return;
            }

            if (MainPage.mainPage.msgPage.UserChatListItems != null)
            {
                MdlServer server;
                //이미 존재하는 userchats 중 하나에 해당 유저 코드가 포함되어 있다면
                foreach (UserChatListItem check in MainPage.mainPage.msgPage.UserChatListItems)
                {
                    server = check.Server;
                    if (server.Users == null) { continue; }
                    if (server.Users.Contains(friend.FriendCode) == true && server.IsCompact == true)
                    {
                        //해당 채팅방으로 이동 후 리턴
                        MainPage.mainPage.ShowMsgPage();
                        MainPage.mainPage.msgPage.SwitchChat(check.Server.Code,1);
                        return;
                    }
                }
            }
            //선택한 유저에 대한 Compact Server Data 전송
            MdlServer s = new(ServerContainer.Instance.Items.Count + 1, true, friend.Nickname, MdlMyself.Instance.Code);
            s.AddUser(friend.FriendCode);
            s.AddUser(MdlMyself.Instance.Code);
            SvcDistributor.Instance.PutServer(s);
            SvcDistributor.Instance.PutChatroom(new(s.Chatrooms.Items.Count + 1, s.Code, "chatroomname"));
            MainPage.mainPage.ShowMsgPage();
            MainPage.mainPage.msgPage.SwitchChat(s.Code,1);
            return;
        }

        private void rbtnProfile_Click(object sender, EventArgs e)
        {
            MdlUser user = UserContainer.Instance.Items.Values.FirstOrDefault(MdlUser => MdlUser.Code == friend.FriendCode);
            if (user != null)
            {
                UserProfilePopup profile = new UserProfilePopup(user);
                profile.ShowDialog();
            }
            else
            {
                MessageBox.Show("유효하지 않은 유저 정보입니다.","알림");
            }
        }
    }
}
