namespace Page;

public partial class PWHelpResultPage : ContentPage
{
	public PWHelpResultPage()
	{
		InitializeComponent();
	}

    private async void OnButtonReleased(object sender, EventArgs args)
    {
        await Shell.Current.GoToAsync("//SignIn");
    }
    private async void OnButtonReleased_send(object sender, EventArgs args)
    {
        await Shell.Current.GoToAsync("//PWHelpRedirectT");
    }
}