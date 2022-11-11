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
            mousePoint = new Point(e.X, e.Y); //���� �������� ��ǥ����
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
            mousePoint = new Point(e.X, e.Y); //���� �������� ��ǥ����
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
            mousePoint = new Point(e.X, e.Y); //���� �������� ��ǥ����
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
            else if (IDTxt.Text == "1" || PWTxt.Text == "1") //�׽�Ʈ������ �� �� 1�� �Է��ϸ� �ٷ� ����
            {
                this.Close();
                return;
            }

            MdlLogIn login = new(IDTxt.Text, PWTxt.Text);
            //������ ID PW ������ ID PW �´��� �����κ��� ���� ����, �����ڵ尡 0�̸� ����, �ƴϸ� ����
            LogInController.SendLogInRequestAndWait(login);

            if (MdlMyself.Instance.Code == 0) {
                MessageBox.Show("�Է��Ͻ� �α��� ������ �ش��ϴ� ȸ�� ������ �����ϴ�.");
                this.Focus();
                return;
            }

            this.Close();
            //�α��� ���� �� mainForm�� ȸ������ ����
            //var mainPage = new MainPage();
            //mainPage.Show();
            //this.Close();
            //this.Visible = false;
        }


    }
}