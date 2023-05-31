using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SprintathonLaundryApp.ViewModels
{
    public partial class ServiceViewModel : BaseViewModel
    {
        [RelayCommand]
        public void NavigateToServiceOptions()
        {
            Shell.Current.GoToAsync(nameof(ServiceOptionView));
        }
    }
}
