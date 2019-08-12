namespace Sales_Management
{
    partial class DatabaseManipulation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatabaseManipulation));
            this.label1 = new System.Windows.Forms.Label();
            this._Create = new System.Windows.Forms.Button();
            this._location = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this._status = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(711, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Warning !!\r\nPlease make sure you make a backup before creating new session.\r\nThis" +
    " system will permanently delete all the old records and make a new one you can f" +
    "ind database in following location.";
            // 
            // _Create
            // 
            this._Create.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._Create.Location = new System.Drawing.Point(15, 137);
            this._Create.Name = "_Create";
            this._Create.Size = new System.Drawing.Size(727, 45);
            this._Create.TabIndex = 2;
            this._Create.Text = "Create New Session";
            this._Create.UseVisualStyleBackColor = true;
            this._Create.Click += new System.EventHandler(this._Create_Click);
            // 
            // _location
            // 
            this._location.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._location.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._location.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this._location.Location = new System.Drawing.Point(15, 60);
            this._location.Name = "_location";
            this._location.ReadOnly = true;
            this._location.Size = new System.Drawing.Size(727, 22);
            this._location.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(12, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(730, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Copy the \"sales.mdb\" file as a backup. Note* it is password protected so make sur" +
    "e you get the password from the vendor.";
            // 
            // _status
            // 
            this._status.AutoSize = true;
            this._status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this._status.Location = new System.Drawing.Point(12, 118);
            this._status.Name = "_status";
            this._status.Size = new System.Drawing.Size(0, 16);
            this._status.TabIndex = 5;
            // 
            // DatabaseManipulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(753, 189);
            this.Controls.Add(this._status);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._location);
            this.Controls.Add(this._Create);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DatabaseManipulation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Database Manipulation";
            this.Load += new System.EventHandler(this.DatabaseManipulation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button _Create;
        private System.Windows.Forms.TextBox _location;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label _status;
    }
}