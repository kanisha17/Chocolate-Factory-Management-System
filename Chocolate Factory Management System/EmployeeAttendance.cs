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
        
        public EmployeeAttendance(string str3)
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\hp\source\Access\ChocolateFactory17.accdb;Persist Security Info=False;";
            textBoxEID.Text = str3;
        }

       

       
        private void eMPDETAILSToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        void resetControls()
        {
            textBoxEID.Clear();
            textBoxEmpName.Clear();
            checkedListBoxMark.ResetText();
            textBoxReason.Clear();
        }

        private void cLEARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
           
            
        }

        

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeSearch f2 = new EmployeeSearch();
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
                command.CommandText = "insert into EmployeeAttendance (EID,EmployeeName,CurrentDate,Mark,Reason) " +
                    "values('" + textBoxEID.Text + "','"+textBoxEmpName.Text+"','" + dateTimePickerCurrentDate.Value.Date + "','" + checkedListBoxMark.Text + "','" + textBoxReason.Text + "')";


                command.ExecuteNonQuery();
                resetControls();
                MessageBox.Show("Data Saved Successfully");

                EmployeeSearch s1 = new EmployeeSearch();
                s1.ShowDialog();
            }
            catch 
            {
                MessageBox.Show("Data Not Saved");
            }
            connection.Close();
        }

        private void EmployeeAttendance_Load(object sender, EventArgs e)
        {
            connection.Open();
            OleDbCommand c1 = new OleDbCommand("select EID,EmployeeName from EmployeeDetails where EID=@param", connection);
            c1.Parameters.AddWithValue("@param", textBoxEID.Text);
            OleDbDataReader reader1;
            reader1 = c1.ExecuteReader();
            if (reader1.Read())
            {
                textBoxEID.Text = reader1["EID"].ToString();
                textBoxEmpName.Text = reader1["EmployeeName"].ToString();
            }
            else
            {
                MessageBox.Show("No Data Found");
            }
            connection.Close();
        }
    }
}
