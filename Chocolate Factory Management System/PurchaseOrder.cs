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
        public PurchaseOrder()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\hp\source\Access\Cdataa.accdb;Persist Security Info=False;";

        }

        private void PurchaseOrder_Load(object sender, EventArgs e)
        {

        }

        private void rEFRESHToolStripMenuItem_Click(object sender, EventArgs e)
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
                dataGridView1.DataSource = dt;



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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void aDDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "insert into PurchaseOrder (OrderNo,Date,ProductName,Quantity(gm),Quantity(kg),Price,Total) " +
                    "values('" + textBoxOrderNo.Text + "','" + dateTimePickerOrderDate.Text + "','" +comboBoxProductName.Text + "','" + textBoxQuantitygm.Text + "'," +
                    "'" + textBoxQuantitykg.Text + "','" + textBoxUnitPrice.Text + "','" + textBoxTotal.Text + "')";


                command.ExecuteNonQuery();
                MessageBox.Show("Data Saved Successfully");

            }
            catch (Exception ee)
            {
                MessageBox.Show("Error" + ee);
            }
            connection.Close();
        }

        private void eDITToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {

                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "update PurchaseOrder set  Date='"+dateTimePickerOrderDate.Value.Date+"',ProductName='" + comboBoxProductName.Text + "'," +
                    "Quantity(gm)='" + textBoxQuantitygm + "', Quantity(kg)='" + textBoxQuantitykg.Text + "',UnitPrice='" + textBoxUnitPrice.Text + "', " +
                    "Total='" +textBoxTotal.Text + "' where OrderNo=" + textBoxOrderNo.Text + "";
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
                string query = "delete from PurchaseOrder where OrderNo=" + textBoxOrderNo.Text + "";
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

        private void pRINTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (printPreviewDialogPO.ShowDialog() == DialogResult.OK)
            {
                printDocumentPO.Print();
            }
        }

        private void printDocumentPO_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void sEARCHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "select *from PurchaseOrder where [OrderNo] like('"+textBoxOrderNo.Text+"%')";
                //MessageBox.Show(query);
                command.CommandText = query;

                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ee)
            {
                MessageBox.Show("Enter a valid input");
            }
        }
    }
}
