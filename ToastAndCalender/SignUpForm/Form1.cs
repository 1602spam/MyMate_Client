namespace SignUpForm
{
	public partial class Form1 : Form
	{
		/*
		 * public string id;
            public string password;
            public string name;
            public string nickname;
            public string email;
            public string phone;
		 * 
		 */
		public Form1()
		{
			InitializeComponent();
		}

		private void btn_Cancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btn_SignUp_Click(object sender, EventArgs e)
		{
			do
			{
				if (this.tb_Id.Text == "")
					break;
				if (this.tb_Pw.Text == "")
					break;
				if (this.tb_PwChk.Text == "")
					break;
				if (!this.tb_Pw.Text.Equals(this.tb_PwChk.Text))
				{
					MessageBox.Show("��й�ȣ�� ��ġ���� �ʽ��ϴ�.", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				if (this.tb_Name.Text == "")
					break;
				if (this.tb_Nick.Text == "")
					break;
				if (this.tb_Email.Text == "")
					break;
				SignUpConditionSatisfy();
				return;
			} while (true);
			MessageBox.Show("������ �׸��� �����մϴ�.", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
		private void SignUpConditionSatisfy()
		{

		}
	}
}