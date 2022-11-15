using ClientModules.Containers;
using ClientModules.Models.CheckList;
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

        public MdlProject Project { get; set; }
        public List<CheckListWork> works = new List<CheckListWork>();

        public CheckListProject(MdlProject v)
        {
            InitializeComponent();
            this.Project = v;
            Invalidate();
            
            //폼 이름을 projectCode로 줌
            this.Name = Convert.ToString(Project.Code);
        }        

        //프로젝트 
        private void projectBtn_Click(object sender, EventArgs e)
        {
            // 프로젝트 정보 바꾸는 함수 호출
            MainPage.mainPage.checkListPage.SwitchProject(this.Project);
            //가서 진짜로 프로젝트 정보 바꿔줘야함
        }

        //프로젝트 업데이트
        public void Invalidate()
        {
            string str = ServerContainer.Instance.Items.Values.FirstOrDefault(MdlServer => MdlServer.Code == this.Project.ServerCode).Title;
            label1.Text = "[ 서버 " + str + "의 프로젝트]";
            label2.Text = "진척도 - 0 %";
            label3.Text = "기한 - "; // + startDay + " ~ " + endDay;
        }
    }
}
