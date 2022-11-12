using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yeji
{
	public partial class FriendListPopup : Form
	{
		private string checkItem = "";
		public string ?CheckItem { get; set; }
		public FriendListPopup()
		{
			InitializeComponent();
		}

		private void OkBtn_Click(object sender, EventArgs e)
		{
			//체크된 게 있다면 체크된 것만큼 반복, 없다면 친구 선택하십시오 출력

			if (checkedListBox1.SelectedIndex == -1)
			{
				MessageBox.Show("친구를 선택하십시오.", "도움말");
			}
			else
			{
				for (int i = 0; i < checkedListBox1.Items.Count; i++)
				{
					this.CheckItem = checkedListBox1.SelectedItems.ToString();
				}
				this.Close();
			}


		}

		private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
		{
			if (e.NewValue == CheckState.Checked)
				for (int i = 0; i < checkedListBox1.Items.Count; ++i)
					if (e.Index != i) checkedListBox1.SetItemChecked(i, false);
		}
	}
}
