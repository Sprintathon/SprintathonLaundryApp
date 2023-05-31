

namespace SprintathonLaundryApp.ViewModels
{
    public partial class LogInViewModel : BaseViewModel
    {

        [RelayCommand]
        public async void SignIn()
        {
            IsBusy = true;
            await Task.Delay(2000);
            await Shell.Current.GoToAsync("//Home");
            IsBusy = false;
        }

        [RelayCommand]
        public async void NavigateToSignUp()
        {
            IsBusy = true;
            await Task.Delay(2000);
            await Shell.Current.GoToAsync(nameof(SignUp));
            IsBusy = false;
        }

        [RelayCommand]
        public async void NavigateToForgotPassword()

        {
            IsBusy = true;
            await Task.Delay(2000);
            await Shell.Current.GoToAsync(nameof(ForgotPassword));
            IsBusy = false;
        }
    }
}
