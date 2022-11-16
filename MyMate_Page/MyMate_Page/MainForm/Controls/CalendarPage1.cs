using ClientModules.Containers;
using ClientModules.Models;
using ClientModules.Models.CheckList;
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
    public partial class CalendarPage1 : UserControl
    {
        int y, m;
        DateTime dateTime;
        public MdlProject Project { get; set; }

        public CalendarPage1()
        {
            InitializeComponent();
            this.Visible = false;
            dateTime = DateTime.Now;
            this.c.Set(dateTime.Year, dateTime.Month);
            y = dateTime.Year;
            m = dateTime.Month;
            roundButton1.Parent = this;
            roundButton2.Parent = this;

            c.Add("Test", new(2022, 10, 30), new(2022, 11, 3));
            c.Add("Test", new(2022, 11, 2), new(2022, 11, 2));
            c.Add("Test", new(2022, 11, 2), new(2022, 11, 3));
            c.Add("Test", new(2022, 11, 16), new(2022, 11, 16));
            c.Add("Test", new(2022, 11, 16), new(2022, 11, 16));
            c.Add("Test", new(2022, 11, 5), new(2022, 11, 10));
            c.Add("Test", new(2022, 11, 20), new(2022, 11, 26));
            c.Add("Test", new(2022, 11, 21), new(2022, 11, 24));
            c.Add("Test", new(2022, 11, 20), new(2022, 11, 25));
        }

        private void RBtn_Click(object sender, EventArgs e)
        {
            m = m + 1;
            if (m > 12)
            {
                y = y + 1;
                m = m - 12;
            }
            Panel7.Controls.Clear();
            Calender.Calender c = new Calender.Calender();
            //c.Clear();
            c.Set(y, m);
            c.Dock = DockStyle.Fill;
            Panel7.Controls.Add(c);
        }

        private void OKBtn_Click(object sender, EventArgs e)
        {
            if (yearTxt.Text == "" || MonTxt.Text == "" || DayTxt.Text == "" || m > 12 || m < 1 || y > 3000 || y < 1900)
            {
                MessageBox.Show("날짜를 입력하세요.", "안내");
            }
            else
            {
                y = Convert.ToInt32(yearTxt.Text);
                m = Convert.ToInt32(MonTxt.Text);
                Panel7.Controls.Clear();
                Calender.Calender c = new Calender.Calender();
                //c.Clear();
                c.Set(y, m);
                c.Dock = DockStyle.Fill;
                Panel7.Controls.Add(c);
                //int channel = 4;

                // 날짜에 해당하는 일정들을 가지고 와서 페널에 넣어 줌(for 문) /////////////해당 유저가 가지고있는 스케줄
                /*
                foreach(var s in ScheduleContainer.Instance.GetScheduleItems(Project.Code))
                {
                    c.Add(s.Title, s.StartDate, s.EndDate);
                    DaySchedule DS = new DaySchedule(s.Title, s.StartDate, s.EndDate);
                }

                string? str = ServerContainer.Instance.Items.Values.FirstOrDefault(MdlServer => MdlServer.Code == Project.ServerCode).Title;
                if (str != null) { }
                {
                    DaySchedule DS = new DaySchedule(str,); //누구의 스케줄인지, 제목, 시작날짜, 종료날짜 넘겨줌
                    UpdateDaySchedule();
                }*/
            }
        }

        // 하루 스케줄이 바뀔때마다 호출해서 DaySchedule 다시로드
        public void UpdateDaySchedule()
        {

        }

        // 나의 프로젝트 목록 가지고와서 보여주기, 새로고침
        public void UpdateProjectSchedule()
        {

        }

        private void LBtn_Click(object sender, EventArgs e)
        {
            m = m - 1;
            if (m < 1)
            {
                y = y - 1;
                m = m + 12;
            }
            Panel7.Controls.Clear();
            Calender.Calender c = new Calender.Calender();
            c.Set(y, m);
            c.Dock = DockStyle.Fill;
            Panel7.Controls.Add(c);
        }
    }
}
