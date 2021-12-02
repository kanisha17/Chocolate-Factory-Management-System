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
            getCustomerID();
        }
      
        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            
        }

      
       

        private void aDDToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
        }

        private void eDITToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }



        private void pRINTToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
           
        }

      

        private void eXITToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            CustomerSearch f2 = new CustomerSearch();
            f2.ShowDialog();
           
        }

        private void dELETEToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void mENUToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void oRDERToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxcPhone.Text.Length == 10 && textBoxcPincode.Text.Length==6)
            {

                try
                {
                    connection.Open();
                    command = new OleDbCommand("insert into Customer(CustomerID,CustomerName,DOB,Address,City,Pincode,PhoneNo,Email) values(@customerID,@customername,@dob,@address,@city,@pincode,@phone,@email)", connection);
                    command.Parameters.AddWithValue("@customerID", textBoxCID.Text);
                    command.Parameters.AddWithValue("@customername", textBoxCustomerName.Text);
                    command.Parameters.AddWithValue("@dob", dateTimePickercDOB.Text);
                    command.Parameters.AddWithValue("@address", textBoxcAddress.Text);
                    command.Parameters.AddWithValue("@city", textBoxcCity.Text);
                    command.Parameters.AddWithValue("@pincode", textBoxcPincode.Text);
                    command.Parameters.AddWithValue("@phone", textBoxcPhone.Text);
                    command.Parameters.AddWithValue("@email", textBoxcEmail.Text);
                    command.ExecuteNonQuery();
                    resetControls();
                    connection.Close();

                    MessageBox.Show("Registered Successfully");

                    CustomerSearch s1 = new CustomerSearch();
                    s1.ShowDialog();
                }
                catch
                {
                    MessageBox.Show("Registration Failed");
                }
            }
            else
            {
                MessageBox.Show("Please Enter Only 10 Digit PhoneNo / 6 Digit Pincode");
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
           

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

        }

        void getCustomerID()
        {
            string sql;
            string query = "select CustomerID from Customer order by CustomerID desc";
            connection.Open();
            OleDbCommand command = new OleDbCommand(query, connection);
            OleDbDataReader dr = command.ExecuteReader();

            if (dr.Read())
            {
                int id = int.Parse(dr[0].ToString()) + 1;
                sql = id.ToString("0");

            }
            else if (Convert.IsDBNull(dr))
            {
                sql = ("1");

            }
            else
            {
                sql = ("1");
            }

            connection.Close();
            textBoxCID.Text = sql.ToString();

     }
        void resetControls()
        {
            textBoxcAddress.Clear();
            textBoxcCity.Clear();
            textBoxcEmail.Clear();
            textBoxcPhone.Clear();
            textBoxcPincode.Clear();
            textBoxCustomerName.Clear();
        }

        private void textBoxcPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxcPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 10 && e.KeyChar != (char)Keys.Space && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void textBoxCustomerName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Space && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private void textBoxcCity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Space && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private void textBoxCID_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 6 && e.KeyChar != (char)Keys.Space && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void textBoxcPincode_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 6 && e.KeyChar != (char)Keys.Space && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
