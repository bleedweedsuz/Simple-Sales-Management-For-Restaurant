namespace Sales_Management
{
    partial class SearchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this._select = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.B = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.d2 = new System.Windows.Forms.DateTimePicker();
            this.d1 = new System.Windows.Forms.DateTimePicker();
            this._SearchB = new System.Windows.Forms.Button();
            this.A = new System.Windows.Forms.Panel();
            this._SearchA = new System.Windows.Forms.Button();
            this.inA = new System.Windows.Forms.TextBox();
            this.searchGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.B.SuspendLayout();
            this.A.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this._select);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.A);
            this.panel1.Controls.Add(this.B);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(806, 103);
            this.panel1.TabIndex = 0;
            // 
            // _select
            // 
            this._select.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._select.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._select.FormattingEnabled = true;
            this._select.Items.AddRange(new object[] {
            "Receipt No",
            "Customer Name",
            "Date"});
            this._select.Location = new System.Drawing.Point(81, 7);
            this._select.Name = "_select";
            this._select.Size = new System.Drawing.Size(722, 21);
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
            this.B.Location = new System.Drawing.Point(78, 34);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(725, 65);
            this.B.TabIndex = 3;
            this.B.Visible = false;
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
            // A
            // 
            this.A.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.A.Controls.Add(this.label3);
            this.A.Controls.Add(this._SearchA);
            this.A.Controls.Add(this.inA);
            this.A.Location = new System.Drawing.Point(78, 34);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(725, 65);
            this.A.TabIndex = 1;
            // 
            // _SearchA
            // 
            this._SearchA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._SearchA.Image = ((System.Drawing.Image)(resources.GetObject("_SearchA.Image")));
            this._SearchA.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._SearchA.Location = new System.Drawing.Point(3, 27);
            this._SearchA.Name = "_SearchA";
            this._SearchA.Size = new System.Drawing.Size(112, 36);
            this._SearchA.TabIndex = 1;
            this._SearchA.Text = "Search Data";
            this._SearchA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._SearchA.UseVisualStyleBackColor = true;
            this._SearchA.Click += new System.EventHandler(this._SearchA_Click);
            // 
            // inA
            // 
            this.inA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inA.Location = new System.Drawing.Point(3, 3);
            this.inA.Name = "inA";
            this.inA.Size = new System.Drawing.Size(719, 20);
            this.inA.TabIndex = 0;
            this.inA.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inA_KeyDown);
            // 
            // searchGrid
            // 
            this.searchGrid.AllowUserToAddRows = false;
            this.searchGrid.AllowUserToResizeRows = false;
            this.searchGrid.BackgroundColor = System.Drawing.Color.White;
            this.searchGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.searchGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchGrid.Location = new System.Drawing.Point(0, 103);
            this.searchGrid.Name = "searchGrid";
            this.searchGrid.RowHeadersVisible = false;
            this.searchGrid.Size = new System.Drawing.Size(806, 362);
            this.searchGrid.TabIndex = 1;
            this.searchGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.searchGrid_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "SN";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Receipt No.";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Token No.";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
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
            this.Column6.Width = 150;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Status";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(122, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Note* Hit \"Enter\" to search data";
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(806, 465);
            this.Controls.Add(this.searchGrid);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SearchForm";
            this.Text = "Search Sales";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.B.ResumeLayout(false);
            this.B.PerformLayout();
            this.A.ResumeLayout(false);
            this.A.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox _select;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel A;
        private System.Windows.Forms.Button _SearchA;
        private System.Windows.Forms.TextBox inA;
        private System.Windows.Forms.DataGridView searchGrid;
        private System.Windows.Forms.Panel B;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker d2;
        private System.Windows.Forms.DateTimePicker d1;
        private System.Windows.Forms.Button _SearchB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Label label3;
    }
}