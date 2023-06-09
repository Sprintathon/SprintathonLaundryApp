namespace SprintathonLaundryApp.Views;

public partial class CreateWashingBasketView : ContentPage
{
	public CreateWashingBasketView()
	{
		InitializeComponent();
		BindingContext = new CreateWashingBasketViewModel();
	}
}
