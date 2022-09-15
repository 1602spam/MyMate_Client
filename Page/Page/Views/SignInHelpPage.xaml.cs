using System.Diagnostics;

namespace Page;

public partial class SignInHelpPage : ContentPage
{
	public SignInHelpPage()
	{
		InitializeComponent();
	}

    private async void OnIDButtonReleased(object sender, EventArgs args)
    {
        await Shell.Current.GoToAsync("//IDHelp");
    }

    private async void OnPWButtonReleased(object sender, EventArgs args)
    {
        await Shell.Current.GoToAsync("//PWHelp");
    }
}