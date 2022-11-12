using Microsoft.Toolkit.Uwp.Notifications;
using ToastMessage;

namespace TestForm
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnSend_Click(object sender, EventArgs e)
		{
			Thread.Sleep(10);
			new ToastContentBuilder()
			.AddArgument("action", "viewConversation")
			.AddArgument("conversationId", 9813)
			.AddText("Andrew sent you a picture")
			.AddText("Check this out, The Enchantments in Washington!")
			.AddButton(new ToastButton()
				.SetContent("Ȯ��")
				.AddArgument("OK")
				.SetBackgroundActivation()
				)
			.Show(toast =>
			{
				// �޽��� ����ð� ����
				toast.ExpirationTime = DateTime.Now.AddHours(1);
			});
		}
		private void btnUserMessage_Click(object sender, EventArgs e)
		{
			ToastMessage.ToastMessage.RaiseMessageToast("Poro", "�̰��� ������ �׽�Ʈ�޽����̴�.");
		}
		private void SystemMessage_Click(object sender, EventArgs e)
		{
			ToastMessage.ToastMessage.RaiseSystemToast("�̰��� �ý����� �׽�Ʈ�޽����̴�.");
		}
	}
}