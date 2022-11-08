using MainForm.Controls;
using MainForm.PopupControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm
{
    public partial class MainPage : Form
    {
        public static MainPage? mainPage;
        public MsgPage msgPage = new MsgPage();
        public CalendarPage calendarPage = new CalendarPage();
        public List<ServerBtn> serverBtns = new List<ServerBtn>();
        public List<ServerPage> serverPages = new List<ServerPage>();      

        private Point mousePoint;

        //ServerPage serverPage = new ServerPage("server1");
        //private static int serverPageIndex;
        /*
        public static int ServerPageIndex
        {
            get
            {
                return serverPageIndex;
            }
            set
            {
                serverPageIndex = value;              
            }
        }
        
        public Panel Panel8
        {
            get
            {
                return this.panel8;
            }

            set
            {
                this.panel8.Controls.Add(value);
            }
            
        }
        */
        public MainPage()
        {
            mainPage = this;
            InitializeComponent();
            panel8.Controls.Add(calendarPage);
            panel8.Controls.Add(msgPage);
            //panel8.Controls.Add(serverPage);
            msgPage.Visible = true;
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            this.Visible = false;
            var loginPage = new LoginForm();
            loginPage.ShowDialog();
            
            if(loginPage.LoginStatus == 0)
            {
                this.Close();
            }
            else
            {
                this.Visible = true;
            }            
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y); //지금 윈도우의 좌표저장
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int x = mousePoint.X - e.X;
                int y = mousePoint.Y - e.Y;
                Location = new Point(this.Left - x, this.Top - y);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {           
            calendarPage.Visible = false;
            msgPage.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {          
            msgPage.Visible = false;
            calendarPage.Visible = true;
        }

        private void profileBtn_Click(object sender, EventArgs e)
        {
            var profile = new Profile();
            profile.ShowDialog();
        }

        

        private void serverAddBtn_Click(object sender, EventArgs e)
        {
            
            var serverAddPopup = new ServerAddPopup();
            serverAddPopup.ShowDialog();
            //string SName;
            
            var serverBtn = new ServerBtn(serverAddPopup.ServerName);
            serverBtns.Add(serverBtn);
            var serverPage = new ServerPage(serverAddPopup.ServerName);
            serverPages.Add(serverPage);
            panel11.Controls.Add(serverBtn);
            serverBtns[0].SendToBack();
            serverBtns[0].Dock = DockStyle.Top;
            
            panel8.Controls.Add(serverPages[0]);
            msgPage.Visible = false;
            calendarPage.Visible = false;
            serverPages[0].Visible = true;
        }

        public void ServerPageChange(string SBtn)
        {
            for (int i = 0; i < serverPages.Count; i++)
            {
                if (SBtn == serverPages[i].Name)
                {
                    panel8.Controls.Add(serverPages[i]);
                    break;
                }
            }
        }

    }
}
