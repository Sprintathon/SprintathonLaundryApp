global using SprintathonLaundryApp.Services;
using SprintathonLaundryApp.Models;

namespace SprintathonLaundryApp.ViewModels
{
    public partial class SignUpViewModel : BaseViewModel
    {
        private readonly AuthServices authServices = new();
     

        [ObservableProperty]
        CreateUserDto newUser = new();

        [RelayCommand]
        async void SignUp()
        {
            IsBusy = true;
            //var user = await authServices.CreateUser (newUser);
            //if (user is not null)
                await Shell.Current.GoToAsync("//Home");
            IsBusy = false;

        }
    }
}
