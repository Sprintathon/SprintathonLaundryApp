using System;
using System.Windows.Input;
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


        // Create a list of Garment objects
        [ObservableProperty]
        public List<Garment> garments = new List<Garment>()
        {
            new Garment(1, "T-shirt", "Popular", "👕", "🌟"),
            new Garment(12, "Shirt", "Business Clothing", "👔", "💼"),
            new Garment(31, "Scarf", "Casual", "🧣", "🎒"),
            new Garment(33, "Coat", "Winter Wear", "🧥", "❄️"),
            new Garment(41, "Thermal Underwear", "Winter Wear", "👖", "❄️"),

        };

        public List<GarmentGroup> GroupedGarments { get; set; } = new List<GarmentGroup>();
        public PlaceOrderViewModel()
        {
            var groupedData = garments.GroupBy(f => f.Category).Select(f => new GarmentGroup(f.Key.ToString(), f.ToList(), f.First().CategoryEmoji));
            GroupedGarments.AddRange(groupedData);
        }

        public ICommand AddOrRemoveGroupDataCommand => new Command<GarmentGroup>((item) =>
        {
            if (item.GroupIcon == "➕")
            {
                item.Clear();
                item.GroupIcon = "➖";
            }
            else
            {
                var recordsTobeAdded = garments.Where(f => f.Category.ToLower().StartsWith(item.GroupTitle.ToLower())).ToList();
                item.AddRange(recordsTobeAdded);
                item.GroupIcon = "➕";
            }
        });

        [RelayCommand]
        public void NavigateToPlaceOrder()
        {
            Shell.Current.GoToAsync(nameof(OrderSummaryView));

        }
    }
}

