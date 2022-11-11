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
    public partial class CheckListProject : UserControl
    {
        public CheckListProject(string title)
        {
            InitializeComponent();
            label1.Text = "[" + "]";
            label2.Text = "진척도 - ";
            label3.Text = "기한 - ";
            
        }
    }
}
