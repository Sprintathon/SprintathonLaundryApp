using CommunityToolkit.Mvvm.Input;

namespace SprintathonLaundryApp.ViewModels
{
    public partial class MainPageViewModel : BaseViewModel
    {

        [RelayCommand]
        public async void NavigateToLogIn()
        {
            IsBusy = true;
            await Task.Delay(4000);
            await Shell.Current.GoToAsync(nameof(LogInView));
            IsBusy = false;
        }
    }
}
