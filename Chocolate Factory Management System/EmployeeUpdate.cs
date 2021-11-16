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
    public partial class EmployeeUpdate : Form
    {
        private OleDbConnection connection = new OleDbConnection();
      //  OleDbCommand command;
        public EmployeeUpdate(string str2)
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\hp\source\Access\ChocolateFactory17.accdb;Persist Security Info=False;";
          
            textBoxEID.Text = str2;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "update EmployeeDetails set EmployeeName='" + textBoxEmployeeName.Text + "'," +
                    "Department='" + comboBoxDepartment.Text + "',DOB='" + dateTimePickerDOB.Value.Date + "'," +
                    "Gender='" + comboBoxGender.Text + "',Address='" + textBoxAddress.Text + "',Pincode='" + textBoxPincode.Text + "'," +
                    "City='" + textBoxCity.Text + "',State='" + textBoxState.Text + "',PhoneNo='" + textBoxPhone.Text + "'," +
                    "Email='" + textBoxEmail.Text + "',Qualification='" + textBoxQualification.Text + "',DateOfJoining='" + dateTimePickerJoining.Value.Date + "' where EID=" + textBoxEID.Text + "";
                MessageBox.Show(query);
                command.CommandText = query;

                command.ExecuteNonQuery();
                MessageBox.Show("Data Updated Successfully");
            }
            catch
            {
                MessageBox.Show("Data Not Updated");
            }
            connection.Close();
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {

            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
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
            e.Graphics.DrawString("Employee Phone No: " + textBoxPhone.Text, new Font("Lucida Bright", 18, FontStyle.Bold), Brushes.Blue, new Point(30, 570));
            e.Graphics.DrawString("Employee Email: " + textBoxEmail.Text, new Font("Lucida Bright", 18, FontStyle.Bold), Brushes.Blue, new Point(30, 620));
            e.Graphics.DrawString("Employee Qualification: " + textBoxQualification.Text, new Font("Lucida Bright", 18, FontStyle.Bold), Brushes.Blue, new Point(30, 670));
            e.Graphics.DrawString("Employee Joining Date: " + dateTimePickerJoining.Value.Date, new Font("Lucida Bright", 18, FontStyle.Bold), Brushes.Blue, new Point(30, 720));

        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeSearch f2 = new EmployeeSearch();
            f2.Show();
            this.Hide();
        }

        private void EmployeeUpdate_Load(object sender, EventArgs e)
        {
            connection.Open();
            OleDbCommand c1 = new OleDbCommand("select EmployeeName,Department,DOB,Gender,Address,Pincode,City,State,PhoneNo,Email,Qualification,DateOfJoining from EmployeeDetails where EID=@param", connection);
            c1.Parameters.AddWithValue("@param", textBoxEID.Text);
            OleDbDataReader reader1;
            reader1 = c1.ExecuteReader();
            if (reader1.Read())
            {
                textBoxEmployeeName.Text = reader1["EmployeeName"].ToString();
                comboBoxDepartment.Text = reader1["Department"].ToString();
                dateTimePickerDOB.Text = reader1["DOB"].ToString();
                comboBoxGender.Text = reader1["Gender"].ToString();
                textBoxAddress.Text = reader1["Address"].ToString();
                textBoxPincode.Text = reader1["Pincode"].ToString();
                textBoxCity.Text = reader1["City"].ToString();
                textBoxState.Text = reader1["State"].ToString();
                textBoxPhone.Text = reader1["PhoneNo"].ToString();
                textBoxEmail.Text = reader1["Email"].ToString();
                textBoxQualification.Text = reader1["Qualification"].ToString();
                dateTimePickerDOB.Text = reader1["DateOfJoining"].ToString();
            }
            else
            {
                MessageBox.Show("No Data Found");
            }
            connection.Close();


        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
           
        }
    }
}
