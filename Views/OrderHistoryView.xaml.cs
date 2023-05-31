namespace SprintathonLaundryApp.Views;

public partial class OrderHistoryView : ContentPage
{
	public OrderHistoryView()
	{
		InitializeComponent();
        BindingContext = new OrderHistoryViewModel();
    }
}
