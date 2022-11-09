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
    public partial class FriendList : Form
    {
        private string userName = "";
        public string UserName
        {
            get
            {
                return userName;
            }
            set
            {
                userName = value;
            }
        }
        public FriendList()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //확인버튼 눌렀을 때
            for (int i = 0; i < userListBox.Items.Count; i++)
            {
                if (userListBox.GetItemChecked(i))
                {                    
                    UserName = userListBox.SelectedItem.ToString();

                    for (int k = 0; i < MainPage.mainPage.msgPage.Uchats.Count; i++)
                    {
                        if (userName == MainPage.mainPage.msgPage.Uchats[i].Name)
                        {
                            MessageBox.Show("이미 채팅방이 존재합니다.", "안내");
                            userName = "";
                            return;
                        }
                    }
                    
                    
                    {
                        MainPage.mainPage.msgPage.AddChatList(UserName);
                        this.Close();
                    }
                    
                    
                }                
            }

            if (userName == "")
            {
                MessageBox.Show("친구를 선택하세요!", "안내");
            }
                       
        }

        private void userListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int i = 0; i < userListBox.Items.Count; i++)
            {
                if (e.Index != i)
                {
                    userListBox.SetItemChecked(i, false);
                }
            }
        }
    }
}
