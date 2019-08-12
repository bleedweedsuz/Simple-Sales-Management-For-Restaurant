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
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }
        private void SearchForm_Load(object sender, EventArgs e)
        {
            _select.SelectedIndex = 0;
            A.Visible = true;
            B.Visible = false;
        } 
        private void _SearchA_Click(object sender, EventArgs e)
        {
            if (_select.SelectedIndex == 0)
            {
                SearchReceiptNo(inA.Text.Trim());
            }
            else if (_select.SelectedIndex == 1)
            {
                SearchCustomer(inA.Text.Trim());
            }
        }
        private void _SearchB_Click(object sender, EventArgs e)
        {
            SearchDate(d1.Value.ToShortDateString() + " 00:00:00 AM", d2.Value.ToShortDateString() + " 12:59:59 PM");
        }
        private void _select_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_select.SelectedIndex == 0 || _select.SelectedIndex == 1)
            {
                A.Visible = true;
                B.Visible = false;
            }
            else if (_select.SelectedIndex == 2)
            {
                A.Visible = false;
                B.Visible = true;
            }
        }
        private void SearchReceiptNo(String Rno)
        {
            try
            {
                searchGrid.Rows.Clear();
                int count = 0;
                DBConnection.Open();
                String query = "select * from Sales where Rno LIKE @needle + '%' order by Rno desc;";
                OleDbParameter[] pars = new OleDbParameter[] { new OleDbParameter() { Value = Rno } };
                OleDbDataReader reader = DBConnection._Read(query, pars);
                while (reader.Read())
                {
                    count++;
                    String _STATUS = "#Error";
                    if (reader[5].ToString() == "0")
                    {
                        _STATUS = "Draft";
                    }
                    else if (reader[5].ToString() == "1")
                    {
                        _STATUS = "Paid";
                    }
                    else if (reader[5].ToString() == "2")
                    {
                        _STATUS = "Cancled";
                    }
                    searchGrid.Rows.Add(count, (int)reader[0], reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), _STATUS);
                    searchGrid.Rows[count - 1].Cells[1].Style.BackColor = Color.LightGreen;
                    if (_STATUS.Equals("Draft")) { searchGrid.Rows[count - 1].Cells[6].Style.BackColor = Color.YellowGreen; }
                    else if (_STATUS.Equals("Paid")) { searchGrid.Rows[count - 1].Cells[6].Style.BackColor = Color.LightGreen; }
                    else if (_STATUS.Equals("Cancled")) { searchGrid.Rows[count - 1].Cells[6].Style.BackColor = Color.Red; }
                    else if (_STATUS.Equals("#Error")) { searchGrid.Rows[count - 1].Cells[6].Style.BackColor = Color.OrangeRed; }

                }
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
        private void SearchCustomer(String Customer)
        {
            try
            {
                searchGrid.Rows.Clear();
                int count = 0;
                DBConnection.Open();
                String query = "select * from Sales where customer LIKE @needle + '%' order by Rno desc;";
                OleDbParameter[] pars = new OleDbParameter[] { new OleDbParameter() { Value = Customer } };
                OleDbDataReader reader = DBConnection._Read(query, pars);
                while (reader.Read())
                {
                    count++;
                    String _STATUS = "#Error";
                    if (reader[5].ToString() == "0")
                    {
                        _STATUS = "Draft";
                    }
                    else if (reader[5].ToString() == "1")
                    {
                        _STATUS = "Paid";
                    }
                    else if (reader[5].ToString() == "2")
                    {
                        _STATUS = "Cancled";
                    }
                    searchGrid.Rows.Add(count, (int)reader[0], reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), _STATUS);
                    searchGrid.Rows[count - 1].Cells[4].Style.BackColor = Color.LightGreen;
                    if (_STATUS.Equals("Draft")) { searchGrid.Rows[count - 1].Cells[6].Style.BackColor = Color.YellowGreen; }
                    else if (_STATUS.Equals("Paid")) { searchGrid.Rows[count - 1].Cells[6].Style.BackColor = Color.LightGreen; }
                    else if (_STATUS.Equals("Cancled")) { searchGrid.Rows[count - 1].Cells[6].Style.BackColor = Color.Red; }
                    else if (_STATUS.Equals("#Error")) { searchGrid.Rows[count - 1].Cells[6].Style.BackColor = Color.OrangeRed; }
                }
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
        private void SearchDate(String d1,String d2)
        {
            try
            {
                searchGrid.Rows.Clear();
                int count = 0;
                DBConnection.Open();
                String query = "select * from Sales where lastdate between @d1 and @d2 order by Rno desc;";
                OleDbParameter[] pars = new OleDbParameter[] { new OleDbParameter() { Value = d1 }, new OleDbParameter() { Value = d2 } };
                OleDbDataReader reader = DBConnection._Read(query, pars);
                while (reader.Read())
                {
                    count++;
                    String _STATUS = "#Error";
                    if (reader[5].ToString() == "0")
                    {
                        _STATUS = "Draft";
                    }
                    else if (reader[5].ToString() == "1")
                    {
                        _STATUS = "Paid";
                    }
                    else if (reader[5].ToString() == "2")
                    {
                        _STATUS = "Cancled";
                    }
                    searchGrid.Rows.Add(count, (int)reader[0], reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), _STATUS);
                    searchGrid.Rows[count - 1].Cells[5].Style.BackColor = Color.LightGreen;
                    if (_STATUS.Equals("Draft")) { searchGrid.Rows[count - 1].Cells[6].Style.BackColor = Color.YellowGreen; }
                    else if (_STATUS.Equals("Paid")) { searchGrid.Rows[count - 1].Cells[6].Style.BackColor = Color.LightGreen; }
                    else if (_STATUS.Equals("Cancled")) { searchGrid.Rows[count - 1].Cells[6].Style.BackColor = Color.Red; }
                    else if (_STATUS.Equals("#Error")) { searchGrid.Rows[count - 1].Cells[6].Style.BackColor = Color.OrangeRed; }
                }
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
        private void inA_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                if (_select.SelectedIndex == 0)
                {
                    SearchReceiptNo(inA.Text.Trim());
                }
                else if (_select.SelectedIndex == 1)
                {
                    SearchCustomer(inA.Text.Trim());
                }
            }
        }
        private void searchGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    NewSales nSales = new NewSales();
                    nSales.Text = "Edit Sales";
                    nSales._TOKEN = searchGrid[2, e.RowIndex].Value.ToString();
                    nSales._ISNEW = false;
                    nSales.MdiParent = MainForm.mForm;
                    nSales.Show();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
