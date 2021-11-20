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
    public partial class CustomerComplaints : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        OleDbCommand command;
        public CustomerComplaints(string str_value)
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\hp\source\Access\ChocolateFactory17.accdb;Persist Security Info=False;";
            textBoxPhoneNo.Text = str_value;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
          
        }

        void resetControls()
        {
            textBoxCID.Clear();
            textBoxPhoneNo.Clear();
            textBoxName.Clear();
            textBoxEmail.Clear();
            checkedListBoxapprcomplaint.ResetText();
            textBoxDefectmsg.Clear();
            textBoximprovement.Clear();
            comboBoxProductName.ResetText();
            textBoxtakenby.Clear();
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

        private void buttonSubmit_Click(object sender, EventArgs e)
        {


            try
            {
                connection.Open();
                command = new OleDbCommand("insert into CustomerComplaint(CustomerID,CustomerName,Email,PhoneNo,ProductName,ComplaintTakenBy,DefectiveInfo,Improvement,Complaint) " +
                    "values(@cid,@customername,@email,@phone,@productid,@takenby,@defective,@improvement,@complaint)", connection);
                command.Parameters.AddWithValue("@cid", textBoxCID.Text);
                command.Parameters.AddWithValue("@customername", textBoxName.Text);
                command.Parameters.AddWithValue("@email", textBoxEmail.Text);
                command.Parameters.AddWithValue("@phone", textBoxPhoneNo.Text);
                command.Parameters.AddWithValue("@productid",comboBoxProductName.Text);
                command.Parameters.AddWithValue("@takenby", textBoxtakenby.Text);
                command.Parameters.AddWithValue("@defective", textBoxDefectmsg.Text);
                command.Parameters.AddWithValue("@improvement", textBoximprovement.Text);
                command.Parameters.AddWithValue("@complaint",checkedListBoxapprcomplaint.Text);

                command.ExecuteNonQuery();
                resetControls();
                connection.Close();

                MessageBox.Show("Data Saved Successfully");

                CustomerSearch c1 = new CustomerSearch();
                c1.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void CustomerComplaints_Load(object sender, EventArgs e)
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

        private void rEPORTToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void labeltosearch_Click(object sender, EventArgs e)
        {

        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Space && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private void textBoxtakenby_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void textBoxCID_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 6 && e.KeyChar != (char)Keys.Space && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
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
