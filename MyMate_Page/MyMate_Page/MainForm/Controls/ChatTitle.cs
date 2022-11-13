using ClientModules.Models.Chat;
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
        public MdlChatroom chatroom { get; set; }

        public ChatTitle(MdlChatroom ch)
        {
            InitializeComponent();
            this.chatroom = ch;
            chatTileTxt.Text = chatroom.Title;
        }

        private void chatTileTxt_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainPage.mainPage.msgPage.ClearChat();
            //여기에 챗 추가 함수
        }
    }
}
