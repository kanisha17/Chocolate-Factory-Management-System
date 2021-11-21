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
    public partial class CustomerSearch : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        //  OleDbCommand command;
        public CustomerSearch()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\hp\source\Access\ChocolateFactory17.accdb;Persist Security Info=False;";

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {

        }

        void resetControls()
        {

            textBoxPhoneNo.Clear();
        }
        private void labelRegister_Click(object sender, EventArgs e)
        {

        }

        private void linkLabelNewRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CustomerRegister c1 = new CustomerRegister();
            c1.ShowDialog();
        }

        private void placeAnOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBoxPhoneNo.Text.Length == 10)
            {
                try
                {
                    connection.Open();
                    OleDbCommand p1 = new OleDbCommand("select PhoneNo from Customer where PhoneNo=@parm1", connection);
                    p1.Parameters.AddWithValue("@parm1", textBoxPhoneNo.Text);
                    OleDbDataReader reader1;
                    reader1 = p1.ExecuteReader();
                    if (reader1.Read())
                    {
                        textBoxPhoneNo.Text = reader1["PhoneNo"].ToString();
                        

                        SalesOrder s1 = new SalesOrder(textBoxPhoneNo.Text);
                        s1.ShowDialog();

                    }
                    else
                    {
                        MessageBox.Show("Please Register And Continue");
                    }
                    connection.Close();

                    resetControls();
                }
                catch
                {
                    MessageBox.Show("Please Fill The Details");
                }
            }
            else {
                MessageBox.Show("Please Enter Only 10 Digit");
            }
        }

        private void enquiryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBoxPhoneNo.Text.Length == 10)
            {
                try
                {
                    connection.Open();
                    OleDbCommand e1 = new OleDbCommand("select PhoneNo from Customer where PhoneNo=@parm1", connection);
                    e1.Parameters.AddWithValue("@parm1", textBoxPhoneNo.Text);
                    OleDbDataReader reader1;
                    reader1 = e1.ExecuteReader();
                    if (reader1.Read())
                    {

                        textBoxPhoneNo.Text = reader1["PhoneNo"].ToString();

                        Enquiry s1 = new Enquiry(textBoxPhoneNo.Text);

                        s1.ShowDialog();

                    }
                    else
                    {
                        MessageBox.Show("Please Register And Continue");
                    }
                    connection.Close();

                    resetControls();
                }
                catch
                {
                    MessageBox.Show("Please Fill The Details");
                }
            }
            else { MessageBox.Show("Please Enter Only 10 Digit"); }
        }

        private void feedbackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBoxPhoneNo.Text.Length == 10)
            {
                try
                {
                    connection.Open();
                    OleDbCommand f1 = new OleDbCommand("select PhoneNo from Customer where PhoneNo=@parm1", connection);
                    f1.Parameters.AddWithValue("@parm1", textBoxPhoneNo.Text);
                    OleDbDataReader reader1;
                    reader1 = f1.ExecuteReader();
                    if (reader1.Read())
                    {
                        textBoxPhoneNo.Text = reader1["PhoneNo"].ToString();
                     

                        CustomerFeedback s1 = new CustomerFeedback(textBoxPhoneNo.Text);
                        s1.ShowDialog();

                    }
                    else
                    {
                        MessageBox.Show("Please Register And Continue");
                    }
                    connection.Close();

                    resetControls();
                }
                catch
                {
                    MessageBox.Show("Please Fill The Details");
                }
            }
            else { MessageBox.Show("Please Enter Only 10 Digit"); }
        }

        private void complaintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBoxPhoneNo.Text.Length == 10)
            {
                try
                {
                    connection.Open();
                    OleDbCommand c1 = new OleDbCommand("select PhoneNo from Customer where PhoneNo=@parm1", connection);
                    c1.Parameters.AddWithValue("@parm1", textBoxPhoneNo.Text);
                    OleDbDataReader reader1;
                    reader1 = c1.ExecuteReader();
                    if (reader1.Read())
                    {
                        textBoxPhoneNo.Text = reader1["PhoneNo"].ToString();


                        CustomerComplaints s1 = new CustomerComplaints(textBoxPhoneNo.Text);
                        s1.ShowDialog();

                    }
                    else
                    {
                        MessageBox.Show("Please Register And Continue");
                    }
                    connection.Close();

                    resetControls();
                }
                catch
                {
                    MessageBox.Show("Please Fill The Details");
                }
            }
            else { MessageBox.Show("Please Enter Only 10 Digit"); }
        }

        private void deliveryProcessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBoxPhoneNo.Text.Length == 10)
            {
                try
                {
                    connection.Open();
                    OleDbCommand c1 = new OleDbCommand("select PhoneNo from Customer where PhoneNo=@parm1", connection);
                    c1.Parameters.AddWithValue("@parm1", textBoxPhoneNo.Text);
                    OleDbDataReader reader1;
                    reader1 = c1.ExecuteReader();
                    if (reader1.Read())
                    {
                        textBoxPhoneNo.Text = reader1["PhoneNo"].ToString();


                        DeliveryProcess s1 = new DeliveryProcess(textBoxPhoneNo.Text);
                        s1.ShowDialog();

                    }
                    else
                    {
                        MessageBox.Show("Please Register And Continue");
                    }
                    connection.Close();

                    resetControls();
                }
                catch
                {
                    MessageBox.Show("Please Fill The Details");
                }
            }
            else
            {
                MessageBox.Show("Please Enter Only 10 Digit");
            }
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

       
