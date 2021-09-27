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
    public partial class EmployeeView : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public EmployeeView()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\hp\source\Access\Cdata.accdb;Persist Security Info=False;";
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            connection.Open();
            OleDbCommand c1 = new OleDbCommand("select EmployeeName,Department,DOB,Gender,Address,Pincode,City,State,Phone,Qualification from EmployeeDetails where EID=@parm1", connection);
            c1.Parameters.AddWithValue("@parm1",textBoxViewEID.Text);
            OleDbDataReader reader1;
            reader1 = c1.ExecuteReader();
            if (reader1.Read())
            {
                textBoxEmployeeName.Text = reader1["EmployeeName"].ToString();
                textBoxDepartment.Text = reader1["Department"].ToString();
                textBoxDOB.Text = reader1["DOB"].ToString();
                textBoxGender.Text = reader1["Gender"].ToString();
                textBoxAddress.Text = reader1["Address"].ToString();
                textBoxPincode.Text = reader1["Pincode"].ToString();
                textBoxCity.Text = reader1["City"].ToString();
                textBoxState.Text = reader1["State"].ToString();
                textBoxPhone.Text = reader1["Phone"].ToString();
                textBoxQualification.Text = reader1["Qualification"].ToString();
            }
            else 
            {
                MessageBox.Show("No Data Found");
            }
            connection.Close();
        }

        private void EmployeeView_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            Form2 f1 = new Form2();
            f1.ShowDialog();
            this.Hide();
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
           if(printPreviewDialog1.ShowDialog()==DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("EMPLOYEE SUMMARY", new Font("Lucida Bright", 24, FontStyle.Bold), Brushes.Red, new Point(250));
            e.Graphics.DrawString("Employee Name: "+textBoxEmployeeName.Text, new Font("Lucida Bright", 18, FontStyle.Bold), Brushes.Blue, new Point(30,120));
            e.Graphics.DrawString("Employee Department: " + textBoxDepartment.Text, new Font("Lucida Bright", 18, FontStyle.Bold), Brushes.Blue, new Point(30, 170));
            e.Graphics.DrawString("Employee Date Of Birth: " + textBoxDOB.Text, new Font("Lucida Bright", 18, FontStyle.Bold), Brushes.Blue, new Point(30, 220));
            e.Graphics.DrawString("Employee Gender: " + textBoxGender.Text, new Font("Lucida Bright", 18, FontStyle.Bold), Brushes.Blue, new Point(30, 270));
            e.Graphics.DrawString("Employee Address: " + textBoxAddress.Text, new Font("Lucida Bright", 18, FontStyle.Bold), Brushes.Blue, new Point(30, 320));
            e.Graphics.DrawString("Employee Pincode: " + textBoxPincode.Text, new Font("Lucida Bright", 18, FontStyle.Bold), Brushes.Blue, new Point(30, 370));
            e.Graphics.DrawString("Employee City: " + textBoxCity.Text, new Font("Lucida Bright", 18, FontStyle.Bold), Brushes.Blue, new Point(30, 420));
            e.Graphics.DrawString("Employee State: " + textBoxState.Text, new Font("Lucida Bright", 18, FontStyle.Bold), Brushes.Blue, new Point(30, 470));
            e.Graphics.DrawString("Employee Phone Number: " + textBoxPhone.Text, new Font("Lucida Bright", 18, FontStyle.Bold), Brushes.Blue, new Point(30, 520));
            e.Graphics.DrawString("Employee Qualification: " + textBoxQualification.Text, new Font("Lucida Bright", 18, FontStyle.Bold), Brushes.Blue, new Point(30, 570));
        }
    }
}
