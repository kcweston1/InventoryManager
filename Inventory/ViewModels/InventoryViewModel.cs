using Inventory.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.ViewModels
{
    class InventoryViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<InventoryCategories> inventoryCategories;

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public ObservableCollection<InventoryCategories> InventoryCategories
        {
            get
            {
                return inventoryCategories;
            }
            set
            {
                if (inventoryCategories != value)
                {
                    inventoryCategories = value;
                    NotifyPropertyChanged();
                }
            }
        }


        private InventoryCategories selectedCategory { get; set; }
        public InventoryCategories SelectedCategory
        {
            get
            {
                return selectedCategory;
            }

            set
            {
                if (value != selectedCategory)
                {
                    selectedCategory = value;
                    NotifyPropertyChanged();
                }
            }
        }


        public InventoryViewModel()
        {
            InventoryCategories = DataAccess.GetCategories();
            SelectedCategory = new InventoryCategories();
        }


    }
}
