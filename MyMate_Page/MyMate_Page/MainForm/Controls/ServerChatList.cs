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
    public partial class ServerChatList : UserControl
    {
        public ServerChatList(string Sname)
        {
            InitializeComponent();
            serverNameLabel.Text = Sname;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
