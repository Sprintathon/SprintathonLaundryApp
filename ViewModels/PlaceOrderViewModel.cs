using System;
using CommunityToolkit.Mvvm.Input;

namespace SprintathonLaundryApp.ViewModels
{
	public partial class PlaceOrderViewModel : BaseViewModel
	{
        [RelayCommand]
        public void NavigateToOrderSummary()
		{
			Shell.Current.GoToAsync(nameof(OrderSummaryView));
		}
	}
}

