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
using E2NEngineFactory;
namespace Sales_Management
{
    public partial class NewSales : Form
    {
        public String _TOKEN;
        private String _RECEIPTNO = "#ERROR";
        public Boolean _ISNEW = true;
        //Sales*******************************************//
        public enum SALES_MODE { SAVE, CANCEL, CHECKOUT };
        //End Sales***************************************//
        public NewSales()
        {
            InitializeComponent();
        } 
        private void NewSales_Load(object sender, EventArgs e)
        {
            LoadTitleData();
            if (_ISNEW)
            {
                AddDefaultRows();
                GenerateToken();
                GetLastServiceCharge();
                this.ActiveControl = title;
            }
            else
            {
                GetOldDataUsingToken();
                this.ActiveControl = title;
            }
        }
        #region "Custom TBox Edit"
        int _currRIndex = -1;//DEFAULT
        private void billgrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            _currRIndex = -1;
        }
        private void billgrid_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            _currRIndex = e.RowIndex;
        }
        private void billgrid_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            try
            {
                var txtBox = e.Control as TextBox;
                if (txtBox != null && txtBox is TextBox)
                {
                    txtBox.TextChanged -= txtBox_TextChanged;
                    txtBox.TextChanged += txtBox_TextChanged;
                    
                    txtBox.AutoCompleteMode = AutoCompleteMode.Suggest;
                    txtBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    AutoCompleteStringCollection dataCollection = new AutoCompleteStringCollection();
                    LoadProductData(txtBox.Text.Trim(), dataCollection);
                    txtBox.AutoCompleteCustomSource = dataCollection;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void txtBox_TextChanged(object sender, EventArgs e)
        {
            if (billgrid.CurrentCell.ColumnIndex == 2)
            {
                FindProduct(((TextBox)sender).Text.Trim(),_currRIndex);
                CalculateGrandTotal();
            }
            else if (billgrid.CurrentCell.ColumnIndex == 3)
            {
                CalculateQR(((TextBox)sender).Text.Trim());
                CalculateGrandTotal();
            }
        }
        private void FindProduct(String data,int rowindex)
        {
            try
            {
                if (_currRIndex == -1) { return; }
                DBConnection.Open();
                String query = "select rate,ID from Product where name = @needle order by ID desc;";
                OleDbParameter[] pars = new OleDbParameter[] { new OleDbParameter() { Value = data } };
                OleDbDataReader reader = DBConnection._Read(query, pars);
                reader.Read();
                if (reader.HasRows)
                {
                    Decimal rate = Decimal.Parse(reader[0].ToString());
                    //Rate
                    try { billgrid[4, rowindex].Value = rate; }
                    catch (Exception ex) { billgrid[4, rowindex].Value = 0; Console.WriteLine(ex.Message); }
                    //Total
                    try { billgrid[5, rowindex].Value = rate * Convert.ToInt16(billgrid[3, rowindex].Value); }
                    catch (Exception ex) { billgrid[5, rowindex].Value = 0; Console.WriteLine(ex.Message); }
                    //ID SET
                    try { billgrid[6, rowindex].Value = reader[1].ToString(); } catch (Exception ex) { Console.WriteLine(ex.ToString()); }
                }
                else
                {
                    billgrid[4, rowindex].Value = "";
                    billgrid[5, rowindex].Value = "";
                    billgrid[6, rowindex].Value = "";
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
        #endregion
        private void AddDefaultRows()
        {
            billgrid.Rows.Clear();
            for (int i = 0; i < 10; i++)
            {
                billgrid.Rows.Add(Sales_Management.Properties.Resources.delete, i + 1, "", "1", "","");
            }
        }
        private void GetLastServiceCharge()
        {
            try
            {
                DBConnection.Open();
                OleDbDataReader reader = DBConnection._Read("select scharge from sChargeSetting where ID = (select MAX(ID) from sChargeSetting)");
                reader.Read();
                if (reader.HasRows)
                {
                    sCharge.Value = Decimal.Parse(reader[0].ToString());
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
        private void GenerateToken()
        {
            try
            {
                Random rand = new Random();
                int r= rand.Next(111111, 99999999);
                _TOKEN = DateTime.Now.Year + "_" + DateTime.Now.Month + "_" + DateTime.Now.Day + "_" + DateTime.Now.Hour + "_" + DateTime.Now.Minute + "_" + DateTime.Now.Millisecond + "_" + r.ToString();
                DBConnection.Open();
                String query = "insert into `Sales` (`token`,`ttc`,`customer`,`lastdate`,`status`,`stotal`,`servicecharge`,`discount`,`grandtotal`,`pAmt`,`rAmt`) values (?,?,?,?,?,?,?,?,?,?,?)";
                OleDbParameter[] parsLists = new OleDbParameter[]{
                        new OleDbParameter { Value = _TOKEN},
                        new OleDbParameter { Value = ""},
                        new OleDbParameter { Value = "" },
                        new OleDbParameter { Value = dateTimepick.Value.ToString()},
                        new OleDbParameter { Value = 0},
                        new OleDbParameter { Value = ""},
                        new OleDbParameter { Value = ""},
                        new OleDbParameter { Value = ""},
                        new OleDbParameter { Value = ""},
                        new OleDbParameter { Value = ""},
                        new OleDbParameter { Value = ""}
                    };
                DBConnection._Write(query, parsLists);

                ///SELECT THE RECEIPT NOW
                query = "select Rno from Sales where token=?";
                OleDbParameter[] pars = new OleDbParameter[] { new OleDbParameter() { Value = _TOKEN } };
                OleDbDataReader reader = DBConnection._Read(query, pars);
                reader.Read();
                if (reader.HasRows)
                {
                    _RECEIPTNO = reader[0].ToString();
                }
                reader.Close();
                //--------RECEIPT NO-------------------------
                receipt.Text = _RECEIPTNO;
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
        public void GetOldDataUsingToken()
        {
            bool isExists = false;
            try
            {
                DBConnection.Open();
                String query = "select * from `Sales` where `token`='"  + _TOKEN + "'";
                OleDbDataReader reader = DBConnection._Read(query);
                reader.Read();
                if (reader.HasRows)
                {
                    isExists = true;
                    _RECEIPTNO = reader[0].ToString();
                    receipt.Text = reader[0].ToString();
                    dateTimepick.Value = DateTime.Parse(reader[4].ToString());
                    title.Text = reader[2].ToString();
                    customer.Text = reader[3].ToString();

                    if(reader[5].ToString() == "2"){
                        _status.Text ="Cancled";
                    }
                    else if(reader[5].ToString() == "0"){
                        _status.Text ="Draft";
                    }
                    else if(reader[5].ToString() == "1"){
                        _status.Text ="Paid";
                    }
                    try { subTotal.Text = reader[6].ToString(); }catch (Exception ex) { Console.WriteLine(ex.ToString()); }
                    try { sCharge.Value = Decimal.Parse(reader[7].ToString()); }catch (Exception ex) { Console.WriteLine(ex.ToString());}
                    try { discount.Value = Decimal.Parse(reader[8].ToString());}catch (Exception ex) { Console.WriteLine(ex.ToString());}
                    try { GrandTotal.Text = "Grand Total: Rs. " + Decimal.Parse(reader[9].ToString()) +  "/-";}catch (Exception ex) { Console.WriteLine(ex.ToString());}
                    try { pAmtTemp.Text = reader[10].ToString();}catch (Exception ex) { Console.WriteLine(ex.ToString());}
                    try { rAmt.Text = reader[11].ToString(); }
                    catch (Exception ex) { Console.WriteLine(ex.ToString()); }
                }
                reader.Close();
                //--------------------------------------------------------------------------------------->
                if (isExists)
                {
                    int i=0;
                    billgrid.Rows.Clear();
                    String query2 = "select * from `SalesLists` where `token`='" + _TOKEN + "'";
                    OleDbDataReader reader2 = DBConnection._Read(query2);
                    while (reader2.Read())
                    {
                        i++;
                        Decimal A = Convert.ToDecimal(reader2[3]);
                        Decimal B = Convert.ToDecimal(reader2[4]);

                        billgrid.Rows.Add(Sales_Management.Properties.Resources.delete, i, reader2[2].ToString(), reader2[3].ToString(), reader2[4].ToString(),(A*B).ToString(),reader2[0].ToString());
                    }

                    for (int j = 0; j < (10 - i); j++)
                    {
                        billgrid.Rows.Add(Sales_Management.Properties.Resources.delete, (j+1), "", "1", "", "");
                    }
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
        private void LoadProductData(String needle,AutoCompleteStringCollection dataCollection)
        {
            #region "Select"
            try
            {
                DBConnection.Open();
                String query = "select name from Product where name like @needle +  '%' order by ID desc;";
                OleDbParameter[] pars = new OleDbParameter[]{ new OleDbParameter() { Value = needle }};
                OleDbDataReader reader = DBConnection._Read(query,pars);
                while (reader.Read())
                {
                    dataCollection.Add(reader[0].ToString());
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
        private void LoadTitleData()
        {
            title.AutoCompleteMode = AutoCompleteMode.Suggest;
            title.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection dataCollection = new AutoCompleteStringCollection();
            #region "Select"
            try
            {
                DBConnection.Open();
                String query = "select * from Sales";
                OleDbDataReader reader = DBConnection._Read(query);
                while (reader.Read())
                {
                    dataCollection.Add(reader[2].ToString());
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
            title.AutoCompleteCustomSource = dataCollection;
        }
        private void CalculateQR(String data)
        {
            try
            {
                if (billgrid[4, billgrid.CurrentCell.RowIndex].Value != null)
                {
                    //Calculate 
                    Decimal A = Convert.ToDecimal(data);
                    Decimal B = Convert.ToDecimal(billgrid[4, billgrid.CurrentCell.RowIndex].Value.ToString());
                    billgrid[5, billgrid.CurrentCell.RowIndex].Value = A * B;
                }
            }
            catch (Exception ex)
            {
                billgrid[5, billgrid.CurrentCell.RowIndex].Value = "N/A";
                Console.WriteLine(ex.ToString());
            }
        }
        private void billgrid_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            ReSerilizeNo();
        }
        private void billgrid_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            ReSerilizeNo();
        }
        private void ReSerilizeNo()
        {
            for (int i = 0; i < billgrid.Rows.Count; i++)
            {
                billgrid[1, i].Value = (i + 1).ToString();
            }
            CalculateGrandTotal();
        }
        private void billgrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 0 && e.RowIndex == -1)
                {
                    //Add Rows
                    billgrid.Rows.Add(Sales_Management.Properties.Resources.delete, "", "", "1", "");
                }
                else if (e.ColumnIndex == 0 && e.RowIndex >= 0)
                {
                    //Remove Rows
                    billgrid.Rows.RemoveAt(e.RowIndex);
                    if (billgrid.Rows.Count < 10)
                    {
                        billgrid.Rows.Add(Sales_Management.Properties.Resources.delete, "", "", "1", "");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        private void billgrid_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex == -1)
            {
                e.Graphics.Clear(Color.White);
                e.Graphics.DrawImage(
                    Sales_Management.Properties.Resources.add,new Rectangle(
                        e.CellBounds.X + 4,
                        e.CellBounds.X + 4,
                        e.CellBounds.Width - 8,
                        e.CellBounds.Height - 8)
                        );
                e.Handled = true;
            }
        }
        #region "Context Menu"
        private void addNewItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Add Rows
            billgrid.Rows.Add(Sales_Management.Properties.Resources.delete, "", "", "1", "");
        }
        private void removeSelectedItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Remove Rows
            billgrid.Rows.RemoveAt(billgrid.CurrentCell.RowIndex);
            if (billgrid.Rows.Count < 10)
            {
                billgrid.Rows.Add(Sales_Management.Properties.Resources.delete, "", "", "1", "");
            }
        }
        private void CalculateGrandTotal()
        {
            try
            {
                Decimal sTotal = 0.0m;
                Decimal gTotal = 0.0m;
                for (int i = 0; i < billgrid.Rows.Count; i++)
                {
                    try
                    {
                        //------------------------->
                        if (billgrid[5, i].Value != null && !billgrid[5, i].Value.ToString().Equals(""))
                        {
                            sTotal += Decimal.Parse(billgrid[5, i].Value.ToString());
                        }
                        else
                        {
                            sTotal += 0;
                        }                      
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                }
                //--------->
                subTotal.Text = "Rs. " + sTotal.ToString() + "/-";
                gTotal = (sTotal + ((sCharge.Value / 100) * sTotal));
                gTotal = Math.Round(gTotal - ((discount.Value / 100) * gTotal),2);
                GrandTotal.Text ="Grand Total: Rs. " + gTotal.ToString() + "/-";
                gTotalText.Text = gTotal.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion
        private void sCharge_ValueChanged(object sender, EventArgs e)
        {
            CalculateGrandTotal();
        }
        private void discount_ValueChanged(object sender, EventArgs e)
        {
            CalculateGrandTotal();
        }
        #region "SAVE"
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rearrangeData();//---------------REARRANGE
            SaveData(SALES_MODE.SAVE);
        }
        private void _Save_Click(object sender, EventArgs e)
        {
            rearrangeData();//---------------REARRANGE
            SaveData(SALES_MODE.SAVE);
        }
        #endregion
        #region "CHECK OUT"
        private void checkOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rearrangeData();//---------------REARRANGE
            SaveData(SALES_MODE.CHECKOUT);
        }
        private void _checkout_Click(object sender, EventArgs e)
        {
            rearrangeData();//---------------REARRANGE
            SaveData(SALES_MODE.CHECKOUT);
        }
        #endregion
        #region "Print Out"
        private void printReceiptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rearrangeData();//---------------REARRANGE
            PrintDocs(false);
        }
        private void _print_Click(object sender, EventArgs e)
        {
            rearrangeData();//---------------REARRANGE
            PrintDocs(false);
        }
        #endregion
        #region "Cancel Receipt"
        private void _cancel_Click(object sender, EventArgs e)
        {
            SaveData(SALES_MODE.CANCEL);
        }
        private void cancelReceiptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveData(SALES_MODE.CANCEL);
        }
        #endregion
        #region "PRINT"
        String BillHeader = "",BillFooter ="";
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
                    BillHeader = reader[1].ToString();
                    BillFooter = reader[2].ToString();
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
        private void PrintDocs(bool isPrint)
        {
            try
            {
                LoadInfo();
                ReportForm rForm = new ReportForm();
                ReportViewer rViewer = rForm.rViewerPanel;
                MainDataset mDataSet = new MainDataset();
                DataTable dtSalesLists = mDataSet.Tables[0];

                //First SalesLists
                for (int i = 0; i < billgrid.Rows.Count; i++)
                {
                    String _name,_quantity,_rate,_total;
                    if(billgrid[2,i].Value == null){ _name = ""; } else { _name  =  billgrid[2,i].Value.ToString();}
                    if(billgrid[3,i].Value == null){ _quantity = ""; } else { _quantity  =  billgrid[3,i].Value.ToString();}
                    if(billgrid[4,i].Value == null){ _rate = ""; } else { _rate  =  billgrid[4,i].Value.ToString();}
                    if(billgrid[5,i].Value == null){ _total = ""; } else { _total  =  billgrid[5,i].Value.ToString();}
                    if (!_total.Trim().Equals(""))
                    {
                        dtSalesLists.Rows.Add((i + 1).ToString(), _name, _quantity, _rate, _total);
                    }
                }
                ReportDataSource rds = new ReportDataSource("SalesLists", dtSalesLists);
                rViewer.LocalReport.DataSources.Clear();
                rViewer.LocalReport.DataSources.Add(rds);
                
                List<ReportParameter> rpLists = new List<ReportParameter>();
                rpLists.Add(new ReportParameter("rno",_RECEIPTNO));
                rpLists.Add(new ReportParameter("date", dateTimepick.Value.ToString()));
                rpLists.Add(new ReportParameter("title", title.Text.Trim()));

                String _CUSTOMER = "********"; if (!customer.Text.Trim().Equals("")) { _CUSTOMER = customer.Text.Trim(); }

                rpLists.Add(new ReportParameter("customer", _CUSTOMER));
                rpLists.Add(new ReportParameter("status", _status.Text.Trim()));
                rpLists.Add(new ReportParameter("subtotal", subTotal.Text.Trim()));
                rpLists.Add(new ReportParameter("servicecharge", sCharge.Value.ToString()));
                rpLists.Add(new ReportParameter("discount", discount.Value.ToString()));
                rpLists.Add(new ReportParameter("grandtotal", GrandTotal.Text.Trim()));
                rpLists.Add(new ReportParameter("pAmt", pAmtTemp.Text.Trim()));
                rpLists.Add(new ReportParameter("rAmt", rAmt.Text.Trim()));

                try { rpLists.Add(new ReportParameter("nts", new E2NEngine().InWords(gTotalText.Text.ToString())));}catch (Exception ex) { Console.WriteLine(ex.ToString()); }
                rpLists.Add(new ReportParameter("header_", BillHeader));
                rpLists.Add(new ReportParameter("footer_", BillFooter));

                rViewer.LocalReport.SetParameters(rpLists);
                System.Drawing.Printing.PageSettings pSetting = new System.Drawing.Printing.PageSettings();
                pSetting.Margins.Top = 0;
                pSetting.Margins.Bottom = 0;
                pSetting.Margins.Left = 0;
                pSetting.Margins.Right = 0;
                rViewer.SetPageSettings(pSetting);
                rViewer.ZoomMode = ZoomMode.FullPage;
                rViewer.RefreshReport();
                rForm.MdiParent = MainForm.mForm;
                rForm.Show();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #endregion
        #region "DATABASE MANIPULATIOn"
        //Main database methods
        private void SaveData(SALES_MODE sMode)
        {
            try
            {
                DBConnection.Open();
                if (sMode == SALES_MODE.SAVE) //Only Save To Draft => 0
                {
                    UpdateSales(0);
                }
                else if (sMode == SALES_MODE.CHECKOUT) //Only Save To Checkout Mode => 1
                {
                    UpdateSales(1);
                }
                else if (sMode == SALES_MODE.CANCEL) //Only Save To Cancle Data => 2
                {
                    if (MessageBox.Show("Are you sure want to cancel this receipt?", "Wait", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    {
                        UpdateSales(2);
                    }
                }
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
        private void UpdateSales(int status)
        {
            _updateStatus.Text = "Saving..";
            String _TITLE = title.Text.Trim();
            String _CUSTOMER = customer.Text.Trim();
            String _DATE = dateTimepick.Value.ToString();
            if (status != 2)
            {
                if (_TITLE.Equals("")) { MessageBox.Show("Please Insert Title / Table / Cabin", "Info"); _updateStatus.Text = "#Error fill form correctly.."; return; }
            }

            //UPDATE MAIN TABLE
            String query = "update Sales set ttc=?,customer=?,lastdate=?,status=?,stotal=?,servicecharge=?,discount=?,grandtotal=?,pAmt=?,rAmt=? where token=?";
            OleDbParameter[] pars = new OleDbParameter[]{
                        new OleDbParameter { Value = _TITLE},
                        new OleDbParameter { Value = _CUSTOMER},
                        new OleDbParameter { Value = _DATE},
                        new OleDbParameter { Value = status},
                        new OleDbParameter { Value = subTotal.Text.ToString()},
                        new OleDbParameter { Value = sCharge.Value.ToString()},
                        new OleDbParameter { Value = discount.Value.ToString()},
                        new OleDbParameter { Value = gTotalText.Text.ToString()},
                        new OleDbParameter { Value = pAmtTemp.Text.ToString()},
                        new OleDbParameter { Value = rAmt.Text.ToString()},
                        new OleDbParameter { Value = _TOKEN}
                    };
            DBConnection._Write(query, pars);
            //INSET INTO SALESLISTS
            InsertSalesLists();

            if (status ==0)
            {
                _status.Text = "DRAFT";
            }
            else if (status == 1)
            {
                _status.Text = "Paid";
                MessageBox.Show("Data Saved, bill will be out in a moment.", "Info", MessageBoxButtons.OK);
                PrintDocs(true);
            }
            else if (status == 2)
            {
                _status.Text = "CANCLED";
                this.Close();
            }
            _updateStatus.Text = "Last saved at " + DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString();
        }
        private void InsertSalesLists()
        {
            try
            {
                //FIRST DELETE THE SALES LISTS USING TOKEN THEN INSERT SALES LISTS INTO TABLE
                //DELETE
                String query = "delete from SalesLists where token=?";
                OleDbParameter[] pars = new OleDbParameter[]{
                        new OleDbParameter { Value = _TOKEN}
                    };
                DBConnection._Write(query, pars);
                //INSERT
                for (int i = 0; i < billgrid.Rows.Count; i++)
                {
                    if (billgrid[5, i].Value != null && !billgrid[5, i].Value.ToString().Equals(""))
                    {
                        String _NAME = "";
                        String _QUANTITY = "";
                        String _RATE = "";

                        if (billgrid[2, i].Value == null) { _NAME = ""; } else { _NAME = billgrid[2, i].Value.ToString().Trim(); }
                        if (billgrid[3, i].Value == null) { _QUANTITY = ""; } else { _QUANTITY = billgrid[3, i].Value.ToString().Trim(); }
                        if (billgrid[4, i].Value == null) { _RATE = ""; } else { _RATE = billgrid[4, i].Value.ToString().Trim(); }

                        String queryTemp = "insert into `SalesLists` (`token`,`name`,`quantity`,`rate`) values (?,?,?,?)";
                        OleDbParameter[] parsLists = new OleDbParameter[]{
                            new OleDbParameter { Value = _TOKEN},
                            new OleDbParameter { Value = _NAME},
                            new OleDbParameter { Value = _QUANTITY},
                            new OleDbParameter { Value = _RATE}
                            };
                        DBConnection._Write(queryTemp, parsLists);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #endregion
        private void rAmtTemp_TextChanged(object sender, EventArgs e)
        {
            try
            {
                rAmt.Text = (Decimal.Parse(pAmtTemp.Text.ToString()) - Decimal.Parse(gTotalText.Text.ToString())).ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void title_TextChanged(object sender, EventArgs e)
        {
            if (_ISNEW)
            {
                this.Text = "New Sales [" + title.Text  + "]";
            }
            else
            {
                this.Text = "Edit Sales [" + title.Text + "]";
            }
        }
        private void rearrangeData()
        {
            if (billgrid.Rows.Count <= 1)
            {
                return;
            }

            List<LBlock> lBlock = new List<LBlock>();
            for (int i = 0; i < billgrid.Rows.Count; i++)
            {
                //Check if id exists or not
                if (billgrid[6, i].Value != null && !billgrid[2, i].Value.ToString().Equals("")){
                    //2 => index start point of data
                    LBlock temp = new LBlock();
                    temp.BLists.Add(billgrid[2, i].Value.ToString().Trim());
                    temp.BLists.Add(billgrid[3, i].Value.ToString().Trim());
                    temp.BLists.Add(billgrid[4, i].Value.ToString().Trim());
                    temp.BLists.Add(billgrid[5, i].Value.ToString().Trim());
                    temp.BLists.Add(billgrid[6, i].Value.ToString().Trim());
                    lBlock.Add(temp);
                    displayLists(temp.BLists);
                }
            }
            List<int> passed = new List<int>();
            for (int i = 0; i < lBlock.Count; i++)
            {
                String ID = lBlock[i].BLists[4].ToString();
                for (int j = 0; j < lBlock.Count; j++)
                {
                    if (j != i)
                    {
                        if (!isDataExists(i.ToString(), passed)) //check rows exists or not
                        {
                            if (lBlock[j].BLists[4].ToString().Equals(ID))
                            {
                                passed.Add(i);
                                if (lBlock[i].BLists[1] != null && !lBlock[i].BLists[1].Equals("") && lBlock[j].BLists[1] != null && !lBlock[j].BLists[1].Equals(""))
                                {
                                    lBlock[i].BLists[1] = (Decimal.Parse(lBlock[i].BLists[1]) + Decimal.Parse(lBlock[j].BLists[1])).ToString();
                                    lBlock[i].BLists[3] = (Decimal.Parse(lBlock[i].BLists[1]) * Decimal.Parse(lBlock[j].BLists[2])).ToString();
                                    lBlock[j].BLists[0] = "";
                                    lBlock[j].BLists[1] = "";
                                    lBlock[j].BLists[2] = "";
                                    lBlock[j].BLists[3] = "";
                                    lBlock[j].BLists[4] = "";
                                }
                            }
                        }
                    }
                }
            }
            //----------------Now rearrange the whole lists---------------------->
            int counter = 0;
            int tLists = billgrid.Rows.Count;
            billgrid.Rows.Clear();
            for (int i = 0; i < lBlock.Count; i++)
            {
                Console.WriteLine("-->" + i);
                if (!lBlock[i].BLists[4].Equals(""))
                {
                    counter++;
                    billgrid.Rows.Add(Sales_Management.Properties.Resources.delete, (i + 1), lBlock[i].BLists[0], lBlock[i].BLists[1], lBlock[i].BLists[2], lBlock[i].BLists[3], lBlock[i].BLists[4]);
                }
            }
            for (int i = 0; i < tLists - counter; i++)
            {
                billgrid.Rows.Add(Sales_Management.Properties.Resources.delete, (i + 1), "", "1", "", "");
            }
        }
        private bool isDataExists(String val, List<int> data)
        {
            foreach (int d in data)
            {
                if (d.Equals(val))
                {
                    return true;
                }
            }
            return false;
        }
        private class LBlock
        {
            public List<String> BLists = new List<String>();
        }
        private void displayLists(List<String> data)
        {
            String t = "";
            foreach (string d in data)
            {
                t += d.ToString() + " ,";
            }
            Console.WriteLine(t + " <<ARRAY LIST DATA");
        }
    }
}