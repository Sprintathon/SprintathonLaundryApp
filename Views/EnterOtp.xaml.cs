using SprintathonLaundryApp.ViewModels;

namespace SprintathonLaundryApp.Views;

public partial class EnterOtp : ContentPage
{
	public EnterOtp()
	{
		InitializeComponent();
		BindingContext = new EnterOtpViewModel();
    }
}