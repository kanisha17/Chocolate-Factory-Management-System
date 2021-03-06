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
    public partial class Package : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        OleDbCommand command;
        public Package()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\hp\source\Access\ChocolateFactory17.accdb;Persist Security Info=False;";

        }

        private void Package_Load(object sender, EventArgs e)
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
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
           

            try
            {
                connection.Open();
                command = new OleDbCommand("insert into Packaging(ProductID,ProductName,NewStock,PackagingDate) values(@pid,@pname,@newstock,@packdate)", connection);

                command.Parameters.AddWithValue("@pid", textBoxProductID.Text);
                command.Parameters.AddWithValue("@pname", comboBoxProductName.Text);
                command.Parameters.AddWithValue("@newstock", textBoxNewStock.Text);
                command.Parameters.AddWithValue("@packdate", dateTimePickerPackage.Text);

                command.ExecuteNonQuery();

                connection.Close();
                MessageBox.Show("Data Saved Successfully");
                resetControls();
            }
            catch
            {

            }
        }
        void resetControls()
        {
            comboBoxProductName.ResetText();
            textBoxNewStock.Clear();
            textBoxProductID.Clear();
        }

        private void eXITToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
       
        }

        private void textBoxProductID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand c1 = new OleDbCommand("select ProductName from ProductDetails where ProductID=@param", connection);
                c1.Parameters.AddWithValue("@param", textBoxProductID.Text);
                OleDbDataReader reader1;
                reader1 = c1.ExecuteReader();
                if (reader1.Read())
                {

                    comboBoxProductName.Text = reader1["ProductName"].ToString();

                }
                else
                {

                }
                connection.Close();
            }
            catch
            { }
        }

        private void comboBoxProductName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxProductName.SelectedItem == null)
            {

            }
            else
            {
                try
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                    string query = "select ProductID from ProductDetails where ProductName='" + comboBoxProductName.Text + "';";
                    command.CommandText = query;
                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string p = (string)reader["ProductID"].ToString();
                        textBoxProductID.Text = p;

                    }
                    connection.Close();
                }
                catch
                {
                    MessageBox.Show("Error");
                }

            }
        }

        private void textBoxProductID_KeyPress(object sender, KeyPressEventArgs e)
        {

            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 6 && e.KeyChar != (char)Keys.Space && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void textBoxNewStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 6 && e.KeyChar != (char)Keys.Space && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
