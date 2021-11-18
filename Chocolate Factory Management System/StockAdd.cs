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
                    MessageBox.Show("No Data Found");
                }
                connection.Close();
            }
            catch
            { }
        }

        void resetControls()
        {
            textBoxAvailableStock.Clear();
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
                string query = "update ProductDetails set SDate='" + dateTimePickerDate.Text + "','"+textBoxAvailableStock.Text+"',StockInward='" + textBoxStockInward.Text + "'," +
                    "StockOutward='" + textBoxStockOutward.Text + "',NetStock='" + textBoxNetStock.Text + "' where ProductID=" + textBoxProductID.Text + "";
                MessageBox.Show(query);
                command.CommandText = query;

                command.ExecuteNonQuery();
                MessageBox.Show("Data Updated Successfully");
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
            FinishedStockSearch f2 = new FinishedStockSearch();
            f2.Show();
            this.Hide();
        }
    }
}
