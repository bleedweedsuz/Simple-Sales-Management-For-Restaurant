namespace Sales_Management
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.salesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.newTransactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchReceiptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.totalSalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeBackgroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseManipulationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewServiceChargeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCustomTextInBillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salesToolStripMenuItem,
            this.reportToolStripMenuItem,
            this.settingToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(705, 24);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "menuStrip1";
            // 
            // salesToolStripMenuItem
            // 
            this.salesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productsToolStripMenuItem,
            this.toolStripSeparator1,
            this.newTransactionToolStripMenuItem,
            this.searchReceiptToolStripMenuItem});
            this.salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            this.salesToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.salesToolStripMenuItem.Text = "Master";
            // 
            // productsToolStripMenuItem
            // 
            this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            this.productsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.productsToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.productsToolStripMenuItem.Text = "Products";
            this.productsToolStripMenuItem.Click += new System.EventHandler(this.productsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(201, 6);
            // 
            // newTransactionToolStripMenuItem
            // 
            this.newTransactionToolStripMenuItem.Name = "newTransactionToolStripMenuItem";
            this.newTransactionToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.newTransactionToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.newTransactionToolStripMenuItem.Text = "New Transaction";
            this.newTransactionToolStripMenuItem.Click += new System.EventHandler(this.newTransactionToolStripMenuItem_Click);
            // 
            // searchReceiptToolStripMenuItem
            // 
            this.searchReceiptToolStripMenuItem.Name = "searchReceiptToolStripMenuItem";
            this.searchReceiptToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.searchReceiptToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.searchReceiptToolStripMenuItem.Text = "Search Sales";
            this.searchReceiptToolStripMenuItem.Click += new System.EventHandler(this.searchReceiptToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.totalSalesToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // totalSalesToolStripMenuItem
            // 
            this.totalSalesToolStripMenuItem.Name = "totalSalesToolStripMenuItem";
            this.totalSalesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.totalSalesToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.totalSalesToolStripMenuItem.Text = "Total Sales";
            this.totalSalesToolStripMenuItem.Click += new System.EventHandler(this.totalSalesToolStripMenuItem_Click);
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.windowToolStripMenuItem,
            this.changeBackgroundToolStripMenuItem,
            this.databaseManipulationToolStripMenuItem,
            this.addNewServiceChargeToolStripMenuItem,
            this.addCustomTextInBillToolStripMenuItem});
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.settingToolStripMenuItem.Text = "Setting";
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cascadeViewToolStripMenuItem,
            this.tileVerticalToolStripMenuItem,
            this.tileHorizontalToolStripMenuItem});
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.windowToolStripMenuItem.Text = "Window";
            // 
            // cascadeViewToolStripMenuItem
            // 
            this.cascadeViewToolStripMenuItem.Name = "cascadeViewToolStripMenuItem";
            this.cascadeViewToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cascadeViewToolStripMenuItem.Text = "Cascade View";
            this.cascadeViewToolStripMenuItem.Click += new System.EventHandler(this.cascadeViewToolStripMenuItem_Click);
            // 
            // tileVerticalToolStripMenuItem
            // 
            this.tileVerticalToolStripMenuItem.Name = "tileVerticalToolStripMenuItem";
            this.tileVerticalToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tileVerticalToolStripMenuItem.Text = "Tile Vertical";
            this.tileVerticalToolStripMenuItem.Click += new System.EventHandler(this.tileVerticalToolStripMenuItem_Click);
            // 
            // tileHorizontalToolStripMenuItem
            // 
            this.tileHorizontalToolStripMenuItem.Name = "tileHorizontalToolStripMenuItem";
            this.tileHorizontalToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tileHorizontalToolStripMenuItem.Text = "Tile Horizontal";
            this.tileHorizontalToolStripMenuItem.Click += new System.EventHandler(this.tileHorizontalToolStripMenuItem_Click);
            // 
            // changeBackgroundToolStripMenuItem
            // 
            this.changeBackgroundToolStripMenuItem.Name = "changeBackgroundToolStripMenuItem";
            this.changeBackgroundToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.changeBackgroundToolStripMenuItem.Text = "Change Background";
            this.changeBackgroundToolStripMenuItem.Click += new System.EventHandler(this.changeBackgroundToolStripMenuItem_Click);
            // 
            // databaseManipulationToolStripMenuItem
            // 
            this.databaseManipulationToolStripMenuItem.Name = "databaseManipulationToolStripMenuItem";
            this.databaseManipulationToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.databaseManipulationToolStripMenuItem.Text = "Database Manipulation";
            this.databaseManipulationToolStripMenuItem.Click += new System.EventHandler(this.databaseManipulationToolStripMenuItem_Click);
            // 
            // addNewServiceChargeToolStripMenuItem
            // 
            this.addNewServiceChargeToolStripMenuItem.Name = "addNewServiceChargeToolStripMenuItem";
            this.addNewServiceChargeToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.addNewServiceChargeToolStripMenuItem.Text = "Add New Service Charge";
            this.addNewServiceChargeToolStripMenuItem.Click += new System.EventHandler(this.addNewServiceChargeToolStripMenuItem_Click);
            // 
            // addCustomTextInBillToolStripMenuItem
            // 
            this.addCustomTextInBillToolStripMenuItem.Name = "addCustomTextInBillToolStripMenuItem";
            this.addCustomTextInBillToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.addCustomTextInBillToolStripMenuItem.Text = "Add Custom Text In Bill";
            this.addCustomTextInBillToolStripMenuItem.Click += new System.EventHandler(this.addCustomTextInBillToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(705, 482);
            this.Controls.Add(this.mainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mainMenu;
            this.Name = "MainForm";
            this.Text = "Sales Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newTransactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchReceiptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem totalSalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeBackgroundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascadeViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databaseManipulationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewServiceChargeToolStripMenuItem;
        public System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem addCustomTextInBillToolStripMenuItem;
    }
}

