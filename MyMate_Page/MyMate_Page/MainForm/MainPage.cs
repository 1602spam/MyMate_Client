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
        //ServerPage serverPage = new ServerPage("server1");
        MsgPage msgPage = new MsgPage();
        CalendarPage calendarPage = new CalendarPage();
        List<ServerBtn> Serverlist = new List<ServerBtn>();
        public static List<ServerPage> serverPages = new List<ServerPage>();


        /*public int loginStatus
        {
            get
            {
                return loginStatus;
            }
            set
            {
                loginStatus = value;
                
            }
        }
        */

        public MainPage()
        {
            InitializeComponent();
            panel8.Controls.Add(calendarPage);
            panel8.Controls.Add(msgPage);
            //panel8.Controls.Add(serverPage);
            msgPage.Visible = true;
        }

        

        private Point mousePoint;

        private void MainPage_Load(object sender, EventArgs e)
        {
            this.Visible = false;
            var loginPage = new LoginForm();
            loginPage.ShowDialog();
            //this.loginStatus = loginPage.loginStatus;
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

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void serverBtn_Click(object sender, EventArgs e)
        {
            //serverPage.Visible = true;
            msgPage.Visible = false;
        }

        private void serverAddBtn_Click(object sender, EventArgs e)
        {
            msgPage.Visible = false;
            var serverAddBtn = new ServerAddPopup();
            serverAddBtn.ShowDialog();
            string SName;
            
            var serverBtn = new ServerBtn(serverAddBtn.ServerName);
            Serverlist.Add(serverBtn);
            panel11.Controls.Add(serverBtn);
            serverBtn.SendToBack();
            serverBtn.Dock = DockStyle.Top;

            
            panel8.Controls.Add(serverPages[0]);
        }

        
    }
}
