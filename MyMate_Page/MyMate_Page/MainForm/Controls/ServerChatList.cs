using MainForm.PopupControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm.Controls
{
    public partial class ServerChatList : UserControl
    {
        public List<ChatTitle> chatTitles = new List<ChatTitle>();
        public string SName;
        public ServerChatList(string Sname)
        {
            InitializeComponent();
            serverNameLabel.Text = "- "+ Sname;
            this.SName = Sname;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void addChatBtn_Click(object sender, EventArgs e)
        {
            ServerChatAddPopup serverChatAddPopup = new ServerChatAddPopup(SName);
            serverChatAddPopup.ShowDialog();
        }

        public void AddCaht(string title)
        {
            ChatTitle chatTitle = new ChatTitle(title);
            chatTitles.Add(chatTitle);
            chatTitle.SendToBack();
            chatTitle.Dock = DockStyle.Top;
            panel3.Controls.Add(chatTitle);
        }
    }
}
