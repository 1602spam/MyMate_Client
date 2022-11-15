using ClientModules.Containers;
using ClientModules.Models;
using ClientModules.Models.Chat;
using ClientModules.Services;
using MainForm.Controls;
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

namespace MainForm
{
	public partial class MainPage : Form
	{
		public static MainPage? mainPage;
		public MsgPage msgPage = new MsgPage();
		public FriendPage friendPage = new FriendPage();
		public CalendarPage calendarPage = new CalendarPage();
		public CheckListPage checkListPage = new CheckListPage();

		public List<ServerBtn> serverBtns = new List<ServerBtn>();
		public ServerPage serverPageInst;
		public List<MdlServer> servers = new();
		//string serverName = "";

		private Point mousePoint;

		public MainPage()
		{
			//메인페이지 인스턴스 속성 지정
			mainPage = this;
			InitializeComponent();

			//캘린더, 메시지, 친구, 체크리스트 페이지 생성
			panel8.Controls.Add(calendarPage);
			panel8.Controls.Add(msgPage);
			panel8.Controls.Add(friendPage);
			panel8.Controls.Add(checkListPage);
			//panel8.Controls.Add(serverPage);

			//메시지 페이지가 보이도록 설정
			msgPage.Visible = true;

			//서버 컨테이너 정보 변경 발생 시 서버 버튼/페이지 설정하는 메서드를 이벤트에 등록
			ServerContainer.Instance.DataDistributedEvent += AddOrUpdateServerBtn;
		}

		private void MainPage_Load(object sender, EventArgs e)
		{
			//로드되면 이 창을 숨기고 로그인 창을 띄우고, 로그인 창에서 로그인이 성공하면 로그인 창을 닫고 이 창을 띄움
			this.Visible = false;
			var loginPage = new LoginForm();
			loginPage.ShowDialog();

			if (loginPage.LoginStatus == 0)
			{
				//this.Close();
			}
			else
			{
				this.Visible = true;
			}
		}

		private void closeBtn_Click(object sender, EventArgs e)
		{
			//종료 버튼을 누를 시 이 창을 닫음
			this.Close();
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

		public void AddOrUpdateServerBtn(object? server)
		{
			//서버 컨테이너에 변경사항이 발생했을 시 호출됨
			//이벤트로 받은 객체 정보가 null일 경우 리턴
			if (server == null)
				return;

			//이벤트로 받은 객체를 MdlServer로 변환했을 때 null일 경우 리턴
			MdlServer? s = server as MdlServer;
			if (s == null)
				return;
            //개인 채팅방일 경우 추가하지 않음, 개인 채팅방 버튼(UserChat) 관리는 mainpage 인스턴스 안의 msgpage 안에서 진행
            if (s.IsCompact == true)
                return;
            //서버버튼과 서버페이지에는 서버 객체와 initialize 함수 필요
            //동일한 코드를 가진 서버를 이전에 추가했는지 확인함
            MdlServer? tserver = servers.FirstOrDefault(MdlServer => MdlServer.Code == s.Code);
			//이미 저장된 서버 코드라면 해당 서버를 담은 페이지와 버튼을 갱신해 줌
			//아니라면 추가함
			if (tserver == null)
			{
				AddServerBtn(s);
			}
			else
			{
				UpdateServerBtn(s);
			}
		}

		public void AddServerBtn(MdlServer server)
		{
			servers.Add(server);
			var serverBtn = new ServerBtn(server);
			serverBtns.Add(serverBtn);
			var serverPage = new ServerPage(server);

			server.Chatrooms.DataDistributedEvent += AddChatroom;
			int i = servers.IndexOf(server);

            panel11.Controls.Add(serverBtns[i]);
            serverBtns[i].SendToBack();
            serverBtns[i].Dock = DockStyle.Top;
			serverPageInst = new(server);
            panel8.Controls.Add(serverPage);

			ShowServerChat();

            /*
			for (int i = 0; serverBtns.Count > i; i++)
			{
				if (server.Title == serverBtns[i].Name)
				{
					panel11.Controls.Add(serverBtns[i]);
					serverBtns[i].BringToFront();
					serverBtns[i].Dock = DockStyle.Top;
					panel8.Controls.Add(serverPages[i]);
					serverPages[i].Visible = true;

					msgPage.Visible = false;
					calendarPage.Visible = false;
					friendPage.Visible = false;
					checkListPage.Visible = false;
				}
				else
				{
					serverPages[i].Visible = false;
				}
			}*/
        }


        private void AddChatroom(object ch)
		{
			MdlChatroom? chatroom = ch as MdlChatroom;
			if (chatroom == null || mainPage == null)
				return;
			serverPageInst.SCL.AddChannel(chatroom);
        }

		public void UpdateServerBtn(MdlServer server)
		{
			int index = servers.IndexOf(server);
            servers.RemoveAt(index);
			servers.Insert(index, server);
		}

		public void ServerPageChange(MdlServer server)
		{
			serverPageInst = new(server);
			MainPage.mainPage.ShowServerChat();
            serverPageInst.Visible = true;
        }

		public void ShowServerChat()
		{
            calendarPage.Visible = false;
            friendPage.Visible = false;
            msgPage.Visible = false;
            checkListPage.Visible = false;
			serverPageInst.Visible = true;
        }

		public void ShowMsgPage()
		{
            calendarPage.Visible = false;
            friendPage.Visible = false;
            msgPage.Visible = true;
            checkListPage.Visible = false;
        }

		public void ShowCalendarPage()
		{
            msgPage.Visible = false;
            friendPage.Visible = false;
            calendarPage.Visible = true;
            checkListPage.Visible = false;
        }
        public void ShowCheckListPage()
        {
            msgPage.Visible = false;
            friendPage.Visible = false;
            calendarPage.Visible = false;
            checkListPage.Visible = true;
        }
        public void ShowFriendPage()
        {
            msgPage.Visible = false;
            friendPage.Visible = true;
            calendarPage.Visible = false;
            checkListPage.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
			//개인 채팅 탭 클릭 시
			ShowMsgPage();
        }

        private void button4_Click(object sender, EventArgs e)
        {
			//친구 탭 클릭 시
			ShowFriendPage();
        }

        private void button2_Click(object sender, EventArgs e)
        {
			//체크리스트 탭 클릭 시
			ShowCheckListPage();
        }

        private void button3_Click(object sender, EventArgs e)
        {
			//캘린더 탭 클릭 시
			ShowCalendarPage();
        }

        public void profileBtn_Click(object sender, EventArgs e)
        {
			//프로필 버튼 클릭 시
            var profile = new UserProfilePopup(MdlMyself.Instance);
            profile.ShowDialog();
        }

        private void serverAddBtn_Click(object sender, EventArgs e)
        {
			//서버 추가 버튼 클릭 시
            var serverAddPopup = new ServerAddPopup();
            serverAddPopup.ShowDialog();
        }
	}
}
