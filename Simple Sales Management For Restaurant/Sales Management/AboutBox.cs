/*Copyright (C) Sujan Thapa - All Rights Reserved
Unauthorized copying of this file, via any medium is strictly prohibited
Proprietary and confidential
Written by Sujan Thapa <suz_47@outlook.com>, 2016
*/

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
    public partial class AboutBox : Form
    {
        Boolean isScroll = false;
        int flux = 1;
        public AboutBox()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void tScrollerTimer_Tick(object sender, EventArgs e)
        {
            if (!isScroll)
            {
                int currentY = descriptionBox.Location.Y;
                if (currentY <= -234)
                {
                    descriptionBox.Location = new Point(descriptionBox.Location.X, 202);//81
                }
                descriptionBox.Location = new Point(descriptionBox.Location.X, (descriptionBox.Location.Y - flux));
            }
        }
        private void AboutBox_Load(object sender, EventArgs e)
        {
            tScrollerTimer.Start();
        }

        private void descriptionBox_MouseEnter(object sender, EventArgs e)
        {
            isScroll = true;
        }

        private void descriptionBox_MouseLeave(object sender, EventArgs e)
        {
            isScroll = false;
        }

        private void panel3_MouseEnter(object sender, EventArgs e)
        {
            isScroll = true;
        }

        private void panel3_MouseLeave(object sender, EventArgs e)
        {
            isScroll = false;
        }
    }
}
