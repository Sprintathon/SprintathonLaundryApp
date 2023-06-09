namespace SprintathonLaundryApp.Views;

public partial class CreateOrderView : ContentPage
{
	public CreateOrderView()
	{
		InitializeComponent();
		BindingContext = new CreateOrderViewModel();
	}
}
