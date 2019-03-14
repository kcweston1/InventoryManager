using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Models
{
    class InventoryItem
    {
        public string Name { get; set; }

        public List<Conversion> Conversions { get; set; }

        public List<Amount> Amounts { get; set; }
    }
}
