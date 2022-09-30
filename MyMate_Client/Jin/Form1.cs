using Page.Models;

namespace Jin
{
    public partial class Form1 : Form
    {
        // 로그인 유저 정보 객체 생성
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
            // 로그인 유저 정보 입력
            signInUserInfo.enterSignInInfo(tbID.Text, tbPW.Text);
            // 입력된 로그인 유저 정보를 바탕으로 로그인 리퀘스트를 송신
            signInUserInfo.sendSignInRequest();
            // 로그인 정보 송신, DisplayUserInfo를 송신
            signInUserInfo.recvSignInResponse();

            syncButtons();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // 로그인 수신에 성공했다면, 지속적으로 logoutCheck를 진행
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