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
    public partial class CheckListProject : UserControl
    {
        public CheckListProject(string title, int serverCode, string startDay, string endDay)
        {
            InitializeComponent();
            label1.Text = "[ 서버 " + serverCode + "의 프로젝트]";
            label2.Text = "진척도 - 0 %";
            label3.Text = "기한 - " + startDay + " ~ " + endDay;
            //우선 제목으로 프로젝트 구별.. 추후 바꿔야됨 프로젝트 코드로..
            this.Name = title; 
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void projectBtn_Click(object sender, EventArgs e)
        {
            // 프로젝트 정보 바꾸는 함수 호출
            //MainPage.mainPage.CheckListPage.CreateProjectPanel();
        }
    }
}
