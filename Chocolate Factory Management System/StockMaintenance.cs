﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Chocolate_Factory_Management_System
{
    public partial class StockMaintenance : Form
    {

        private OleDbConnection connection = new OleDbConnection();
        OleDbCommand command;
        public StockMaintenance()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\hp\source\Access\ChocolateFactory17.accdb;Persist Security Info=False;";

        }
        double inward, outward, netstock;
        private void buttonSerach_Click(object sender, EventArgs e)
        {
            connection.Open();
            OleDbCommand c1 = new OleDbCommand("select ProductID,SDate,StockInward,StockOutward,NetStock from ProductStock where StockNo=@parm1", connection);
            c1.Parameters.AddWithValue("@parm1", textBoxSearch.Text);
            OleDbDataReader reader1;
            reader1 = c1.ExecuteReader();
            if (reader1.Read())
            {
                textBoxProductID.Text = reader1["ProductID"].ToString();
                dateTimePickerDate.Text = reader1["SDate"].ToString();
                textBoxStockInward.Text = reader1["StockInward"].ToString();
                textBoxStockOutward.Text = reader1["StockOutward"].ToString();
                textBoxNetStock.Text = reader1["NetStock"].ToString();
                MessageBox.Show("Data Found");
            }
            else
            {
                MessageBox.Show("Data Not Found");
            }
            connection.Close();
        }

        private void aDDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void eDITToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void dELETEToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void cLEARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxNetStock.Clear();
            textBoxProductID.Clear();
            textBoxSearch.Clear();
            textBoxStockInward.Clear();
            textBoxStockOutward.Clear();
            MessageBox.Show("Data Cleared");
        }

        private void buttonADD_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                command = new OleDbCommand("insert into ProductStock(ProductID,SDate,StockInward,StockOutward,NetStock) " +
                    "values(@prodid,@dob,@inward,@outward,@net)", connection);
                command.Parameters.AddWithValue("@prodid", textBoxProductID.Text);
                command.Parameters.AddWithValue("@dob", dateTimePickerDate.Text);
                command.Parameters.AddWithValue("@inward", textBoxStockInward.Text);
                command.Parameters.AddWithValue("@outward", textBoxStockOutward.Text);
                command.Parameters.AddWithValue("@net", textBoxNetStock.Text);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Data Saved Successfully");
            }
            catch 
            {
                MessageBox.Show("Data Not Saved".ToString());
            }
        }

        private void buttonEDIT_Click(object sender, EventArgs e)
        {
            try
            {

                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "update ProductStock set ProductID='" + textBoxProductID.Text + "',SDate='" + dateTimePickerDate.Text + "',StockInward='" + textBoxStockInward.Text + "'," +
                    "StockOutward='" + textBoxStockOutward.Text + "',NetStock='" + textBoxNetStock.Text + "' where StockNo=" + textBoxSearch.Text + "";
                MessageBox.Show(query);
                command.CommandText = query;

                command.ExecuteNonQuery();
                MessageBox.Show("Data Updated Successfully");
            }
            catch 
            {
                MessageBox.Show("Data Not Updated");
            }
            connection.Close();
        }

        private void buttonDELETE_Click(object sender, EventArgs e)
        {
            try
            {

                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "delete from ProductStock where StockNo=" + textBoxSearch.Text + "";
                //MessageBox.Show(query);
                command.CommandText = query;
                command.ExecuteNonQuery();
                MessageBox.Show("Data Deleted Successfully");
            }
            catch 
            {
                MessageBox.Show("Data Not Deleted");
            }
            connection.Close();
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();

        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            inward = int.Parse(textBoxStockInward.Text);
            outward = int.Parse(textBoxStockOutward.Text);
          

            if (inward >= 0 && outward >= 0)
            {
                netstock= inward -outward;
                textBoxNetStock.Text = netstock.ToString();
                MessageBox.Show("Net Stock:"+netstock.ToString());
            }
            else
            {
                MessageBox.Show("Enter a valid input");
            }
        }
    }
}
