﻿using ClientModules.Containers;
using ClientModules.Models;
using ClientModules.Models.Chat;
using ClientModules.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm.Controls
{
    public partial class UserChatAddPopup : Form
    {
        public UserChatAddPopup()
        {
            InitializeComponent();
            //체크박스 초기화
            userListBox.Items.Clear();

            foreach (var item in FriendContainer.Instance.GetAvailableFriends())
            {
                //삭제되지 않은 친구 목록을 불러옴
                userListBox.Items.Add(item.Nickname);
            }
        }
        private Point mousePoint;
        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //확인버튼 눌렀을 때
            if (userListBox.CheckedItems.Count == 0)
            {
                MessageBox.Show("친구를 선택하세요!", "안내");
                return;
            }

            MdlFriend? f = null;

            //체크한 항목이 friend nickname과 같은 mdlfriend를 가져옴
            foreach (string item in userListBox.CheckedItems)
            {
                f = FriendContainer.Instance.Items.Values.FirstOrDefault(MdlFriend => MdlFriend.Nickname == item.ToString());
            }

            if (f == null)
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
                    if (server.Users.Contains(f.FriendCode) == true)
                    {
                        MainPage.mainPage.msgPage.SwitchChat(check.Server.Code,1);
                        //해당 채팅방으로 이동 후 리턴
                        this.Close();
                        return;
                    }
                }
            }
            //선택한 유저에 대한 Compact Server Data 전송
            MdlServer s = new(ServerContainer.Instance.Items.Count + 1, true, f.Nickname, MdlMyself.Instance.Code);
            s.AddUser(f.FriendCode);
            s.AddUser(MdlMyself.Instance.Code);
            SvcDistributor.Instance.PutServer(s);
            SvcDistributor.Instance.PutChatroom(new(s.Chatrooms.Items.Count + 1, s.Code, "chatroomname"));
            MainPage.mainPage.msgPage.SwitchChat(s.Code,1);
            this.Close();
            return;
        }

        private void userListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int i = 0; i < userListBox.Items.Count; i++)
            {
                if (e.Index != i)
                {
                    userListBox.SetItemChecked(i, false);
                }
            }
        }

        private void UserChatAddPopup_MouseDown(object sender, MouseEventArgs e)
        {
            
            mousePoint = new Point(e.X, e.Y); //지금 윈도우의 좌표저장
            
        }

        private void UserChatAddPopup_MouseMove(object sender, MouseEventArgs e)
        {
            
            if (e.Button == MouseButtons.Left)
            {
                int x = mousePoint.X - e.X;
                int y = mousePoint.Y - e.Y;
                 Location = new Point(this.Left - x, this.Top - y);
            }
}
    }
}
