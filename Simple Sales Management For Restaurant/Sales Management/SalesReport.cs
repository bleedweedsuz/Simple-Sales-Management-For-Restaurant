using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sales_Management
{
    public partial class SalesReport : Form
    {
        public SalesReport()
        {
            InitializeComponent();
        }
        private void SalesReport_Load(object sender, EventArgs e)
        {
            _select.SelectedIndex = 0;
            A.Visible = true;
            B.Visible = false;
        }
        private void _SearchA_Click(object sender, EventArgs e)
        {
            SearchCalculate();
        }
        private void _SearchB_Click(object sender, EventArgs e)
        {
            SearchDate(d1.Value.ToShortDateString(), d2.Value.ToShortDateString());
        }
        private void _select_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_select.SelectedIndex == 0)
            {
                A.Visible = true;
                B.Visible = false;
                topPanel.Height = 75;
            }
            else if (_select.SelectedIndex == 1)
            {
                A.Visible = false;
                B.Visible = true;
                topPanel.Height = 102;
            }
        }
        private void SearchCalculate()
        {
            try
            {
                Decimal gTotalData = 0.00m;
                int count = 0;
                salesGrid.Rows.Clear();
                DBConnection.Open();
                String query = "select * from Sales where status = 1";
                OleDbDataReader reader = DBConnection._Read(query);
                while (reader.Read())
                {
                    count++;
                    Decimal tempg = Convert.ToDecimal(reader[9].ToString());
                    gTotalData += tempg;
                    salesGrid.Rows.Add(count, (int)reader[0], reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), "Rs. " + tempg + "/-");
                }
                gTotal.Text = "Rs. " + gTotalData.ToString() + "/-";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DBConnection.Close();
            }
        }
        private void SearchDate(String d1, String d2)
        {
            try
            {
                Decimal gTotalData = 0.00m;
                int count = 0;
                salesGrid.Rows.Clear();
                DBConnection.Open();
                String query = "select * from Sales where (lastdate between @d1 and @d2) and status=1 order by Rno desc;";
                OleDbParameter[] pars = new OleDbParameter[] { new OleDbParameter() { Value = d1 }, new OleDbParameter() { Value = d2 } };
                OleDbDataReader reader = DBConnection._Read(query, pars);

                while (reader.Read())
                {
                    count++;
                    Decimal tempg = Convert.ToDecimal(reader[9].ToString());
                    gTotalData += tempg;
                    salesGrid.Rows.Add(count, (int)reader[0], reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), "Rs. " + tempg + "/-");
                }
                gTotal.Text = "Rs. " + gTotalData.ToString() + "/-";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DBConnection.Close();
            }
        }
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    ReportForm rForm = new ReportForm();
                    rForm.rForm = 1;
                    rForm.Text = "Sales Report";
                    ReportViewer rViewer = rForm.rViewerPanel2;
                    MainDataset mDataSet = new MainDataset();
                    DataTable dtSales = mDataSet.Tables[1];
                    //First SalesLists
                    for (int i = 0; i < salesGrid.Rows.Count; i++)
                    {
                        dtSales.Rows.Add((i + 1).ToString(), salesGrid[1, i].Value.ToString(), salesGrid[2, i].Value.ToString(), salesGrid[3, i].Value.ToString(), salesGrid[4, i].Value.ToString(), salesGrid[5, i].Value.ToString());
                    }
                    ReportDataSource rds = new ReportDataSource("SalesDataSet", dtSales);
                    rViewer.LocalReport.DataSources.Clear();
                    rViewer.LocalReport.DataSources.Add(rds);
                    
                    List<ReportParameter> rpLists = new List<ReportParameter>();
                    if (_select.SelectedIndex == 0)
                    {
                        rpLists.Add(new ReportParameter("strA", _select.Text));
                    }
                    else
                    {
                        rpLists.Add(new ReportParameter("strA", "Date Between [ " + d1.Value.ToShortDateString() + " to " + d2.Value.ToShortDateString() + " ]"));
                    }
                    rpLists.Add(new ReportParameter("gTotal", gTotal.Text));
                    rViewer.LocalReport.SetParameters(rpLists);
                    
                    rViewer.RefreshReport();
                    rForm.MdiParent = MainForm.mForm;
                    rForm.Show();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
