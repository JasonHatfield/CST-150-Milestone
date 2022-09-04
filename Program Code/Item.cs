// Jason Hatfield
// This is my original work
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectInventoryLibrary
{
    public class Item : Inventory
    // Inherited class of Inventory
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Quantity { get; set; }
        public int MaxQuantity { get; set; }
        public bool Show { get; set; }
        public bool Delete { get; set; }

        // Constructor
        public Item()
        {
            Name = "";
            Type = "";
            Quantity = 0;
            MaxQuantity = 0;
            Show = true;
            Delete = false;
        }

        public string DisplayItems
        // Displays the following format in the list box for each item
        {
            get
            {
                return $"{ Name } | { Type }";
            }
        }

        public string DisplayOnHandStock
        // Displays the following format in the text box On Hand Stock for each selected item
        {
            get
            {
                return $"{Quantity}";
            }
        }

        public string DisplayMaximumStock
        // Displays the following format in the text box Maximum Stock for each selected item
        {
            get
            {
                return $"{MaxQuantity}";
            }
        }

    }
}
