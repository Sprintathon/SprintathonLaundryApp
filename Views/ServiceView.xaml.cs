namespace SprintathonLaundryApp.Views;

public partial class ServiceView : ContentPage
{
	public ServiceView()
	{
		InitializeComponent();
		BindingContext = new ServiceViewModel();


    }
}