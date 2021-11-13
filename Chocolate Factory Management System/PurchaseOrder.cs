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
    public partial class PurchaseOrder : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        OleDbCommand command;


        public PurchaseOrder(string str_value)
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\hp\source\Access\ChocolateFactory17.accdb;Persist Security Info=False;";
            dataGridViewPurchaseOrder.ColumnCount = 8;
            dataGridViewPurchaseOrder.Columns[0].Name = "Sr No";
            dataGridViewPurchaseOrder.Columns[1].Name = "Item Name";
            dataGridViewPurchaseOrder.Columns[2].Name = "Unit Price";
            dataGridViewPurchaseOrder.Columns[3].Name = "Quantity";
            dataGridViewPurchaseOrder.Columns[4].Name = "Discount";
            dataGridViewPurchaseOrder.Columns[5].Name = "Sub Total";
            dataGridViewPurchaseOrder.Columns[6].Name = "Tax";
            dataGridViewPurchaseOrder.Columns[7].Name = "Total Cost";

            textBoxName.Text = str_value;
        }

        int finalcost = 0;
        int SrNo = 0;
        int t = 0;

        private void buttonEDIT_Click(object sender, EventArgs e)
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

        private void labelPaid_Click(object sender, EventArgs e)
        {

        }

        private void lOADTABLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void buttonADD_Click(object sender, EventArgs e)
        {
           
          
        }

        private void buttonEDIT_Click_1(object sender, EventArgs e)
        {
          
        }

        private void buttonDELETE_Click(object sender, EventArgs e)
        {

           
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
                    string query = "select Price,Discount from RawMaterialDetails where RawMaterialName='" + comboBoxProductName.Text + "';";
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
            textBoxQuantitykg.Enabled = true;
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }
        private void PurchaseOrder_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "select *from RawMaterialDetails";
                command.CommandText = query;
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    comboBoxProductName.Items.Add(reader["RawMaterialName"].ToString());
                }
                connection.Close();
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void buttonCALCULATE_Click(object sender, EventArgs e)
        {
          
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
                
        }

        private void buttonLoadTable_Click(object sender, EventArgs e)
        {
           
        }

        private void textBoxQuantitykg_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxQuantitykg.Text) == true)
            {

            }
            else
            {

                int price = Convert.ToInt32(textBoxUnitPrice.Text);
                int discount = Convert.ToInt32(textBoxDiscount.Text);
                int quantity = Convert.ToInt32(textBoxQuantitykg.Text);
                int subtotal = price * quantity;
                subtotal = subtotal - discount * quantity;
                textBoxSubTotal.Text = subtotal.ToString();
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

        private void textBoxPaid_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxPaid.Text) == true)
            {

            }
            else
            {
                int amtpaid = Convert.ToInt32(textBoxPaid.Text);
                int fcost = Convert.ToInt32(textBoxFinalCost.Text);
                int change = amtpaid - fcost;
                textBoxChange.Text = change.ToString();
            }
        }
        void calculateFinalCost()
        {

            finalcost = 0;
            for (int i = 0; i < dataGridViewPurchaseOrder.Rows.Count; i++)
            {
                finalcost = finalcost + Convert.ToInt32(dataGridViewPurchaseOrder.Rows[i].Cells[7].Value);

            }
            textBoxFinalCost.Text = finalcost.ToString();

        }
        void resetControls()
        {
            textBoxChange.Clear();
            textBoxDiscount.Clear();
            textBoxFinalCost.Clear();
            
            textBoxPaid.Clear();
            textBoxQuantitykg.Clear();
            textBoxSubTotal.Clear();
            textBoxTax.Clear();
            textBoxTotalCost.Clear();
            textBoxUnitPrice.Clear();

            textBoxQuantitykg.Enabled = false;
            
        }
        private void buttonAdd_Click_1(object sender, EventArgs e)
        {
            addDataToGridView((++SrNo).ToString(), comboBoxProductName.SelectedItem.ToString(), textBoxUnitPrice.Text, textBoxQuantitykg.Text, textBoxDiscount.Text, textBoxSubTotal.Text, textBoxTax.Text, textBoxTotalCost.Text);
            resetControls();
            calculateFinalCost();
        }
        void addDataToGridView(string Sr_No, string Item_Name, string Unit_Price, string Quantity, string Discount, string Sub_Total, string Tax, string Total_Cost)
        {
            string[] row = { Sr_No, Item_Name, Unit_Price, Quantity, Discount, Sub_Total, Tax, Total_Cost };
            dataGridViewPurchaseOrder.Rows.Add(row);

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            resetControls();
        }

        private void buttonClearTable_Click(object sender, EventArgs e)
        {
            dataGridViewPurchaseOrder.Rows.Clear();
            SrNo = 0;
        }
    }
}
