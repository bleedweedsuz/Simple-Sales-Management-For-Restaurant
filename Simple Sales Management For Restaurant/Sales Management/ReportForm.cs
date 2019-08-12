using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sales_Management
{
    public partial class ReportForm : Form
    {
        public int rForm = 0;

        public ReportForm()
        {
            InitializeComponent();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            if (rForm == 0)
            {
                rViewerPanel.Visible = true;
                rViewerPanel2.Visible = false;
                rViewerPanel.Dock = DockStyle.Fill;
            }
            else if (rForm == 1)
            {
                rViewerPanel.Visible = false;
                rViewerPanel2.Visible = true;
                rViewerPanel2.Dock = DockStyle.Fill;
            }
            //--------------------------------------------------->
            this.rViewerPanel.RefreshReport();
        }
    }
}
