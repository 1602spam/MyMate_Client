using Controls;

namespace MainForm
{
	public partial class MainFrame : Form
	{
		ServerListBar SLB = new ServerListBar();
		public MainFrame()
		{
			InitializeComponent();
		}

		private void MainFrame_Load(object sender, EventArgs e)
		{
			
			SLB.Show();
		}
	}
}