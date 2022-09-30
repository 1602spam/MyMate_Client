using CommunityToolkit.Maui.Views;

namespace 연습;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

    private async void OnButtonReleased(object sender, EventArgs args)
    {
        await Shell.Current.GoToAsync("//MainPage2");
    }
    private async void OnButtonReleased3(object sender, EventArgs args)
    {
        await Shell.Current.GoToAsync("//MainPage3");
    }

    private async void OnButtonReleased4(object sender, EventArgs args)
    {
        await Shell.Current.GoToAsync("//MainPage4");
    }
    private async void OnButtonReleased_send(object sender, EventArgs args)
    {
        await Shell.Current.GoToAsync("//PWHelpRedirectT");
    }
    
    private void OnButtonReleased_pop(object sender, EventArgs args)
    {
        this.ShowPopup(new PopupPage());
    }
}

