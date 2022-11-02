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
    public partial class MsgPage : UserControl
    {
        

        public MsgPage()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            this.Visible = false;
            
            
            
        }

        void RSend()
        {
            if (chatTxt.Text.Trim().Length == 0)
                return;

            RChat(chatTxt.Text);
            chatTxt.Text = String.Empty;
                       
        }

        void LSend()
        {
            if (chatTxt.Text.Trim().Length == 0)
                return;

            LChat(chatTxt.Text);
            chatTxt.Text = String.Empty;

        }

        private void MsgPage_Load(object sender, EventArgs e)
        {
           
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            LSend();
        }

        void RChat(string message)
        {
            
            var rchat = new Controls.Rchat(chatPanel.Width, message);
            chatPanel.Controls.Add(rchat);
            rchat.BringToFront();
            rchat.Dock = DockStyle.Top;
            
           
        }

        void LChat(string message)
        {

            var lchat = new Controls.Lchat(chatPanel.Width, message);
            chatPanel.Controls.Add(lchat);
            lchat.BringToFront();
            lchat.Dock = DockStyle.Top;


        }

        
    }
}
