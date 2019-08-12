namespace Sales_Management
{
    partial class BackgroundImageSetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackgroundImageSetting));
            this.mode_ = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.save_ = new System.Windows.Forms.Button();
            this.imgtextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.browse_btn = new System.Windows.Forms.Button();
            this.clr_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mode_
            // 
            this.mode_.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mode_.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mode_.FormattingEnabled = true;
            this.mode_.Items.AddRange(new object[] {
            "None",
            "Center",
            "Stretch",
            "Tile",
            "Zoom"});
            this.mode_.Location = new System.Drawing.Point(151, 39);
            this.mode_.Name = "mode_";
            this.mode_.Size = new System.Drawing.Size(484, 21);
            this.mode_.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Background Image Setting";
            // 
            // save_
            // 
            this.save_.Location = new System.Drawing.Point(151, 66);
            this.save_.Name = "save_";
            this.save_.Size = new System.Drawing.Size(96, 31);
            this.save_.TabIndex = 2;
            this.save_.Text = "Save";
            this.save_.UseVisualStyleBackColor = true;
            this.save_.Click += new System.EventHandler(this.save__Click);
            // 
            // imgtextbox
            // 
            this.imgtextbox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.imgtextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgtextbox.Location = new System.Drawing.Point(151, 13);
            this.imgtextbox.Name = "imgtextbox";
            this.imgtextbox.ReadOnly = true;
            this.imgtextbox.Size = new System.Drawing.Size(308, 20);
            this.imgtextbox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Background Image";
            // 
            // browse_btn
            // 
            this.browse_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.browse_btn.Location = new System.Drawing.Point(465, 11);
            this.browse_btn.Name = "browse_btn";
            this.browse_btn.Size = new System.Drawing.Size(83, 23);
            this.browse_btn.TabIndex = 5;
            this.browse_btn.Text = "browse";
            this.browse_btn.UseVisualStyleBackColor = true;
            this.browse_btn.Click += new System.EventHandler(this.browse_btn_Click);
            // 
            // clr_btn
            // 
            this.clr_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.clr_btn.Location = new System.Drawing.Point(554, 11);
            this.clr_btn.Name = "clr_btn";
            this.clr_btn.Size = new System.Drawing.Size(83, 23);
            this.clr_btn.TabIndex = 6;
            this.clr_btn.Text = "Clear";
            this.clr_btn.UseVisualStyleBackColor = true;
            this.clr_btn.Click += new System.EventHandler(this.clr_btn_Click);
            // 
            // BackgroundImageSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 105);
            this.Controls.Add(this.clr_btn);
            this.Controls.Add(this.browse_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.imgtextbox);
            this.Controls.Add(this.save_);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mode_);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "BackgroundImageSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Background Image Setting";
            this.Load += new System.EventHandler(this.BackgroundImageSetting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox mode_;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button save_;
        private System.Windows.Forms.TextBox imgtextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button browse_btn;
        private System.Windows.Forms.Button clr_btn;
    }
}