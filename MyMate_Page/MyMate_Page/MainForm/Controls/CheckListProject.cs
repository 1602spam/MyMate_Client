using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm.Controls
{
    public partial class CheckListProject : UserControl
    {
        int workCode = 0;
        public List<CheckListWork> works = new List<CheckListWork>();
        string Title;
        int ServerCode;
        string StartDay;
        string EndDay;
        int ProjectCode;
        public CheckListProject(string title, int serverCode, string startDay, string endDay, int projectCode)
        {
            InitializeComponent();
            AddInfo(serverCode, startDay,endDay);
            //폼 이름을 projectCode로 줌
            this.Name = Convert.ToString(projectCode);

            this.Title = title;
            this.ServerCode = serverCode;
            this.StartDay = startDay;
            this.EndDay = endDay;
            this.ProjectCode = projectCode;
        }        

        private void projectBtn_Click(object sender, EventArgs e)
        {
            // 프로젝트 정보 바꾸는 함수 호출
            MainPage.mainPage.checkListPage.CreateProjectPanel(Title, ServerCode, StartDay, EndDay, ProjectCode);
            //가서 진짜로 프로젝트 정보 바꿔줘야함
        }

        //프로젝트 업데이트
        public void AddInfo(int serverCode, string startDay, string endDay)
        {
            label1.Text = "[ 서버 " + serverCode + "의 프로젝트]";
            label2.Text = "진척도 - 0 %";
            label3.Text = "기한 - " + startDay + " ~ " + endDay;
        }
        public void EditInfo(int serverCode, string startDay, string endDay)
        {
            label1.Text = "[ 서버 " + serverCode + "의 프로젝트]";
            //label2.Text = "진척도 - 0 %";
            label3.Text = "기한 - " + startDay + " ~ " + endDay;
        }
        public List<CheckListWork> AddWork(string workTxt)
        {
            CheckListWork checkListWork = new CheckListWork(workTxt, workCode);
            works.Add(checkListWork);
            workCode++;
            return works;
        }
        /* 넘겨받은 코드로 객체 찾아서 지우기*/
        public List<CheckListWork> RemoveWork(string workcode)
        {
            for (int i = 0; i < works.Count; i++)
            {
                if (works[i].WorkCode == workcode)
                {
                    works.RemoveAt(i);
                }
            }
            return works;
        }
    }
}
