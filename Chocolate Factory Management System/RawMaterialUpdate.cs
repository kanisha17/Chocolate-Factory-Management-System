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
    public partial class RawMaterialUpdate : Form
    {
        private OleDbConnection connection = new OleDbConnection();
       // OleDbCommand command;
        public RawMaterialUpdate()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\hp\source\Access\ChocolateFactory17.accdb;Persist Security Info=False;";

        }

        private void pictureBoxRawMaterial_Click(object sender, EventArgs e)
        {
          
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand c1 = new OleDbCommand("select RawMaterialName,Description,Price,Discount,Review from RawMaterialDetails where RawMaterialID=@param", connection);
                c1.Parameters.AddWithValue("@param", textBoxSearch.Text);
                OleDbDataReader reader1;
                reader1 = c1.ExecuteReader();
                if (reader1.Read())
                {

                    textBoxRawMaterialName.Text = reader1["RawMaterialName"].ToString();
                    textBoxDescription.Text = reader1["Description"].ToString();
                    textBoxPrice.Text = reader1["Price"].ToString();
                    textBoxDicsount.Text = reader1["Discount"].ToString();
                    comboBoxRawMaterial.Text = reader1["Review"].ToString();
                    MessageBox.Show("Raw Material Details Found");
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

        private void buttonSearch_Click(object sender, EventArgs e)
        {

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;

                string query = "update RawMaterialDetails set RawMaterialName='" + textBoxRawMaterialName.Text + "',Description='" + textBoxDescription.Text + "'," +
                    "Price='" + textBoxPrice.Text + "',Discount='" + textBoxDicsount.Text + "',Review='" + comboBoxRawMaterial.Text + "' where RawMaterialID=" + textBoxSearch.Text + "";

                MessageBox.Show(query);
                command.CommandText = query;

                command.ExecuteNonQuery();

                MessageBox.Show("Data Updated Successfully");
                resetControls();
                connection.Close();
            }
            catch
            {
                MessageBox.Show("Data Not Updated");
            }
          
           
        }
        void resetControls()
        {
            textBoxDescription.Clear();
            textBoxDicsount.Clear();
            textBoxPrice.Clear();
            textBoxRawMaterialName.Clear();
            textBoxSearch.Clear();
            comboBoxRawMaterial.ResetText();
        }
        private void RawMaterialUpdate_Load(object sender, EventArgs e)
        {

        }

        private void textBoxDicsount_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelDiscount_Click(object sender, EventArgs e)
        {

        }

        private void labelRawMaterialID_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxRawMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelReview_Click(object sender, EventArgs e)
        {

        }

        private void labelRawMaterialName_Click(object sender, EventArgs e)
        {

        }

        private void labelDescription_Click(object sender, EventArgs e)
        {

        }

        private void labelPrice_Click(object sender, EventArgs e)
        {

        }

        private void textBoxRawMaterialName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelRawMaterailDetails_Click(object sender, EventArgs e)
        {

        }

        private void textBoxSearch_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBoxDicsount_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 6 && e.KeyChar != (char)Keys.Space && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void textBoxRawMaterialName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Space && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }
    }
}
