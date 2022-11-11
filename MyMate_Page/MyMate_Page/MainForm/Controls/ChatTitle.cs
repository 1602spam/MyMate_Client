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
    public partial class ChatTitle : UserControl
    {
        public ChatTitle(string title)
        {
            InitializeComponent();
            this.Name = title;
            chatTileTxt.Text = title;
        }
    }
}
