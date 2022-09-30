namespace 연습;

public partial class MainPage3 : ContentPage
{
	public MainPage3()
	{
		InitializeComponent();
	}

    private async void OnButtonReleased(object sender, EventArgs args)
    {
        await Shell.Current.GoToAsync("//MainPage");
    }
}