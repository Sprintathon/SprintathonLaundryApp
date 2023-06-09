namespace SprintathonLaundryApp.Views;

public partial class AboutView : ContentPage
{
	public AboutView()
	{
		InitializeComponent();
		BindingContext = new AboutViewModel();
	}
}
