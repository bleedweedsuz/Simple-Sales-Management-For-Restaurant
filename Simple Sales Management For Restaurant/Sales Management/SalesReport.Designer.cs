namespace Sales_Management
{
    partial class SalesReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesReport));
            this.salesGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._SearchA = new System.Windows.Forms.Button();
            this._SearchB = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.d2 = new System.Windows.Forms.DateTimePicker();
            this.d1 = new System.Windows.Forms.DateTimePicker();
            this._select = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.B = new System.Windows.Forms.Panel();
            this.A = new System.Windows.Forms.Panel();
            this.topPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gTotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.salesGrid)).BeginInit();
            this.B.SuspendLayout();
            this.A.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // salesGrid
            // 
            this.salesGrid.AllowUserToAddRows = false;
            this.salesGrid.BackgroundColor = System.Drawing.Color.White;
            this.salesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.salesGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.salesGrid.Location = new System.Drawing.Point(0, 95);
            this.salesGrid.Name = "salesGrid";
            this.salesGrid.RowHeadersVisible = false;
            this.salesGrid.Size = new System.Drawing.Size(687, 407);
            this.salesGrid.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "SN";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 40;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Receipt No.";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Title / Table / Cabin";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Customer";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 150;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Date";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 140;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Total";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // _SearchA
            // 
            this._SearchA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._SearchA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._SearchA.Image = ((System.Drawing.Image)(resources.GetObject("_SearchA.Image")));
            this._SearchA.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._SearchA.Location = new System.Drawing.Point(3, 3);
            this._SearchA.Name = "_SearchA";
            this._SearchA.Size = new System.Drawing.Size(600, 36);
            this._SearchA.TabIndex = 1;
            this._SearchA.Text = "Search Data";
            this._SearchA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._SearchA.UseVisualStyleBackColor = true;
            this._SearchA.Click += new System.EventHandler(this._SearchA_Click);
            // 
            // _SearchB
            // 
            this._SearchB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._SearchB.Image = ((System.Drawing.Image)(resources.GetObject("_SearchB.Image")));
            this._SearchB.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._SearchB.Location = new System.Drawing.Point(3, 27);
            this._SearchB.Name = "_SearchB";
            this._SearchB.Size = new System.Drawing.Size(112, 36);
            this._SearchB.TabIndex = 1;
            this._SearchB.Text = "Search Data";
            this._SearchB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._SearchB.UseVisualStyleBackColor = true;
            this._SearchB.Click += new System.EventHandler(this._SearchB_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "to";
            // 
            // d2
            // 
            this.d2.Location = new System.Drawing.Point(241, 5);
            this.d2.Name = "d2";
            this.d2.Size = new System.Drawing.Size(209, 20);
            this.d2.TabIndex = 5;
            // 
            // d1
            // 
            this.d1.Location = new System.Drawing.Point(3, 5);
            this.d1.Name = "d1";
            this.d1.Size = new System.Drawing.Size(209, 20);
            this.d1.TabIndex = 4;
            // 
            // _select
            // 
            this._select.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._select.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._select.FormattingEnabled = true;
            this._select.Items.AddRange(new object[] {
            "Full Report From Beginning",
            "Use Date Between"});
            this._select.Location = new System.Drawing.Point(81, 7);
            this._select.Name = "_select";
            this._select.Size = new System.Drawing.Size(603, 21);
            this._select.TabIndex = 1;
            this._select.SelectedIndexChanged += new System.EventHandler(this._select_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search By";
            // 
            // B
            // 
            this.B.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.B.Controls.Add(this.label2);
            this.B.Controls.Add(this.d2);
            this.B.Controls.Add(this.d1);
            this.B.Controls.Add(this._SearchB);
            this.B.Location = new System.Drawing.Point(78, 28);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(606, 65);
            this.B.TabIndex = 3;
            this.B.Visible = false;
            // 
            // A
            // 
            this.A.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.A.Controls.Add(this._SearchA);
            this.A.Location = new System.Drawing.Point(78, 28);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(606, 65);
            this.A.TabIndex = 1;
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this._select);
            this.topPanel.Controls.Add(this.label1);
            this.topPanel.Controls.Add(this.B);
            this.topPanel.Controls.Add(this.A);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(687, 95);
            this.topPanel.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gTotal);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 502);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(687, 39);
            this.panel1.TabIndex = 4;
            // 
            // gTotal
            // 
            this.gTotal.AutoSize = true;
            this.gTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gTotal.Location = new System.Drawing.Point(12, 17);
            this.gTotal.Name = "gTotal";
            this.gTotal.Size = new System.Drawing.Size(73, 16);
            this.gTotal.TabIndex = 1;
            this.gTotal.Text = "Rs. 0.00/-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Total Sales";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(501, 212);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(144, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // SalesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(687, 541);
            this.Controls.Add(this.salesGrid);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.topPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(660, 580);
            this.Name = "SalesReport";
            this.Text = "Sales Report";
            this.Load += new System.EventHandler(this.SalesReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.salesGrid)).EndInit();
            this.B.ResumeLayout(false);
            this.B.PerformLayout();
            this.A.ResumeLayout(false);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView salesGrid;
        private System.Windows.Forms.Button _SearchA;
        private System.Windows.Forms.Button _SearchB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker d2;
        private System.Windows.Forms.DateTimePicker d1;
        private System.Windows.Forms.ComboBox _select;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel B;
        private System.Windows.Forms.Panel A;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label gTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
    }
}