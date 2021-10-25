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


        public PurchaseOrder()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\hp\source\Access\ChocolateFactory17.accdb;Persist Security Info=False;";
        }

        double qty, price, dis, tot, a, b;

        private void buttonEDIT_Click(object sender, EventArgs e)
        {
            try
            {

                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "update PurchaseOrder set SupplierID='"+textBoxSID.Text+"',PurchaseDate='"+dateTimePickerOrderDate.Value.Date+"'," +
                    "ProductName='" + comboBoxProductName.Text + "',Quantity='"+textBoxQuantitykg.Text + "'," +
                    "Discount='" + textBoxDiscount.Text + "',UnitPrice='" + textBoxUnitPrice.Text + "',Total='" + textBoxTotal.Text + "'," +
                    "Paid='"+textBoxPaid.Text+"',Balance='"+textBoxBalance.Text+"',DueDate='"+dateTimePickerDueDate.Value.Date+"' where POrderNo=" + textBoxSearch.Text + "";
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

        private void aDDToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                connection.Open();
                command = new OleDbCommand("insert into PurchaseOrder(SupplierID,PurchaseDate,ProductName,Quantity,Discount,UnitPrice,Total,Paid,Balance,DueDate) " +
                    "values(@phoneno,@pdate,@productname,@qty,@dis,@unitprice,@ptotal,@paid,@balance,@duedate)", connection);
                command.Parameters.AddWithValue("@phoneno", textBoxSID.Text);
                command.Parameters.AddWithValue("@pdate", dateTimePickerOrderDate.Text);
                command.Parameters.AddWithValue("@productname", comboBoxProductName.Text);
                command.Parameters.AddWithValue("@qty", textBoxQuantitykg.Text);
                command.Parameters.AddWithValue("@dis", textBoxDiscount.Text);
                command.Parameters.AddWithValue("@unitprice", textBoxUnitPrice.Text);
                command.Parameters.AddWithValue("@ptotal", textBoxTotal.Text);
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

        private void eDITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "update PurchaseOrder set SupplierID='" + textBoxSID.Text + "',PurchaseDate='" + dateTimePickerOrderDate.Value.Date + "'," +
                    "ProductName='" + comboBoxProductName.Text + "',Quantity='" + textBoxQuantitykg.Text + "'," +
                    "Discount='" + textBoxDiscount.Text + "',UnitPrice='" + textBoxUnitPrice.Text + "',Total='" + textBoxTotal.Text + "',Paid='"+textBoxPaid.Text+"'," +
                    "Balance='"+textBoxBalance.Text+"',DueDate='"+dateTimePickerDueDate.Value.Date+"' where POrderNo=" + textBoxSearch.Text + "";
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

        private void dELETEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "delete from PurchaseOrder where POrderNo=" + textBoxSearch.Text + "";
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

        private void cLEARToolStripMenuItem_Click(object sender, EventArgs e)
        {

            textBoxQuantitykg.Clear();
            textBoxSearch.Clear();
           
            textBoxTotal.Clear();
            textBoxUnitPrice.Clear();
            textBoxDiscount.Clear();
            comboBoxProductName.ResetText();
            textBoxPaid.Clear();
            textBoxBalance.Clear();
        }

        private void labelPaid_Click(object sender, EventArgs e)
        {

        }

        private void lOADTABLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "select *from PurchaseOrder";
                //MessageBox.Show(query);
                command.CommandText = query;

                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewPurchaseOrder.DataSource = dt;



                connection.Close();
            }
            catch (Exception ef)
            {
                MessageBox.Show("Error" + ef);
            }
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }
        private void PurchaseOrder_Load(object sender, EventArgs e)
        {

        }

        private void buttonCALCULATE_Click(object sender, EventArgs e)
        {
            price = int.Parse(textBoxUnitPrice.Text);   
            qty = int.Parse(textBoxQuantitykg.Text);
            dis = int.Parse(textBoxDiscount.Text);

            if (qty>=0 && price>=0)
            {
                a = qty * price;
                textBoxTotal.Text = a.ToString();

                b = a *dis /100;
                textBoxTotal.Text = b.ToString();

                tot = a - b;
                textBoxTotal.Text = tot.ToString();
            }
            else
            {
                MessageBox.Show("Enter a valid input");
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            connection.Open();
            OleDbCommand c1 = new OleDbCommand("select SupplierID,PurchaseDate,ProductName,Quantity,Discount,UnitPrice,Total,Paid,Balance,DueDate from PurchaseOrder where POrderNo=@parm1", connection);
            c1.Parameters.AddWithValue("@parm1", textBoxSearch.Text);
            OleDbDataReader reader1;
            reader1 = c1.ExecuteReader();
            if (reader1.Read())
            {
                textBoxSID.Text = reader1["SupplierID"].ToString();
                dateTimePickerOrderDate.Text = reader1["PurchaseDate"].ToString();
                comboBoxProductName.Text = reader1["ProductName"].ToString();
                textBoxQuantitykg.Text = reader1["Quantity"].ToString();
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

        private void buttonLoadTable_Click(object sender, EventArgs e)
        {
           
        }
    }
}
