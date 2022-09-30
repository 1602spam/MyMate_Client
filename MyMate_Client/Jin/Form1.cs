using Page.Models;

namespace Jin
{
    public partial class Form1 : Form
    {
        // �α��� ���� ���� ��ü ����
        MdlSignInUserInfo signInUserInfo = new MdlSignInUserInfo();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            syncButtons();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // �α��� ���� ���� �Է�
            signInUserInfo.enterSignInInfo(tbID.Text, tbPW.Text);
            // �Էµ� �α��� ���� ������ �������� �α��� ������Ʈ�� �۽�
            signInUserInfo.sendSignInRequest();
            // �α��� ���� �۽�, DisplayUserInfo�� �۽�
            signInUserInfo.recvSignInResponse();

            syncButtons();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // �α��� ���ſ� �����ߴٸ�, ���������� logoutCheck�� ����
            signInUserInfo.logoutCheck();

            syncButtons();
        }

        private void syncButtons()
        {
            btnLogin.Enabled = !signInUserInfo.FlagSignOn;
            btnLogout.Enabled = signInUserInfo.FlagSignOn;
        }
    }
}