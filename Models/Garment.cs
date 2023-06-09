using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using MvvmHelpers;

namespace SprintathonLaundryApp.Models
{
	public class Garment : BaseEntity
	{
        public string Category { get; set; }
        public string Emoji { get; set; } // Added a new property for emoji
        public string CategoryEmoji { get; set; } // Added a new property for category emoji

        // Constructor to initialize the properties
        public Garment(int id, string name, string category, string emoji, string categoryEmoji)
        {
            Id = id;
            Name = name;
            Category = category;
            Emoji = emoji;
            CategoryEmoji = categoryEmoji;
        }


    }

    public class GarmentGroup : ObservableRangeCollection<Garment>, INotifyPropertyChanged
    {
        public string GroupTitle { get; set; }
        public string FooterTitle { get; set; }
        public string Icon { get; set; }

        private string _groupIcon = "➕";
        public string GroupIcon
        {
            get => _groupIcon;
            set => SetProperty(ref _groupIcon, value);
        }

        public GarmentGroup(string groupTitle, List<Garment> employees, string icon, string footerTitle = "") : base(employees)
        {
            GroupTitle = groupTitle;
            FooterTitle = footerTitle;
            Icon = icon;
        }

        protected bool SetProperty<T>(ref T backingStore, T value,
      [CallerMemberName] string propertyName = "",
      Action onChanged = null)
        {
            if (EqualityComparer<T>.Default.Equals(backingStore, value))
                return false;

            backingStore = value;
            onChanged?.Invoke();
            OnPropertyChanged(propertyName);
            return true;
        }

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            var changed = PropertyChanged;
            if (changed == null)
                return;

            changed.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}

