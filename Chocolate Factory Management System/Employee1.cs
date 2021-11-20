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
    public partial class Employee1 : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        OleDbCommand command;
        
        public Employee1()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\hp\source\Access\ChocolateFactory17.accdb;Persist Security Info=False;";
          
        }


        private void buttonClose_Click(object sender, EventArgs e)
        {
           
        }



        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("EMPLOYEE SUMMARY", new Font("Lucida Bright", 24, FontStyle.Bold), Brushes.Red, new Point(250));

            e.Graphics.DrawString("Employee ID: " + textBoxEID.Text, new Font("Lucida Bright", 18, FontStyle.Bold), Brushes.Blue, new Point(30, 120));
            e.Graphics.DrawString("Employee Name: " + textBoxEmployeeName.Text, new Font("Lucida Bright", 18, FontStyle.Bold), Brushes.Blue, new Point(30, 170));
            e.Graphics.DrawString("Employee Department: " + comboBoxDepartment.Text, new Font("Lucida Bright", 18, FontStyle.Bold), Brushes.Blue, new Point(30, 220));
            e.Graphics.DrawString("Employee DOB: " + dateTimePickerDOB.Value.Date, new Font("Lucida Bright", 18, FontStyle.Bold), Brushes.Blue, new Point(30, 270));
            e.Graphics.DrawString("Employee Gender: " + comboBoxGender.Text, new Font("Lucida Bright", 18, FontStyle.Bold), Brushes.Blue, new Point(30, 320));
            e.Graphics.DrawString("Employee Address: " + textBoxAddress.Text, new Font("Lucida Bright", 18, FontStyle.Bold), Brushes.Blue, new Point(30, 370));
            e.Graphics.DrawString("Employee Pincode: " + textBoxPincode.Text, new Font("Lucida Bright", 18, FontStyle.Bold), Brushes.Blue, new Point(30, 420));
            e.Graphics.DrawString("Employee City: " + textBoxCity.Text, new Font("Lucida Bright", 18, FontStyle.Bold), Brushes.Blue, new Point(30, 470));
            e.Graphics.DrawString("Employee State: " + textBoxState.Text, new Font("Lucida Bright", 18, FontStyle.Bold), Brushes.Blue, new Point(30, 520));
            e.Graphics.DrawString("Employee Phone: " + textBoxPhone.Text, new Font("Lucida Bright", 18, FontStyle.Bold), Brushes.Blue, new Point(30, 570));
            e.Graphics.DrawString("Employee Email: " + textBoxEmail.Text, new Font("Lucida Bright", 18, FontStyle.Bold), Brushes.Blue, new Point(30, 620));
            e.Graphics.DrawString("Employee Qualification: " + textBoxQualification.Text, new Font("Lucida Bright", 18, FontStyle.Bold), Brushes.Blue, new Point(30, 670));
            e.Graphics.DrawString("Employee Joining Date: " + dateTimePickerJoining.Value.Date, new Font("Lucida Bright", 18, FontStyle.Bold), Brushes.Blue, new Point(30, 720));

        }

        private void pRINTToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dELETEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void aDDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void eDITToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }
      
        private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    

        private void pRINTToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
         
        }

        private void mENUToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void vIEWToolStripMenuItem_Click(object sender, EventArgs e)
        {
          EmployeeSearch f2 = new EmployeeSearch();
            f2.Show();
            this.Hide();

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
           
        }

        private void rEPORTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        void getEmployeeID()
        {
            string sql;
            string query = "select EID from EmployeeDetails order by EID desc";
            connection.Open();
            OleDbCommand command = new OleDbCommand(query, connection);
            OleDbDataReader dr = command.ExecuteReader();

            if (dr.Read())
            {
                int id = int.Parse(dr[0].ToString()) + 1;
                sql = id.ToString("000");

            }
            else if (Convert.IsDBNull(dr))
            {
                sql = ("101");

            }
            else
            {
                sql = ("101");
            }

            connection.Close();
            textBoxEID.Text = sql.ToString();
        }
        private void Employee1_Load(object sender, EventArgs e)
        {
            getEmployeeID();
        }

        private void buttonADD_Click(object sender, EventArgs e)
        {
            if (textBoxPhone.Text.Length == 10 && textBoxPincode.Text.Length == 6)
            {
                try
                {
                    connection.Open();
                    command = new OleDbCommand("insert into EmployeeDetails(EID,EmployeeName,Department,DOB,Gender,Address,Pincode,City,State,PhoneNo,Email,Qualification,DateOfJoining) " +
                        "values(@eid,@employeename,@department,@dob,@gender,@address,@pincode,@city,@state,@phone,@email,@qualification,@joiningdate)", connection);
                    command.Parameters.AddWithValue("@eid", textBoxEID.Text);
                    command.Parameters.AddWithValue("@employeename", textBoxEmployeeName.Text);
                    command.Parameters.AddWithValue("@department", comboBoxDepartment.Text);
                    command.Parameters.AddWithValue("@dob", dateTimePickerDOB.Text);
                    command.Parameters.AddWithValue("@gender", comboBoxGender.Text);
                    command.Parameters.AddWithValue("@address", textBoxAddress.Text);
                    command.Parameters.AddWithValue("@pincode", textBoxPincode.Text);
                    command.Parameters.AddWithValue("@city", textBoxCity.Text);
                    command.Parameters.AddWithValue("@state", textBoxState.Text);
                    command.Parameters.AddWithValue("@phone", textBoxPhone.Text);
                    command.Parameters.AddWithValue("@email", textBoxEmail.Text);
                    command.Parameters.AddWithValue("@qualification", textBoxQualification.Text);
                    command.Parameters.AddWithValue("@joiningdate", dateTimePickerJoining.Text);

                    command.ExecuteNonQuery();

                    connection.Close();

                    MessageBox.Show("Data Saved Successfully");
                }
                catch
                {
                    MessageBox.Show("Data Not Saved".ToString());
                }
            }
            else { MessageBox.Show("Please Enter Only 10 Digit PhoneNo / 6 Digit Pincode"); }
        }

        private void buttonEDIT_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonDELETE_Click(object sender, EventArgs e)
        {
          
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
        }

        private void pRINTToolStripMenuItem_Click_2(object sender, EventArgs e)
        {

            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void textBoxEmployeeName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Space && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private void textBoxCity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Space && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private void textBoxState_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Space && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private void textBoxPincode_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 6 && e.KeyChar != (char)Keys.Space && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void textBoxPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 10 && e.KeyChar != (char)Keys.Space && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
