namespace Sales_Management
{
    partial class Product
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Product));
            this._clear = new System.Windows.Forms.Button();
            this.quantity = new System.Windows.Forms.NumericUpDown();
            this.rate = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.detail = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ProductGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Save_ = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.mStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.quantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductGrid)).BeginInit();
            this.mStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // _clear
            // 
            this._clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._clear.Location = new System.Drawing.Point(142, 267);
            this._clear.Name = "_clear";
            this._clear.Size = new System.Drawing.Size(128, 35);
            this._clear.TabIndex = 4;
            this._clear.Tag = "4";
            this._clear.Text = "Clear";
            this._clear.UseVisualStyleBackColor = true;
            this._clear.Click += new System.EventHandler(this._clear_Click);
            // 
            // quantity
            // 
            this.quantity.Location = new System.Drawing.Point(11, 138);
            this.quantity.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.quantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            this.quantity.Size = new System.Drawing.Size(256, 20);
            this.quantity.TabIndex = 6;
            this.quantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // rate
            // 
            this.rate.DecimalPlaces = 2;
            this.rate.Location = new System.Drawing.Point(11, 99);
            this.rate.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.rate.Name = "rate";
            this.rate.Size = new System.Drawing.Size(256, 20);
            this.rate.TabIndex = 1;
            this.rate.Tag = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Rate";
            // 
            // detail
            // 
            this.detail.Location = new System.Drawing.Point(8, 177);
            this.detail.Name = "detail";
            this.detail.Size = new System.Drawing.Size(259, 71);
            this.detail.TabIndex = 2;
            this.detail.Tag = "2";
            this.detail.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Details";
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.Color.White;
            this.name.ForeColor = System.Drawing.Color.Black;
            this.name.Location = new System.Drawing.Point(8, 60);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(259, 20);
            this.name.TabIndex = 0;
            this.name.Tag = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Name [ important ]";
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(8, 21);
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Size = new System.Drawing.Size(259, 20);
            this.id.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "ID";
            // 
            // ProductGrid
            // 
            this.ProductGrid.AllowUserToAddRows = false;
            this.ProductGrid.AllowUserToOrderColumns = true;
            this.ProductGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductGrid.BackgroundColor = System.Drawing.Color.White;
            this.ProductGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column5,
            this.Column6,
            this.Column3,
            this.Column7,
            this.Column4});
            this.ProductGrid.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.ProductGrid.Location = new System.Drawing.Point(276, 30);
            this.ProductGrid.Name = "ProductGrid";
            this.ProductGrid.RowHeadersVisible = false;
            this.ProductGrid.Size = new System.Drawing.Size(571, 273);
            this.ProductGrid.TabIndex = 31;
            this.ProductGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductGrid_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Rate";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 70;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Quantity";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 70;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Details";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 70;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Edit";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Delete";
            this.Column4.Name = "Column4";
            // 
            // Save_
            // 
            this.Save_.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save_.Location = new System.Drawing.Point(5, 267);
            this.Save_.Name = "Save_";
            this.Save_.Size = new System.Drawing.Size(128, 35);
            this.Save_.TabIndex = 3;
            this.Save_.Tag = "3";
            this.Save_.Text = "Save";
            this.Save_.UseVisualStyleBackColor = true;
            this.Save_.Click += new System.EventHandler(this.Save__Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(8, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(235, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Note* Ctrl + S to save data. Ctrl + Q to clear form";
            // 
            // mStrip
            // 
            this.mStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.mStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.mStrip.Location = new System.Drawing.Point(409, 234);
            this.mStrip.Name = "mStrip";
            this.mStrip.Size = new System.Drawing.Size(56, 24);
            this.mStrip.TabIndex = 41;
            this.mStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.clearFormToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileToolStripMenuItem.Text = "Tools";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // clearFormToolStripMenuItem
            // 
            this.clearFormToolStripMenuItem.Name = "clearFormToolStripMenuItem";
            this.clearFormToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.clearFormToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.clearFormToolStripMenuItem.Text = "Clear Form";
            this.clearFormToolStripMenuItem.Click += new System.EventHandler(this.clearFormToolStripMenuItem_Click);
            // 
            // sName
            // 
            this.sName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sName.BackColor = System.Drawing.Color.White;
            this.sName.ForeColor = System.Drawing.Color.Black;
            this.sName.Location = new System.Drawing.Point(354, 4);
            this.sName.Name = "sName";
            this.sName.Size = new System.Drawing.Size(493, 20);
            this.sName.TabIndex = 5;
            this.sName.Tag = "0";
            this.sName.TextChanged += new System.EventHandler(this.sName_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(276, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 42;
            this.label7.Text = "Search [Name]";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(272, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 300);
            this.panel1.TabIndex = 44;
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(851, 307);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this._clear);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.rate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.detail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProductGrid);
            this.Controls.Add(this.Save_);
            this.Controls.Add(this.mStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mStrip;
            this.Name = "Product";
            this.Text = "Product";
            this.Load += new System.EventHandler(this.Product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductGrid)).EndInit();
            this.mStrip.ResumeLayout(false);
            this.mStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _clear;
        private System.Windows.Forms.NumericUpDown quantity;
        private System.Windows.Forms.NumericUpDown rate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox detail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ProductGrid;
        private System.Windows.Forms.Button Save_;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewButtonColumn Column7;
        private System.Windows.Forms.DataGridViewButtonColumn Column4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MenuStrip mStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearFormToolStripMenuItem;
        private System.Windows.Forms.TextBox sName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
    }
}