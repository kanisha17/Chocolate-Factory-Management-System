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
        public Enquiry(string str2)
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\hp\source\Access\ChocolateFactory17.accdb;Persist Security Info=False;";
           
            textBoxPhoneNo.Text = str2;
        }

        private void textBoxPhoneNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSUBMIT_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                command = new OleDbCommand("insert into Enquiry(FullName,Address,PhoneNo,Email,Product,EDate) " +
                    "values(@fullname,@address,@phoneno,@email,@product,@edate)", connection);
                command.Parameters.AddWithValue("@fullname", textBoxName.Text);
              //  command.Parameters.AddWithValue("@cid",textBoxCID.Text);
                command.Parameters.AddWithValue("@address", textBoxAddress.Text);
                command.Parameters.AddWithValue("@phoneno", textBoxPhoneNo.Text);
                command.Parameters.AddWithValue("@email", textBoxEmail.Text);
                command.Parameters.AddWithValue("@product", comboBoxProduct.Text);
                command.Parameters.AddWithValue("@edate", dateTimePickerDate.Text);  

                command.ExecuteNonQuery();

                connection.Close();
                
                resetControls();
                MessageBox.Show("Data Saved Sucessfully");

                EmployeeSearch e1 = new EmployeeSearch();
                e1.ShowDialog();
            }
            catch 
            {
                MessageBox.Show("Data Not Saved".ToString());
            }
        }
        void resetControls()
        {
            textBoxAddress.Clear();
            textBoxEmail.Clear();
            textBoxName.Clear();
            textBoxPhoneNo.Clear();
            comboBoxProduct.ResetText();
        }
        private void cLEARToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void buttonSEARCH_Click(object sender, EventArgs e)
        {
           
        }

        private void textBoxSEARCH_TextChanged(object sender, EventArgs e)
        {

        }

        private void Enquiry_Load(object sender, EventArgs e)
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
                    comboBoxProduct.Items.Add(reader["ProductName"].ToString());
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
                OleDbCommand c1 = new OleDbCommand("select CustomerID,CustomerName,Address,Email from Customer where PhoneNo=@param", connection);
                c1.Parameters.AddWithValue("@param", textBoxPhoneNo.Text);
                OleDbDataReader reader1;
                reader1 = c1.ExecuteReader();
                if (reader1.Read())
                {
                    textBoxCID.Text = reader1["CustomerID"].ToString();
                    textBoxName.Text = reader1["CustomerName"].ToString();
                    textBoxAddress.Text = reader1["Address"].ToString();
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

        private void comboBoxProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
