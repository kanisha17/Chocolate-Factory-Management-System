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
        OleDbCommand command;
        public StockMaintenance()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\hp\source\Access\ChocolateFactory17.accdb;Persist Security Info=False;";

        }
        double inward, outward, netstock;
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
            textBox1.Clear();
            textBoxNetStock.Clear();
            textBoxProductID.Clear();
            textBoxStockInward.Clear();
            textBoxStockOutward.Clear();
            comboBoxRawMaterialName.ResetText();
        }
        private void buttonEDIT_Click(object sender, EventArgs e)
        {
            try
            {

                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "update RawMaterialDetails set RDate='" + dateTimePickerDate.Text + "',AvailableStock='" + textBox1.Text + "',StockInward='" + textBoxStockInward.Text + "'," +
                    "StockOutward='" + textBoxStockOutward.Text + "',NetStock='" + textBoxNetStock.Text + "' where RawMaterialID=" + textBoxProductID.Text + "";
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

            try
            {
                connection.Open();
                OleDbCommand c1 = new OleDbCommand("select RawMaterialName from RawMaterialDetails where RawMaterialID=@param", connection);
                c1.Parameters.AddWithValue("@param", textBoxProductID.Text);
                OleDbDataReader reader1;
                reader1 = c1.ExecuteReader();
                if (reader1.Read())
                {

                    comboBoxRawMaterialName.Text = reader1["RawMaterialName"].ToString();
                    
                }
                else
                {
                    
                }
                connection.Close();
            }
            catch
            { }
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();

        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            inward = int.Parse(textBoxStockInward.Text);
            outward = int.Parse(textBoxStockOutward.Text);


            if (inward >= 0 && outward >= 0)
            {
                netstock = inward - outward;
                textBoxNetStock.Text = netstock.ToString();
                MessageBox.Show("Net Stock:" + netstock.ToString());
            }
            else
            {
                MessageBox.Show("Enter a valid input");
            }
        }
    }
}
