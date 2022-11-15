using ClientModules.Containers;
using ClientModules.Models;
using ClientModules.Models.Calendar;
using ClientModules.Models.Chat;
using ClientModules.Services;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace MainForm.Controls
{
    public partial class CalendarPage : UserControl
    {
        //스케줄 리스트
        List<MdlSchedule>? Schedules = new();
        //스케줄 항목 리스트
        List<MdlScheduleItem> ScheduleItems = new();
        //현재 활성화한 스케줄의 코드 리스트
        List<int> CurrentActivatedScheduleCodes = new();

        public CalendarPage()
        {
            //폼 설정
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            this.Visible = false;
            refreshlvItem();
            refreshlvSchedule();
            tbStartDate.Text = "2001-08-11";
            tbEndDate.Text = "2001-08-11";
            ScheduleContainer.Instance.DataDistributedEvent += AddOrUpdateSchedule;
        }

        private void CalendarPage_Load(object sender, EventArgs e)
        {
            int i = 0;

            //스케줄 탭을 열면 스케줄 컨테이너로부터 모두 가져와 Schedules에 넣고, 하위 항목도 ScheduleItems에 넣음
            //Schedules와 ScheduleItems는 표시 후보
            Schedules = ScheduleContainer.Instance.Items.Values.ToList();
            for (i = 0; i < Schedules.Count; i++)
            {
                List<MdlScheduleItem>? temp = ScheduleContainer.Instance.GetScheduleItems(i);
                if (temp != null)
                {
                    ScheduleItems.AddRange(temp);
                }
                i++;
            }
        }

        //스케줄을 가져와 리스트에 추가하거나 갱신하는 메서드
        private void AddOrUpdateSchedule(object v)
        {
            if (Schedules == null)
                return;

            MdlSchedule? item = v as MdlSchedule;
            if (item == null)
                return;

            MdlSchedule? schedule = Schedules.FirstOrDefault(MdlSchedule => MdlSchedule.Code == item.Code);
            if (schedule == null)
                Schedules.Add(item);
            else
            {
                Schedules.Add(item);
                Schedules.Remove(schedule);
            }

            refreshlvSchedule();
            return;
        }

        //스케줄 항목을 가져와 리스트에 추가하거나 갱신하는 메서드
        private void AddOrUpdateScheduleItem(object v)
        {
            if (ScheduleItems == null)
                return;

            //스케줄 항목 정보가 null일 경우 리턴
            MdlScheduleItem? item = v as MdlScheduleItem;
            if (item == null)
                return;

            MdlScheduleItem? scheduleitem = ScheduleItems.FirstOrDefault(MdlScheduleItem => MdlScheduleItem.Code == item.Code);
            if (scheduleitem == null)
                ScheduleItems.Add(item);
            else
            {
                ScheduleItems.Add(item);
                ScheduleItems.Remove(scheduleitem);
            }

            refreshlvItem();
            return;
        }

        private void refreshlvSchedule()
        {
            lvSchedule.Items.Clear();
            if (Schedules != null)
            {
                foreach (MdlSchedule item in Schedules)
                {
                    string[] arr = new string[] {
                        item.Code.ToString(),
                        item.ServerCode.ToString(),
                        item.OwnerCode.ToString(),
                        item.Title
                    };
                    lvSchedule.Items.Add(new ListViewItem(arr));
                }
            }
        }

        private void refreshlvItem()
        {
            lvItem.Items.Clear();
            foreach (int num in CurrentActivatedScheduleCodes)
            {
                List<MdlScheduleItem>? list = ScheduleContainer.Instance.GetScheduleItems(num);
                if (list != null)
                {
                    foreach (MdlScheduleItem item in list)
                    {
                        string[] arr = new string[] {
                            item.ScheduleCode.ToString(),
                            item.ServerCode.ToString(),
                            item.Code.ToString(),
                            item.Title,
                            item.StartDate.ToString("yyyy-MM-dd"),
                            item.EndDate.ToString("yyyy-MM-dd"),
                            item.Context,
                            item.Creator.ToString(),
                            item.IsPrivate.ToString()};
                        lvItem.Items.Add(new ListViewItem(arr));
                    }
                }
            }
        }



        private void btnAddSchedule_Click(object sender, EventArgs e)
        {
            MdlSchedule mdl = new MdlSchedule(
                Convert.ToInt32(tbSCode.Text),
                Convert.ToInt32(tbSServerCode.Text),
                Convert.ToInt32(tbSCreatorCode.Text),
                tbSTitle.Text);

            mdl.Items.DataDistributedEvent += AddOrUpdateScheduleItem;
            SvcDistributor.Instance.PutSchedule(mdl);
        }

        private void btnAddScheduleItem_Click(object sender, EventArgs e)
        {
            MdlScheduleItem mdl = new MdlScheduleItem(
                Convert.ToInt32(tbCode.Text),
                Convert.ToInt32(tbServerCode.Text),
                Convert.ToInt32(tbScheduleCode.Text),
                tbTitle.Text,
                Convert.ToDateTime(tbStartDate.Text),
                Convert.ToDateTime(tbEndDate.Text),
                tbContent.Text,
                Convert.ToInt32(tbCreator.Text),
                Convert.ToBoolean(cbIsPrivate.Text));

            SvcDistributor.Instance.PutScheduleItem(mdl);
        }

        private void lvSchedule_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurrentActivatedScheduleCodes = new();
            foreach (int i in lvSchedule.SelectedIndices)
            {
                CurrentActivatedScheduleCodes.Add(int.Parse(lvSchedule.Items[i].Text));
            }
            CurrentActivatedScheduleCodes.Sort();
            refreshlvItem();
        }
    }
}