namespace SprintathonLaundryApp.ViewModels
{
    public partial class ServiceOptionsViewModel : BaseViewModel
    {
        [RelayCommand]
        public void NavigateToCreateBacket()
        {
            Shell.Current.GoToAsync(nameof(CreateWashingBasketView));
        }
    }

}
