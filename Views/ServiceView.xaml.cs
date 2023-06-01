namespace SprintathonLaundryApp.Views;

public partial class ServiceView : ContentPage
{
	public ServiceView()
	{
		InitializeComponent();
		BindingContext = new ServiceViewModel();


    }

   
    public void OnServiceImagClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(ServiceOptionView));
    }

}