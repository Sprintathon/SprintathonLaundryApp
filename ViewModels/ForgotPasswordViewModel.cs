using CommunityToolkit.Mvvm.Input;
using SprintathonLaundryApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SprintathonLaundryApp.ViewModels
{
    public partial class ForgotPasswordViewModel: BaseViewModel
    {
        [RelayCommand]
        public async void NavigateToEnterOtp()

        {
            IsBusy = true;
            await Task.Delay(2000);
            await Shell.Current.GoToAsync(nameof(EnterOtp));
            IsBusy = false;

        }
    }
}
