using MainForm.PopupControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm.Controls
{
    public partial class CheckListPage : UserControl
    {
        int projectCode = 1;
        int projectCodeStatus = 0;
        public List<CheckListProject> projects = new List<CheckListProject>();
        public CheckListPage()
        {
            InitializeComponent();
            //페이지 처음 들어갔을 때는 정보 안보이게 함
            this.Visible = false;

            //프로젝트 클릭하거나 생성했을 때 부터 보이게 함
            panel4.Visible = false;
        }

        private void createProjectBtn_Click(object sender, EventArgs e)
        {
            CreateProjectPopup createProjectPopup = new CreateProjectPopup();
            createProjectPopup.ShowDialog();
        }


        //프로젝트 생성 함수 : 팝업으로 부터 입력된 정보 가져오기
        public void CreateProject(string title, int serverCode, string startDay, string endDay)
        {
            // 프로젝트 폼에 서버이름, 시작날짜, 종료날짜, 프로젝트코드(이게 프로젝트 폼의 이름이 됨) 전달
            CheckListProject checkListProject = new CheckListProject(title, serverCode, startDay, endDay, projectCode); 

            //프로젝트 폼을 리스트에 저장
            projects.Add(checkListProject);
            checkListProject.SendToBack();
            checkListProject.Dock = DockStyle.Top;
            panel6.Controls.Add(checkListProject);
            //CreateProjectPanel()함수 호출
            projectCode++;
        }

        //프로젝트 정보 Panel에 보여주기
        //주제, 기간, 참여자(서버에 속해있는 사람 리스트), 업무목록(List) ,완료좐 업무목록(List)를 인수로 받아온다.
        public void CreateProjectPanel(string title, int serverCode, string startDay, string endDay, int projectCode)
        {
            projectCodeStatus = projectCode; // 현재 패널에 보여주는 프로젝트 코드
            panel4.Visible = true;
            titleTxt.Text = title;
            dateTxt.Text = startDay + " ~ " + endDay;

            //유저 개인의 프로젝트일때 유저이름만 써줌
            if (serverCode == 1)
            {
                membersTxt.Text = "고구마"; 
            }
            //else if( 서버 코드 통해서 해당서버에 속해있는 친구리스트를 가져옴)
            //membersTxt.Text = server; --> 친구들을 Text에 넣어줌
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            CheckListWorkPopup checkListWorkPopup = new CheckListWorkPopup(); //정보넘겨줌
            checkListWorkPopup.ShowDialog();
        }

        public void EditProject(string title, string startDay, string endDay)
        {
            int i = 0;
            if (projects[i].Name == projectCodeStatus.ToString())
            {
                ///////////////
            }
        }
    }
}
