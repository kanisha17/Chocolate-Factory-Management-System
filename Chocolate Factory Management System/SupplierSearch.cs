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
            if (textBoxPhoneNo.Text.Length == 10)
            {
                try
                {
                    connection.Open();
                    OleDbCommand e1 = new OleDbCommand("select PhoneNo from Supplier where PhoneNo=@parm1", connection);
                    e1.Parameters.AddWithValue("@parm1", textBoxPhoneNo.Text);
                    OleDbDataReader reader1;
                    reader1 = e1.ExecuteReader();
                    if (reader1.Read())
                    {

                        textBoxPhoneNo.Text = reader1["PhoneNo"].ToString();

                        PurchaseOrder s1 = new PurchaseOrder(textBoxPhoneNo.Text);

                        s1.ShowDialog();

                    }
                    else
                    {
                        MessageBox.Show("Data Not Found");
                    }
                    connection.Close();

                    resetControls();
                }
                catch
                {
                    MessageBox.Show("Please Fill The Details");
                }
            }
            else { MessageBox.Show("Please Enter Only 10 Digit PhoneNo"); }
           
        }

        void resetControls()
        {
            textBoxPhoneNo.Clear();
            
        }

        private void linkLabelNotRegistered_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SupplierRegister s1 = new SupplierRegister();
            s1.ShowDialog();
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void textBoxPhoneNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 10 && e.KeyChar != (char)Keys.Space && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
