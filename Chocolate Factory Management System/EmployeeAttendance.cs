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
           checkedListBoxPermission.ResetText();
            textBoxReason.Clear();
            textBoxSearch.Clear();
            
        }

        

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

       
        private void buttonSearch_Click_1(object sender, EventArgs e)
        {
            connection.Open();
            OleDbCommand c1 = new OleDbCommand("select CurrentDate,Mark,Permission,Reason from EmployeeAttendance where AttendanceID=@parm1", connection);
            c1.Parameters.AddWithValue("@parm1",textBoxSearch.Text);
            OleDbDataReader reader1;
            reader1 = c1.ExecuteReader();
            if (reader1.Read())
            {
                dateTimePickerCurrentDate.Text = reader1["CurrentDate"].ToString();
                checkedListBoxMark.Text = reader1["Mark"].ToString();
                checkedListBoxPermission.Text = reader1["Permission"].ToString();
                textBoxReason.Text = reader1["Reason"].ToString();

            }
            else
            {
                MessageBox.Show("No Data Found");
            }
            connection.Close();
        }

        private void mENUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "insert into EmployeeAttendance (EID,CurrentDate,Mark,Permission,Reason) " +
                    "values('" + textBoxEID.Text + "','" + dateTimePickerCurrentDate.Value.Date + "','" + checkedListBoxMark.Text + "','" + checkedListBoxPermission.Text + "','" + textBoxReason.Text + "')";


                command.ExecuteNonQuery();
                MessageBox.Show("Data Saved Successfully");

            }
            catch (Exception ee)
            {
                MessageBox.Show("Error" + ee);
            }
            connection.Close();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
