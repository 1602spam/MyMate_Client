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
    public partial class MainBar : UserControl
    {
        public MainBar()
        {
            InitializeComponent();
            this.Dock = DockStyle.Top;
        }

        private void MsgBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var calendarPage = new CalendarPage();
            
        }
    }
}
