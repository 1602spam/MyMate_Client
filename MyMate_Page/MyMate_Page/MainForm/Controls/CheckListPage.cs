using ClientModules.Containers;
using ClientModules.Models;
using ClientModules.Models.Chat;
using ClientModules.Models.CheckList;
using ClientModules.Services;
using MainForm.PopupControls;
using Protocol;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm.Controls
{
    public partial class CheckListPage : UserControl
    {    
        // 프로젝트, 프로젝트 아이템, 서버
        public MdlProject Project { get; set; }
        public MdlProjectItem ProjectItem { get; set; }
        public MdlServer server { get; set; }

        // 서버코드 상태
        int serverCodeStatus;
        //프로젝트 코드 1부터 시작
        int projectCode = 1;
        //프로젝트 코드 상태
        int projectCodeStatus = 0;
        //오른쪽 바에 넣을 프로젝트 객체 저장
        public List<CheckListProject> projects = new List<CheckListProject>();

        public CheckListPage()
        {
            InitializeComponent();

            //페이지 처음 들어갔을 때는 정보 안보이게 함
            this.Visible = false;

            //프로젝트 클릭하거나 생성했을 때 부터 보이게 함
            panel4.Visible = false;
            //ProjectContainer.Instance.GetListItems()
            //projects.Add()

            //프로젝트 컨테이너에 프로젝트 추가/갱신 될 때마다 프로젝트 세로고침
            //ProjectContainer.Instance.DataDistributedEvent += AddUpdateProjectList();
        }

        //프로젝트 생성 버튼 눌렀을 때
        private void createProjectBtn_Click(object sender, EventArgs e)
        {
            // 팝업 띄움
            CreateProjectPopup createProjectPopup = new CreateProjectPopup();
            createProjectPopup.ShowDialog();
        }


        //프로젝트 생성 함수 : 팝업으로 부터 입력된 정보 가져오기
        public void CreateProject(string title, int serverCode, string startDay, string endDay)
        {
            foreach (MdlServer server in ServerContainer.Instance.Items.Values)
            {
                //팝업 폼에서 선택한 서버 코드와 비교해서 서버 저장
                if (server.Code == serverCode)    
                {
                    this.server = server;
                }
            }
            //프로젝트 생성
            MdlProject p = new MdlProject(serverCode, server.OwnerCode, title);
            // 서버에 보내기
            SvcDistributor.Instance.PutProject(p);
            
            // 프로젝트 폼에 서버이름, 시작날짜, 종료날짜, 프로젝트코드(이게 프로젝트 폼의 이름이 됨) 전달
            CheckListProject checkListProject = new CheckListProject(title, serverCode, startDay, endDay, projectCode);

            //ProjectContainer.Instance.GetListItems()
            
            //프로젝트 폼을 리스트에 저장
            projects.Add(checkListProject);

            AddUpdateProject();
            
            //페널에 정보 표시 해줌
            CreateProjectPanel(title, serverCode, startDay, endDay, projectCode);
            projectCode++;
            serverCodeStatus = serverCode;
        }

        // 프로젝트를 페널에 추가 / 업데이트
        public void AddUpdateProject()
        {
            for (int i = 0; i < projects.Count; i++)
            {
                projects[i].SendToBack();
                projects[i].Dock = DockStyle.Top;
                panel6.Controls.Add(projects[i]);
            }
        }

        //프로젝트 정보 Panel에 보여주기
        //주제, 기간, 참여자(서버에 속해있는 사람 리스트), 업무목록(List) ,완료된 업무목록(List)를 인수로 받아 옴
        public void CreateProjectPanel(string title, int serverCode, string startDay, string endDay, int projectCode)
        {
            // 현재 패널에 보여주는 프로젝트 코드
            projectCodeStatus = projectCode; 
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

            //체크리스트 업데이트
            AddCheckListWork();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            CheckListWorkPopup checkListWorkPopup = new CheckListWorkPopup(serverCodeStatus); //정보넘겨줌
            checkListWorkPopup.ShowDialog();
            AddCheckListWork();
        }


        //정보 바뀌었을때 페널 정보 갱신
        public void EditProject(string title, string startDay, string endDay, int serverCode)
        {
            for (int i = 0; i < projects.Count; i++)
            {
                if (projects[i].Name == projectCodeStatus.ToString())
                {
                    //정보 변경
                    projects[i].EditInfo(serverCode, startDay, endDay);

                    CreateProjectPanel(title, serverCode, startDay, endDay, projectCodeStatus);
                }
            }
            
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < projects.Count; i++)
            {
                if (projects[i].Name == projectCodeStatus.ToString())
                {
                    // 프로젝트 삭제
                    projects.RemoveAt(i);
                    panel4.Visible = false;
                }
                    
            }
            AddUpdateProject();
        }

        

        //체크리스트 업데이트
        public void AddCheckListWork()
        {
            for (int i = 0; i < projects.Count; i++)
            {
                if (projects[i].Name == projectCodeStatus.ToString())
                {
                    CLBox.DataSource = null;  // 데이터바인딩 해제
                    CLBox.Items.Clear();      // 아이템 초기화
                    CLBox.DataSource = projects[i].works;   // 데이터 연결
                    CLBox.DisplayMember = "Work";
                    CLBox.ValueMember = "CodetoString";
                    //projects[i].works
                }

            }
        }

        private void CLBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            //code 검색
            //삭제
            //리셋
        }
    }
}
