using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SprintathonLaundryApp.ViewModels
{
    public partial class EnterOtpViewModel : BaseViewModel
    {
        [RelayCommand]
        public void NavigateToNewPasssword() 
        {
                Shell.Current.GoToAsync(nameof(CreatePasswordView));
        
        }
    }
}
