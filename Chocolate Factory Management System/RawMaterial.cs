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
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
        
        }

        private void cLEARToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void pictureBoxRawMaterial_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
           
        }
        void resetControls()
        {
            textBoxRawMaterialName.Clear();
            textBoxPrice.Clear();
            textBoxDicsount.Clear();
            textBoxDescription.Clear();
            comboBoxRawMaterial.ResetText();
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                command = new OleDbCommand("insert into RawMaterialDetails(RawMaterialID,RawMaterialName,Description,Price,Discount,Review) " +
                    "values(@rid,@materialname,@desc,@price,@dis,@rev)", connection);


                command.Parameters.AddWithValue("@rid", textBoxSearch.Text);
                command.Parameters.AddWithValue("@materialname",textBoxRawMaterialName.Text);
                command.Parameters.AddWithValue("@desc",textBoxDescription.Text);
                command.Parameters.AddWithValue("@price",textBoxPrice.Text);
                command.Parameters.AddWithValue("@dis", textBoxDicsount.Text);
                command.Parameters.AddWithValue("@rev", comboBoxRawMaterial.Text);
               

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

        private void buttonDelete_Click(object sender, EventArgs e)
        {
           
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

        private void textBoxRawMaterialName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Space && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
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
    }
}
