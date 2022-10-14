using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yeji.MyControls
{
    public partial class MyChetting : UserControl
    {
        private Image ?img;

        public MyChetting()
        {
            InitializeComponent();
        }

        public string Message
        {
            get
            {
                return MsgText.Text;
            }
            set
            {
                MsgText.Text = value;
            }
        }
        

        void AdjustHeight()
        {
            
            MsgText.Height = Utility.GetTextHeight(MsgText) + 10;

            Bubble.Height = MsgText.Top + Bubble.Top + MsgText.Top;

            this.Height = Bubble.Bottom + 10;
        }

       

        private void MyChetting_DockChanged(object sender, EventArgs e)
        {
            AdjustHeight();
        }

        private void MyChetting_Resize(object sender, EventArgs e)
        {
            AdjustHeight();
        }
    }
}
