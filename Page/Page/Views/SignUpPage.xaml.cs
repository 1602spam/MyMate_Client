namespace Page;

public partial class SignUpPage : ContentPage
{
	public SignUpPage()
	{
		InitializeComponent();
	}
<<<<<<< HEAD
=======

>>>>>>> a347a8f3667bc389b2cd3cee821a47ec36d50699
    private async void TapGestureRecognizer_Tapped_For_SignIn(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//SignIn");
    }

}