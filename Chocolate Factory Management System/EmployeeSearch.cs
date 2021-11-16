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
   
    public partial class EmployeeSearch : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        //OleDbCommand command;
        public EmployeeSearch()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\hp\source\Access\ChocolateFactory17.accdb;Persist Security Info=False;";
        }
        void resetControls()
        {
            textBoxEID.Clear();
            textBoxEmpName.Clear();
        }
        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand e1 = new OleDbCommand("select EID from EmployeeDetails where EID=@parm1", connection);
                e1.Parameters.AddWithValue("@parm1", textBoxEID.Text);
                OleDbDataReader reader1;
                reader1 = e1.ExecuteReader();
                if (reader1.Read())
                {
                 //   textBoxFullName.Text = reader1["CustomerName"].ToString();
                    textBoxEID.Text = reader1["EID"].ToString();

                 
                    EmployeeUpdate s1 = new EmployeeUpdate(textBoxEID.Text);

                    s1.ShowDialog();
                   // MessageBox.Show("Data Found");
                }
                else
                {
                    MessageBox.Show("Data Not Found");
                }
                connection.Close();

                resetControls();
            }
            catch
            {
                MessageBox.Show("Please Fill The Details");
            }

           // EmployeeUpdate e1 = new EmployeeUpdate();
           // e1.ShowDialog();

         
        }

        private void attendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand e1 = new OleDbCommand("select EID from EmployeeDetails where EID=@parm1", connection);
                e1.Parameters.AddWithValue("@parm1", textBoxEID.Text);
                OleDbDataReader reader1;
                reader1 = e1.ExecuteReader();
                if (reader1.Read())
                {
                    //   textBoxFullName.Text = reader1["CustomerName"].ToString();
                    textBoxEID.Text = reader1["EID"].ToString();


                   EmployeeAttendance s1 = new EmployeeAttendance(textBoxEID.Text);

                    s1.ShowDialog();
                    // MessageBox.Show("Data Found");
                }
                else
                {
                    MessageBox.Show("Data Not Found");
                }
                connection.Close();

                resetControls();
            }
            catch
            {
                MessageBox.Show("Please Fill The Details");
            }

        }

        private void salaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand e1 = new OleDbCommand("select EID from EmployeeDetails where EID=@parm1", connection);
                e1.Parameters.AddWithValue("@parm1", textBoxEID.Text);
                OleDbDataReader reader1;
                reader1 = e1.ExecuteReader();
                if (reader1.Read())
                {
                    //   textBoxFullName.Text = reader1["CustomerName"].ToString();
                    textBoxEID.Text = reader1["EID"].ToString();


                    EmployeeSalary s1 = new EmployeeSalary(textBoxEID.Text);

                    s1.ShowDialog();
                    // MessageBox.Show("Data Found");
                }
                else
                {
                    MessageBox.Show("Data Not Found");
                }
                connection.Close();

                resetControls();
            }
            catch
            {
                MessageBox.Show("Please Fill The Details");
            }
        }

        private void linkLabelNotRegistered_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Employee1 e1 = new Employee1();
            e1.ShowDialog();
        }
    }
}
