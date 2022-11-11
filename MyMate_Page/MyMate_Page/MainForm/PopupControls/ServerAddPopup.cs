using ClientModules.Containers;
using ClientModules.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MainForm.PopupControls
{
    //1. 열면 친구컨테이너로부터 친구 목록을 코드/MdlFriend 딕셔너리로 가져와서
    //체크박스 리스트에 해당 친구 목록에서 이름만 표시함

    //2. 확인 버튼을 누르면 친구 목록과 이름을 비교해서 유저코드를 리스트로 가져와서 서버 객체를 만들고 전송
    //OKBtn_Click에서 titem = chatMember.FirstOrDefault(MdlFriend => MdlFriend.code == chatmember[i].userName );
    //list<int> tlist에 titem.Code를 넣어 MdlServer를 전송

    //3. 서버 정보를 받으면 메인페이지에서 이벤트 호출받아서 서버 버튼을 만드는데 서버 객체를 파라미터로 넣어주고 그 안에 해당 코드 리스트를 넣어줌

    public partial class ServerAddPopup : Form
    {

        private string serverName = "";
        public string ServerName
        {
            get { return serverName; }
            set { serverName = value; }
        }

        List<MdlFriend> chatMember = new();

        public ServerAddPopup()
        {
            InitializeComponent();
            setUserList();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OKBtn_Click(object sender, EventArgs e)
        {
            //서버 추가 버튼을 누를 시
            //서버명 텍스트박스의 텍스트를 가져옴
            ServerName = serverNameTxt.Text;
            //해당 텍스트가 공백일 경우 서버 이름 입력을 안내
            if (ServerName == "")
            {
                MessageBox.Show("서버 이름을 입력하세요!", "안내");
            }
            //멤버를 선택하지 않았을 경우 멤버 선택을 안내
            else if (userList.CheckedItems.Count == 0)
            {
                MessageBox.Show("멤버를 선택하세요!", "안내");
            }
            //텍스트가 공백이 아니고, 하나 이상의 멤버를 선택했을 경우
            else
            {
                //선택한 유저 리스트의 각 항목을 chatMember에 더함
                foreach (MdlFriend item in userList.Items)
                {
                    chatMember.Add(item);
                }
                //MainPage 인스턴스 속성이 null이 아니라면
                if (MainPage.mainPage != null)
                {
                    //서버 버튼을 더함
                    MainPage.mainPage.AddServerBtn(ServerName);
                }
                //창을 닫음
                this.Close();
            }
        }

        private void setUserList()
        {
            userList.Items.Clear();
            List<MdlFriend> friends = FriendContainer.Instance.GetFriends();
            foreach (var item in friends)
            {
                string[] str = { item.Nickname };
                userList.Items.Add(item.Nickname);
            }
        }
    }
}
