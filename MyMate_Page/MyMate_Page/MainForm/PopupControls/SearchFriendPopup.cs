using ClientModules.Containers;
using ClientModules.Models;
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
    public partial class SearchFriendPopup : Form
    {
        public MdlUser user { get; set; }
        private Point mousePoint;
        public SearchFriendPopup()
        {
            InitializeComponent();
            rbtnProfile.Visible = false;
            lblUsername.Visible = false;
            rbtnAdd.Visible = false;
            user = new();
        }

        private void rbtnSearch_Click(object sender, EventArgs e)
        {
            searchById();
        }

        private void searchById()
        {
            //ID를 입력하지 않은 경우
            if (tbID.Text == "")
            {
                MessageBox.Show("ID를 입력해 주세요!", "알림");
                return;
            }
            //내 ID를 입력한 경우
            else if (tbID.Text == MdlMyself.Instance.ID)
            {
                MessageBox.Show("자기 자신은 친구로 등록할 수 없습니다.", "알림");
                return;
            }
            //그 외, 친구 목록에 있는 사람의 ID를 입력한 경우: 친구 정보에는 ID가 포함되어있지 않기 때문에 받아온 뒤 처리

            //id를 통해 유저정보를 불러오려는 요청을 보냄
            user = new();
            //0.1초 대기하는 동안 검색결과 프로토콜이 수신되면 SvcDistributor에서 해당 내용을 검색 결과 유저 정보를 인스턴스에 올려줌
            Task.Delay(100).Wait();

            if (user == null)
            {
                MessageBox.Show("유효하지 않은 유저 정보입니다.", "알림");
                return;
            }
            //반환받은 유저 정보와 일치하는 친구 정보를 찾아냈다면
            MdlFriend? friend = FriendContainer.Instance.Items.Values.FirstOrDefault(MdlFriend => MdlFriend.FriendCode == user.Code);
            if (friend != null)
            {
                MessageBox.Show("이미 친구로 등록한 유저입니다.", "알림");
                return;
            }

            lblUsername.Text = user.Username;
            if (user != null)
            {
                rbtnProfile.Visible = true;
                lblUsername.Visible = true;
                rbtnAdd.Visible = true;
            }
            else
            {
                rbtnProfile.Visible = false;
                lblUsername.Visible = false;
                rbtnAdd.Visible = false;
            }
        }

        private void rbtnAdd_Click(object sender, EventArgs e)
        {
            //유저정보를 토대로 친구 객체를 전송함
        }

        private void SearchFriendPopup_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y); //지금 윈도우의 좌표저장
        }

        private void SearchFriendPopup_MouseMove(object sender, MouseEventArgs e)
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
