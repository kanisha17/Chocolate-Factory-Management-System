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
    public partial class SalesOrder : Form
    {
        private OleDbConnection connection = new OleDbConnection();
         OleDbCommand command;
       
        
        public SalesOrder(string str_value)
        {
            InitializeComponent();
            getInvoiceID();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\hp\source\Access\ChocolateFactory17.accdb;Persist Security Info=False;";
            dataGridViewSaleOrder.ColumnCount = 8;
            dataGridViewSaleOrder.Columns[0].Name ="Sr No";
            dataGridViewSaleOrder.Columns[1].Name="Item Name";
            dataGridViewSaleOrder.Columns[2].Name="Unit Price";
            dataGridViewSaleOrder.Columns[3].Name ="Quantity";
            dataGridViewSaleOrder.Columns[4].Name ="Discount";
            dataGridViewSaleOrder.Columns[5].Name="Sub Total";
            dataGridViewSaleOrder.Columns[6].Name="Tax";
            dataGridViewSaleOrder.Columns[7].Name="Total Cost";

            textBoxName.Text = str_value;
        }

        int finalcost = 0;
        int SrNo = 0;
        int t = 0;
        private void SalesOrder_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "select *from ProductDetails";
                command.CommandText = query;
                OleDbDataReader reader= command.ExecuteReader();
                while (reader.Read())
                {
                    comboBoxItemName.Items.Add(reader["ProductName"].ToString());
                }
                connection.Close();
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void dataGridViewSaleOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonLoadTable_Click(object sender, EventArgs e)
        {
          
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            
        }

        private void textBoxBalance_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dELETEToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void lOADTABLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void rECEIPTToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonADD_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonEDIT_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonDELETE_Click(object sender, EventArgs e)
        {
          
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
           

        }

        private void aDDToolStripMenuItem_Click(object sender, EventArgs e)
        {

           
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void cLEARToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void eDITToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void comboBoxItemName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxItemName.SelectedItem == null)
            {

            }
            else
            {
                try
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                    string query = "select Price,Discount from ProductDetails where ProductName='" + comboBoxItemName.Text + "';";
                    command.CommandText = query;
                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string p = (string)reader["Price"].ToString();
                        textBoxUnitPrice.Text = p;
                        string dis = (string)reader["Discount"].ToString();
                        textBoxDiscount.Text = dis;
                    }
                    connection.Close();
                }
                catch
                {
                    MessageBox.Show("Error");
                }
            }
                textBoxQuantity.Enabled = true;
            
        }

        private void textBoxQuantity_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxQuantity.Text) == true)
            {

            }
            else
            {

                int price = Convert.ToInt32(textBoxUnitPrice.Text);
                int discount = Convert.ToInt32(textBoxDiscount.Text);
                int quantity = Convert.ToInt32(textBoxQuantity.Text);
                int subtotal = price * quantity;
                subtotal = subtotal - discount * quantity;
                textBoxSubTotal.Text = subtotal.ToString();
            }
        }

        private void textBoxSubTotal_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxSubTotal.Text) == true)
            {

            }
            else
            {
                int subtotal = Convert.ToInt32(textBoxSubTotal.Text);
                if (subtotal >= 10000)
                {
                    t = (int)(subtotal * 0.15);
                    textBoxTax.Text = t.ToString();
                }
                else if (subtotal >= 6000)
                {
                    t = (int)(subtotal * 0.10);
                    textBoxTax.Text = t.ToString();
                }
                else if (subtotal >= 3000)
                {
                    t = (int)(subtotal * 0.06);
                    textBoxTax.Text = t.ToString();
                }
                if (subtotal >= 1000)
                {
                    t = (int)(subtotal * 0.04);
                    textBoxTax.Text = t.ToString();
                }
                else
                {
                    t = (int)(subtotal * 0.02);
                    textBoxTax.Text = t.ToString();
                }
            }
        }

        private void textBoxTax_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxTax.Text) == true)
            {

            }
            else
            {
                int subtotal = Convert.ToInt32(textBoxSubTotal.Text);
                int tax = Convert.ToInt32(textBoxTax.Text);
                int totalcost = subtotal + tax;
                textBoxTotalCost.Text = totalcost.ToString();
            }
        }

        void addDataToGridView(string Sr_No, string Item_Name, string Unit_Price, string Quantity, string Discount,string Sub_Total, string Tax, string Total_Cost)
        {
            string[] row = { Sr_No, Item_Name, Unit_Price, Quantity, Discount, Sub_Total, Tax, Total_Cost };
            dataGridViewSaleOrder.Rows.Add(row);

        }

        private void buttonADD_Click_1(object sender, EventArgs e)
        {
            addDataToGridView((++SrNo).ToString(), comboBoxItemName.SelectedItem.ToString(),textBoxUnitPrice.Text,textBoxQuantity.Text,textBoxDiscount.Text,textBoxSubTotal.Text,textBoxTax.Text,textBoxTotalCost.Text);
            resetControls();
            calculateFinalCost();
        }
        void resetControls()
        {
            textBoxChange.Clear();
            textBoxDiscount.Clear();
            textBoxQuantity.Clear();
            textBoxSubTotal.Clear();
            textBoxUnitPrice.Clear();
            textBoxPaid.Clear();
            textBoxChange.Clear();
            textBoxTax.Clear();
            textBoxTotalCost.Clear();
            textBoxFinalCost.Clear();
          //  textBoxInvoiceNo.Clear();
            textBoxQuantity.Enabled = false;

         MessageBox.Show("Item Added");
        }
        void calculateFinalCost()
        {
           
                finalcost = 0;
                for (int i = 0; i < dataGridViewSaleOrder.Rows.Count; i++)
                {
                    finalcost = finalcost + Convert.ToInt32(dataGridViewSaleOrder.Rows[i].Cells[7].Value);

                }
                textBoxFinalCost.Text = finalcost.ToString();
            
        }

        private void textBoxPaid_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxPaid.Text) == true)
            {

            }
            else
            {
                int amtpaid = Convert.ToInt32(textBoxPaid.Text);
                int fcost =Convert.ToInt32(textBoxFinalCost.Text);
                int change = amtpaid - fcost;
                textBoxChange.Text = change.ToString();
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            resetControls();
        }

        private void buttonClearTable_Click(object sender, EventArgs e)
        {
            dataGridViewSaleOrder.Rows.Clear();
            SrNo = 0;
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        void getInvoiceID()
        {
            try
            {
                connection.Open();
                OleDbCommand command= new OleDbCommand();
                command.Connection = connection;
                string query = "select InvoiceID from SalesOrder";
                command.CommandText = query;
                OleDbDataReader reader = command.ExecuteReader();
                OleDbDataAdapter da = new OleDbDataAdapter(query,connection);
                DataTable data = new DataTable();
                da.Fill(data);
                if (data.Rows.Count < 1)
                {
                    textBoxInvoiceNo.Text = "1";
                }
                else 
                {
                    MessageBox.Show("a");
                }

            }
            catch
            {
                MessageBox.Show("b");
            }
        
        }

        private void textBoxTotalCost_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxFinalCost_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
