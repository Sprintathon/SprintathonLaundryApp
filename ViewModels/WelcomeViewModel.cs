using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SprintathonLaundryApp.ViewModels
{
    public partial class WelcomeViewModel : BaseViewModel
    {
        [RelayCommand]
        public void NavigateToSignIn()
        {
            Shell.Current.GoToAsync(nameof(LogInView));

        }
    }
}
