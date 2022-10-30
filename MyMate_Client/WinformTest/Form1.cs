using ClientModules.Containers;
using ClientModules.Models;
using Microsoft.VisualBasic.ApplicationServices;

namespace WinformTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.btnEdit.Enabled = false;
            this.tbCode.Text = "";
            this.tbDesc.Text = "";
            updateListView();

            UserContainer.Instance.DataDistributedEvent += updateListView;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int code = int.Parse(this.tbCode.Text);
            string desc = this.tbDesc.Text;
            MdlUser user = new(code, "asdf", "asdf", 1, "asdf", "01011010101", desc);
            UserContainer.Instance.AddOrUpdate(code,user);
        }

        private void tryToActivateButton()
        {
            if (this.tbCode.Text != "" && this.tbDesc.Text != "")
                this.btnEdit.Enabled = true;
            else
                this.btnEdit.Enabled = false;
        }

        private void updateListView()
        {
            this.lvUsers.Items.Clear();
            IEnumerable<MdlUser> users = UserContainer.Instance.Dict.Values;
            foreach (MdlUser u in users)
            {
                this.lvUsers.Items.Add(new ListViewItem(new String[] { u.Code.ToString(), u.Username, u.Introduction }));
            }
        }

        private void tbCode_TextChanged(object sender, EventArgs e)
        {
            tryToActivateButton();
        }

        private void tbDesc_TextChanged(object sender, EventArgs e)
        {
            tryToActivateButton();
        }
    }
}