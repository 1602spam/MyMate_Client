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
    public partial class DaySchedule : UserControl
    {
        public DaySchedule(string Title, DateTime StartDate, DateTime EndDate)
        {
            InitializeComponent();
            titleTxt.Text = Title;
            STxt.Text = StartDate.ToString();
            Etxt.Text = EndDate.ToString();
        }
    }
}
