namespace Sales_Management
{
    partial class NewServiceCharge
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewServiceCharge));
            this.label1 = new System.Windows.Forms.Label();
            this._val = new System.Windows.Forms.NumericUpDown();
            this._save = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._val)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Service Charge ";
            // 
            // _val
            // 
            this._val.DecimalPlaces = 2;
            this._val.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._val.Location = new System.Drawing.Point(16, 30);
            this._val.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this._val.Name = "_val";
            this._val.Size = new System.Drawing.Size(265, 22);
            this._val.TabIndex = 1;
            // 
            // _save
            // 
            this._save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._save.Location = new System.Drawing.Point(16, 57);
            this._save.Name = "_save";
            this._save.Size = new System.Drawing.Size(284, 30);
            this._save.TabIndex = 2;
            this._save.Text = "Save";
            this._save.UseVisualStyleBackColor = true;
            this._save.Click += new System.EventHandler(this._save_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(287, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "%";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NewServiceCharge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(312, 92);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._save);
            this.Controls.Add(this._val);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewServiceCharge";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add New Service Charge";
            this.Load += new System.EventHandler(this.NewServiceCharge_Load);
            ((System.ComponentModel.ISupportInitialize)(this._val)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown _val;
        private System.Windows.Forms.Button _save;
        private System.Windows.Forms.Label label2;
    }
}