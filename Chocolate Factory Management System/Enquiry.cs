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
    public partial class Enquiry : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        OleDbCommand command;
        public Enquiry()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\hp\source\Access\ChocolateFactory.accdb;Persist Security Info=False;";
        }

        private void textBoxPhoneNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSUBMIT_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                command = new OleDbCommand("insert into Enquiry(FullName,Address,PhoneNo,Email,Product,EDate) " +
                    "values(@fullname,@address,@phoneno,@email,@product,@edate)", connection);
                command.Parameters.AddWithValue("@fullname", textBoxName.Text);
                command.Parameters.AddWithValue("@address", textBoxAddress.Text);
                command.Parameters.AddWithValue("@phoneno", textBoxPhoneNo.Text);
                command.Parameters.AddWithValue("@email", textBoxEmail.Text);
                command.Parameters.AddWithValue("@product", comboBoxProduct.Text);
                command.Parameters.AddWithValue("@edate", dateTimePickerDate.Text);  

                command.ExecuteNonQuery();

                connection.Close();
                MessageBox.Show("Saved Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cLEARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxAddress.Clear();
            textBoxEmail.Clear();
            textBoxName.Clear();
            textBoxPhoneNo.Clear();
            comboBoxProduct.ResetText();
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }
    }
}
