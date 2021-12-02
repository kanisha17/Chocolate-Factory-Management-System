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
    public partial class FinalProductDelete : Form
    {
        private OleDbConnection connection = new OleDbConnection();
      //  OleDbCommand command;
        public FinalProductDelete()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\hp\source\Access\ChocolateFactory17.accdb;Persist Security Info=False;";

        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
           
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {

                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "delete *from ProductDetails where ProductID=" + textBoxProductID.Text + "";
                //MessageBox.Show(query);
                command.CommandText = query;

                command.ExecuteNonQuery();
                MessageBox.Show("Data Deleted Successfully");
            }
            catch
            {
                MessageBox.Show("Data Not Deleted");
            }
            connection.Close();
        }
          void resetControls()
        {
            textBoxProductID.Clear();
            textBoxPrice.Clear();
            textBoxDiscount.Clear();
            textBoxDescription.Clear();
            comboBoxreview.ResetText();
            
        }
        private void FinalProductDelete_Load(object sender, EventArgs e)
        {

        }

        private void textBoxProductID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand c1 = new OleDbCommand("select ProductName,Description,Price,Discount,Review from ProductDetails where ProductID=@param", connection);
                c1.Parameters.AddWithValue("@param",textBoxProductID.Text);
                OleDbDataReader reader1;
                reader1 = c1.ExecuteReader();
                if (reader1.Read())
                {

                    textBoxProductName.Text = reader1["ProductName"].ToString();
                    textBoxDescription.Text = reader1["Description"].ToString();
                    textBoxPrice.Text = reader1["Price"].ToString();
                    textBoxDiscount.Text = reader1["Discount"].ToString();
                    comboBoxreview.Text = reader1["Review"].ToString();
                    MessageBox.Show("Product Details Found");
                }
                else
                {
                    MessageBox.Show("Product Detils Not Found");
                }

                
                connection.Close();
            }
            catch
            {
            }
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
