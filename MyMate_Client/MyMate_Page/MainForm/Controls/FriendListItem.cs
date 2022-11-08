using ClientModules.Containers;
using ClientModules.Models;
using ClientModules.Models.Chat;
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
            //유저에 종속되는 1대1 채팅, 그룹 채팅방, 서버
            //유저코드를 대상으로 한 채팅방 탐색
            //이미 있다면 해당 채팅방을 불러옴
            //없다면 유저코드를 대상으로 채팅방 개설
        }
    }
}