using ClientModules.Models;
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

namespace MainForm.Controls
{
    public partial class UserProfile : UserControl
    {
        public MdlUser user { get; set; }
        
        public UserProfile(MdlUser user)
        {
            InitializeComponent();
            this.user = user;
            this.Name = user.Username;
            userNameTxt.Text = user.Username;
        }

        private void userprofileBtn_Click(object sender, EventArgs e)
        {
            UserProfilePopup profile = new UserProfilePopup(user);
            profile.ShowDialog();
        }
    }
}
