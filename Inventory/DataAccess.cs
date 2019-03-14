using Inventory.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace Inventory
{
    static class DataAccess
    {
        public static ObservableCollection<InventoryCategories> GetCategories()
        {
            //pull json string data from file
            var json = File.ReadAllText(@"C:\Users\Kevin\source\repos\Inventory\Inventory\CategoryData.txt");

            //convert to ObservableCollection<InventoryCategories>
            var categories = JsonConvert.DeserializeObject<ObservableCollection<InventoryCategories>>(json);

            return categories;
        }


        public static List<InventoryItem> GetInventoryItems(string categoryName)
        {
            var inventoryItems = new List<InventoryItem>();

            // select ID from Categories where Name = categoryName
            // select * from items where categoryID = ID
            
            //foreach (var item in items)
            //{
            //    //get conversions
            //    //get amounts
            //    inventoryItems.Add(new InventoryItem {
            //        Name = "name",
            //        Conversions = new List<Conversion>(),
            //        Amounts = new List<Amount>()
            //    });
            //}
            return inventoryItems;
        }
    }
}
