/*Copyright (C) Sujan Thapa - All Rights Reserved
Unauthorized copying of this file, via any medium is strictly prohibited
Proprietary and confidential
Written by Sujan Thapa <suz_47@outlook.com>, 2016
*/
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
    public partial class BackgroundImageSetting : Form
    {
        String imagePath = "";
        public BackgroundImageSetting()
        {
            InitializeComponent();
        }
        private void save__Click(object sender, EventArgs e)
        {
            bool isSaved = false;
            try
            {
                DBConnection.Open();
                DBConnection._Write("update `BSetting` set bValue=?,path=?", new System.Data.OleDb.OleDbParameter[]{
                    new OleDbParameter { Value = mode_.SelectedIndex.ToString()},
                    new OleDbParameter { Value = imgtextbox.Text.ToString().Trim()}
                });
                isSaved = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                DBConnection.Close();
            }
            if (isSaved)
            {
                MainForm.mForm.LoadPBImage();
            }
        }
        private void BackgroundImageSetting_Load(object sender, EventArgs e)
        {
            try
            {
                DBConnection.Open();
                OleDbDataReader reader = DBConnection._Read("select * from `BSetting` where ID=1");
                reader.Read();
                if (reader.HasRows)
                {
                    imagePath = reader["path"].ToString();
                    mode_.SelectedIndex = Convert.ToInt16(reader["bValue"].ToString());
                }
                reader.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                DBConnection.Close();
            }
            imgtextbox.Text = imagePath;
        }
        private void browse_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog oFileDialog = new OpenFileDialog();
            oFileDialog.Filter = "Image File|*.png;*.jpg;*.jpeg";
            oFileDialog.Title = "browse image file";
            if (oFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                imgtextbox.Text = oFileDialog.FileName;
            }
        }

        private void clr_btn_Click(object sender, EventArgs e)
        {
            imgtextbox.Clear();
        }
    }
}
