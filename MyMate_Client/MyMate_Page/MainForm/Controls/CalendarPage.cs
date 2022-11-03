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
    public partial class CalendarPage : UserControl
    {
        public CalendarPage()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            this.Visible = false;
        }
    }
}
