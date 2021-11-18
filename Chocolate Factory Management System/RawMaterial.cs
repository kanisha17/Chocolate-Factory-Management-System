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
using System.IO;

namespace Chocolate_Factory_Management_System
{
    public partial class RawMaterial : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        OleDbCommand command;
        public RawMaterial()
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

        private void cLEARToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void pictureBoxRawMaterial_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            PictureBox p = sender as PictureBox;
            if (p != null)
            {
                open.Filter = "(*.jpg;*.jpeg,*.png) | *.jpg;*.jpeg,*.png";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    p.Image = Image.FromFile(open.FileName);
                }
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string location = "C:\\Users\\hp\\source\\RawMaterial";
                string path = Path.Combine(location, textBoxRawMaterialName.Text + ".jpg");
                command = new OleDbCommand("insert into RawMaterialDetails(RawMaterialName,Description,Price,Review,RawMaterialImage) " +
                    "values(@productname,description,price,review,productimage)", connection);

                command.Parameters.AddWithValue("@productname", textBoxRawMaterialName.Text);
                command.Parameters.AddWithValue("@description", textBoxDescription.Text);
                command.Parameters.AddWithValue("@price", textBoxPrice.Text);
                command.Parameters.AddWithValue("@review", comboBoxRawMaterial.Text);
                command.Parameters.AddWithValue("@productimage", path);

                Image a = pictureBoxRawMaterial.Image;

                command.ExecuteNonQuery();
                a.Save(path);
                connection.Close();
                MessageBox.Show("Data Saved Successfully");
            }
            catch
            {
                MessageBox.Show("Data Not Saved");
            }
        }

        private void buttonEDIT_Click(object sender, EventArgs e)
        {
            try
            {

                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
             
                string query = "update RawMaterialDetails set RawMaterialName='" +textBoxRawMaterialName.Text + "',Description='" + textBoxDescription.Text + "'," +
                    "Price='" + textBoxPrice.Text + "',Discount='"+textBoxDicsount.Text+"',Review='" + comboBoxRawMaterial.Text + "' where RawMaterialID=" + textBoxSearch.Text + "";
               
                MessageBox.Show(query);
                command.CommandText = query;

                command.ExecuteNonQuery();
                
                MessageBox.Show("Data Updated Successfully");
            }
            catch 
            {
                MessageBox.Show("Data Not Updated");
            }
            connection.Close();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {

                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "delete from RawMaterialDetails where RawMaterialID=" + textBoxSearch.Text + "";
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
        void getInvoiceID()
        {

            // command.connection.Open();
            string sql;
            string query = "select RawMaterialID from RawMaterialDetails order by RawMaterialID desc";
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
            textBoxSearch.Text = sql.ToString();

        }
        private void RawMaterial_Load(object sender, EventArgs e)
        {
            getInvoiceID();
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

        private void labelRawMaterailDetails_Click(object sender, EventArgs e)
        {

        }

        private void textBoxDicsount_TextChanged(object sender, EventArgs e)
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

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
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
    }
}
