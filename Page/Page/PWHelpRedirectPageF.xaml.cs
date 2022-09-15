namespace Page;

public partial class PWHelpRedirectPageF : ContentPage
{
	public PWHelpRedirectPageF()
	{
		InitializeComponent();
	}

    private async void OnButtonReleased(object sender, EventArgs args)
    {
        await Shell.Current.GoToAsync("//SignIn");
    }

    
}