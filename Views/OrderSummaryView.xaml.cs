namespace SprintathonLaundryApp.Views;

public partial class OrderSummaryView : ContentPage
{
	public OrderSummaryView()
	{
		InitializeComponent();
        BindingContext = new OrderSummaryViewModel();
    }
}
