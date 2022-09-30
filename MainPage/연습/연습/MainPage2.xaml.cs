namespace 연습;

public partial class MainPage2 : ContentPage
{
	public MainPage2()
	{
		InitializeComponent();
	}

    private async void OnButtonReleased(object sender, EventArgs args)
    {
        await Shell.Current.GoToAsync("//MainPage");
    }
}