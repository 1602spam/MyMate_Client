namespace Page;

public partial class PWHelpVerificationPage : ContentPage
{
	public PWHelpVerificationPage()
	{
		InitializeComponent();
	}

    private async void OnButtonReleased(object sender, EventArgs args)
    {
        await Shell.Current.GoToAsync("//SignIn");
    }
    private async void OnButtonReleased_resend(object sender, EventArgs args)
    {
        await Shell.Current.GoToAsync("//PWHelpVerification");
    }

    private async void OnButtonReleased_send(object sender, EventArgs args)
    {
        await Shell.Current.GoToAsync("//PWHelpResult");
    }
}