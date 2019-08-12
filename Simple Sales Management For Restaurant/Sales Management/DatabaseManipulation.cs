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
    public partial class DatabaseManipulation : Form
    {
        public DatabaseManipulation()
        {
            InitializeComponent();
        }

        private void _Create_Click(object sender, EventArgs e)
        {
            try
            {
                if(MessageBox.Show("Are you sure want to re-set the session?","Warning!!!",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes){
                    String _up = "0/5";
                    DBConnection.Open();
                    {
                        //-------------------Product----------------------------------------------->
                        String A = "delete from Product;";
                        DBConnection._Write(A);

                        String B = "ALTER TABLE Product ALTER Column ID INT;";
                        DBConnection._Write(B);

                        String C = "ALTER TABLE Product ALTER Column ID AUTOINCREMENT;";
                        DBConnection._Write(C);
                        _up = "1/5 ..";
                        //-------------------------------------------------------------------------->
                    }
                    {
                        //-------------------Sales-------------------------------------------------->
                        String A = "delete from Sales;";
                        DBConnection._Write(A);

                        String B = "ALTER TABLE Sales ALTER Column Rno INT;";
                        DBConnection._Write(B);

                        String C = "ALTER TABLE Sales ALTER Column Rno AUTOINCREMENT;";
                        DBConnection._Write(C);
                        _up = "2/5 ..";
                        //-------------------------------------------------------------------------->
                    }
                    {
                        //-------------------SalesLists--------------------------------------------->
                        String A = "delete from SalesLists;";
                        DBConnection._Write(A);

                        String B = "ALTER TABLE SalesLists ALTER Column ID INT;";
                        DBConnection._Write(B);

                        String C = "ALTER TABLE SalesLists ALTER Column ID AUTOINCREMENT;";
                        DBConnection._Write(C);
                        _up = "3/5 ..";
                        //-------------------------------------------------------------------------->
                    }
                    {
                        //-------------------CTEXT--------------------------------------------->
                        String C = "UPDATE CText set header='',footer='' where ID = 1;";
                        DBConnection._Write(C);
                        _up = "4/5 ..";
                        //-------------------------------------------------------------------------->
                    }
                    {
                        //-------------------sChargingSetting--------------------------------------------->
                        String A = "delete from sChargeSetting;";
                        DBConnection._Write(A);
                        _up = "5/5 ..";
                        //-------------------------------------------------------------------------->
                    }
                    _status.Text = _up + " Database re-set.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                DBConnection.Close();
            }
        }
        private void DatabaseManipulation_Load(object sender, EventArgs e)
        {
            _location.Text = Application.StartupPath + "\\Sales.mdb";
        }
    }
}
