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
    public partial class ProductDetails : Form
    {

        private OleDbConnection connection = new OleDbConnection();
        OleDbCommand command;
        public ProductDetails()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\hp\source\Access\ChocolateFactory17.accdb;Persist Security Info=False;";

        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void aDDToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aDDToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
               
           
        }

        private void pictureBoxProductDetail_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonSEARCH_Click(object sender, EventArgs e)
        {
            
        }

        private void eDITToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void dELETEToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
        void resetControls()
        {
            textBoxDiscount.Clear();
        
            comboBoxreview.ResetText();
            textBoxProductName.Clear();
            textBoxPrice.Clear();
            textBoxDescription.Clear();
        }

        private void buttonADD_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                command = new OleDbCommand("insert into ProductDetails(ProductID,ProductName,Description,Price,Discount,Review) " +
                    "values(@rid,@materialname,@desc,@price,@dis,@rev)", connection);


                command.Parameters.AddWithValue("@rid",textBoxProductID.Text);
                command.Parameters.AddWithValue("@materialname", textBoxProductName.Text);
                command.Parameters.AddWithValue("@desc", textBoxDescription.Text);
                command.Parameters.AddWithValue("@price", textBoxPrice.Text);
                command.Parameters.AddWithValue("@dis",textBoxDiscount.Text);
                command.Parameters.AddWithValue("@rev", comboBoxreview.Text);


                command.ExecuteNonQuery();
                resetControls();
                connection.Close();

                MessageBox.Show("Data Saved Successfully");
                getInvoiceID();

            }
            catch
            {
                MessageBox.Show("Data Not Saved".ToString());
            }
        }

        private void buttonEDIT_Click(object sender, EventArgs e)
        {

        }

        private void ProductDetails_Load(object sender, EventArgs e)
        {
            getInvoiceID();
            

        }

        void getInvoiceID()
        {

            // command.connection.Open();
            string sql;
            string query = "select ProductID from ProductDetails order by ProductID desc";
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
            textBoxProductID.Text = sql.ToString();

        }

        private void textBoxProductID_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxProductID_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 6 && e.KeyChar != (char)Keys.Space && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void textBoxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 6 && e.KeyChar != (char)Keys.Space && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void textBoxDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 6 && e.KeyChar != (char)Keys.Space && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void textBoxProductName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Space && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }
    }

}
