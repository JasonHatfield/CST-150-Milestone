namespace Inventory_Project
{
    partial class InventoryProject
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryProject));
            this.inventoryLabel = new System.Windows.Forms.Label();
            this.itemsListBox = new System.Windows.Forms.ListBox();
            this.itemNameLabel = new System.Windows.Forms.Label();
            this.itemNameTextBox = new System.Windows.Forms.TextBox();
            this.itemTypeTextBox = new System.Windows.Forms.TextBox();
            this.itemTypeLabel = new System.Windows.Forms.Label();
            this.itemsListBoxLabel = new System.Windows.Forms.Label();
            this.stockLabel = new System.Windows.Forms.Label();
            this.onHandStockTextBox = new System.Windows.Forms.TextBox();
            this.maximumStockTextBox = new System.Windows.Forms.TextBox();
            this.onHandStockLabel = new System.Windows.Forms.Label();
            this.maxStockLabel = new System.Windows.Forms.Label();
            this.upButton = new System.Windows.Forms.Button();
            this.downButton = new System.Windows.Forms.Button();
            this.addRemoveStockLabel = new System.Windows.Forms.Label();
            this.restockButton = new System.Windows.Forms.Button();
            this.addItemButton = new System.Windows.Forms.Button();
            this.deleteItemButton = new System.Windows.Forms.Button();
            this.stockGroupBox = new System.Windows.Forms.GroupBox();
            this.searchNameButton = new System.Windows.Forms.Button();
            this.searchTypeButton = new System.Windows.Forms.Button();
            this.returnButton = new System.Windows.Forms.Button();
            this.stockGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // inventoryLabel
            // 
            this.inventoryLabel.AutoSize = true;
            this.inventoryLabel.BackColor = System.Drawing.Color.Transparent;
            this.inventoryLabel.Font = new System.Drawing.Font("Mongolian Baiti", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryLabel.Location = new System.Drawing.Point(222, 9);
            this.inventoryLabel.Name = "inventoryLabel";
            this.inventoryLabel.Size = new System.Drawing.Size(217, 50);
            this.inventoryLabel.TabIndex = 0;
            this.inventoryLabel.Text = "Inventory";
            // 
            // itemsListBox
            // 
            this.itemsListBox.FormattingEnabled = true;
            this.itemsListBox.ItemHeight = 20;
            this.itemsListBox.Location = new System.Drawing.Point(35, 111);
            this.itemsListBox.Name = "itemsListBox";
            this.itemsListBox.Size = new System.Drawing.Size(285, 324);
            this.itemsListBox.TabIndex = 1;
            this.itemsListBox.SelectedIndexChanged += new System.EventHandler(this.itemsListBox_SelectedIndexChanged);
            // 
            // itemNameLabel
            // 
            this.itemNameLabel.AutoSize = true;
            this.itemNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.itemNameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemNameLabel.ForeColor = System.Drawing.Color.Black;
            this.itemNameLabel.Location = new System.Drawing.Point(388, 88);
            this.itemNameLabel.Name = "itemNameLabel";
            this.itemNameLabel.Size = new System.Drawing.Size(110, 24);
            this.itemNameLabel.TabIndex = 2;
            this.itemNameLabel.Text = "Item Name";
            // 
            // itemNameTextBox
            // 
            this.itemNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itemNameTextBox.Location = new System.Drawing.Point(350, 111);
            this.itemNameTextBox.Name = "itemNameTextBox";
            this.itemNameTextBox.Size = new System.Drawing.Size(173, 26);
            this.itemNameTextBox.TabIndex = 2;
            this.itemNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.itemNameTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.itemNameTextBox_MouseClick);
            // 
            // itemTypeTextBox
            // 
            this.itemTypeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itemTypeTextBox.Location = new System.Drawing.Point(350, 174);
            this.itemTypeTextBox.Name = "itemTypeTextBox";
            this.itemTypeTextBox.Size = new System.Drawing.Size(173, 26);
            this.itemTypeTextBox.TabIndex = 2;
            this.itemTypeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // itemTypeLabel
            // 
            this.itemTypeLabel.AutoSize = true;
            this.itemTypeLabel.BackColor = System.Drawing.Color.Transparent;
            this.itemTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemTypeLabel.ForeColor = System.Drawing.Color.Black;
            this.itemTypeLabel.Location = new System.Drawing.Point(392, 151);
            this.itemTypeLabel.Name = "itemTypeLabel";
            this.itemTypeLabel.Size = new System.Drawing.Size(102, 24);
            this.itemTypeLabel.TabIndex = 4;
            this.itemTypeLabel.Text = "Item Type";
            // 
            // itemsListBoxLabel
            // 
            this.itemsListBoxLabel.AutoSize = true;
            this.itemsListBoxLabel.BackColor = System.Drawing.Color.Transparent;
            this.itemsListBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemsListBoxLabel.Location = new System.Drawing.Point(111, 88);
            this.itemsListBoxLabel.Name = "itemsListBoxLabel";
            this.itemsListBoxLabel.Size = new System.Drawing.Size(133, 20);
            this.itemsListBoxLabel.TabIndex = 6;
            this.itemsListBoxLabel.Text = "Inventory Items";
            // 
            // stockLabel
            // 
            this.stockLabel.AutoSize = true;
            this.stockLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockLabel.Location = new System.Drawing.Point(76, 22);
            this.stockLabel.Name = "stockLabel";
            this.stockLabel.Size = new System.Drawing.Size(55, 20);
            this.stockLabel.TabIndex = 7;
            this.stockLabel.Text = "Stock";
            // 
            // onHandStockTextBox
            // 
            this.onHandStockTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.onHandStockTextBox.Location = new System.Drawing.Point(10, 46);
            this.onHandStockTextBox.Name = "onHandStockTextBox";
            this.onHandStockTextBox.Size = new System.Drawing.Size(40, 22);
            this.onHandStockTextBox.TabIndex = 3;
            this.onHandStockTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // maximumStockTextBox
            // 
            this.maximumStockTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maximumStockTextBox.Location = new System.Drawing.Point(10, 78);
            this.maximumStockTextBox.Name = "maximumStockTextBox";
            this.maximumStockTextBox.Size = new System.Drawing.Size(40, 22);
            this.maximumStockTextBox.TabIndex = 4;
            this.maximumStockTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // onHandStockLabel
            // 
            this.onHandStockLabel.AutoSize = true;
            this.onHandStockLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onHandStockLabel.Location = new System.Drawing.Point(55, 48);
            this.onHandStockLabel.Name = "onHandStockLabel";
            this.onHandStockLabel.Size = new System.Drawing.Size(80, 20);
            this.onHandStockLabel.TabIndex = 10;
            this.onHandStockLabel.Text = "On Hand";
            // 
            // maxStockLabel
            // 
            this.maxStockLabel.AutoSize = true;
            this.maxStockLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxStockLabel.Location = new System.Drawing.Point(55, 80);
            this.maxStockLabel.Name = "maxStockLabel";
            this.maxStockLabel.Size = new System.Drawing.Size(142, 20);
            this.maxStockLabel.TabIndex = 11;
            this.maxStockLabel.Text = "Full Stock Count";
            // 
            // upButton
            // 
            this.upButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.upButton.Location = new System.Drawing.Point(42, 139);
            this.upButton.Name = "upButton";
            this.upButton.Size = new System.Drawing.Size(58, 33);
            this.upButton.TabIndex = 12;
            this.upButton.Text = "Up";
            this.upButton.UseVisualStyleBackColor = false;
            this.upButton.Click += new System.EventHandler(this.upButton_Click);
            // 
            // downButton
            // 
            this.downButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.downButton.Location = new System.Drawing.Point(106, 139);
            this.downButton.Name = "downButton";
            this.downButton.Size = new System.Drawing.Size(59, 33);
            this.downButton.TabIndex = 13;
            this.downButton.Text = "Down";
            this.downButton.UseVisualStyleBackColor = false;
            this.downButton.Click += new System.EventHandler(this.downButton_Click);
            // 
            // addRemoveStockLabel
            // 
            this.addRemoveStockLabel.AutoSize = true;
            this.addRemoveStockLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addRemoveStockLabel.Location = new System.Drawing.Point(22, 116);
            this.addRemoveStockLabel.Name = "addRemoveStockLabel";
            this.addRemoveStockLabel.Size = new System.Drawing.Size(162, 20);
            this.addRemoveStockLabel.TabIndex = 14;
            this.addRemoveStockLabel.Text = "Add/Remove Stock";
            // 
            // restockButton
            // 
            this.restockButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.restockButton.Location = new System.Drawing.Point(67, 178);
            this.restockButton.Name = "restockButton";
            this.restockButton.Size = new System.Drawing.Size(77, 33);
            this.restockButton.TabIndex = 15;
            this.restockButton.Text = "Restock";
            this.restockButton.UseVisualStyleBackColor = false;
            this.restockButton.Click += new System.EventHandler(this.restockButton_Click);
            // 
            // addItemButton
            // 
            this.addItemButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.addItemButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addItemButton.Location = new System.Drawing.Point(377, 441);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(204, 36);
            this.addItemButton.TabIndex = 16;
            this.addItemButton.Text = "Add New Item";
            this.addItemButton.UseVisualStyleBackColor = false;
            this.addItemButton.Click += new System.EventHandler(this.addItemButton_Click);
            // 
            // deleteItemButton
            // 
            this.deleteItemButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.deleteItemButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteItemButton.Location = new System.Drawing.Point(67, 441);
            this.deleteItemButton.Name = "deleteItemButton";
            this.deleteItemButton.Size = new System.Drawing.Size(226, 36);
            this.deleteItemButton.TabIndex = 17;
            this.deleteItemButton.Text = "Remove Selected Item";
            this.deleteItemButton.UseVisualStyleBackColor = false;
            this.deleteItemButton.Click += new System.EventHandler(this.deleteItemButton_Click);
            // 
            // stockGroupBox
            // 
            this.stockGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.stockGroupBox.Controls.Add(this.stockLabel);
            this.stockGroupBox.Controls.Add(this.onHandStockTextBox);
            this.stockGroupBox.Controls.Add(this.maximumStockTextBox);
            this.stockGroupBox.Controls.Add(this.restockButton);
            this.stockGroupBox.Controls.Add(this.onHandStockLabel);
            this.stockGroupBox.Controls.Add(this.addRemoveStockLabel);
            this.stockGroupBox.Controls.Add(this.downButton);
            this.stockGroupBox.Controls.Add(this.maxStockLabel);
            this.stockGroupBox.Controls.Add(this.upButton);
            this.stockGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockGroupBox.ForeColor = System.Drawing.Color.Black;
            this.stockGroupBox.Location = new System.Drawing.Point(374, 209);
            this.stockGroupBox.Name = "stockGroupBox";
            this.stockGroupBox.Size = new System.Drawing.Size(207, 224);
            this.stockGroupBox.TabIndex = 18;
            this.stockGroupBox.TabStop = false;
            this.stockGroupBox.Text = "Manage Stock";
            // 
            // searchNameButton
            // 
            this.searchNameButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.searchNameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchNameButton.Location = new System.Drawing.Point(529, 106);
            this.searchNameButton.Name = "searchNameButton";
            this.searchNameButton.Size = new System.Drawing.Size(117, 36);
            this.searchNameButton.TabIndex = 16;
            this.searchNameButton.Text = "Search";
            this.searchNameButton.UseVisualStyleBackColor = false;
            this.searchNameButton.Click += new System.EventHandler(this.searchNameButton_Click);
            // 
            // searchTypeButton
            // 
            this.searchTypeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.searchTypeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTypeButton.Location = new System.Drawing.Point(529, 169);
            this.searchTypeButton.Name = "searchTypeButton";
            this.searchTypeButton.Size = new System.Drawing.Size(117, 36);
            this.searchTypeButton.TabIndex = 19;
            this.searchTypeButton.Text = "Search";
            this.searchTypeButton.UseVisualStyleBackColor = false;
            this.searchTypeButton.Click += new System.EventHandler(this.searchTypeButton_Click);
            // 
            // returnButton
            // 
            this.returnButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.returnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnButton.Location = new System.Drawing.Point(231, 497);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(226, 36);
            this.returnButton.TabIndex = 20;
            this.returnButton.Text = "Return To Main Menu";
            this.returnButton.UseVisualStyleBackColor = false;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // InventoryProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(661, 545);
            this.ControlBox = false;
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.searchTypeButton);
            this.Controls.Add(this.searchNameButton);
            this.Controls.Add(this.stockGroupBox);
            this.Controls.Add(this.deleteItemButton);
            this.Controls.Add(this.addItemButton);
            this.Controls.Add(this.itemsListBoxLabel);
            this.Controls.Add(this.itemTypeTextBox);
            this.Controls.Add(this.itemTypeLabel);
            this.Controls.Add(this.itemNameTextBox);
            this.Controls.Add(this.itemNameLabel);
            this.Controls.Add(this.itemsListBox);
            this.Controls.Add(this.inventoryLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "InventoryProject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.stockGroupBox.ResumeLayout(false);
            this.stockGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label inventoryLabel;
        private System.Windows.Forms.ListBox itemsListBox;
        private System.Windows.Forms.Label itemNameLabel;
        private System.Windows.Forms.TextBox itemNameTextBox;
        private System.Windows.Forms.TextBox itemTypeTextBox;
        private System.Windows.Forms.Label itemTypeLabel;
        private System.Windows.Forms.Label itemsListBoxLabel;
        private System.Windows.Forms.Label stockLabel;
        private System.Windows.Forms.TextBox onHandStockTextBox;
        private System.Windows.Forms.TextBox maximumStockTextBox;
        private System.Windows.Forms.Label onHandStockLabel;
        private System.Windows.Forms.Label maxStockLabel;
        private System.Windows.Forms.Button upButton;
        private System.Windows.Forms.Button downButton;
        private System.Windows.Forms.Label addRemoveStockLabel;
        private System.Windows.Forms.Button restockButton;
        private System.Windows.Forms.Button addItemButton;
        private System.Windows.Forms.Button deleteItemButton;
        private System.Windows.Forms.GroupBox stockGroupBox;
        private System.Windows.Forms.Button searchNameButton;
        private System.Windows.Forms.Button searchTypeButton;
        private System.Windows.Forms.Button returnButton;
    }
}

