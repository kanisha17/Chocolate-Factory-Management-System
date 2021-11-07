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
    public partial class Enquiry : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        OleDbCommand command;
        public Enquiry()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\hp\source\Access\ChocolateFactory17.accdb;Persist Security Info=False;";
        }

        private void textBoxPhoneNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSUBMIT_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                command = new OleDbCommand("insert into Enquiry(FullName,CustomerID,Address,PhoneNo,Email,Product,EDate) " +
                    "values(@fullname,@cid,@address,@phoneno,@email,@product,@edate)", connection);
                command.Parameters.AddWithValue("@fullname", textBoxName.Text);
                command.Parameters.AddWithValue("@cid",textBoxCID.Text);
                command.Parameters.AddWithValue("@address", textBoxAddress.Text);
                command.Parameters.AddWithValue("@phoneno", textBoxPhoneNo.Text);
                command.Parameters.AddWithValue("@email", textBoxEmail.Text);
                command.Parameters.AddWithValue("@product", comboBoxProduct.Text);
                command.Parameters.AddWithValue("@edate", dateTimePickerDate.Text);  

                command.ExecuteNonQuery();

                connection.Close();
                MessageBox.Show("Saved Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cLEARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxCID.Clear();
            textBoxAddress.Clear();
            textBoxEmail.Clear();
            textBoxName.Clear();
            textBoxPhoneNo.Clear();
            comboBoxProduct.ResetText();
            textBoxsearch.Clear();
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void buttonSEARCH_Click(object sender, EventArgs e)
        {
            connection.Open();
            OleDbCommand c1 = new OleDbCommand("select CustomerID,CustomerName,Address,PhoneNo,Email from Customer where PhoneNo=@parm1", connection);
            c1.Parameters.AddWithValue("@parm1", textBoxsearch.Text);
            OleDbDataReader reader1;
            reader1 = c1.ExecuteReader();
            if (reader1.Read())
            {
                textBoxCID.Text = reader1["CustomerID"].ToString();
                textBoxName.Text = reader1["CustomerName"].ToString();
                textBoxAddress.Text = reader1["Address"].ToString();
                textBoxPhoneNo.Text = reader1["PhoneNo"].ToString();
                textBoxEmail.Text = reader1["Email"].ToString();

            }
            else
            {
                MessageBox.Show("No Data Found");
            }
            connection.Close();
        }

        private void textBoxSEARCH_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
