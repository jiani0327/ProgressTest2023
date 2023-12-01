using ProgressTest2023.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProgressTest2023.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Items> _yourItems;

        public ObservableCollection<Items> YourItems
        {
            get => _yourItems;
            set
            {
                if (_yourItems != value)
                {
                    _yourItems = value;
                    OnPropertyChanged();
                }
            }
        }

        public MainViewModel()
        {
            // Initialize your items in the constructor
            YourItems = new ObservableCollection<Items>
            {
                new Items { ImagePath = "image1.jpeg" },
                new Items { ImagePath = "image2.jpeg" },
                 new Items { ImagePath = "image3.jpeg" },
                 new Items { ImagePath = "image4.jpeg" },
                // Add more items as needed
            };
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}
