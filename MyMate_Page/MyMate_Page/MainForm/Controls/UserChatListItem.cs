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
    public partial class UserChatListItem : UserControl
    {
        private MdlServer? server;
        public MdlServer Server
        {
            get {
                if (server == null)
                {
                    return new();
                }
            return server;
            }
            set {
                server = value;
                Initialize();
            }
        }
        //IsCompact가 true인 서버를 나타내는 개인 채팅방 버튼
        //개인 채팅방 이름을 표시
        public UserChatListItem(MdlServer s)
        {
            InitializeComponent();
            this.Server = s;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainPage.mainPage.msgPage.SwitchChat(Server.Code);
        }

        public void Initialize()
        {
            if (MainPage.mainPage != null)
            {
                if (MainPage.mainPage.msgPage.Server != null)
                {
                    if (this.Server.Code == MainPage.mainPage.msgPage.Server.Code)
                    {
                        button1.BackColor = Color.White;
                    }
                    else button1.BackColor = Color.FromArgb(240, 240, 240);
                }
            }

            if (Name.Length > 8)
            {
                userNameTxt.Text = server.Title.Substring(0, 10) + "...";
            }
            else
            {
                userNameTxt.Text = server.Title;
            }
        }
    }
}
