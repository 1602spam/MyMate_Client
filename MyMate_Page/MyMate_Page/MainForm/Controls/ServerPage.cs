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
    public partial class ServerPage : UserControl
    {
        //서버 버튼을 누르면 표시되는 서버 페이지
        //서버 채팅방 리스트(캘린더, 체크리스트 포함)
        public ServerChatList SCL;
        //서버 내 유저 목록
        public ServerFriends SF;
        //서버 채팅방으로 구성
        public ServerChat SC;
        public MdlServer server { get; set; }

        public ServerPage(MdlServer s)
        {
            InitializeComponent();

            server = new();
            Initialize(s);
            
            SF = new ServerFriends(server);
            SF.Dock = DockStyle.Fill;

            SCL = new ServerChatList(server);
            SCL.Dock = DockStyle.Fill;

            SC = new ServerChat();
            SC.Dock = DockStyle.Fill;

            SChatListPanel.Controls.Add(SCL);
            SChatPanel.Controls.Add(SC);
            SFriendsPanel.Controls.Add(SF);

            this.Visible = false;
            this.Dock = DockStyle.Fill;
        }

        private void Initialize(MdlServer s)
        {
            //서버 정보가 변할 때마다 호출됨
            this.server = s;
            this.Name = server.Title;
        }
    }
}
