using Microsoft.Toolkit.Uwp.Notifications;

namespace ToastMessage
{
	public static class ToastMessage
	{
		public static void RaseToast(string title, string content)
		{
			new ToastContentBuilder()
			.AddArgument("action", "viewConversation")
			.AddArgument("conversationId", 9813)
			.AddText("Andrew sent you a picture")
			.AddText("Check this out, The Enchantments in Washington!")
			.AddButton(new ToastButton()
				.SetContent("확인")
				.AddArgument("OK")
				.SetBackgroundActivation()
				)
			.Show(toast =>
			{
				// 메시지 만료시간 설정
				toast.ExpirationTime = DateTime.Now.AddHours(1);
			});
		}
		public static void RaiseMessageToast(string userName, string content)
		{
			new ToastContentBuilder()
			.AddArgument("action", "viewConversation")
			.AddArgument("conversationId", 9813)
			.AddText(userName)
			//.AddText(userName)
			.AddText(content)
			.AddInputTextBox("tbReply", "Type a reply")
			.AddButton(new ToastButton()
				.SetContent("전송")
				.AddArgument("Send", "SendMessage")
				.SetBackgroundActivation()
				)
			.AddButton(new ToastButton()
				.SetContent("확인")
				.AddArgument("OK","OpenView")
				.SetBackgroundActivation()
				)
			.Show(toast =>
			{
				// 메시지 만료시간 설정
				toast.ExpirationTime = DateTime.Now.AddHours(1);
			});
		}
		public static void RaiseSystemToast(string content)
		{
			new ToastContentBuilder()
			.AddArgument("action", "viewConversation")
			.AddArgument("conversationId", 9813)
			.AddText("MyMate")
			.AddText("System Message")
			.AddText(content)
			.AddButton(new ToastButton()
				.SetContent("확인")
				.AddArgument("OK", "OpenView")
				.SetBackgroundActivation()
				)
			.Show(toast =>
			{
				// 메시지 만료시간 설정
				toast.ExpirationTime = DateTime.Now.AddHours(1);
			});
		}
	}

}