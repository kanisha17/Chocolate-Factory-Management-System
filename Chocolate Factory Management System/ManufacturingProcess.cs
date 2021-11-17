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
    public partial class ManufacturingProcess : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        OleDbCommand command;

        public ManufacturingProcess()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\hp\source\Access\ChocolateFactory17.accdb;Persist Security Info=False;";

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void ManufacturingProcess_Load(object sender, EventArgs e)
        {

        }

        private void buttonSEARCH_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                command = new OleDbCommand("select ProductImage from ProductDetails where ProductID=@param", connection);
                command.Parameters.AddWithValue("@param", int.Parse(textBoxSEARCH.Text));
                OleDbDataReader rd = command.ExecuteReader();
                while (rd.Read())
                {
            
                    string path = Path.Combine(rd.GetValue(1).ToString());
                    pictureBox1.Image = Image.FromFile(path);
                   // textBoxProductName.Text = rd.GetValue(2).ToString();
                    //MessageBox.Show("Raw Material Details Found");
                }
                connection.Close();
                // MessageBox.Show("Product Details Found");
            }
            catch
            {
                MessageBox.Show("Details Not Found");
            }

            int a = 1;
            int b = 2;
            int c = 3;
            int d = 4;
            int e1 = 5;
            int f = 6;
            int g = 7;
            try
            {

                int search = Convert.ToInt32(textBoxSEARCH.Text);
                if (search == c)
                {
                    textBoxFermenting.BackColor = System.Drawing.Color.Red;
                }
                else if (search == e1)
                {
                    textBoxDrying.BackColor = System.Drawing.Color.Red;
                }
                else if (search == a)
                {
                    textBoxRoasting.BackColor = System.Drawing.Color.Red;
                }
                else if (search == d)
                {
                    textBoxCracking.BackColor = System.Drawing.Color.Red;
                }
                else if (search == f)
                {
                    textBoxGrinding.BackColor = System.Drawing.Color.Red;
                }
                else if (search == c)
                {
                    textBoxTempering.BackColor = System.Drawing.Color.Red;
                }
                else if (search == g)
                {
                    textBoxMoulding.BackColor = System.Drawing.Color.Red;
                }
                else
                {
                    textBoxWrapping.BackColor = System.Drawing.Color.Red;
                }
               
            }
            catch
            {
                MessageBox.Show("Enter a valid input");
            }
        }
        void resetControls()
        {
            textBoxWrapping.BackColor = System.Drawing.Color.White;
            textBoxTempering.BackColor = System.Drawing.Color.White;
            textBoxRoasting.BackColor = System.Drawing.Color.White;
            textBoxMoulding.BackColor = System.Drawing.Color.White;
            textBoxGrinding.BackColor = System.Drawing.Color.White;
            textBoxFermenting.BackColor = System.Drawing.Color.White;
            textBoxDrying.BackColor = System.Drawing.Color.White;
            textBoxCracking.BackColor = System.Drawing.Color.White;
        }

        private void textBoxFermenting_Leave(object sender, EventArgs e)
        {
           
        }

        private void textBoxSEARCH_Leave(object sender, EventArgs e)
        {
            resetControls();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
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
    }
}
