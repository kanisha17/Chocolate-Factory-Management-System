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
        public CustomerComplaints()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\hp\source\Access\ChocolateFactory17.accdb;Persist Security Info=False;";

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            connection.Open();
            OleDbCommand c1 = new OleDbCommand("select CustomerID,CustomerName,Email,PhoneNo from Customer where PhoneNo=@parm1", connection);
            c1.Parameters.AddWithValue("@parm1", textBoxSearch.Text);
            OleDbDataReader reader1;
            reader1 = c1.ExecuteReader();
            if (reader1.Read())
            {
                textBoxCID.Text = reader1["CustomerID"].ToString();
                textBoxName.Text = reader1["CustomerName"].ToString();
                textBoxEmail.Text = reader1["Email"].ToString();
                textBoxPhoneNo.Text = reader1["PhoneNo"].ToString();
                MessageBox.Show("Data Found");
            }
            else
            {
                MessageBox.Show("No Data Found");
            }
            connection.Close();
        }

        private void cLEARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxCID.Clear();
            textBoxPhoneNo.Clear();
            textBoxName.Clear();
            textBoxEmail.Clear();
            textBoxSearch.Clear();
            checkedListBoxapprcomplaint.ResetText();
            textBoxDefectmsg.Clear();
            textBoximprovement.Clear();
            textBoxProductID.Clear();
            textBoxtakenby.Clear();
            MessageBox.Show("Data Cleared");
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
                command = new OleDbCommand("insert into CustomerComplaint(CustomerID,CustomerName,Email,PhoneNo,ProductID,ComplaintTakenBy,DefectiveInfo,Improvement,Complaint) " +
                    "values(@cid,@customername,@email,@phone,@productid,@takenby,@defective,@improvement,@complaint)", connection);
                command.Parameters.AddWithValue("@cid", textBoxCID.Text);
                command.Parameters.AddWithValue("@customername", textBoxName.Text);
                command.Parameters.AddWithValue("@email", textBoxEmail.Text);
                command.Parameters.AddWithValue("@phone", textBoxPhoneNo.Text);
                command.Parameters.AddWithValue("@productid",textBoxProductID.Text);
                command.Parameters.AddWithValue("@takenby", textBoxtakenby.Text);
                command.Parameters.AddWithValue("@defective", textBoxDefectmsg.Text);
                command.Parameters.AddWithValue("@improvement", textBoximprovement.Text);
                command.Parameters.AddWithValue("@complaint",checkedListBoxapprcomplaint.Text);

                command.ExecuteNonQuery();

                connection.Close();
                MessageBox.Show("Data Saved Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void CustomerComplaints_Load(object sender, EventArgs e)
        {

        }

        private void rEPORTToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
