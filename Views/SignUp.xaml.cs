namespace SprintathonLaundryApp.Views;

public partial class SignUp : ContentPage
{
	public SignUp()
	{
		InitializeComponent();
		BindingContext = new SignUpViewModel();
	}
}