using ClientModules.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm.Controls
{
    public partial class FriendListItem : UserControl
    {
        public int userCode { get; set; }
        
        public FriendListItem()
        {
            InitializeComponent();
        }

        public FriendListItem(MdlFriend friend)
        {
            this.lblUsername.Text = friend.Nickname;
            this.userCode = friend.FriendCode;
            this.btnChat.Click += OpenChat;
        }

        private void OpenChat(object? sender, EventArgs e)
        {
            //유저코드를 대상으로 한 채팅방 탐색
            //이미 있다면 해당 채팅방을 불러옴
            //없다면 유저코드를 대상으로 채팅방 개설
        }
    }
}
