﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BuyNSell
{
    public partial class User_Details : Form
    {
        public  static string  UID;
        

        public User_Details(String uid)
        {
            UID = uid;
            InitializeComponent();
            contentPanel.Controls.Add(MyProfile_UserControl.Instance);
            MyProfile_UserControl.Instance.Dock = DockStyle.Fill;
            MyProfile_UserControl.Instance.showDetails(UID);
            MyProfile_UserControl.Instance.BringToFront();

            MyProperties_UserControl.Instance.Dock = DockStyle.Fill;
            MyProperties_UserControl.Instance.refreshDataGridView(UID);

            Buy_UserControl.Instance.Dock = DockStyle.Fill;
            Buy_UserControl.Instance.refreshDataGridView(UID);

            Rent_UserControl.Instance.Dock = DockStyle.Fill;
            Rent_UserControl.Instance.refreshDataGridView(UID);

            MyBids_UserControl.Instance.Dock = DockStyle.Fill;
            MyBids_UserControl.Instance.refreshDataGridView(UID);

            Sold_UserControl.Instance.Dock = DockStyle.Fill;
            Sold_UserControl.Instance.refreshDataGridView(UID);

            Bought_UserControl.Instance.Dock = DockStyle.Fill;
            Bought_UserControl.Instance.refreshDataGridView(UID);

        }
        public void showDetails()
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if(!contentPanel.Controls.Contains(MyProfile_UserControl.Instance))
            {
                contentPanel.Controls.Add(MyProfile_UserControl.Instance);
                MyProfile_UserControl.Instance.Dock = DockStyle.Fill;
            }
            MyProfile_UserControl.Instance.showDetails(UID);
            MyProfile_UserControl.Instance.BringToFront();
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            contentPanel.Controls.Add(MyProperties_UserControl.Instance);
            MyProperties_UserControl.Instance.Dock = DockStyle.Fill;
            MyProperties_UserControl.Instance.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!contentPanel.Controls.Contains(MyBids_UserControl.Instance))
            {
                contentPanel.Controls.Add(MyBids_UserControl.Instance);
                MyBids_UserControl.Instance.Dock = DockStyle.Fill;
            }
            MyBids_UserControl.Instance.BringToFront();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (!contentPanel.Controls.Contains(Buy_UserControl.Instance))
            {
                contentPanel.Controls.Add(Buy_UserControl.Instance);
                Buy_UserControl.Instance.Dock = DockStyle.Fill;
            }
            Buy_UserControl.Instance.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!contentPanel.Controls.Contains(Rent_UserControl.Instance))
            {
                contentPanel.Controls.Add(Rent_UserControl.Instance);
                Rent_UserControl.Instance.Dock = DockStyle.Fill;
            }
            Rent_UserControl.Instance.BringToFront();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void logOut_Click(object sender, EventArgs e)
        {   
            UID = "";
            Login obj = new Login();
            obj.Show();
            this.Hide();
           
             
           
            //lets check it first?
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (!contentPanel.Controls.Contains(Bought_UserControl.Instance))
            {
                contentPanel.Controls.Add(Bought_UserControl.Instance);
                Bought_UserControl.Instance.Dock = DockStyle.Fill;
            }
            Bought_UserControl.Instance.BringToFront();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!contentPanel.Controls.Contains(Sold_UserControl.Instance))
            {
                contentPanel.Controls.Add(Sold_UserControl.Instance);
                Sold_UserControl.Instance.Dock = DockStyle.Fill;
            }
            Sold_UserControl.Instance.BringToFront();
        }
    }
}
