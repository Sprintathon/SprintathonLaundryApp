namespace SprintathonLaundryApp.Views;

public partial class PlaceOrderView : ContentPage
{
	public PlaceOrderView()
	{
		InitializeComponent();
        BindingContext = new PlaceOrderViewModel();
    }
}
