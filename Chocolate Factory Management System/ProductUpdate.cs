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
    public partial class ProductUpdate : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        OleDbCommand command;
        public ProductUpdate()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\hp\source\Access\ChocolateFactory17.accdb;Persist Security Info=False;";

        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void pictureBoxProductDetail_Click(object sender, EventArgs e)
        {

        }
        void resetControls()
        {
            textBoxProductID.Clear();
            textBoxDiscount.Clear();
            comboBoxreview.ResetText();
            textBoxProductName.Clear();
            textBoxPrice.Clear();
            textBoxDescription.Clear();
        }
        private void ProductUpdate_Load(object sender, EventArgs e)
        {
          
           
        }

     
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;

                string query = "update ProductDetails set ProductName='" + textBoxProductName.Text + "',Description='" + textBoxDescription.Text + "'," +
                    "Price='" + textBoxPrice.Text + "',Discount='" + textBoxDiscount.Text + "',Review='" + comboBoxreview.Text + "' where ProductID=" +textBoxProductID.Text + "";

                MessageBox.Show(query);
                command.CommandText = query;

                command.ExecuteNonQuery();

                MessageBox.Show("Data Updated Successfully");
                resetControls();
                
            }
            catch
            {
                MessageBox.Show("Data Not Updated");
            }
            connection.Close();

        }

        private void textBoxProductID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand c1 = new OleDbCommand("select ProductName,Description,Price,Discount,Review from ProductDetails where ProductID=@param", connection);
                c1.Parameters.AddWithValue("@param", textBoxProductID.Text);
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

                }
                connection.Close();
            }
            catch
            {

            }


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
           
 
        }

        private void comboBoxProductName_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}

        
    



