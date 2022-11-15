using ClientModules.Models;
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
    public partial class UserProfilePopup : Form
    {
        public MdlUser User { get; set; }

        public UserProfilePopup(MdlUser u)
        {
            InitializeComponent();
            User = u;
            lblName.Text = "Username: "+ u.Username;
            lblEmail.Text = "E-mail: "+u.Email;
            lblIntroduction.Text = "Introduction: "+u.Introduction;
        }

        private Point mousePoint;

        private void Profile_Move(object sender, EventArgs e)
        {
            
        }

        private void Profile_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int x = mousePoint.X - e.X;
                int y = mousePoint.Y - e.Y;
                Location = new Point(this.Left - x, this.Top - y);
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nameLabel_Click(object sender, EventArgs e)
        {

        }

        private void Profile_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y); //지금 윈도우의 좌표저장
        }

        private void statusLabel_Click(object sender, EventArgs e)
        {

        }

        private void UserProfilePopup_Load(object sender, EventArgs e)
        {

        }
    }
}
