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
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
        }
        private void Save__Click(object sender, EventArgs e)
        {
            _SaveData();
        }
        private void _clear_Click(object sender, EventArgs e)
        {
            ClearField();
        }
        //RAW METHODS
        private void ClearField()
        {
            name.Clear(); name.BackColor = Color.White;
            rate.Value = 0;
            quantity.Value = 1;
            detail.Clear();
            id.Clear();
            sName.Clear();
            this.ActiveControl = name;
        }
        private void ProductGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (e.ColumnIndex == 5)
                {
                    String data = Utils.Prompt.ShowDialogPassword("Pin No. (12 Char Pin)", "Enter Pin No. For Edit!!", '*');
                    if (data == "#ilovenepal#")
                    {
                        id.Text = ProductGrid[0, e.RowIndex].Value.ToString();
                        name.Text = ProductGrid[1, e.RowIndex].Value.ToString();
                        rate.Text = ProductGrid[2, e.RowIndex].Value.ToString();
                        quantity.Text = ProductGrid[3, e.RowIndex].Value.ToString();
                        detail.Text = ProductGrid[4, e.RowIndex].Value.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Pin no. Does Not match!", "Error");
                    }
                }
                else if (e.ColumnIndex == 6)
                {
                    if (MessageBox.Show("Are you sure want to delete this info? [note* this will effect other entry]", "Wait", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            DBConnection.Open();
                            String query = "delete from `Product` where `ID`=" + ProductGrid[0, e.RowIndex].Value.ToString() + "";
                            DBConnection._Write(query);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.ToString());
                        }
                        finally
                        {
                            DBConnection.Close();
                        }
                        //Load Data
                        LoadProductList("");
                    }
                }
            }
        }
        private void LoadProductList(String needle)
        {
            #region "Select"
            try
            {
                ProductGrid.Rows.Clear();
                DBConnection.Open();
                String query = "select * from Product where name LIKE @needle + '%' order by ID desc;";
                OleDbParameter[] pars = new OleDbParameter[] { new OleDbParameter() { Value = needle } };
                OleDbDataReader reader = DBConnection._Read(query, pars);
                while (reader.Read())
                {
                    ProductGrid.Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4], "Edit", "Delete");
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
            #endregion
        }
        private void Product_Load(object sender, EventArgs e)
        {
            LoadProductList("");
            this.ActiveControl = name;
        }
        private Boolean isExists(String Data,int ID)
        {
            Boolean isExistsVal = false;
            if (ID == 0)
            {
                #region "Insert Mode"
                try
                {
                    DBConnection.Open();
                    String query = "select name from Product where name = @needle;";
                    OleDbParameter[] pars = new OleDbParameter[] { new OleDbParameter() { Value = Data } };
                    OleDbDataReader reader = DBConnection._Read(query, pars);
                    reader.Read();
                    if (reader.HasRows)
                    {
                        isExistsVal = true;
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
                #endregion
            }
            else
            {
                #region "Insert Mode"
                try
                {
                    DBConnection.Open();
                    String query = "select name from Product where name=@needle and ID<>@ID;";
                    OleDbParameter[] pars = new OleDbParameter[] { new OleDbParameter() { ParameterName ="needle", Value = Data }, new OleDbParameter() { ParameterName="ID", Value = ID .ToString()}};
                    OleDbDataReader reader = DBConnection._Read(query, pars);
                    reader.Read();
                    if (reader.HasRows)
                    {
                        isExistsVal = true;
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
                #endregion
            }
            Console.WriteLine(isExistsVal + "--->data");
            return isExistsVal;
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _SaveData();
        }
        private void _SaveData()
        {
            if (id.Text == "")
            {
                if (name.Text.ToString().Equals("")) { name.BackColor = Color.FromArgb(255, 255, 192, 192); return; }

                //Check before data exists
                if (isExists(name.Text.Trim(), 0)) { MessageBox.Show("This name is already in database, please select another one.", "Wait", MessageBoxButtons.OK); return; }
                #region "Insert"
                try
                {
                    DBConnection.Open();
                    String query = "insert into `Product` (`name`,`rate`,`quantity`,`detail`) values (?,?,?,?)";
                    OleDbParameter[] pars = new OleDbParameter[]{
                        new OleDbParameter { Value = name.Text.ToString()},
                        new OleDbParameter { DbType = System.Data.DbType.Currency, Value = rate.Text.ToString()},
                        new OleDbParameter { DbType = System.Data.DbType.Int16, Value = quantity.Text.ToString()},
                        new OleDbParameter { Value = detail.Text.ToString()},
                    };
                    DBConnection._Write(query, pars);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                finally
                {
                    DBConnection.Close();
                }
                #endregion
            }
            else
            {
                if (name.Text.ToString().Equals("")) { name.BackColor = Color.FromArgb(255, 255, 192, 192); return; }
                //Check before data exists except current one
                if (isExists(name.Text.Trim(), Convert.ToInt16(id.Text.ToString()))) { MessageBox.Show("This name is already in database, please select another one.", "Wait", MessageBoxButtons.OK); return; }
                #region "Update"
                try
                {
                    DBConnection.Open();
                    String query = "update `Product` set name=?, rate=?, quantity=?, detail=? where ID=?";
                    OleDbParameter[] pars = new OleDbParameter[]{
                        new OleDbParameter { Value = name.Text.ToString()},
                        new OleDbParameter { DbType = System.Data.DbType.Currency, Value = rate.Text.ToString()},
                        new OleDbParameter { DbType = System.Data.DbType.Int16, Value = quantity.Text.ToString()},
                        new OleDbParameter { Value = detail.Text.ToString()},
                        new OleDbParameter { Value = id.Text.ToString()},
                    };
                    DBConnection._Write(query, pars);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                finally
                {
                    DBConnection.Close();
                }
                #endregion
            }
            ClearField();
            LoadProductList("");
        }
        private void clearFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearField();
        }
        private void sName_TextChanged(object sender, EventArgs e)
        {
            LoadProductList(sName.Text.Trim());
        }
    }
}
