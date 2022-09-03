namespace Page;

public partial class IDHelpPage : ContentPage
{
	public IDHelpPage()
	{
		InitializeComponent();
	}

    private async void TapGestureRecognizer_Tapped_For_SignIn(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//SignIn");
    }
    private async void OnButtonReleased(object sender, EventArgs args)
    {
        await Shell.Current.GoToAsync("//IDHelpResult");
    }
}