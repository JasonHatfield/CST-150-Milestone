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
            InventoryProject inventoryProject = new InventoryProject();
            inventoryProject.Show();
            this.Hide();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // exit the application
            Application.Exit();
        }
    }
}
