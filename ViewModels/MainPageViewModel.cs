using CommunityToolkit.Mvvm.Input;
using SprintathonLaundryApp.Views;

namespace SprintathonLaundryApp.ViewModels
{
    public partial class MainPageViewModel : BaseViewModel
    {

        [RelayCommand]
        public async void NavigateToLogIn()
        {
            IsBusy = true;
            await Task.Delay(2000);
            await Shell.Current.GoToAsync(nameof(LogInView));
            IsBusy = false;
        }
    }
}
