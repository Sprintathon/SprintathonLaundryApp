using System;
using System.Windows.Input;

namespace SprintathonLaundryApp.ViewModels
{
	public partial class CreateWashingBasketViewModel : BaseViewModel
	{
        // Create a list of Garment objects
        [ObservableProperty]
        List<Garment> garments = new List<Garment>()
        {
            new Garment(1, "T-shirt", "Popular", "👕", "🌟"),
            new Garment(2, "Shorts", "Popular", "🩳", "🌟"),
            new Garment(3, "Sneakers", "Popular", "👟", "🌟"),
            new Garment(4, "Jeans", "Popular", "👖", "🌟"),
            //new Garment(5, "Sweater", "Popular", "🧥", "🌟"),
            //new Garment(6, "Jacket", "Popular", "🧥", "🌟"),
            //new Garment(7, "Dress", "Popular", "👗", "🌟"),
            new Garment(8, "Skirt", "Popular", "👗", "🌟"),
            //new Garment(9, "Blouse", "Popular", "👚", "🌟"),
            new Garment(10, "Sandals", "Popular", "👡", "🌟"),
            new Garment(11, "Suit", "Business Clothing", "👔", "💼"),
            new Garment(12, "Shirt", "Business Clothing", "👔", "💼"),
            new Garment(13, "Tie", "Business Clothing", "👔", "💼"),
            new Garment(15, "Pants", "Business Clothing", "👖", "💼"),
            new Garment(16, "Shoes", "Business Clothing", "👞", "💼"),
            new Garment(17, "Blazer", "Business Clothing", "🧥", "💼"),
            new Garment(18, "Dress Shirt", "Business Clothing", "👔", "💼"),
            new Garment(19, "Belt", "Business Clothing", "👖", "💼"),
            new Garment(20, "Skirt Suit", "Business Clothing", "👗", "💼"),
            new Garment(21, "Heels", "Business Clothing", "👠", "💼"),
            new Garment(22, "Hoodie", "Casual", "👕", "🎒"),
            new Garment(23, "Leggings", "Casual", "👖", "🎒"),
            new Garment(24, "Boots", "Casual", "👢", "🎒"),
            new Garment(25, "Sweatpants", "Casual", "👖", "🎒"),
            new Garment(26, "Cap", "Casual", "🧢", "🎒"),
            new Garment(27, "Tunic", "Casual", "👗", "🎒"),
            new Garment(28, "Cardigan", "Casual", "🧥", "🎒"),
             new Garment(30, "Flats", "Casual", "🥿", "🎒"),
            new Garment(31, "Scarf", "Casual", "🧣", "🎒"),
            new Garment(32, "Jumpsuit", "Casual", "👗", "🎒"),
            new Garment(33, "Coat", "Winter Wear", "🧥", "❄️"),
            new Garment(34, "Gloves", "Winter Wear", "🧤", "❄️"),
            new Garment(35, "Hat", "Winter Wear", "🎩", "❄️"),
            new Garment(36, "Boots", "Winter Wear", "👢", "❄️"),
            new Garment(37, "Sweater", "Winter Wear", "🧥", "❄️"),
            new Garment(38, "Socks", "Winter Wear", "🧦", "❄️"),
            new Garment(39, "Mittens", "Winter Wear", "🧤", "❄️"),
            new Garment(40, "Parka", "Winter Wear", "🧥", "❄️"),
            new Garment(41, "Thermal Underwear", "Winter Wear", "👖", "❄️"),
            new Garment(42, "Bikini", "Swimwear", "👙", "🌊"),
            new Garment(44, "Swimsuit", "Swimwear", "🩱", "🌊"),
            new Garment(45, "Trunks", "Swimwear", "🩳", "🌊"),
            new Garment(46, "Flip Flops", "Swimwear", "👡", "🌊"),
            new Garment(47, "Sunglasses", "Swimwear", "🕶️", "🌊"),
            new Garment(48, "Cover Up", "Swimwear", "👗", "🌊"),
            new Garment(49, "Sun Hat", "Swimwear", "👒", "🌊"),
            new Garment(50, "Rash Guard", "Swimwear", "👕", "🌊")

        };
        [ObservableProperty]
        public List<GarmentGroup> groupedGarments = new List<GarmentGroup>();
        public CreateWashingBasketViewModel()
        {
            var groupedData = garments.GroupBy(f => f.Category).Select(f => new GarmentGroup(f.Key.ToString(), f.ToList(), f.First().CategoryEmoji));
            GroupedGarments.AddRange(groupedData);
            bool first = true;
            foreach (var gg in GroupedGarments)
            {
                if(first)
                {
                    first = false;
                    continue;
                }
                
                if (gg.GroupIcon == "➕")
                {
                    gg.Clear();
                    gg.GroupIcon = "➖";
                }
                else
                {
                    var recordsTobeAdded = Garments.Where(f => f.Category.ToLower().StartsWith(gg.GroupTitle.ToLower())).ToList();
                    gg.AddRange(recordsTobeAdded);
                    gg.GroupIcon = "➕";
                }
            }
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
                var recordsTobeAdded = Garments.Where(f => f.Category.ToLower().StartsWith(item.GroupTitle.ToLower())).ToList();
                item.AddRange(recordsTobeAdded);
                item.GroupIcon = "➕";
            }
        });

        [RelayCommand]
        public void NavigateToPlaceOrder()
        {
            Shell.Current.GoToAsync(nameof(PlaceOrderView));
        }
    }
}

