using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Project
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void accessButton_Click(object sender, EventArgs e)
        {
            // create a new mainMenu form, show that, and hide this form
            InventoryProject mainMenu = new InventoryProject();
            mainMenu.Show();
            this.Hide();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // close the program
            this.Close();
        }
    }
}
