using ClientModules.Containers;
using ClientModules.Models;
using MainForm.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm.PopupControls
{
    //여기에서 보여주는 친구 리스트는 서버에 포함 되지 않은 사람들만 보여주게 한다.
    public partial class ServerFriendAddPopup : Form
    {
        public int serverCode;
        public List<MdlFriend> chatMember = new();

        public ServerFriendAddPopup(int serverCode)
        {
            InitializeComponent();
            this.serverCode = serverCode;
            //여기에서 서버 친구들을 제외한 친구들을 리스트박스에 넣어준다.
            userList.Items.Clear();

            foreach (var item in FriendContainer.Instance.GetAvailableFriends())
            {
                bool i = ServerContainer.Instance.GetServer(serverCode).Users.Contains(item.FriendCode);
                if (i == true)
                {
                    continue;
                }
                chatMember.Add(item);
                userList.Items.Add(item.Nickname.ToString());
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OKBtn_Click(object sender, EventArgs e)
        {
            /* 확인 버튼 눌렀을 때
             * 
             * 친구 선택 안했으면 선택하라고 메시지 박스 띄우기
             * 선택했으면 함수 ServerFriend 클래스의 AddFriend 함수 호출하기
             * MainPage.mainPage.serverPages[i].SF.AddFriend();
             */
            if (userList.CheckedItems.Count == 0)
            {
                MessageBox.Show("멤버를 선택하세요!", "안내");
            }
            else
            {
                List<int> codes = new();
                foreach (string item in userList.CheckedItems)
                {
                    codes.Add(int.Parse(item));
                }
            }
        }

        private void ServerFriendAddPopup_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void ServerFriendAddPopup_MouseMove(object sender, MouseEventArgs e)
        {

        }
    }
}
