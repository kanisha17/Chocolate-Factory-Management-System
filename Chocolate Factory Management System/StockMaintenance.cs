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
    public partial class StockMaintenance : Form
    {

        private OleDbConnection connection = new OleDbConnection();
       // OleDbCommand command;
        public StockMaintenance()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\hp\source\Access\ChocolateFactory17.accdb;Persist Security Info=False;";

        }
      
        private void buttonSerach_Click(object sender, EventArgs e)
        {

        }

        private void aDDToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void eDITToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dELETEToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cLEARToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void buttonADD_Click(object sender, EventArgs e)
        {

        }
        void resetControls()
        {

            textBoxNetStock.Clear();
            textBoxProductID.Clear();
            textBoxAStock.Clear();
            textBoxStockInward.Clear();
            comboBoxRawMaterialName.ResetText();
        }
        private void buttonEDIT_Click(object sender, EventArgs e)
        {
            try
            {

                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "update RawMaterialDetails set RDate='" + dateTimePickerDate.Text + "',AvailableStock='" + textBoxAStock.Text + "'," +
                    "StockInward='" + textBoxStockInward.Text + "',NetStock='" + textBoxNetStock.Text + "' where RawMaterialID=" + textBoxProductID.Text + "";
                MessageBox.Show(query);
                command.CommandText = query;

                command.ExecuteNonQuery();
                MessageBox.Show("Data Updated Successfully");
                connection.Close();
                resetControls();
            }
            catch
            {
                MessageBox.Show("Data Not Updated");
            }
        }

        private void buttonDELETE_Click(object sender, EventArgs e)
        {

        }

        private void textBoxProductID_TextChanged(object sender, EventArgs e)
        {


        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void eXITToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            
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

        private void StockMaintenance_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "select RawMaterialName from RawMaterialDetails";
                command.CommandText = query;
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    comboBoxRawMaterialName.Items.Add(reader["RawMaterialName"].ToString());
                }
                connection.Close();
            }
            catch
            {

            }
        }

        private void comboBoxRawMaterialName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxRawMaterialName.SelectedItem == null)
            {

            }
            else
            {
                try
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                    string query = "select RawMaterialID from RawMaterialDetails where RawMaterialName='" + comboBoxRawMaterialName.Text + "';";
                    command.CommandText = query;
                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string p = (string)reader["RawMaterialID"].ToString();
                        textBoxProductID.Text = p;

                    }
                    connection.Close();
                }
                catch
                {

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
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 6 && e.KeyChar != (char)Keys.Space && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void textBoxNetStock_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
