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

        private void chatTileTxt_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainPage.mainPage.msgPage.ChatClear();
            //여기에 챗 추가 함수
        }
    }
}
