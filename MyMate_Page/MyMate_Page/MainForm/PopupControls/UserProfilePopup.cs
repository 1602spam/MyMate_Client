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
using static Protocol.FriendProtocol;

namespace MainForm.Controls
{
    public partial class UserProfilePopup : Form
    {
        public MdlUser User { get; set; }

        public UserProfilePopup(MdlUser u)
        {
            InitializeComponent();
            User = u;
            lblName.Text = "Name: " + u.Name;
            lblUserName.Text = "Username: "+ u.Username;
            lblEmail.Text = "E-mail: "+u.Email;
            lblIntroduction.Text = "Introduction: ";
            rtbIntroduction.Text = u.Introduction;
            if (User.Code == MdlMyself.Instance.Code)
            {
                button1.Visible = false;
            }
        }

        private Point mousePoint;

        private void Profile_Move(object sender, EventArgs e)
        {
            
        }

        private void Profile_MouseMove(object sender, MouseEventArgs e)
        {
            
            if (e.Button == MouseButtons.Left)
            {
                int x = mousePoint.X - e.X;
                int y = mousePoint.Y - e.Y;
                Location = new Point(this.Left - x, this.Top - y);
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nameLabel_Click(object sender, EventArgs e)
        {

        }

        private void Profile_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y); //지금 윈도우의 좌표저장
        }

        private void statusLabel_Click(object sender, EventArgs e)
        {

        }

        private void UserProfilePopup_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (User == null)
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
                    if (server.Users.Contains(User.Code) == true && server.IsCompact == true)
                    {
                        //해당 채팅방으로 이동 후 리턴
                        MainPage.mainPage.ShowMsgPage();
                        MainPage.mainPage.msgPage.SwitchChat(check.Server.Code, 1);
                        this.Close();
                        return;
                    }
                }
            }
            //선택한 유저에 대한 Compact Server Data 전송
            MdlServer s = new(ServerContainer.Instance.Items.Count + 1, true, User.Username, MdlMyself.Instance.Code);
            s.AddUser(User.Code);
            s.AddUser(MdlMyself.Instance.Code);
            SvcDistributor.Instance.PutServer(s);
            SvcDistributor.Instance.PutChatroom(new(s.Chatrooms.Items.Count + 1, s.Code, "chatroomname"));
            MainPage.mainPage.ShowMsgPage();
            MainPage.mainPage.msgPage.SwitchChat(s.Code, 1);
            this.Close();
            return;
        }
    }
}
