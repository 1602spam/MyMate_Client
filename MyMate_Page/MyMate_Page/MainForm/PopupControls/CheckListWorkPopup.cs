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
    public partial class CheckListWorkPopup : Form
    {
        //CheckListProject에 있는 Works 저장 할 리스트
        List<CheckListWork> CLW = new List<CheckListWork>(); 
        // 서버 코드
        int ServerCode;
        public CheckListWorkPopup(int serverCode)
        {
            InitializeComponent();
            //서버코드 CheckListPage로 부터 받아 옴
            ServerCode = serverCode;
            // 내 서버라는 레이블 추가????????
            //CheckListProject 에 있는 Works 리스트 가지고 옴
            // for 문!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            CLW = MainPage.mainPage.checkListPage.projects[0].works;
            //리스트 정보 업데이트
            UpdateWork(CLW);
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editProjectBtn_Click(object sender, EventArgs e)
        {
            //text 빈칸인지 아닌지 조건 넣어줘야 함
            MainPage.mainPage.checkListPage.EditProject(projectNameTxt.Text, startDayTxt.Text, endDayTxt.Text, ServerCode);
            this.Close();
        }

        private void addWorkBtn_Click(object sender, EventArgs e)
        {
            //for 문 넣기
            CLW = MainPage.mainPage.checkListPage.projects[0].AddWork(workTxt.Text);
            //새로고침함수
            UpdateWork(CLW);
            workTxt.Text = "";

        }

        //새로고침함수 (리스트 보여주기)
        public void UpdateWork(List<CheckListWork> clw) 
        {
            //리스트 가지고와서 뿌려주기
            workListBox.DataSource = null;  // 데이터바인딩 해제
            workListBox.Items.Clear();      // 아이템 초기화
            workListBox.DataSource = clw;   // 데이터 연결
            workListBox.DisplayMember = "Work";
            workListBox.ValueMember = "CodetoString";
        }


        //삭제버튼 눌렷을때
        private void removeWorkBtn_Click(object sender, EventArgs e)
        {
            
            if (workListBox.SelectedItem != null)
            {
                //for문 넣기
                CLW = MainPage.mainPage.checkListPage.projects[0].RemoveWork(workListBox.SelectedValue.ToString());
                UpdateWork(CLW);
            }
            else
            {
                MessageBox.Show("업무를 선택하세요!", "안내");
            }
            
            
        }


         
        /* 선택됐는지 조건
         * 선택됐으면 코드 넘겨주기 project 로
         * 돌아오면 새로고침 함수 호출
         */
    }
}
