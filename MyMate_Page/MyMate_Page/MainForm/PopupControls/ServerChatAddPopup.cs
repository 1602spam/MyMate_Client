using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm.PopupControls
{
    public partial class ServerChatAddPopup : Form
    {
        public string SName;
        public ServerChatAddPopup(string sname)
        {
            InitializeComponent();
            this.SName = sname;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OKBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < MainPage.mainPage.serverPages.Count; i++)
            {
                if(MainPage.mainPage.serverPages[i].Name == SName)
                {
                    MainPage.mainPage.serverPages[i].SCL.AddCaht(chatNameTxt.Text);
                }
            }
            
            this.Close();
        }

        private void chatNameTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
