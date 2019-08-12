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
    public partial class AddCustomTextInBill : Form
    {
        public AddCustomTextInBill()
        {
            InitializeComponent();
        }

        private void LoadInfo() 
        {
            try
            {
                DBConnection.Open();
                String query = "select * from CText where ID = 1";
                OleDbDataReader reader = DBConnection._Read(query);
                reader.Read();
                if (reader.HasRows)
                {
                    header_.Text = reader[1].ToString();
                    footer_.Text = reader[2].ToString();
                }
                reader.Close();
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
        private void _Save_Click(object sender, EventArgs e)
        {
            try
            {
                String Header = header_.Text.Trim();
                String Footer = footer_.Text.Trim();
                DBConnection.Open();
                String query = "update CText set header =?, footer =? where ID =1";
                OleDbParameter[] parsLists = new OleDbParameter[] { new OleDbParameter() { Value = Header }, new OleDbParameter() { Value = Footer } };
                DBConnection._Write(query, parsLists);
                MessageBox.Show("New Header Footer Defined In Bill", "Info", MessageBoxButtons.OK);
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

        private void AddCustomTextInBill_Load(object sender, EventArgs e)
        {
            LoadInfo();
        }
    }
}
