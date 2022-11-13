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
    public partial class ServerChatListItem : UserControl
    {
        private MdlChatroom chatroom;
        public MdlChatroom Chatroom {
            get {
                if (chatroom == null) { return new(); }
                else return chatroom;
            }
            set {
                chatroom = value;
                Initialize();
            }}

        public ServerChatListItem(MdlChatroom ch)
        {
            InitializeComponent();
            this.Chatroom = ch;
        }

        public void Initialize()
        {
            chatTileTxt.Text = Chatroom.Title;
            if (MainPage.mainPage != null)
            {
                if (MainPage.mainPage.msgPage.Server != null)
                {
                    if (this.Chatroom.Code == MainPage.mainPage.msgPage.Chatroom.Code &&
                        this.chatroom.ServerCode == MainPage.mainPage.msgPage.Server.Code)
                    {
                        button1.BackColor = Color.White;
                    }
                    else button1.BackColor = Color.FromArgb(240,240,240);
                }
            }
        }

        private void chatTileTxt_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainPage.mainPage.msgPage.ClearChat();
            //여기에 채팅 불러오는 함수
        }
    }
}
