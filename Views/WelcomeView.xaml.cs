
namespace SprintathonLaundryApp.Views;

public partial class WelcomeView : ContentPage
{
	public WelcomeView()
	{
		InitializeComponent();
        BindingContext = new WelcomeViewModel();
    }
}