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
          
        }
        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBoxEID.Text.Length == 3)
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

                        this.Hide();
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
            }
            else { MessageBox.Show("Please Enter Only 3 Digit ID"); }
        }

        private void attendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBoxEID.Text.Length == 3)
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

                        this.Hide();
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
            else { MessageBox.Show("Please Enter Only 3 Digit EID"); };
        }

        private void salaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBoxEID.Text.Length == 3)
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

                        this.Hide();
                        EmployeeSalary2 s1 = new EmployeeSalary2(textBoxEID.Text);
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
            else { MessageBox.Show("Please Enter Only 3 Digit EID"); }
        }

        private void linkLabelNotRegistered_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Employee1 e1 = new Employee1();
            e1.ShowDialog();
        }

        private void EmployeeSearch_Load(object sender, EventArgs e)
        {

        }

        private void textBoxEID_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 6 && e.KeyChar != (char)Keys.Space && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }
    }
}
