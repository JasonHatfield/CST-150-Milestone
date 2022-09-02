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
using System.IO;

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

        private void ReadFile()
        {
            try
            {
                StreamReader inputFile; // To read the file
                string line; // to hold a line from a file

                // create an instance of the PhoneBook Entry structure
                Item inventoryItem = new Item();

                // create a delimiter array.
                char[] delim = { ';' };

                // open the PhoneList file
                inputFile = File.OpenText("InventoryList.txt");

                // read the lines from the file
                while (!inputFile.EndOfStream)
                {
                    // read a line from the file
                    line = inputFile.ReadLine();

                    // tokenize the line
                    string[] tokens = line.Split(delim);

                    // store the tokens in the entry object
                    inventoryItem.Name = tokens[0];
                    //inventoryItem.dateAdded = tokens[1].ToString();
                    //inventoryItem.dateExpired = tokens[2];

                    // add the entry object to the list
                    //listItems.Items.Add(tokens[0] + " " + tokens[1]("MM/dd/yyyy"));
                }
            }
            catch (Exception ex)
            {
                // display an error message
                MessageBox.Show(ex.Message);
            }
        }

        private void AddItem()
        {
            // if the itemNameInput.Text box is empty, returns.
            if (string.IsNullOrEmpty(itemNameInput.Text))
                return;

            // creates a new item with a name, date added, and date expired information.
            Item inventoryItem = new Item 
            { 
                Name = itemNameInput.Text, 
                //dateAdded = dateTimePicker1.Value, 
                //dateExpired = dateTimePicker2.Value 
            };

            // TODO: Remove this before final push.
            MessageBox.Show("Item Name: " + inventoryItem.Name);
            //+ "\nDate Added: " + inventoryItem.dateAdded.ToString("d") 
            //+ "\nExpiration Date: " + inventoryItem.dateExpired.ToString("d"));


            // add the item to the list box with expiration date
            listItems.Items.Add(inventoryItem.Name);

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
        //TODO: Load an input file on load, something like InventoryList.txt
        private void Form1_Load(object sender, EventArgs e)
        {
            ReadFile();
        }
    }
}
