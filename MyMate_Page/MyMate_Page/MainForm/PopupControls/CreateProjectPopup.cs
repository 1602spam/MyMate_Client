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
        public CreateProjectPopup()
        {
            InitializeComponent();
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
            //프로젝트 생성이 안되는 조건 넣어주기

            //프로젝트객체 생성하는 함수 호출
            //프로젝트 정보 함수에게 넘겨주기
            //프로젝트 이름, 대상 서버, 시작날짜, 종료날짜 넘겨줌

            if(serverComboBox.SelectedItem.ToString() == "내 서버")
            {
                int ServerCode = 1; //임시 데이터 : 내서버라고 할때 1 넘겨줌
            }
            //MainPage.mainPage.checkListPage.CreateProject(projectNameTxt.Text, ServerCode, startDayTxt.Text, endDayTxt.Text);
        }
    }
}
