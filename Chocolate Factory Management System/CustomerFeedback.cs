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
        public CustomerFeedback(string str_value)
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\hp\source\Access\ChocolateFactory17.accdb;Persist Security Info=False;";
            textBoxPhoneNo.Text = str_value;
        }



        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void cLEARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        void resetControls()
        {
            textBoxCID.Clear();
            textBoxPhoneNo.Clear();
            textBoxName.Clear();
            textBoxEmail.Clear();
            textBoxQ2.Clear();
            checkedListBoxQ1.ResetText();
            checkedListBoxReview.ResetText();
        }
        private void button1_Click(object sender, EventArgs e)
        {
         try
            {
                connection.Open();
                command = new OleDbCommand("insert into CustomerFeedback(CustomerID,CustomerName,Email,PhoneNo,ProductName,Review,Satisfied,Suggestion) values(@cid,@customername,@email,@phone,@productname,@review,@satisfied,@suggestion)", connection);


                command.Parameters.AddWithValue("@cid", textBoxCID.Text);
                command.Parameters.AddWithValue("@customername", textBoxName.Text);
                command.Parameters.AddWithValue("@email",textBoxEmail.Text);
                command.Parameters.AddWithValue("@phone", textBoxPhoneNo.Text);
                command.Parameters.AddWithValue("@productname",comboBoxProductName.Text);
                command.Parameters.AddWithValue("@review", textBoxQ2.Text);
                command.Parameters.AddWithValue("@satisfied", checkedListBoxQ1.Text);
                command.Parameters.AddWithValue("@suggestion", textBoxQ2.Text);

                command.ExecuteNonQuery();
                resetControls();
                connection.Close();
                MessageBox.Show("Data Saved Successfully");

                CustomerSearch c1 = new CustomerSearch();
                c1.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Data Not Saved".ToString());
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
           
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

        private void CustomerFeedback_Load(object sender, EventArgs e)
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

            try
            {
                connection.Open();
                OleDbCommand c1 = new OleDbCommand("select CustomerID,CustomerName,Email from Customer where PhoneNo=@param", connection);
                c1.Parameters.AddWithValue("@param", textBoxPhoneNo.Text);
                OleDbDataReader reader1;
                reader1 = c1.ExecuteReader();
                if (reader1.Read())
                {
                    textBoxCID.Text = reader1["CustomerID"].ToString();
                    textBoxName.Text = reader1["CustomerName"].ToString();
                    textBoxEmail.Text = reader1["Email"].ToString();

                }
                else
                {
                    MessageBox.Show("No Data Found");
                }
                connection.Close();
            }
            catch
            {

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

        private void textBoxCID_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 6 && e.KeyChar != (char)Keys.Space && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Space && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }
    }
}
