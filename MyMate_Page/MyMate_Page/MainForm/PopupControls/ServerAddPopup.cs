﻿using ClientModules.Containers;
using ClientModules.Models;
using ClientModules.Models.Chat;
using ClientModules.Services;
using ClientToServer;
using Protocol;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MainForm.PopupControls
{

    public partial class ServerAddPopup : Form
    {

        public ServerAddPopup()
        {
            InitializeComponent();

            userList.Items.Clear();

            foreach (var item in FriendContainer.Instance.GetAvailableFriends())
            {
                userList.Items.Add(item.Nickname.ToString());
            }
        }
        private Point mousePoint;
        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OKBtn_Click(object sender, EventArgs e)
        {
            if (serverNameTxt.Text.Trim() == "")
            {
                MessageBox.Show("서버이름을 입력하세요!", "안내");
            }
            else if (userList.CheckedItems.Count == 0)
            {
                MessageBox.Show("멤버를 선택하세요!", "안내");
            }
            else
            {
                List<int> codes = new();
                foreach (string item in userList.CheckedItems)
                {
                    //체크된 유저 이름과 friendcontainer에서 비교해서 해당 친구의 유저코드를 불러온다.
                    //해당 유저코드를 비교해서 usercontainer에서 유저 정보를 찾아서 임시 MdlUser 리스트에 넣는다.
                    //해당 유저리스트를 가지고 서버를 만들어서 보낸다.

                    if (FriendContainer.Instance.Items.Count != 0)
                    {
                        int code = FriendContainer.Instance.Items.Values.FirstOrDefault(MdlFriend => MdlFriend.Nickname == item.ToString()).FriendCode;
                        codes.Add(code);
                    }
                }
                //ServerProtocol.Server server = new()
                //Server.Instance.Send(Generater.Generate(server));
                MdlServer server = new(ServerContainer.Instance.Items.Count + 1, false, serverNameTxt.Text.Trim(), MdlMyself.Instance.Code, codes);
                SvcDistributor.Instance.PutServer(server);
                this.Close();
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y); //지금 윈도우의 좌표저장
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
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
