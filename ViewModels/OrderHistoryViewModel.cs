using System;
using CommunityToolkit.Mvvm.Input;

namespace SprintathonLaundryApp.ViewModels
{
	public partial class OrderHistoryViewModel : BaseViewModel
	{
		[RelayCommand]
		public void NavigateToPlaceOrder()
		{
			Shell.Current.GoToAsync(nameof(PlaceOrderView));
		}
    }
}
