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
        public SalesOrder()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\hp\source\Access\ChocolateFactory17.accdb;Persist Security Info=False;";

        }

        double price, qty, tot, dis, a, b;
        private void SalesOrder_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewSaleOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonLoadTable_Click(object sender, EventArgs e)
        {
          
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            connection.Open();
            OleDbCommand c1 = new OleDbCommand("select CustomerID,SalesDate,ItemName,Quantity,Discount,UnitPrice,Total,Paid,Balance,DueDate from SalesOrder where SOrderNo=@parm1", connection);
            c1.Parameters.AddWithValue("@parm1", textBoxSearch.Text);
            OleDbDataReader reader1;
            reader1 = c1.ExecuteReader();
            if (reader1.Read())
            {
                textBoxCID.Text = reader1["CustomerID"].ToString();
                dateTimePickerSDate.Text = reader1["SalesDate"].ToString();
                comboBoxItemName.Text = reader1["ItemName"].ToString();
                textBoxQuantity.Text = reader1["Quantity"].ToString();
                textBoxDiscount.Text = reader1["Discount"].ToString();
                textBoxUnitPrice.Text = reader1["UnitPrice"].ToString();
                textBoxTotal.Text = reader1["Total"].ToString();
                textBoxPaid.Text = reader1["Paid"].ToString();
                textBoxBalance.Text = reader1["Balance"].ToString();
                dateTimePickerDueDate.Text = reader1["DueDate"].ToString();
            }
            else
            {
                MessageBox.Show("No Data Found");
            }
            connection.Close();
        }

        private void textBoxBalance_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dELETEToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void lOADTABLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "select *from SalesOrder";
                //MessageBox.Show(query);
                command.CommandText = query;

                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewSaleOrder.DataSource = dt;



                connection.Close();
            }
            catch (Exception ef)
            {
                MessageBox.Show("Error" + ef);
            }
        }

        private void rECEIPTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerSalesOrder s2 = new CustomerSalesOrder();
            s2.ShowDialog();
        }

        private void buttonADD_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                command = new OleDbCommand("insert into SalesOrder(CustomerID,SalesDate,ItemName,Quantity,Discount,UnitPrice,Total,Paid,Balance,DueDate) " +
                    "values(@cid,@salesdate,@itemname,@qty,@dis,@unitprice,@stotal,@paid,@balance,@duedate)", connection);
                command.Parameters.AddWithValue("@cid", textBoxCID.Text);
                command.Parameters.AddWithValue("@salesdate", dateTimePickerSDate.Text);
                command.Parameters.AddWithValue("@itemname", comboBoxItemName.Text);
                command.Parameters.AddWithValue("@qty", textBoxQuantity.Text);
                command.Parameters.AddWithValue("@dis", textBoxDiscount.Text);
                command.Parameters.AddWithValue("@unitprice", textBoxUnitPrice.Text);
                command.Parameters.AddWithValue("@stotal", textBoxTotal.Text);
                command.Parameters.AddWithValue("@paid", textBoxPaid.Text);
                command.Parameters.AddWithValue("@balance", textBoxBalance.Text);
                command.Parameters.AddWithValue("@duedate", dateTimePickerDueDate.Text);

                command.ExecuteNonQuery();

                connection.Close();
                MessageBox.Show("Saved Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void buttonEDIT_Click(object sender, EventArgs e)
        {
            try
            {

                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "update SalesOrder set CustomerID='" + textBoxCID.Text + "',SalesDate='" + dateTimePickerSDate.Value.Date + "'," +
                    "ItemName='" + comboBoxItemName.Text + "',Quantity='" + textBoxQuantity.Text + "',Discount='" + textBoxDiscount.Text + "'," +
                    "UnitPrice='" + textBoxUnitPrice.Text + "',Total='" + textBoxTotal.Text + "',Paid='" + textBoxPaid.Text + "',Balance='" + textBoxBalance.Text + "'," +
                    "DueDate='" + dateTimePickerDueDate.Value.Date + "' where SOrderNo=" + textBoxSearch.Text + "";
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

        private void buttonDELETE_Click(object sender, EventArgs e)
        {
            try
            {

                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "delete from SalesOrder where SOrderNo=" + textBoxSearch.Text + "";
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

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            price = int.Parse(textBoxUnitPrice.Text);
            qty = int.Parse(textBoxQuantity.Text);
            dis = int.Parse(textBoxDiscount.Text);

            if (qty >= 0 && price >= 0)
            {
                a= qty * price;
                textBoxTotal.Text = a.ToString();

                b= a * dis / 100;
                textBoxTotal.Text = b.ToString();

                tot = a - b;
                textBoxTotal.Text = tot.ToString();
            }
            else
            {
                MessageBox.Show("Enter a valid input");
            }

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
            textBoxBalance.Clear();
           
            textBoxDiscount.Clear();
            textBoxQuantity.Clear();
            textBoxSearch.Clear();
            textBoxTotal.Clear();
            textBoxUnitPrice.Clear();
            textBoxPaid.Clear();
            comboBoxItemName.ResetText();
          
        }

        private void eDITToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
    }
}
