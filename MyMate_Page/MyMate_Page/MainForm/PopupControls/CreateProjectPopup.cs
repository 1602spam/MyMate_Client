using ClientModules.Containers;
using ClientModules.Models;
using ClientModules.Models.Chat;
using ClientModules.Models.CheckList;
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
    public partial class CreateProjectPopup : Form
    {
        int ServerCode;
        private Point mousePoint;
        public CreateProjectPopup()
        {
            InitializeComponent();
            serverComboBox.Items.Clear();

            SvcDistributor.Instance.PutServer(new(3, false, "asd", MdlMyself.Instance.Code));

            // 콤보 박스에 서버 이름 목록 넣어주기
            foreach (MdlServer server in ServerContainer.Instance.Items.Values)
            {
                if (server.OwnerCode == MdlMyself.Instance.Code && server.IsDeleted==false && server.IsCompact == false)    // 방장코드, 로그인 코드
                {
                    string str = server.Title + "(" + server.Code + ")";
                    serverComboBox.Items.Add(server.Title);
                }       
            }
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

                // 서버이름이 동일한 서버의 코드 가져오기
                foreach (MdlServer item in ServerContainer.Instance.Items.Values)
                {
                    if (item.Title == serverComboBox.SelectedItem.ToString())    // 서버 이름
                    {
                        ServerCode = item.Code;
                    }
                }
                MdlServer? server = ServerContainer.Instance.Items.Values.FirstOrDefault(MdlServer => MdlServer.Title == serverComboBox.Text.ToString());
                if (server == null)
                {
                    MessageBox.Show("유효하지 않은 서버 정보입니다.");
                }
                else
                {
                    MdlProject project = new(ProjectContainer.Instance.Items.Count + 1,
                        ServerCode,
                        MdlMyself.Instance.Code,
                        projectNameTxt.Text,
                        false);

                    SvcDistributor.Instance.PutProject(project);

                    SvcDistributor.Instance.PutProjectItem(new(project.Items.Items.Count + 1, project.Code, "테스트asfasg", true));
                    SvcDistributor.Instance.PutProjectItem(new(project.Items.Items.Count + 1, project.Code, "테스트ads", false));
                }
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
        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
