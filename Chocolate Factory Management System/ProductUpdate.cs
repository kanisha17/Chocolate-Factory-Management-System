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
using System.IO;

namespace Chocolate_Factory_Management_System
{
    public partial class ProductUpdate : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        OleDbCommand command;
        public ProductUpdate()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\hp\source\Access\ChocolateFactory17.accdb;Persist Security Info=False;";

        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void pictureBoxProductDetail_Click(object sender, EventArgs e)
        {

            OpenFileDialog open = new OpenFileDialog();
            PictureBox p = sender as PictureBox;
            if (p != null)
            {
                open.Filter = "(*.jpg;*.jpeg,*.png) | *.jpg;*.jpeg,*.png";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    p.Image = Image.FromFile(open.FileName);
                }
            }
        }
        void resetControls()
        {
            textBoxDiscount.Clear();
            comboBoxreview.ResetText();
            comboBoxProductName.ResetText();
            textBoxPrice.Clear();
            textBoxDescription.Clear();
        }
        private void ProductUpdate_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "select *from ProductDetails";
                command.CommandText = query;
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    comboBoxProductName.Items.Add(reader["ProductName"].ToString());
                }
                connection.Close();
            }
            catch
            {
                MessageBox.Show("Error");
            }
           
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "update ProductDetails set ProductName='" + comboBoxProductName.Text + "',Description='" + textBoxDescription.Text + "'," +
                    "Price='" + textBoxPrice.Text + "',Review='" + comboBoxreview.Text + "' where ProductID=" + textBoxProductID.Text + "";
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

        private void textBoxProductID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                command = new OleDbCommand("select *from ProductDetails where ProductID=@param", connection);
                command.Parameters.AddWithValue("@param", int.Parse(textBoxProductID.Text));
                OleDbDataReader rd = command.ExecuteReader();
                while (rd.Read())
                {
                    comboBoxProductName.Text = rd.GetValue(1).ToString();
                    textBoxDescription.Text = rd.GetValue(2).ToString();
                    textBoxPrice.Text = rd.GetValue(3).ToString();
                    textBoxDiscount.Text = rd.GetValue(4).ToString();
                    comboBoxreview.Text = rd.GetValue(5).ToString();

                    string path = Path.Combine(rd.GetValue(6).ToString());
                    pictureBoxProductDetail.Image = Image.FromFile(path);
                    MessageBox.Show("Raw Material Details Found");
                }
                connection.Close();
                // MessageBox.Show("Product Details Found");
            }
            catch
            {
                MessageBox.Show("Raw Material Details Not Found");
            }
        }
    }

        
    }



