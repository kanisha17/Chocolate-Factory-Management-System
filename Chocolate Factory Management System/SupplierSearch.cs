using System;
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
    public partial class SupplierSearch : Form
    {
        private OleDbConnection connection = new OleDbConnection();
     //   OleDbCommand command;
        public SupplierSearch()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\hp\source\Access\ChocolateFactory17.accdb;Persist Security Info=False;";

        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            connection.Open();
            OleDbCommand c1 = new OleDbCommand("select PhoneNo from Supplier where PhoneNo=@parm1", connection);
            c1.Parameters.AddWithValue("@parm1", textBoxPhoneNo.Text);
            OleDbDataReader reader1;
            reader1 = c1.ExecuteReader();
            if (reader1.Read())
            {
                textBoxPhoneNo.Text = reader1["PhoneNo"].ToString();
                MessageBox.Show("Data Found");

                SupplierSearch s1 = new SupplierSearch(tex.Text);
                s1.ShowDialog();

            }
            else
            {
                MessageBox.Show("Data Not Found");
            }
            connection.Close();

            resetControls();
        }

        void resetControls()
        {
            textBoxPhoneNo.Clear();
            textBoxFullName.Clear();
        }

        private void linkLabelNotRegistered_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SupplierRegister s1 = new SupplierRegister();
            s1.ShowDialog();
        }
    }
}
