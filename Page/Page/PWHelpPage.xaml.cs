namespace Page;

public partial class PWHelpPage : ContentPage
{
	public PWHelpPage()
	{
		InitializeComponent();
	}
    private async void TapGestureRecognizer_Tapped_For_SignIn(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//SignIn");
    }

    private async void OnButtonReleased_send(object sender, EventArgs args)
    {
        await Shell.Current.GoToAsync("//PWHelpVerification");
    }
}