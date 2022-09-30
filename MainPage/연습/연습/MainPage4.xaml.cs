namespace 연습;

public partial class MainPage4 : ContentPage
{
	public MainPage4()
	{
		InitializeComponent();
	}

    private async void OnButtonReleased(object sender, EventArgs args)
    {
        await Shell.Current.GoToAsync("//MainPage");
    }
}