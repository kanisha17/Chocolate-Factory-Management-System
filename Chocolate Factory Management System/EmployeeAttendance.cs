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
    public partial class EmployeeAttendance : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        
        public EmployeeAttendance()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\hp\source\Access\ChocolateFactory17.accdb;Persist Security Info=False;";

        }

       

       
        private void eMPDETAILSToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

       

        private void cLEARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxEID.Clear();
            checkedListBoxMark.ResetText();
            textBoxReason.Clear();
            MessageBox.Show("Data Cleared");
            
        }

        

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

       
        private void buttonSearch_Click_1(object sender, EventArgs e)
        {
          
        }

        private void mENUToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "insert into EmployeeAttendance (EID,CurrentDate,Mark,Reason) " +
                    "values('" + textBoxEID.Text + "','" + dateTimePickerCurrentDate.Value.Date + "','" + checkedListBoxMark.Text + "','" + textBoxReason.Text + "')";


                command.ExecuteNonQuery();
                MessageBox.Show("Data Saved Successfully");

            }
            catch 
            {
                MessageBox.Show("Data Not Saved");
            }
            connection.Close();
        }
    }
}
