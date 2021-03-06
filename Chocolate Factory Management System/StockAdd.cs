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
    public partial class StockAdd : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        // OleDbCommand command;
        public StockAdd()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\hp\source\Access\ChocolateFactory17.accdb;Persist Security Info=False;";
        }

        private void textBoxProductID_TextChanged(object sender, EventArgs e)
        {


        }

        void resetControls()
        {
            textBoxNetStock.Clear();
            textBoxAStock.Clear();
            textBoxStockInward.Clear();
            textBoxProductID.Clear();
            comboBoxProductName.ResetText();
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {

                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "update ProductDetails set SDate='" + dateTimePickerDate.Text + "',AvailableStock='" + textBoxAStock.Text + "'," +
                    "StockInward='" + textBoxStockInward.Text + "',NetStock='" + textBoxNetStock.Text + "' where ProductID=" + textBoxProductID.Text + "";
                MessageBox.Show(query);
                command.CommandText = query;

                command.ExecuteNonQuery();
                MessageBox.Show("Data Updated Successfully");
                resetControls();
                connection.Close();
            }
            catch
            {
                MessageBox.Show("Data Not Updated");
            }


        }



        private void StockAdd_Load(object sender, EventArgs e)
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

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
          
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
                    string query = "select ProductID,AvailableStock from ProductDetails where ProductName='" + comboBoxProductName.Text + "';";
                    command.CommandText = query;
                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string p = (string)reader["ProductID"].ToString();
                        textBoxProductID.Text = p;
                        string p1 = (string)reader["AvailableStock"].ToString();
                        textBoxAStock.Text = p1;

                    }
                    connection.Close();
                }
                catch
                {
                    
                }
            }
        }

        private void textBoxStockOutward_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxStockInward.Text) == true)
            {

            }
            else
            {

                int price = Convert.ToInt32(textBoxAStock.Text);
                int discount = Convert.ToInt32(textBoxStockInward.Text);
              
                int subtotal = price + discount;
         
               textBoxNetStock.Text = subtotal.ToString();
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

        private void textBoxStockInward_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 6 && e.KeyChar != (char)Keys.Space && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void textBoxStockOutward_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 6 && e.KeyChar != (char)Keys.Space && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void textBoxNetStock_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
