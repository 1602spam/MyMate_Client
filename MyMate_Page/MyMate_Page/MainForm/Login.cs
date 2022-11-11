using System.Diagnostics;
using ClientModules.Classes;
using ClientModules.Controllers;
using ClientModules.Models;

namespace MainForm
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private int loginStatus;

        public int LoginStatus
        {
            get
            {
                return loginStatus;
            }
            set
            {
                loginStatus = value;

            }
        }

        private Point mousePoint;

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.LoginStatus = 0;
            this.Close();
        }

        private void LoginForm_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y); //지금 윈도우의 좌표저장
        }

        private void LoginForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int x = mousePoint.X - e.X;
                int y = mousePoint.Y - e.Y;
                Location = new Point(this.Left - x, this.Top - y);
            }
        }

        private void leftPanel_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y); //지금 윈도우의 좌표저장
        }

        private void leftPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int x = mousePoint.X - e.X;
                int y = mousePoint.Y - e.Y;
                Location = new Point(this.Left - x, this.Top - y);
            }
        }

        private void rightPanel_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y); //지금 윈도우의 좌표저장
        }

        private void rightPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int x = mousePoint.X - e.X;
                int y = mousePoint.Y - e.Y;
                Location = new Point(this.Left - x, this.Top - y);
            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            this.LoginStatus = 1;
            if (IDTxt.Text == "" || PWTxt.Text == "")
            {
                return;
            }
            else if (IDTxt.Text == "1" || PWTxt.Text == "1") //테스트용으로 둘 다 1을 입력하면 바로 들어가짐
            {
                this.Close();
                return;
            }

            MdlLogIn login = new(IDTxt.Text, PWTxt.Text);
            //서버에 ID PW 보내고 ID PW 맞는지 서버로부터 응답 받음, 유저코드가 0이면 실패, 아니면 성공
            LogInController.SendLogInRequestAndWait(login);

            if (MdlMyself.Instance.Code == 0) {
                MessageBox.Show("입력하신 로그인 정보에 해당하는 회원 정보가 없습니다.");
                this.Focus();
                return;
            }

            this.Close();
            //로그인 성공 시 mainForm에 회원정보 전달
            //var mainPage = new MainPage();
            //mainPage.Show();
            //this.Close();
            //this.Visible = false;
        }


    }
}