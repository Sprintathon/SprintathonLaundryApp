using SprintathonLaundryApp.ViewModels;

namespace SprintathonLaundryApp.Views;

public partial class ForgotPassword : ContentPage
{
	public ForgotPassword()
	{
		InitializeComponent();
		BindingContext = new ForgotPasswordViewModel();
    }
}