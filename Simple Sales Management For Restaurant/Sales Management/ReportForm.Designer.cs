namespace Sales_Management
{
    partial class ReportForm
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportForm));
            this.SalesListsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MainDataset = new Sales_Management.MainDataset();
            this.rViewerPanel = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rViewerPanel2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SalesReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.SalesListsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesReportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // SalesListsBindingSource
            // 
            this.SalesListsBindingSource.DataMember = "SalesLists";
            this.SalesListsBindingSource.DataSource = this.MainDataset;
            // 
            // MainDataset
            // 
            this.MainDataset.DataSetName = "MainDataset";
            this.MainDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rViewerPanel
            // 
            reportDataSource1.Name = "SalesLists";
            reportDataSource1.Value = this.SalesListsBindingSource;
            this.rViewerPanel.LocalReport.DataSources.Add(reportDataSource1);
            this.rViewerPanel.LocalReport.ReportEmbeddedResource = "Sales_Management.SalesBill.rdlc";
            this.rViewerPanel.Location = new System.Drawing.Point(12, 12);
            this.rViewerPanel.Name = "rViewerPanel";
            this.rViewerPanel.Size = new System.Drawing.Size(701, 94);
            this.rViewerPanel.TabIndex = 0;
            // 
            // rViewerPanel2
            // 
            reportDataSource2.Name = "SalesDataSet";
            reportDataSource2.Value = this.SalesReportBindingSource;
            this.rViewerPanel2.LocalReport.DataSources.Add(reportDataSource2);
            this.rViewerPanel2.LocalReport.ReportEmbeddedResource = "Sales_Management.SalesReports.rdlc";
            this.rViewerPanel2.Location = new System.Drawing.Point(12, 112);
            this.rViewerPanel2.Name = "rViewerPanel2";
            this.rViewerPanel2.Size = new System.Drawing.Size(701, 94);
            this.rViewerPanel2.TabIndex = 1;
            // 
            // SalesReportBindingSource
            // 
            this.SalesReportBindingSource.DataMember = "SalesReport";
            this.SalesReportBindingSource.DataSource = this.MainDataset;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(725, 590);
            this.Controls.Add(this.rViewerPanel2);
            this.Controls.Add(this.rViewerPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReportForm";
            this.Text = "Report Form";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SalesListsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainDataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesReportBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Microsoft.Reporting.WinForms.ReportViewer rViewerPanel;
        private System.Windows.Forms.BindingSource SalesListsBindingSource;
        private MainDataset MainDataset;
        public Microsoft.Reporting.WinForms.ReportViewer rViewerPanel2;
        private System.Windows.Forms.BindingSource SalesReportBindingSource;

    }
}