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
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\hp\source\Access\Cdataa.accdb;Persist Security Info=False;";

        }

       
        private void SalesOrder_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewSaleOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonLoadTable_Click(object sender, EventArgs e)
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

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            connection.Open();
            OleDbCommand c1 = new OleDbCommand("select CID,SalesDate,ItemName,SQuantity(gm),SQuantity(kg),SDiscount,GST,SUnitPrice,STotal,SBalance,DueDate from SalesOrder where OrderNo=@parm1", connection);
            c1.Parameters.AddWithValue("@parm1", textBoxSearch.Text);
            OleDbDataReader reader1;
            reader1 = c1.ExecuteReader();
            if (reader1.Read())
            {
                textBoxCID.Text = reader1["CID"].ToString();
                dateTimePickerSDate.Text = reader1["SalesDate"].ToString();
                comboBoxItemName.Text = reader1["ItemName"].ToString();
                textBoxQuantitygm.Text = reader1["SQuantit(gm)"].ToString();
                textBoxQuantitykg.Text = reader1["SQuantity(kg)"].ToString();
                textBoxDiscount.Text = reader1["SDiscount"].ToString();
                textBoxGST.Text = reader1["GST"].ToString();
                textBoxUnitPrice.Text = reader1["UnitPrice"].ToString();
                textBoxTotal.Text = reader1["STotal"].ToString();
                textBoxBalance.Text = reader1["SBalance"].ToString();
                dateTimePickerDueDate.Text = reader1["DueDate"].ToString();
            }
            else
            {
                MessageBox.Show("No Data Found");
            }
            connection.Close();
        }
    }
}
