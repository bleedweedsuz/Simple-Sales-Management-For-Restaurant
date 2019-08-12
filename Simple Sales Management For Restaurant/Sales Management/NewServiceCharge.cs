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
    public partial class NewServiceCharge : Form
    {
        public NewServiceCharge()
        {
            InitializeComponent();
        }

        private void _save_Click(object sender, EventArgs e)
        {
            try
            {
                DBConnection.Open();
                DBConnection._Write("insert into sChargeSetting (scharge) values ('" + _val.Value + "')");
                MessageBox.Show("New Service Charge added", "Info");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                DBConnection.Close();
            }
        }

        private void NewServiceCharge_Load(object sender, EventArgs e)
        {
            try
            {
                DBConnection.Open();
                OleDbDataReader reader = DBConnection._Read("select scharge from sChargeSetting where ID = (select MAX(ID) from sChargeSetting)");
                reader.Read();
                if (reader.HasRows)
                {
                    _val.Value = Decimal.Parse(reader[0].ToString());
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                DBConnection.Close();
            }
        }
    }
}
