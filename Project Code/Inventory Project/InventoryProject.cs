// Jason Hatfield
// This is my original work
using ProjectInventoryLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Inventory_Project
{
    public partial class InventoryProject : Form
    {
        private Inventory inventory = new Inventory();      // Creates new Inventory named inventory
        BindingSource itemsBinding = new BindingSource();   // Creates a new binding source named itemsBinding

        public InventoryProject()
        {

            InitializeComponent();
            

            SetupData();    // Calls the SetupDate method when program is initialized.

            itemsBinding.DataSource = inventory.Items.Where(x => x.Show == true).ToList();      // Connects Items to the binding source ItemsBinding
            itemsListBox.DataSource = itemsBinding;         // Connects the itemsListBox with the binding source

            itemsListBox.DisplayMember = "DisplayItems";    // } - Displays the item name and type to the listbox
            itemsListBox.ValueMember = "DisplayItems";      // } ^
        }

        private void InventoryForm()
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Hide();
        }

        private void SetupData()
        // Initial data to implement the program on run. This would be imported from a database or txt file.
        {
            inventory.Items.Add(new Item { Name = "Carrots", Type = "Frozen", Quantity = 5, MaxQuantity = 25, Show = true, Delete = false });
            inventory.Items.Add(new Item { Name = "Corn", Type = "Canned", Quantity = 8, MaxQuantity = 35, Show = true, Delete = false });
            inventory.Items.Add(new Item { Name = "Pickles", Type = "Jar", Quantity = 6, MaxQuantity = 45, Show = true, Delete = false });
            inventory.Items.Add(new Item { Name = "Ice Cream", Type = "Frozen", Quantity = 9, MaxQuantity = 60, Show = true, Delete = false });
            inventory.Items.Add(new Item { Name = "Macaroni N Cheese", Type = "Boxed", Quantity = 10, MaxQuantity = 10, Show = true, Delete = false });
        }

        private void itemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ItemNameFocus();
        }

        private void ItemNameFocus()
        // When the user selects an item in the list box, the name, type,
        // quantity and maximum quantity are displayed.
        {
            // when the user clicks on the item name tex box, focus is set to this text box
            if (itemsListBox.SelectedIndex == -1)
            {
                itemNameTextBox.Focus();
            }
            else
            {
                Item selectedItem = (Item)itemsListBox.SelectedItem;                // creates selected item at user selection in list box

                itemNameTextBox.Text = selectedItem.Name;                           // Displays the item name to the itemNameTextBox
                itemTypeTextBox.Text = selectedItem.Type;                           // Displays the item type to the itemTypeTextBox
                onHandStockTextBox.Text = selectedItem.Quantity.ToString();         // Displays the on hand quantity to the onHandStockTextBox
                maximumStockTextBox.Text = selectedItem.MaxQuantity.ToString();     // Displays the maximum quantity to the onHandStockTextBox
            }
        }

        private void itemNameTextBox_MouseClick(object sender, MouseEventArgs e)

        {
            ClearTextBox();
        }

        private void ClearTextBox()
        // Clears information from input text boxes when the name textbox is
        // clicked to enter new data.
        {
            itemNameTextBox.Clear();
            itemTypeTextBox.Clear();
            onHandStockTextBox.Clear();
            maximumStockTextBox.Clear();
            itemsListBox.SelectedIndex = -1;    // Deselects the selected index in the list box
        }

        private void upButton_Click(object sender, EventArgs e)
        // Increases the quantity of on hand stock by 1 for each click.
        {
            {
                try
                {
                    if (itemsListBox.SelectedIndex == -1)
                    // If no item is selected, message is shown and focus is set
                    {
                        MessageBox.Show("Select and Item from the list.");
                        itemNameTextBox.Focus();
                    }
                    else
                    // Increases the quantity of the selected item by 1 for each click.
                    {
                        Item selectedItem = (Item)itemsListBox.SelectedItem;

                        selectedItem.Quantity++;

                        onHandStockTextBox.Text = selectedItem.Quantity.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void downButton_Click(object sender, EventArgs e)
        // Increases the quantity of on hand stock by 1 for each click.
        {
            {
                try
                {
                    if (itemsListBox.SelectedIndex == -1)
                    // If no item is selected, message is shown and focus is set
                    {
                        MessageBox.Show("Select and Item from the list.");
                        itemNameTextBox.Focus();
                    }
                    else
                    // Increases the quantity of the selected item by 1 for each click.
                    {
                        Item selectedItem = (Item)itemsListBox.SelectedItem;

                        selectedItem.Quantity--;

                        onHandStockTextBox.Text = selectedItem.Quantity.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void restockButton_Click(object sender, EventArgs e)
        // Increases the quantity of on hand stock by 1 for each click.
        {
            {
                try
                {
                    if (itemsListBox.SelectedIndex == -1)
                    // If no item is selected, message is shown and focus is set
                    {
                        MessageBox.Show("Select and Item from the list.");
                        itemNameTextBox.Focus();
                    }
                    else
                    // Increases the quantity of the selected item by 1 for each click.
                    {
                        Item selectedItem = (Item)itemsListBox.SelectedItem;

                        selectedItem.Quantity = selectedItem.MaxQuantity;

                        onHandStockTextBox.Text = selectedItem.Quantity.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void addItemButton_Click(object sender, EventArgs e)
        // Adds a new item based on user input
        {
            // if the itemsListBox is not selected
            if (itemsListBox.SelectedIndex >= 0)
            {
                MessageBox.Show("Enter new item information before proceeding.");
                ClearTextBox();
            }
            // else if any of the test boxes return ""
            else if (itemNameTextBox.Text == "" || itemTypeTextBox.Text == ""
                || onHandStockTextBox.Text == "" || maximumStockTextBox.Text == "")
            {
                MessageBox.Show("Enter new item information before proceeding.");
            }
            // else create a new item
            else
            {
                inventory.Items.Add(new Item
                {
                    Name = itemNameTextBox.Text,
                    Type = itemTypeTextBox.Text,
                    Quantity = int.Parse(onHandStockTextBox.Text),
                    MaxQuantity = int.Parse(maximumStockTextBox.Text),
                    Show = true,
                    Delete = false
                });
                // reset itemsListBox to hide items where the Delete boolean value is true
                itemsBinding.DataSource = inventory.Items.Where(x => x.Delete == false).ToList();
                itemsBinding.ResetBindings(false);
                itemsListBox.SelectedIndex = itemsListBox.Items.Count - 1;
            }
        }

        private void deleteItemButton_Click(object sender, EventArgs e)
        {
            if (itemsListBox.SelectedIndex < 0)
            {
                MessageBox.Show("Select an item in the inventory list before proceding.");
            }
            else
            {
                DeleteItem();
            }
        }

        private void DeleteItem()
        {
            // this method does not delete the item, but marks the Delete boolean as true
            Item selectedItem = (Item)itemsListBox.SelectedItem;

            selectedItem.Delete = true;
            
            // reset itemsListBox to hide items where the Delete boolean value is true
            itemsBinding.DataSource = inventory.Items.Where(x => x.Delete == false).ToList();

            itemsBinding.ResetBindings(false);
        }

        private void searchNameButton_Click(object sender, EventArgs e)
        {
            Item selectedItem = (Item)itemsListBox.SelectedItem;
            string searchName = itemNameTextBox.Text;

            if (searchNameButton.Text == "Search")
            {
                foreach (Item item in itemsListBox.Items)
                {
                    if (item.Name != searchName && item.Delete != true)
                    {
                        item.Show = false;
                    }
                }
                
                ClearTextBox();
                // change the button label to "Reset"
                searchNameButton.Text = "Reset";
                // change the background color of the button
                searchNameButton.BackColor = Color.FromArgb(192, 255, 255);
            }
            else if (searchNameButton.Text == "Reset")
            {
                foreach (Item item in inventory.Items)
                {
                    if (item.Show != true && item.Delete != true)
                    {
                        item.Show = true;
                    }
                }

                ClearTextBox();
                // change the button label to "Search"
                searchNameButton.Text = "Search";
                // change the background color of the button
                searchNameButton.BackColor = Color.FromArgb(255, 224, 192);
            }

            // inventory list only shows items with a boolean value of Show = true && Delete == false
            itemsBinding.DataSource = inventory.Items.Where(x => x.Show == true && x.Delete == false).ToList();

            itemsBinding.ResetBindings(false);
        }

        private void searchTypeButton_Click(object sender, EventArgs e)
        {
            Item selectedItem = (Item)itemsListBox.SelectedItem;
            string searchType = itemTypeTextBox.Text;

            if (searchTypeButton.Text == "Search")
            {
                foreach (Item item in itemsListBox.Items)
                {
                    if (item.Type != searchType && item.Delete != true)
                    {
                        item.Show = false;
                    }
                }
                
                ClearTextBox();
                // change the button label to "Reset"
                searchTypeButton.Text = "Reset";
                searchTypeButton.BackColor = Color.FromArgb(192, 255, 255);
            }
            else if (searchTypeButton.Text == "Reset")  // if the button label is "Reset", continue
            {
                // foreach loop to go through the list objects and change the boolean value
                // Show to true as long ad the Delete boolean value does not equal true
                foreach (Item item in inventory.Items)
                {
                    if (item.Show != true && item.Delete != true)
                    {
                        item.Show = true;
                    }
                }
                
                ClearTextBox();
                // change the button label to "Search"
                searchTypeButton.Text = "Search";
                // change the button background color to the original color
                searchTypeButton.BackColor = Color.FromArgb(255, 224, 192);
            }
            // refresh the inventory list to show all items with the boolean Show (true) and Delete (false)
            itemsBinding.DataSource = inventory.Items.Where(x => x.Show == true && x.Delete == false).ToList();

            itemsBinding.ResetBindings(false);
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Hide();
        }
    }
}
