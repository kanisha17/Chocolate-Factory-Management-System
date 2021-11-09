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
    public partial class CustomerRegister : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        OleDbCommand command;
        public CustomerRegister()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\hp\source\Access\ChocolateFactory17.accdb;Persist Security Info=False;";

        }

        private void CustomerRegister_Load(object sender, EventArgs e)
        {

        }
      
        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            connection.Open();
            OleDbCommand c1 = new OleDbCommand("select CustomerID,CustomerName,DOB,Address,City,Pincode,PhoneNo,Email from Customer where PhoneNo=@parm1", connection);
            c1.Parameters.AddWithValue("@parm1", textBoxSearch.Text);
            OleDbDataReader reader1;
            reader1 = c1.ExecuteReader();
            if (reader1.Read())
            {
                textBoxCID.Text = reader1["CustomerID"].ToString();
                textBoxCustomerName.Text = reader1["CustomerName"].ToString();
                dateTimePickercDOB.Text = reader1["DOB"].ToString();
                textBoxcAddress.Text = reader1["Address"].ToString();
                textBoxcCity.Text = reader1["City"].ToString();
              
                textBoxcPincode.Text = reader1["Pincode"].ToString();
                textBoxcPhone.Text = reader1["PhoneNo"].ToString();
                textBoxcEmail.Text = reader1["Email"].ToString();
                MessageBox.Show("Data Found");
            }
            else
            {
                MessageBox.Show("Data Not Found");
            }
            connection.Close();
        }

      
       

        private void aDDToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
        }

        private void eDITToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }



        private void pRINTToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            textBoxCID.Clear();
            textBoxcAddress.Clear();
            textBoxcCity.Clear();
            textBoxcEmail.Clear();
            textBoxcPhone.Clear();
            textBoxcPincode.Clear();
            textBoxCustomerName.Clear();
            textBoxSearch.Clear();
            MessageBox.Show("Data Cleared");
        }

      

        private void eXITToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void dELETEToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void mENUToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void oRDERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesOrder c1 = new SalesOrder();
            c1.ShowDialog();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

            try
            {
                connection.Open();
                command = new OleDbCommand("insert into Customer(CustomerName,DOB,Address,City,Pincode,PhoneNo,Email) values(@customername,@dob,@address,@city,@pincode,@phone,@email)", connection);

                command.Parameters.AddWithValue("@customername", textBoxCustomerName.Text);
                command.Parameters.AddWithValue("@dob", dateTimePickercDOB.Text);
                command.Parameters.AddWithValue("@address", textBoxcAddress.Text);
                command.Parameters.AddWithValue("@city", textBoxcCity.Text);

                command.Parameters.AddWithValue("@pincode", textBoxcPincode.Text);
                command.Parameters.AddWithValue("@phone", textBoxcPhone.Text);
                command.Parameters.AddWithValue("@email", textBoxcEmail.Text);

                command.ExecuteNonQuery();

                connection.Close();
                MessageBox.Show("Data Saved Successfully");
            }
            catch
            {
                MessageBox.Show("Data Not Saved".ToString());
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = connection.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "update Customer set CustomerName='" + textBoxCustomerName.Text + "',DOB='" + dateTimePickercDOB.Value.Date + "'," +
                        "Address='" + textBoxcAddress.Text + "',City='" + textBoxcCity.Text + "',Pincode='" + textBoxcPincode.Text + "'," +
                        "PhoneNo='" + textBoxcPhone.Text + "',Email='" + textBoxcEmail.Text + "' where PhoneNo=" + textBoxSearch.Text + "";
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Data Updated Successfully");
            }
            catch 
            {
                MessageBox.Show("Data Not Updated");
            }

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

        }
    }
    }
