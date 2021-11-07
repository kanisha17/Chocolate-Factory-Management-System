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
            textBoxSearch.Clear();
            textBoxRawMaterialName.Clear();
            textBoxPrice.Clear();
            textBoxDescription.Clear();
            comboBoxRawMaterial.ResetText();
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
            try
            {
                connection.Open();
                command = new OleDbCommand("select *from RawMaterialDetails where RawMaterialID=@param", connection);
                command.Parameters.AddWithValue("@param", int.Parse(textBoxSearch.Text));
                OleDbDataReader rd = command.ExecuteReader();
                while (rd.Read())
                {
                    textBoxRawMaterialName.Text = rd.GetValue(1).ToString();
                    textBoxDescription.Text = rd.GetValue(2).ToString();
                    textBoxPrice.Text = rd.GetValue(3).ToString();
                    comboBoxRawMaterial.Text = rd.GetValue(4).ToString();

                    string path = Path.Combine(rd.GetValue(5).ToString());
                    pictureBoxRawMaterial.Image = Image.FromFile(path);
                    MessageBox.Show("Product Details Found");
                }
                connection.Close();
                // MessageBox.Show("Product Details Found");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Product Details Not Found" + ex);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
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
            MessageBox.Show("Saved Successfully");
        }

        private void buttonEDIT_Click(object sender, EventArgs e)
        {
            try
            {

                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "update RawMaterialDetails set RawMaterialName='" +textBoxRawMaterialName.Text + "',Description='" + textBoxDescription.Text + "'," +
                    "Price='" + textBoxPrice.Text + "',Review='" + comboBoxRawMaterial.Text + "' where RawMaterialID=" + textBoxSearch.Text + "";
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
            catch (Exception ef)
            {
                MessageBox.Show("Error" + ef);
            }
            connection.Close();
        }
    }
}
