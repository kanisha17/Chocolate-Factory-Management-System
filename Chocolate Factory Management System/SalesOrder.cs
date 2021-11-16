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
        //  OleDbCommand command;


        public SalesOrder(string str_value)
        {
            InitializeComponent();
            // getInvoiceID();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\hp\source\Access\ChocolateFactory17.accdb;Persist Security Info=False;";
            dataGridViewSaleOrder.ColumnCount = 8;
            dataGridViewSaleOrder.Columns[0].Name = "Sr No";
            dataGridViewSaleOrder.Columns[1].Name = "Item Name";
            dataGridViewSaleOrder.Columns[2].Name = "Unit Price";
            dataGridViewSaleOrder.Columns[3].Name = "Quantity";
            dataGridViewSaleOrder.Columns[4].Name = "Discount";
            dataGridViewSaleOrder.Columns[5].Name = "Sub Total";
            dataGridViewSaleOrder.Columns[6].Name = "Tax";
            dataGridViewSaleOrder.Columns[7].Name = "Total Cost";

            textBoxPhoneNo.Text = str_value;
        }

        int finalcost = 0;
        int SrNo = 0;
        int t = 0;
        private void SalesOrder_Load(object sender, EventArgs e)
        {
            getInvoiceID();
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
                    comboBoxItemName.Items.Add(reader["ProductName"].ToString());
                }
                connection.Close();
            }
            catch
            {
                MessageBox.Show("Error");
            }

            try
            {
                connection.Open();
                OleDbCommand c1 = new OleDbCommand("select CustomerName from Customer where PhoneNo=@param", connection);
                c1.Parameters.AddWithValue("@param", textBoxPhoneNo.Text);
                OleDbDataReader reader1;
                reader1 = c1.ExecuteReader();
                if (reader1.Read())
                {
                    textBoxName.Text = reader1["CustomerName"].ToString();
                  
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

        void addDataToGridView(string Sr_No, string Item_Name, string Unit_Price, string Quantity, string Discount, string Sub_Total, string Tax, string Total_Cost)
        {
            string[] row = { Sr_No, Item_Name, Unit_Price, Quantity, Discount, Sub_Total, Tax, Total_Cost };
            dataGridViewSaleOrder.Rows.Add(row);

        }

        private void buttonADD_Click_1(object sender, EventArgs e)
        {
            if (comboBoxItemName.SelectedItem != null)
            {
                addDataToGridView((++SrNo).ToString(), comboBoxItemName.SelectedItem.ToString(), textBoxUnitPrice.Text, textBoxQuantity.Text, textBoxDiscount.Text, textBoxSubTotal.Text, textBoxTax.Text, textBoxTotalCost.Text);
                resetControls();
                calculateFinalCost();
            }
            else
            {
                MessageBox.Show("Please Select An Item");
            }
        }
        void resetControls()
        {
            textBoxDiscount.Clear();
            textBoxQuantity.Clear();
            textBoxSubTotal.Clear();
            textBoxUnitPrice.Clear();
            textBoxTax.Clear();
            textBoxTotalCost.Clear();
            textBoxQuantity.Enabled = false;
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
                int fcost = Convert.ToInt32(textBoxFinalCost.Text);
                int change = amtpaid - fcost;
                textBoxChange.Text = change.ToString();
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxPaid.Clear();
            textBoxFinalCost.Clear();
            textBoxChange.Clear();
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

            // command.connection.Open();
            string sql;
            string query = "select InvoiceID from SalesOrder order by InvoiceID desc";
            connection.Open();
            OleDbCommand command = new OleDbCommand(query, connection);
            OleDbDataReader dr = command.ExecuteReader();

            if (dr.Read())
            {
                int id = int.Parse(dr[0].ToString()) + 1;
                sql = id.ToString("0");

            }
            else if (Convert.IsDBNull(dr))
            {
                sql = ("1");

            }
            else
            {
                sql = ("1");
            }

            connection.Close();
            textBoxInvoiceNo.Text = sql.ToString();

        }


        private void textBoxTotalCost_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxFinalCost_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {

            try
            {
                OleDbCommand command;

                connection.Open();
                command = new OleDbCommand("insert into SalesOrder(InvoiceID,ItemName,SalesDate,FinalCost) " +
                    "values(@invoiceid,@name,@date,@finalcost)", connection);

                command.Parameters.AddWithValue("@invoiceid", textBoxInvoiceNo.Text);
                command.Parameters.AddWithValue("@name", textBoxName.Text);
                command.Parameters.AddWithValue("@date", DateTime.Now.ToString());
                command.Parameters.AddWithValue("@finalcost", textBoxFinalCost.Text);
                //int a= command.ExecuteNonQuery();

                command.ExecuteNonQuery();

                resetControls();
                connection.Close();
                getInvoiceID();
            }

            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("CHOCOLATE FACTORY", new Font("Lucida Bright", 30, FontStyle.Bold), Brushes.Blue, new Point(200, 50));
            e.Graphics.DrawString("Invoice ID : " + textBoxInvoiceNo.Text, new Font("Lucida Bright", 16, FontStyle.Bold), Brushes.Black, new Point(20, 150));
            e.Graphics.DrawString("Name : " + textBoxName.Text, new Font("Lucida Bright", 16, FontStyle.Bold), Brushes.Black, new Point(20, 180));
            e.Graphics.DrawString("Date : " + DateTime.Now.ToShortDateString(), new Font("Lucida Bright", 16, FontStyle.Bold), Brushes.Black, new Point(20, 210));
            e.Graphics.DrawString("Time : " + DateTime.Now.ToLongTimeString(), new Font("Lucida Bright", 16, FontStyle.Bold), Brushes.Black, new Point(20, 240));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------", new Font("Lucida Bright", 16, FontStyle.Bold), Brushes.Black, new Point(20, 280));
            e.Graphics.DrawString("ITEM NAME", new Font("Lucida Bright", 16, FontStyle.Bold), Brushes.Black, new Point(20, 300));
            e.Graphics.DrawString("QUANTITY", new Font("Lucida Bright", 16, FontStyle.Bold), Brushes.Black, new Point(270, 300));
            e.Graphics.DrawString("DISCOUNT", new Font("Lucida Bright", 16, FontStyle.Bold), Brushes.Black, new Point(450, 300));
            e.Graphics.DrawString("UNIT PRICE", new Font("Lucida Bright", 16, FontStyle.Bold), Brushes.Black, new Point(640, 300));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------", new Font("Lucida Bright", 16, FontStyle.Bold), Brushes.Black, new Point(20, 320));

            int gap = 350;
            if (dataGridViewSaleOrder.Rows.Count > 0)
            {
                for (int i = 0; i < dataGridViewSaleOrder.Rows.Count; i++)
                {
                    try
                    {
                        e.Graphics.DrawString(dataGridViewSaleOrder.Rows[i].Cells[1].Value.ToString(), new Font("Lucida Bright", 16, FontStyle.Bold), Brushes.Black, new Point(20, gap));
                        gap = gap + 30;
                    }
                    catch
                    {

                    }
                }

            }

            int gap1 = 350;
            if (dataGridViewSaleOrder.Rows.Count > 0)
            {
                for (int i = 0; i < dataGridViewSaleOrder.Rows.Count; i++)
                {
                    try
                    {
                        e.Graphics.DrawString(dataGridViewSaleOrder.Rows[i].Cells[3].Value.ToString(), new Font("Lucida Bright", 16, FontStyle.Bold), Brushes.Black, new Point(330, gap1));
                        gap1 = gap1 + 30;
                    }
                    catch
                    {

                    }
                }

            }

            int gap2 = 350;
            if (dataGridViewSaleOrder.Rows.Count > 0)
            {
                for (int i = 0; i < dataGridViewSaleOrder.Rows.Count; i++)
                {
                    try
                    {
                        e.Graphics.DrawString(dataGridViewSaleOrder.Rows[i].Cells[4].Value.ToString(), new Font("Lucida Bright", 16, FontStyle.Bold), Brushes.Black, new Point(480, gap2));
                        gap2 = gap2 + 30;
                    }
                    catch
                    {

                    }
                }

            }

            int gap3 = 350;
            if (dataGridViewSaleOrder.Rows.Count > 0)
            {
                for (int i = 0; i < dataGridViewSaleOrder.Rows.Count; i++)
                {
                    try
                    {
                        e.Graphics.DrawString(dataGridViewSaleOrder.Rows[i].Cells[2].Value.ToString(), new Font("Lucida Bright", 16, FontStyle.Bold), Brushes.Black, new Point(670, gap3));
                        gap3 = gap3 + 30;
                    }
                    catch
                    {

                    }
                }

            }
           int SubTotalPrint = 0;
            for (int i = 0; i < dataGridViewSaleOrder.Rows.Count; i++)
            {
                SubTotalPrint = SubTotalPrint + Convert.ToInt32(dataGridViewSaleOrder.Rows[i].Cells[5].Value);

            }
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------", new Font("Lucida Bright", 16, FontStyle.Bold), Brushes.Black, new Point(20, 800));
            e.Graphics.DrawString("Sub Total : "+SubTotalPrint.ToString(), new Font("Lucida Bright", 16, FontStyle.Bold), Brushes.Black, new Point(20,900));
            int TaxPrint = 0;
            for (int i = 0; i < dataGridViewSaleOrder.Rows.Count; i++)
            {
                TaxPrint = TaxPrint + Convert.ToInt32(dataGridViewSaleOrder.Rows[i].Cells[6].Value);

            }
            e.Graphics.DrawString("Tax : "+TaxPrint.ToString(), new Font("Lucida Bright", 16, FontStyle.Bold), Brushes.Black, new Point(20, 930));
            e.Graphics.DrawString("Final Amount : "+textBoxFinalCost.Text, new Font("Lucida Bright", 16, FontStyle.Bold), Brushes.Black, new Point(20, 960));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------", new Font("Lucida Bright", 16, FontStyle.Bold), Brushes.Black, new Point(20, 980));
            e.Graphics.DrawString("Amount Paid : "+textBoxPaid.Text, new Font("Lucida Bright", 16, FontStyle.Bold), Brushes.Black, new Point(20, 1000));
            e.Graphics.DrawString("Change : "+textBoxChange.Text, new Font("Lucida Bright", 16, FontStyle.Bold), Brushes.Black, new Point(20, 1030));
            //e.Graphics.DrawString("Final Cost", new Font("Lucida Bright", 16, FontStyle.Bold), Brushes.Black, new Point(640, 960));
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void textBoxInvoiceNo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}