// Jason Hatfield
// This is my original work
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectInventoryLibrary
{
    public class Inventory                              // Base Class
    {
        //public List<Item> Items { get; set; }           // Get/Set List of Item

        //public Inventory()
        //{
        //    Items = new List<Item>();
        //}

        public Array[] Items { get; set; }           // Get/Set Array of Item

        public Inventory()
        {
            Items = new Array[5];
        }
    }
}
