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
    public partial class ProductDetails : Form
    {

        private OleDbConnection connection = new OleDbConnection();
        OleDbCommand command;
        public ProductDetails()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\hp\source\Access\ChocolateFactory.accdb;Persist Security Info=False;";

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
            try
            {
                connection.Open();
                string location = "C:\\Users\\hp\\source\\ProductImages";
                string path = Path.Combine(location,textBoxProductName.Text+".jpg");
                command = new OleDbCommand("insert into ProductDetails(ProductName,Description,Price,Review,ProductImage) " +
                    "values(@productname,description,price,review,productimage)", connection);

                command.Parameters.AddWithValue("@productname", textBoxProductName.Text);
                command.Parameters.AddWithValue("@description", textBoxDescription.Text);
                command.Parameters.AddWithValue("@price",textBoxPrice.Text);
                command.Parameters.AddWithValue("@review", textBoxReview.Text);
                command.Parameters.AddWithValue("@productimage", path);

                Image a = pictureBoxProductDetail.Image;
      
                command.ExecuteNonQuery();
                a.Save(path);
                connection.Close();
                MessageBox.Show("Saved Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void pictureBoxProductDetail_Click(object sender, EventArgs e)
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

        private void buttonSEARCH_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                command = new OleDbCommand("select *from ProductDetails where ProductID=@param", connection);
                command.Parameters.AddWithValue("@param", int.Parse(textBoxSEARCH.Text));
                OleDbDataReader rd = command.ExecuteReader();
                while (rd.Read())
                {
                    textBoxProductName.Text = rd.GetValue(1).ToString();
                    textBoxDescription.Text = rd.GetValue(2).ToString();
                    textBoxPrice.Text = rd.GetValue(3).ToString();
                    textBoxReview.Text = rd.GetValue(4).ToString();

                    string path = Path.Combine(rd.GetValue(5).ToString());
                    pictureBoxProductDetail.Image = Image.FromFile(path);
                    MessageBox.Show("Product Details Found");
                }
                connection.Close();
               // MessageBox.Show("Product Details Found");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Product Details Not Found" +ex);
            }
        }

        private void eDITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "update ProductDetails set ProductName='" + textBoxProductName.Text + "',Description='" + textBoxDescription.Text + "'," +
                    "Price='" + textBoxPrice.Text + "',Review='" + textBoxReview.Text + "' where ProductID=" + textBoxSEARCH.Text + "";
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
                string query = "delete from ProductDetails where ProductID=" + textBoxSEARCH.Text + "";
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
            textBoxSEARCH.Clear();
            textBoxReview.Clear();
            textBoxProductName.Clear();
            textBoxPrice.Clear();
            textBoxDescription.Clear();
        }
    }
}
