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
        int count = 0;
        public CustomerRegister()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\hp\source\Access\Cdataa.accdb;Persist Security Info=False;";

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "update Customers set CustomerName='" + textBoxCustomerName.Text + ",DOB='" + dateTimePickercDOB.Value.Date + "'," +
                    " Address='" + textBoxcAddress.Text + "',City='"+textBoxcCity.Text+"', " +
                    "Pincode='" + textBoxcPincode.Text + "',Email='" + textBoxcEmail.Text + "' where PhoneNo=" +textBoxcPhone.Text + "";
                MessageBox.Show(query);
                command.CommandText = query;

                command.ExecuteNonQuery();
                MessageBox.Show("Data Edited Successfully");
            }
            catch (Exception ef)
            {
                MessageBox.Show("Error" + ef);
            }
            connection.Close();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "insert into Customers (CID,CustomerName,DOB,Address,City,Pincode,PhoneNo,Email) " +
                    "values('"+textBoxCID.Text+"','" + textBoxCustomerName.Text + "','" + dateTimePickercDOB.Value.Date + "'," +
                    "'" + textBoxcAddress.Text + "','" + textBoxcCity.Text + "','" + textBoxcPincode.Text + "','"+textBoxcPhone.Text+"','" + textBoxcEmail.Text + "')";


                command.ExecuteNonQuery();
                MessageBox.Show("Data Saved Successfully");

            }
            catch (Exception ee)
            {
                MessageBox.Show("Error" + ee);
            }
            connection.Close();
        }

        private void CustomerRegister_Load(object sender, EventArgs e)
        {

        }

        private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxcAddress.Clear();
            textBoxcCity.Clear();
            textBoxcEmail.Clear();
            textBoxCustomerName.Clear();
            textBoxcPincode.Clear();
            textBoxSearch.Clear();
            textBoxcPhone.Clear();
            
        }

        private void rEFRESHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "select *from Customers";
                //MessageBox.Show(query);
                command.CommandText = query;

                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;



                connection.Close();
            }
            catch (Exception ef)
            {
                MessageBox.Show("Error" + ef);
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "delete from Customers where CID=" + textBoxCID.Text + "";
                //MessageBox.Show(query);
                command.CommandText = query;

                command.ExecuteNonQuery();
                MessageBox.Show("Data Deleted Successfully");
            }
            catch (Exception ef)
            {
                MessageBox.Show("Error" + ef);
            }
            connection.Close();
        }

        private void pRINTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        
        private void printDocument1c_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
           
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void sEARCHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            connection.Open();
            OleDbCommand c1 = new OleDbCommand("select CustomerName,DOB,Address,City,PhoneNo,Pincode,Email from Customers where CID=@parm1", connection);
            c1.Parameters.AddWithValue("@parm1", textBoxCID.Text);
            OleDbDataReader reader1;
            reader1 = c1.ExecuteReader();
            if (reader1.Read())
            {
                textBoxCustomerName.Text = reader1["CustomerName"].ToString();
                dateTimePickercDOB.Text = reader1["DOB"].ToString();
                textBoxcAddress.Text = reader1["Address"].ToString();
                textBoxcCity.Text = reader1["Cityr"].ToString();
                textBoxcPhone.Text = reader1["PhoneNo"].ToString();
                textBoxcPincode.Text = reader1["Pincode"].ToString();
                textBoxcEmail.Text = reader1["Email"].ToString();
            }
            else
            {
                MessageBox.Show("No Data Found");
            }
                connection.Close();

            }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            count = 0;
            connection.Open();
            OleDbCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select *from Customers where PhoneNo='" + textBoxSearch.Text + "'";
            command.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(command);
            da.Fill(dt);
            count = Convert.ToInt32(dt.Rows.Count.ToString());
            dataGridView1.DataSource = dt;
            connection.Close();

            if (count == 0)
            {
                MessageBox.Show("Record Not Found");
            }
            else
            {
                MessageBox.Show("Record Found");
            }
        }

        private void aDDToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void aDDToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = connection.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "insert into Customers (CID,CustomerName,DOB,Address,City,PhoneNo,Pincode,Email) " +
                    "values('" + textBoxCID.Text + "','" +textBoxCustomerName.Text + "','" + dateTimePickercDOB.Value.Date+"'," +
                    "'" + textBoxcAddress.Text + "','" +textBoxcCity.Text + "','" +textBoxcPhone.Text + "','" + textBoxcPincode.Text + "'," +
                    "'" + textBoxcEmail.Text + "')";


                command.ExecuteNonQuery();
                MessageBox.Show("Data Saved Successfully");

            }
            catch (Exception ee)
            {
                MessageBox.Show("Error" + ee);
            }
            connection.Close();
        }

        private void eDITToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {

                connection.Open();
                OleDbCommand command = connection.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText= "update Customers set CustomerName='" + textBoxCustomerName.Text + "',DOB='" + dateTimePickercDOB.Value.Date + "'," +
                    "Address='" + textBoxcAddress.Text + "',City='" +textBoxcCity.Text + "'," +
                    "Pincode='" + textBoxcPincode.Text + "',Email='" + textBoxcEmail.Text + "' where PhoneNo='" +textBoxcPhone.Text + "'";

                command.ExecuteNonQuery();
                MessageBox.Show("Data Edited Successfully");
            }
            catch (Exception ef)
            {
                MessageBox.Show("Error" + ef);
            }
            connection.Close();
        }

        private void rEFRESHToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            try
            {

                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "select *from Customers";
                //MessageBox.Show(query);
                command.CommandText = query;

                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;



                connection.Close();
            }
            catch (Exception ef)
            {
                MessageBox.Show("Error" + ef);
            }
        }

        private void pRINTToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            textBoxcAddress.Clear();
            textBoxcCity.Clear();
            textBoxcEmail.Clear();
            textBoxCID.Clear();
            textBoxcPhone.Clear();
            textBoxcPincode.Clear();
            textBoxCustomerName.Clear();
            textBoxSearch.Clear();
        }

        private void vIEWToolStripMenuItem_Click(object sender, EventArgs e)
        {
            connection.Open();
            OleDbCommand c1 = new OleDbCommand("select CustomerName,DOB,Address,City,PhoneNo,Pincode,Email from Customers where CID=@parm1", connection);
            c1.Parameters.AddWithValue("@parm1", textBoxCID.Text);
            OleDbDataReader reader1;
            reader1 = c1.ExecuteReader();
            if (reader1.Read())
            {
                textBoxCustomerName.Text = reader1["CustomerName"].ToString();
                dateTimePickercDOB.Text = reader1["DOB"].ToString();
                textBoxcAddress.Text = reader1["Address"].ToString();
                textBoxcCity.Text = reader1["City"].ToString();
                textBoxcPhone.Text = reader1["PhoneNo"].ToString();
                textBoxcPincode.Text = reader1["Pincode"].ToString();
                textBoxcEmail.Text = reader1["Email"].ToString();
               
            }
            else
            {
                MessageBox.Show("No Data Found");
            }
            connection.Close();
        }

        private void eXITToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void dELETEToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {

                connection.Open();
                OleDbCommand command = connection.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText= "delete from Customers where PhoneNo=" + textBoxcPhone.Text + "";
                //MessageBox.Show(query);
                

                command.ExecuteNonQuery();
                MessageBox.Show("Data Deleted Successfully");
            }
            catch (Exception ef)
            {
                MessageBox.Show("Error" + ef);
            }
            connection.Close();
        }

        private void mENUToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
    }
