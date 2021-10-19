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
       
      

        private OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\hp\source\Access\Cdataa.accdb");
        OleDbCommand command;


        public PurchaseOrder()
        {
            InitializeComponent();

        }

        double qty, price, gst, tot, a, b;
        private void button2_Click(object sender, EventArgs e)
        {
           
            textBoxQuantitykg.Clear();
            textBoxSearch.Clear();
            textBoxSID.Clear();
            textBoxTotal.Clear();
            textBoxUnitPrice.Clear();
            textBoxGST.Clear();
            comboBoxProductName.ResetText();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                command = new OleDbCommand("insert into PO(SID,PDate,ProductName,PQuantity,UnitPrice,GST,PTotal) values(@sid,@pdate,@productname,@qty,@unitprice,@gst,@ptotal)", connection);
                command.Parameters.AddWithValue("@sid", textBoxSID.Text);
                command.Parameters.AddWithValue("@pdate", dateTimePickerOrderDate.Text);
                command.Parameters.AddWithValue("@productname", comboBoxProductName.Text);
                command.Parameters.AddWithValue("@qty", textBoxQuantitykg.Text);
                command.Parameters.AddWithValue("@unitprice", textBoxUnitPrice.Text);
                command.Parameters.AddWithValue("@gst", textBoxGST.Text);
                command.Parameters.AddWithValue("@ptotal", textBoxTotal.Text);

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
                string query = "update PO set SID='"+textBoxSID.Text+"',PDate='"+dateTimePickerOrderDate.Value.Date+"',ProductName='" + comboBoxProductName.Text + "',PQuantity='"+textBoxQuantitykg.Text + "'," +
                    "UnitPrice='" + textBoxUnitPrice.Text + "',GST='" + textBoxGST.Text + "',PTotal='" + textBoxTotal.Text + "' where OrderNo=" + textBoxSearch.Text + "";
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
                string query = "delete from PO where OrderNo=" + textBoxSearch.Text + "";
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

        private void buttonEXIT_Click(object sender, EventArgs e)
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
            gst = int.Parse(textBoxGST.Text);

            if (qty>=0 && price>=0)
            {
                a = qty * price;
                textBoxTotal.Text = a.ToString();

                b = a * gst/100;
                textBoxTotal.Text = b.ToString();

                tot = a + b;
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
            OleDbCommand c1 = new OleDbCommand("select SID,PDate,ProductName,PQuantity,UnitPrice,GST,PTotal from PO where OrderNo=@parm1", connection);
            c1.Parameters.AddWithValue("@parm1", textBoxSearch.Text);
            OleDbDataReader reader1;
            reader1 = c1.ExecuteReader();
            if (reader1.Read())
            {
                textBoxSID.Text = reader1["SID"].ToString();
                dateTimePickerOrderDate.Text = reader1["PDate"].ToString();
                comboBoxProductName.Text = reader1["ProductName"].ToString();
                textBoxQuantitykg.Text = reader1["PQuantity"].ToString();
                textBoxUnitPrice.Text = reader1["UnitPrice"].ToString();
                textBoxGST.Text = reader1["GST"].ToString();
                textBoxTotal.Text = reader1["PTotal"].ToString();
            }
            else
            {
                MessageBox.Show("No Data Found");
            }
            connection.Close();
        }

        private void buttonLoadTable_Click(object sender, EventArgs e)
        {
            try
            {

                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "select *from PO";
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
    }
}
