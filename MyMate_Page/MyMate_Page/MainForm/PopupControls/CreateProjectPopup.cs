using ClientModules.Containers;
using ClientModules.Models;
using ClientModules.Models.Chat;
using ClientModules.Models.CheckList;
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
    public partial class CreateProjectPopup : Form
    {
        int ServerCode;
        private Point mousePoint;
        public CreateProjectPopup()
        {
            InitializeComponent();
            //serverComboBox.Items.Clear();
            // 콤보 박스에 서버 이름 목록 넣어주기
            foreach (MdlServer server in ServerContainer.Instance.Items.Values)
            {
                if (server.OwnerCode == MdlMyself.Instance.Code)    // 방장코드, 로그인 코드
                {
                    string str = server.Title + "(" + server.Code + ")";

                    serverComboBox.Items.Add(server.Title);
                }
                    
            }
            
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OKBtn_Click(object sender, EventArgs e)
        {
            if(projectNameTxt.Text == "")
            {
                MessageBox.Show("프로젝트 이름을 입력하세요!", "안내");
            }
            else if(startDayTxt.Text == "" || endDayTxt.Text == "")
            {
                MessageBox.Show("날짜를 입력하세요!", "안내");
            }
            else
            {
                
                if (serverComboBox.SelectedItem.ToString() == "내 서버")
                {
                    ServerCode = 1; // 임시 데이터 : 콤보박스에서 내서버 선택 됐을때 할때 1 넘겨줌
                }

                // 서버코드 가져오기
                foreach (MdlServer server in ServerContainer.Instance.Items.Values)
                {
                    if (server.Title == serverComboBox.SelectedItem.ToString())    // 서버 이름
                    {
                        ServerCode = server.Code;
                    }

                }
                
                //프로젝트 객체 생성하는 함수 호출 : 프로젝트 이름, 대상 서버,프로젝트 코드, 시작날짜, 종료날짜 넘겨줌
                MainPage.mainPage.checkListPage.CreateProject(projectNameTxt.Text, ServerCode, startDayTxt.Text, endDayTxt.Text);
                this.Close();
            }
        }

        private void CreateProjectPopup_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y); //지금 윈도우의 좌표저장
        }

        private void CreateProjectPopup_MouseMove(object sender, MouseEventArgs e)
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
