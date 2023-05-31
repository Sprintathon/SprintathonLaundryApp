using System;
using CommunityToolkit.Mvvm.Input;

namespace SprintathonLaundryApp.ViewModels
{
	public partial class CreatePasswordViewModel : BaseViewModel
	{
        [RelayCommand]
        public async void NavigateToLogin()
		{
			await Shell.Current.GoToAsync(nameof(LogInView));
		}
	}
}

