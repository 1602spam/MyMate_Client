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
    public partial class CheckListWorkPopup : Form
    {
        int ServerCode;
        public CheckListWorkPopup(int serverCode)
        {
            InitializeComponent();
            ServerCode = serverCode;
            // 내써버라는 레이블 추가?
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editProjectBtn_Click(object sender, EventArgs e)
        {
            //text 빈칸인지 아닌지 조건 넣어줘야 함
            MainPage.mainPage.checkListPage.EditProject(projectNameTxt.Text, startDayTxt.Text, endDayTxt.Text, ServerCode);
            this.Close();
        }
    }
}
