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
    public partial class MainForm : Form
    {
        public static MainForm mForm;
        public MainForm()
        {
            InitializeComponent();
        }
        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
             Product product = new Product();
             product.MdiParent = this;
             product.Show();
        }
        private void newTransactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewSales newSales = new NewSales();
            newSales.MdiParent = this;
            newSales.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            mForm = this;
            //-------------------------->
            LoadPBImage();
        }

        private void searchReceiptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchForm sForm = new SearchForm();
            sForm.MdiParent = this;
            sForm.Show();
        }

        private void totalSalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesReport sReport = new SalesReport();
            sReport.MdiParent = MainForm.mForm;
            sReport.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutBox().ShowDialog();
        }

        private void changeBackgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackgroundImageSetting bImgSetting = new BackgroundImageSetting();
            bImgSetting.MdiParent = this;
            bImgSetting.Show();
        }
        public void LoadPBImage()
        {
            String imgPath = "";
            ImageLayout iLayout = ImageLayout.None;
            int layoutVal = 0;
            try
            {
                DBConnection.Open();
                OleDbDataReader reader = DBConnection._Read("select * from BSetting where ID=1");
                reader.Read();
                if (reader.HasRows)
                {
                    layoutVal = Convert.ToInt16(reader["bValue"]);
                    imgPath = reader["path"].ToString();
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
            //----------->
            if (layoutVal == 0)
            {
                iLayout = ImageLayout.None;
            }
            else if (layoutVal == 1)
            {
                iLayout = ImageLayout.Center;
            }
            else if (layoutVal == 2)
            {
                iLayout = ImageLayout.Stretch;
            }
            else if (layoutVal == 3)
            {
                iLayout = ImageLayout.Tile;
            }
            else if (layoutVal == 4)
            {
                iLayout = ImageLayout.Zoom;
            }
            //-------------->
            if (!imgPath.Equals(""))
            {
                if (System.IO.File.Exists(imgPath))
                {
                    this.BackgroundImage = Image.FromFile(imgPath);
                    this.Refresh();
                    this.BackgroundImageLayout = iLayout;
                }
                else
                {
                    this.BackgroundImage = Sales_Management.Properties.Resources.unknown;
                    this.Refresh();
                    this.BackgroundImageLayout = ImageLayout.Center;
                }
            }
            else
            {
                this.BackgroundImage = Sales_Management.Properties.Resources.unknown;
                this.Refresh();
                this.BackgroundImageLayout = ImageLayout.Center;
            }
        }

        private void cascadeViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void databaseManipulationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new DatabaseManipulation().ShowDialog();
        }

        private void addNewServiceChargeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new NewServiceCharge().ShowDialog();
        }

        private void addCustomTextInBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AddCustomTextInBill().ShowDialog();
        }
    }
}
