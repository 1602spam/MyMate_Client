namespace Page;

public partial class PWHelpRedirectPageT : ContentPage
{
	public PWHelpRedirectPageT()
	{
		InitializeComponent();
	}

    private async void OnButtonReleased(object sender, EventArgs args)
    {
        await Shell.Current.GoToAsync("//SignIn");
    }
}