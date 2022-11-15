using ClientModules.Containers;
using ClientModules.Models;
using ClientModules.Models.Calendar;
using ClientModules.Models.Chat;
using ClientModules.Models.CheckList;
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
    public partial class ShareChat : UserControl
    {
        public MdlProject Project { get; set; }
        public MdlSchedule Schedule { get; set; }
        public MdlServer Server { get; set; }
        public MdlMessage Message { get; set; }

        public ShareChat(MdlMessage m, int type, int code)
        {
            InitializeComponent();
            this.Message = m;
            MdlUser? user = UserContainer.Instance.Items.Values.FirstOrDefault(MdlUser => MdlUser.Code == Message.Creator);
            if (user == null) {
                return;
                }
            switch (type) {
                case 1:
                    //캘린더
                    MdlSchedule? schedule = ScheduleContainer.Instance.Items.Values.FirstOrDefault(MdlSchedule => MdlSchedule.Code == code);
                    if (schedule == null)
                        return;
                    else
                        this.Schedule = schedule;
                    btnReceive.Click+=new EventHandler(OpenCalendarPage);
                    break;
                case 2:
                    //프로젝트
                    MdlProject? project = ProjectContainer.Instance.Items.Values.FirstOrDefault(MdlProject => MdlProject.Code == code);
                    if (project == null)
                        return;
                    else
                        this.Project = project;
                    btnReceive.Click+=new EventHandler(OpenCheckListPage);
                    break;
                case 3:
                    //서버
                    MdlServer? server = ServerContainer.Instance.Items.Values.FirstOrDefault(MdlServer => MdlServer.Code == code);
                    if (server == null)
                        return;
                    else
                        this.Server = server;
                    btnReceive.Click += new EventHandler(OpenServerPage);
                    break;
                default:
                    break;
            }
        }

        public void OpenCalendarPage(object sender, EventArgs e)
        {
            MainPage.mainPage.ShowCalendarPage();
        }

        public void OpenCheckListPage(object sender, EventArgs e)
        {
            MainPage.mainPage.ShowCheckListPage();
        }

        public void OpenServerPage(object sender, EventArgs e)
        {
            //MainPage.mainPage.ShowPage();
        }

    }
}
