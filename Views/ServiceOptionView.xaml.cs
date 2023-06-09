namespace SprintathonLaundryApp.Views;

public partial class ServiceOptionView : ContentPage
{
	public ServiceOptionView()
	{
		InitializeComponent();
		BindingContext = new ServiceOptionsViewModel();
	}
}