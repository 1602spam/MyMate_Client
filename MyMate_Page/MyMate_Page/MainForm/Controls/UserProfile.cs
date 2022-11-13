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
    public partial class UserProfile : UserControl
    {
        public UserProfile(MdlUser user)
        {
            InitializeComponent();
            this.Name = user.Username;
            userNameTxt.Text = user.Username;
        }
    }
}
