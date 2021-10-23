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
    public partial class CustomerFeedback : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        OleDbCommand command;
        public CustomerFeedback()
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

        private void cLEARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxPhoneNo.Clear();
            textBoxName.Clear();
            textBoxEmail.Clear();
            textBoxSearch.Clear();
            textBoxQ2.Clear();
            checkedListBoxQ1.ResetText();
            checkedListBoxReview.ResetText();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         try
            {
                connection.Open();
                command = new OleDbCommand("insert into CustomerFeedback(CustomerName,Email,PhoneNo,Review,Satisfied,Suggestion) values(@customername,@email,@phone,@review,@satisfied,@suggestion)", connection);

                command.Parameters.AddWithValue("@customername", textBoxName.Text);
                command.Parameters.AddWithValue("@email",textBoxEmail.Text);
                command.Parameters.AddWithValue("@phone", textBoxPhoneNo.Text);
                command.Parameters.AddWithValue("@review", textBoxQ2.Text);
                command.Parameters.AddWithValue("@satisfied", checkedListBoxQ1.Text);
                command.Parameters.AddWithValue("@suggestion", textBoxQ2.Text);

                command.ExecuteNonQuery();

                connection.Close();
                MessageBox.Show("Saved Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            connection.Open();
            OleDbCommand c1 = new OleDbCommand("select CustomerName,Email,PhoneNo from Customer where PhoneNo=@parm1", connection);
            c1.Parameters.AddWithValue("@parm1", textBoxSearch.Text);
            OleDbDataReader reader1;
            reader1 = c1.ExecuteReader();
            if (reader1.Read())
            {
                textBoxName.Text = reader1["CustomerName"].ToString();
                textBoxEmail.Text = reader1["Email"].ToString();
                textBoxPhoneNo.Text = reader1["PhoneNo"].ToString();

            }
            else
            {
                MessageBox.Show("No Data Found");
            }
            connection.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelPhoneNo_Click(object sender, EventArgs e)
        {

        }

        private void labelName_Click(object sender, EventArgs e)
        {

        }

        private void labelEmail_Click(object sender, EventArgs e)
        {

        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPhoneNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelDate_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePickerDate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
