using ClientModules.Models;
using ClientModules.Services;
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
    public partial class FriendPageItem : UserControl
    {
        public MdlFriend friend { get; set; }
        public FriendPageItem(MdlFriend f)
        {
            InitializeComponent();
            friend = f;
            Initialize(f);
        }

        public void Initialize(MdlFriend f)
        {
            friend = f;
            this.lblUsername.Text = friend.Nickname;
            return;
        }

        private void rbtnRemove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("정말로 삭제하시겠습니까?", "친구 삭제", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                SvcDistributor.Instance.PutFriend(new MdlFriend(friend.FriendCode, true));
                MessageBox.Show("asd");
            }
        }
    }
}
