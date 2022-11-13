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
        int ProjectCode = 0;
        public CreateProjectPopup()
        {
            InitializeComponent();
            // 콤보 박스에 서버 이름 목록 넣어주기
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

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
                int ServerCode = 0;
                if (serverComboBox.SelectedItem.ToString() == "내 서버")
                {
                    ServerCode = 1; // 임시 데이터 : 콤보박스에서 내서버 선택 됐을때 할때 1 넘겨줌
                }

                //프로젝트객체 생성하는 함수 호출 : 프로젝트 이름, 대상 서버,프로젝트 코드, 시작날짜, 종료날짜 넘겨줌
                MainPage.mainPage.checkListPage.CreateProject(projectNameTxt.Text, ServerCode, startDayTxt.Text, endDayTxt.Text);
                this.Close();
            }
        }
    }
}
