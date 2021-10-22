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
    public partial class Adminprofile : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        OleDbCommand command;
        public Adminprofile()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\hp\source\Access\ChocolateFactory17.accdb;Persist Security Info=False;";

        }
        private void Adminprofile_Load(object sender, EventArgs e)
        {

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            connection.Open();
            OleDbCommand c1 = new OleDbCommand("select FirstName,LastName,DOB,Address,City,State,Pincode,PhoneNo,Email from Admin where AdminID=@parm1", connection);
            c1.Parameters.AddWithValue("@parm1", textBoxSearch.Text);
            OleDbDataReader reader1;
            reader1 = c1.ExecuteReader();
            if (reader1.Read())
            {
                textBoxFirstName.Text = reader1["FirstName"].ToString();
                textBoxLastName.Text = reader1["LastName"].ToString();
                dateTimePickerDOB.Text = reader1["DOB"].ToString();
                textBoxAddress.Text = reader1["Address"].ToString();
                textBoxCity.Text = reader1["City"].ToString();
                textBoxState.Text = reader1["State"].ToString();
                textBoxPincode.Text = reader1["Pincode"].ToString();
                textBoxPhoneNo.Text = reader1["PhoneNo"].ToString();
                textBoxEmail.Text = reader1["Email"].ToString();
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

        private void aDDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                command = new OleDbCommand("insert into Admin(FirstName,LastName,DOB,Address,City,State,Pincode,PhoneNo,Email) " +
                    "values(@firstname,@lastname,@dob,@address,@city,@state,@pincode,@phoneno,@email)", connection);

                command.Parameters.AddWithValue("@firstname", textBoxFirstName.Text);
                command.Parameters.AddWithValue("@lastname", textBoxLastName.Text);
                command.Parameters.AddWithValue("@dob", dateTimePickerDOB.Text);
                command.Parameters.AddWithValue("@address", textBoxAddress.Text);
                command.Parameters.AddWithValue("@city", textBoxCity.Text);
                command.Parameters.AddWithValue("@state", textBoxState.Text);
                command.Parameters.AddWithValue("@pincode", textBoxPincode.Text);
                command.Parameters.AddWithValue("@phoneno", textBoxPhoneNo.Text);
                command.Parameters.AddWithValue("@email", textBoxEmail.Text);

                command.ExecuteNonQuery();

                connection.Close();
                MessageBox.Show("Saved Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void eDITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "update Admin set FirstName='" + textBoxFirstName.Text + "', LastName='" + textBoxLastName.Text + "'," +
                    "DOB='" + dateTimePickerDOB.Value.Date + "', Address='" + textBoxAddress.Text + "', City='" + textBoxCity.Text + "',State='" + textBoxState.Text + "'," +
                    "Pincode='" + textBoxPincode.Text + "', PhoneNo='" + textBoxPhoneNo.Text + "',Email='" + textBoxEmail.Text + "' where AdminID=" + textBoxSearch.Text + "";
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

        private void cLEARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxAddress.Clear();
            textBoxCity.Clear();
            textBoxEmail.Clear();
            textBoxFirstName.Clear();
            textBoxLastName.Clear();
            textBoxPhoneNo.Clear();
            textBoxPincode.Clear();
            textBoxSearch.Clear();
            textBoxState.Clear();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
