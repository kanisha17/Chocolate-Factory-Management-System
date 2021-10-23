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
            Close();
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
            try
            {

                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "delete from EmployeeDetails where EID=" + textBoxEID.Text + "";
                //MessageBox.Show(query);
                command.CommandText = query;

                command.ExecuteNonQuery();
                MessageBox.Show("Data Deleted Successfully");
            }
            catch (Exception ef)
            {
                MessageBox.Show("Error" + ef);
            }
            connection.Close();
        }

        private void aDDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                command = new OleDbCommand("insert into EmployeeDetails(EID,EmployeeName,Department,DOB,Gender,Address,Pincode,City,State,Phone,Email,Qualification,DateOfJoining) " +
                    "values(@eid,@employeename,@department,@dob,@gender,@address,@pincode,@city,@state,@phone,@email,@qualification,@joiningdate)", connection);
                command.Parameters.AddWithValue("@eid", textBoxEID.Text);
                command.Parameters.AddWithValue("@employeename", textBoxEmployeeName.Text);
                command.Parameters.AddWithValue("@department",comboBoxDepartment.Text);
                command.Parameters.AddWithValue("@dob", dateTimePickerDOB.Text);
                command.Parameters.AddWithValue("@gender", comboBoxGender.Text);
                command.Parameters.AddWithValue("@address", textBoxAddress.Text);
                command.Parameters.AddWithValue("@pincode", textBoxPincode.Text);
                command.Parameters.AddWithValue("@city", textBoxCity.Text);
                command.Parameters.AddWithValue("@state", textBoxState.Text);
                command.Parameters.AddWithValue("@phone",textBoxPhone.Text);
                command.Parameters.AddWithValue("@email", textBoxEmail.Text);
                command.Parameters.AddWithValue("@qualification", textBoxQualification.Text);
                command.Parameters.AddWithValue("@joiningdate",dateTimePickerJoining.Text);

                command.ExecuteNonQuery();

                connection.Close();
                MessageBox.Show("Saved Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void eDITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "update EmployeeDetails set EmployeeName='" + textBoxEmployeeName.Text + "'," +
                    "Department='" + comboBoxDepartment.Text + "',DOB='" + dateTimePickerDOB.Value.Date + "'," +
                    "Gender='" + comboBoxGender.Text + "',Address='" + textBoxAddress.Text + "',Pincode='" + textBoxPincode.Text + "'," +
                    "City='" + textBoxCity.Text + "',State='" + textBoxState.Text + "',Phone='" + textBoxPhone.Text + "'," +
                    "Email='" + textBoxEmail.Text + "',Qualification='" + textBoxQualification.Text + "',DateOfJoining='" + dateTimePickerJoining.Value.Date + "' where EID=" + textBoxEID.Text + "";
                MessageBox.Show(query);
                command.CommandText = query;

                command.ExecuteNonQuery();
                MessageBox.Show("Data Edited Successfully");
            }
            catch (Exception ef)
            {
                MessageBox.Show("Error" + ef);
            }
            connection.Close();
        }

        private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxSearch.Clear();
            textBoxEID.Clear();
            textBoxEmployeeName.Clear();
            comboBoxDepartment.ResetText();
            textBoxAddress.Clear();
            textBoxPincode.Clear();
            textBoxCity.Clear();
            textBoxState.Clear();
            textBoxPhone.Clear();
            textBoxEmail.Clear();
            textBoxQualification.Clear();
        }
    

        private void pRINTToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void mENUToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void vIEWToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
            
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            connection.Open();
            OleDbCommand c1 = new OleDbCommand("select EID,EmployeeName,Department,DOB,Gender,Address,Pincode,City,State,Phone,Email,Qualification from EmployeeDetails where EID=@parm1", connection);
            c1.Parameters.AddWithValue("@parm1", textBoxSearch.Text);
            OleDbDataReader reader1;
            reader1 = c1.ExecuteReader();
            if (reader1.Read())
            {
                textBoxEID.Text = reader1["EID"].ToString();
                textBoxEmployeeName.Text = reader1["EmployeeName"].ToString();
                comboBoxDepartment.Text = reader1["Department"].ToString();
                dateTimePickerDOB.Text = reader1["DOB"].ToString();
                comboBoxDepartment.Text = reader1["Gender"].ToString();
                textBoxAddress.Text = reader1["Address"].ToString();
                textBoxPincode.Text = reader1["Pincode"].ToString();
                textBoxCity.Text = reader1["City"].ToString();
                textBoxState.Text = reader1["State"].ToString();
                textBoxPhone.Text = reader1["Phone"].ToString();
                textBoxEmail.Text = reader1["Email"].ToString();
                textBoxQualification.Text = reader1["Qualification"].ToString();
            }
            else
            {
                MessageBox.Show("No Data Found");
            }
            connection.Close();
        }

        private void rEPORTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
