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
    public partial class FriendPageItem : UserControl
    {
        public FriendPageItem(MdlFriend f)
        {
            InitializeComponent();
            Initialize(f);
        }

        public void Initialize(MdlFriend f)
        {
            this.lblUsername.Text = f.Nickname;
            return;
        }
    }
}
