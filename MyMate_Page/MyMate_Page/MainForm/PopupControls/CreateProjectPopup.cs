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
            serverComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            // 콤보 박스에 서버 이름 목록 넣어주기
            foreach (MdlServer server in ServerContainer.Instance.Items.Values)
            {
                if (server.OwnerCode == MdlMyself.Instance.Code && server.IsDeleted == false && server.IsCompact == false)    // 방장코드, 로그인 코드
                {
                    MdlProject? project = ProjectContainer.Instance.Items.Values.FirstOrDefault(MdlProject => MdlProject.ServerCode == server.Code && MdlProject.IsDeleted == false);
                    if (project == null)
                    {
                        string str = server.Title + "(" + server.Code + ")";
                        serverComboBox.Items.Add(server.Title);
                    }
                }
            }
        }

        private void OKBtn_Click(object sender, EventArgs e)
        {
            if (projectNameTxt.Text == "")
            {
                MessageBox.Show("프로젝트 이름을 입력하세요!", "안내");
            }
            else
            {
                MdlServer? server = ServerContainer.Instance.Items.Values.FirstOrDefault(MdlServer => MdlServer.Title == serverComboBox.Text.ToString());
                if (server == null)
                {
                    MessageBox.Show("유효하지 않은 서버 정보입니다.");
                }
                else
                {
                    MdlProject project = new(ProjectContainer.Instance.Items.Count + 1,
                        server.Code,
                        MdlMyself.Instance.Code,
                        projectNameTxt.Text,
                        false);

                    SvcDistributor.Instance.PutProject(project);

                    SvcDistributor.Instance.PutProjectItem(new(project.Items.Items.Count + 1, project.Code, "테스트1", true));
                    SvcDistributor.Instance.PutProjectItem(new(project.Items.Items.Count + 1, project.Code, "테스트1", false));
                    SvcDistributor.Instance.PutProjectItem(new(project.Items.Items.Count + 1, project.Code, "테스트2", false));
                    SvcDistributor.Instance.PutProjectItem(new(project.Items.Items.Count + 1, project.Code, "테스트2", true));
                }
                this.Close();
                return;
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
