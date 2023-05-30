using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Input;

namespace SprintathonLaundryApp.ViewModels
{
    public partial class LogInViewModel : BaseViewModel
    {
        [RelayCommand]
        public void NavigateToSignUp()
        {
            Shell.Current.GoToAsync(nameof(SignUp));
        }
    }
}
