using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yeji.View.Controls;

namespace Yeji.MyControls
{
    public partial class OtherChetting : UserControl
    {
        private Image? img;
        public int ChettingPanelSize { get; set; }

        public OtherChetting(int ChettingPanelSize)
        {
            InitializeComponent();
            this.ChettingPanelSize = ChettingPanelSize;
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
                AdjustHeight();
            }
        }
        public Image Img { get => ProfileImg.Image; set => ProfileImg.Image = value; }
        

        public void AdjustHeight()
        {
            ProfileImg.Location = new Point(1,20);

            MsgText.MaximumSize = new Size(ChettingPanelSize / 3 * 2, 0);
            

            MsgText.Height = Utility.GetTextHeight(MsgText) + 10;
            MsgText.Width = Utility.GetTextWeight(MsgText) + 10;

            Bubble.Height = MsgText.Height + 17;
            Bubble.Width = MsgText.Width + 19;
            //Bubble.Height = MsgText.Top + ProfileImg.Top;

            this.Height = Bubble.Bottom + 10;
        }

        private void OtherChetting_Resize(object sender, EventArgs e)
        {
            AdjustHeight();
            //int size = MsgText.Text.Trim().Length;
        }

        
    }
}
