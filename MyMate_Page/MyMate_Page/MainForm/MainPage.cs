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
        //string serverName = "";

        private Point mousePoint;

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
        }

        public void AddServerBtn(string serverName)
        {
            var serverBtn = new ServerBtn(serverName);
            serverBtns.Add(serverBtn);
            var serverPage = new ServerPage(serverName);
            serverPages.Add(serverPage);

            for(int i = 0;serverBtns.Count > i; i++)
            {
                if (serverName == serverBtns[i].Name)
                {
                    panel11.Controls.Add(serverBtns[i]);
                    serverBtns[i].SendToBack();
                    serverBtns[i].Dock = DockStyle.Top;
                    panel8.Controls.Add(serverPages[i]);
                    serverPages[i].Visible = true;
                    msgPage.Visible = false;
                    calendarPage.Visible = false;
                }
                else
                {
                    serverPages[i].Visible = false;
                }                
                
                
            }
            
        }

        public void ServerPageChange(string SBtn)
        {
            for (int i = 0; i < serverPages.Count; i++)
            {
                if (SBtn == serverPages[i].Name)
                {
                    serverPages[i].Visible = true;
                    msgPage.Visible = false;
                    calendarPage.Visible=false;
                }
                else
                {
                    serverPages[i].Visible = false;
                }
            }
        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
