namespace Page;

public partial class SignInPage : ContentPage
{
	public SignInPage()
	{
		InitializeComponent();
	}
	//ȸ������ �������� �̵�
	private async void TapGestureRecognizer_Tapped_For_SignUP(object sender,EventArgs e)
	{
		await Shell.Current.GoToAsync("//SignUp");
	}

	//���̵� ��й�ȣ ã�� �������� �̵�
    private async void TapGestureRecognizer_Tapped_For_SignInHelp(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//SignInHelp");
    }
}