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
    public partial class Package : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        OleDbCommand command;
        public Package()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\hp\source\Access\ChocolateFactory17.accdb;Persist Security Info=False;";

        }

        private void Package_Load(object sender, EventArgs e)
        {

        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                command = new OleDbCommand("insert into Packaging(NewStock,PackagingDate) values(@newstock,@packdate)", connection);


                command.Parameters.AddWithValue("@newstock", textBoxNewStock.Text);
                command.Parameters.AddWithValue("@packdate", dateTimePickerPackage.Text);

                command.ExecuteNonQuery();

                connection.Close();
                MessageBox.Show("Data Saved Successfully");
            }
            catch
            {
                MessageBox.Show("Data Not Saved".ToString());
            }
        }

        private void cLEARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxNewStock.Clear();
            textBoxProductID.Clear();
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }
    }
}
