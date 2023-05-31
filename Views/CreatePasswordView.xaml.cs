namespace SprintathonLaundryApp.Views;

public partial class CreatePasswordView : ContentPage
{

	public CreatePasswordView()
	{
		InitializeComponent();
        BindingContext = new CreatePasswordViewModel();
    }
}
