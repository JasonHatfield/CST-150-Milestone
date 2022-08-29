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
            Item item = new Item 
            { 
                name = itemNameInput.Text, 
                dateAdded = dateTimePicker1.Value, 
                dateExpired = dateTimePicker2.Value 
            };

            // TODO: Remove this before final push.
            MessageBox.Show("Item Name: " + item.name 
                + "\nDate Added: " + item.dateAdded.ToString("MM/dd/yyyy") 
                + "\nExpiration Date: " + item.dateExpired.ToString("MM/dd/yyyy"));

            // add the item to the list box with expiration date
            listItems.Items.Add(item.name + " | " + item.dateExpired.ToString("MM/dd/yyyy"));

            // clears the input text box
            itemNameInput.Clear();

            // sets focus to the input text box upon clearing the user input
            itemNameInput.Focus();
        }

        private void RemoveItem()
        {
            // if the an item is not selected, show a message box to remind the user to select an item.
            if (listItems.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an item to remove.");
            }
            // if the listItems list is greater than zero, continue
            else if (listItems.Items.Count > 0)
            {
                // diaglogue message box asking if the user is sure before removing the selected item
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to remove this item?", "Permanently Delete", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        listItems.Items.RemoveAt(listItems.SelectedIndex);
                        return;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    return;
                }
            }
            else
            {
                return;
            }
        }
    }
}
