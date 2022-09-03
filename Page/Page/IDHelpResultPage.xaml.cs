namespace Page;

public partial class IDHelpResultPage : ContentPage
{
	public IDHelpResultPage()
	{
		InitializeComponent();
	}

    private async void OnButtonReleased(object sender, EventArgs args)
    {
        await Shell.Current.GoToAsync("//SignIn");
    }
}