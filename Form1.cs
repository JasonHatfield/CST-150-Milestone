// Jason Hatfield
// This is my original work

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Milestone
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        // calls the AddItem() method.
        {
            AddItem();
        }

        private void removeButton_Click(object sender, EventArgs e)
        // calls the RemoveItem() method.
        {
            RemoveItem();
        }

        class Item
        // creates the Item class with the name string, dateAdded, and dateExpired DateTimes
        {
            public string name;
            public DateTime dateAdded;
            public DateTime dateExpired;
        }

        private void AddItem()
        {
            // if the itemNameInput.Text box is empty, returns.
            if (string.IsNullOrEmpty(itemNameInput.Text))
                return;
            // creates a new item with a name, date added, and date expired information.
            Item item = new Item()
            {
                name = itemNameInput.Text,
                dateAdded = dateTimePicker1.Value,
                dateExpired = dateTimePicker2.Value
            };
            
            // add the item to the list box, this will eventually include the date added and date expired
            listItems.Items.Add(item.name);

            // clears the input text box
            itemNameInput.Clear();

            // sets focus to the input text box upon clearing the user input
            itemNameInput.Focus();
        }

        private void RemoveItem()
        {
            // if the items are greater than zero, the selected item will be removed
            if (listItems.Items.Count > 0)
                listItems.Items.RemoveAt(listItems.SelectedIndex);
        }
    }
}
