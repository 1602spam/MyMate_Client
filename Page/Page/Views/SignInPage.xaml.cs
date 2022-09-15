namespace Page;

public partial class SignInPage : ContentPage
{
	public SignInPage()
	{
		InitializeComponent();
	}
	//회원가입 페이지로 이동
	private async void TapGestureRecognizer_Tapped_For_SignUP(object sender,EventArgs e)
	{
		await Shell.Current.GoToAsync("//SignUp");
	}

	//아이디 비밀번호 찾기 페이지로 이동
    private async void TapGestureRecognizer_Tapped_For_SignInHelp(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//SignInHelp");
    }
}