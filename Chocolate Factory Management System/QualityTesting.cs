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
    public partial class QualityTesting : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        OleDbCommand command;
        public QualityTesting()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\hp\source\Access\ChocolateFactory17.accdb;Persist Security Info=False;";

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelFinalConclusionTest_Click(object sender, EventArgs e)
        {

        }

        private void labelTestedBy_Click(object sender, EventArgs e)
        {

        }

        private void textBoxFinalConclusion_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxTestedBy_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelNonCompliance_Click(object sender, EventArgs e)
        {

        }

        private void QualityTesting_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "select *from ProductDetails";
                command.CommandText = query;
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    comboBoxProductName.Items.Add(reader["ProductName"].ToString());
                }
                connection.Close();
            }
            catch
            {
                MessageBox.Show("Error");
            }

        }

        private void cLEARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxFinalConclusion.Clear();
            textBoxLaboratoryTesting.Clear();
            textBoxNonCompliance.Clear();
           comboBoxProductName.ResetText();
            textBoxSampleDetails.Clear();
            textBoxTestedBy.Clear();
            checkedListBoxResult.ResetText();
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
          
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void labelDate_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxProductName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxProductName_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBoxProductName.SelectedItem == null)
            {

            }
            else
            {
                try
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                    string query = "select Decription from ProductDetails where ProductName='" + comboBoxProductName.Text + "';";
                    command.CommandText = query;
                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string p = (string)reader["Description"].ToString();
                        textBoxSampleDetails.Text = p;
                        
                    }
                    connection.Close();
                }
                catch
                {
                    MessageBox.Show("Error");
                }
            }
        }
    }
}
