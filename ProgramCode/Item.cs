﻿// Jason Hatfield
// This is my original workusing System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Milestone
{
    internal class Item
    {
        public Item() 
        {
            Name = "";
            ItemType = "";
            Quantity = 0;
            MaximumQuantity = 0;
        }

        public int Count()
        {
            int count = 0;
            return count;
        }

        public void search()
        {

        }

        public int Restock()
        {
            int count = 0;
            return count;
        }

        public string Name { get; set; }
        public string ItemType { get; set; }
        public int Quantity { get; set; }
        public int MaximumQuantity { get; set; }
    }
}
