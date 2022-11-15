using ClientModules.Containers;
using ClientModules.Models.Chat;
using ClientModules.Services;
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
    public partial class ServerChatAddPopup : Form
    {
        public int serverCode;
        private Point mousePoint;
        public ServerChatAddPopup(int serverCode)
        {
            InitializeComponent();
            this.serverCode = serverCode;
            lblWarning.Visible = false;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OKBtn_Click(object sender, EventArgs e)
        {
            MdlServer? server = ServerContainer.Instance.GetServer(serverCode);

            if (server == null)
            {
                MessageBox.Show("서버 정보가 유효하지 않습니다.", "안내");
                return;
            }

            if (chatNameTxt.Text.Trim() == "")
            {
                lblWarning.Visible = true;
                lblWarning.Text = "채팅방 이름을 입력하세요.";
                return;
            }

            MdlChatroom? chatroom = server.Chatrooms.Items.FirstOrDefault(MdlChatroom => MdlChatroom.Title == chatNameTxt.Text);
            if (chatroom != null)
            {
                lblWarning.Visible = true;
                lblWarning.Text = "채팅방 이름이 중복되었습니다!";
                return;
            }

            //채널을 만들어 전송
            SvcDistributor.Instance.PutChatroom(new(server.Chatrooms.Items.Count + 2, serverCode, chatNameTxt.Text.Trim()));
            //전송 코드를 넣으시오

            //메인 페이지에서 서버가 추가될 때 해당 서버의 채팅방 변경 이벤트 채널 추가 메서드를 연결시킴
            
            this.Close();
        }

        private void chatNameTxt_TextChanged(object sender, EventArgs e)
        {
            removeWarning();
        }

        private void chatNameTxt_Enter(object sender, EventArgs e)
        {
            removeWarning();
        }

        private void removeWarning() {
            lblWarning.Visible = false;
        }

        private void ServerChatAddPopup_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y); //지금 윈도우의 좌표저장
        }

        private void ServerChatAddPopup_MouseMove(object sender, MouseEventArgs e)
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
