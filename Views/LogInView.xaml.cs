using SprintathonLaundryApp.ViewModels;

namespace SprintathonLaundryApp.Views;

public partial class LogInView : ContentPage
{
	public LogInView()
	{
		InitializeComponent();
        BindingContext = new LogInViewModel();
    }
}