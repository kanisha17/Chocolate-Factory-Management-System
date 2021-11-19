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
    public partial class RawMaterialDelete : Form
    {
        private OleDbConnection connection = new OleDbConnection();
      //  OleDbCommand command;
        public RawMaterialDelete()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\hp\source\Access\ChocolateFactory17.accdb;Persist Security Info=False;";

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {

                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "delete *from RawMaterialDetails where RawMaterialID=" +textBoxSearch.Text + "";
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
            textBoxSearch.Clear();
            textBoxPrice.Clear();
            textBoxDicsount.Clear();
            textBoxDescription.Clear();
            comboBoxRawMaterial.ResetText();
            
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
            { }
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }
    }
}
