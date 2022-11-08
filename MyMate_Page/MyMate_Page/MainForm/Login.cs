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
            LoginStatus = 1;
            this.Close();
            //ID PW �´��� ���ϱ�
            //�α��� ���� �� mainForm�� ȸ������ ����
            //var mainPage = new MainPage();
            //mainPage.Show();
            //this.Close();
            //this.Visible = false;
        }
    }
}