namespace Sales_Management
{
    partial class AddCustomTextInBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCustomTextInBill));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.footer_ = new System.Windows.Forms.RichTextBox();
            this.header_ = new System.Windows.Forms.RichTextBox();
            this._Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Header Text";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Footer Text";
            // 
            // footer_
            // 
            this.footer_.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.footer_.Location = new System.Drawing.Point(16, 126);
            this.footer_.Name = "footer_";
            this.footer_.Size = new System.Drawing.Size(488, 77);
            this.footer_.TabIndex = 2;
            this.footer_.Text = "";
            // 
            // header_
            // 
            this.header_.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.header_.Location = new System.Drawing.Point(16, 29);
            this.header_.Name = "header_";
            this.header_.Size = new System.Drawing.Size(488, 77);
            this.header_.TabIndex = 1;
            this.header_.Text = "";
            // 
            // _Save
            // 
            this._Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._Save.Location = new System.Drawing.Point(16, 210);
            this._Save.Name = "_Save";
            this._Save.Size = new System.Drawing.Size(103, 36);
            this._Save.TabIndex = 3;
            this._Save.Text = "Save";
            this._Save.UseVisualStyleBackColor = true;
            this._Save.Click += new System.EventHandler(this._Save_Click);
            // 
            // AddCustomTextInBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(519, 258);
            this.Controls.Add(this._Save);
            this.Controls.Add(this.header_);
            this.Controls.Add(this.footer_);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddCustomTextInBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Custom Text In Bill";
            this.Load += new System.EventHandler(this.AddCustomTextInBill_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox footer_;
        private System.Windows.Forms.RichTextBox header_;
        private System.Windows.Forms.Button _Save;
    }
}