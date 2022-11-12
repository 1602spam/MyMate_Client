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
    public partial class SearchFriend : Form
    {
        public MdlUser user { get; set; }
        public SearchFriend()
        {
            InitializeComponent();
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
            //id를 통해 유저정보를 불러오려는 요청을 보냄
            user = new();
            //대기하는 동안 검색결과 프로토콜이 수신되면 SvcDistributor에서 해당 내용을 검색 결과 유저 정보를 인스턴스에 올려줄 것
            Task.Delay(100).Wait();

            if (user != null)
            {
                lblUsername.Text = user.Username;
                lblUsername.Visible = true;
                rbtnAdd.Visible = true;
            }
            else
            {
                lblUsername.Visible = false;
                rbtnAdd.Visible = false;
            }
        }

        private void rbtnAdd_Click(object sender, EventArgs e)
        {
            //유저정보를 토대로 친구 객체를 추가함
        }
    }
}
