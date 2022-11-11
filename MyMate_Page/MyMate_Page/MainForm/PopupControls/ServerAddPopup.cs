using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MainForm.PopupControls
{
    public partial class ServerAddPopup : Form
    {

        private string serverName;

        public string ServerName
        {
            get { return serverName; }
            set { serverName = value; }
        }

        public List<string> chatMember = new List<string>();       

        public ServerAddPopup()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OKBtn_Click(object sender, EventArgs e)
        {
            ServerName = serverNameTxt.Text;
            if (ServerName == "")
            {
                MessageBox.Show("서버이름을 입력하세요!", "안내");
            }
            else if(userList.CheckedItems.Count == 0)
            {
                MessageBox.Show("멤버를 선택하세요!", "안내");
            }
            else
            {
                for (int i = 0; i < userList.Items.Count; i++)
                {
                    if (userList.GetItemChecked(i))
                    {
                        chatMember.Add(userList.SelectedItem.ToString());
                    }
                }
                
                MainPage.mainPage.AddServerBtn(ServerName);
                this.Close();
            }
            
            
        }
    }
}
