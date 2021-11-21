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
    public partial class EmployeeSalary2 : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public EmployeeSalary2(string str4)
        {

            InitializeComponent();
           

            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\hp\source\Access\ChocolateFactory17.accdb;Persist Security Info=False;";
            textBoxEID.Text = str4;
        }
        double basicsalary, da, hra, grossalary, pf, netsalary;

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("EMPLOYEE SALARY SLIP", new Font("Lucida Bright", 30, FontStyle.Bold), Brushes.Blue, new Point(200, 50));
            e.Graphics.DrawString("Salary Slip No : " + textBoxSalarySlip.Text, new Font("Lucida Bright", 16, FontStyle.Bold), Brushes.Black, new Point(20, 150));
            e.Graphics.DrawString("Date : " +dateTimePicker1.Value.Date, new Font("Lucida Bright", 16, FontStyle.Bold), Brushes.Black, new Point(20, 180));
            e.Graphics.DrawString("Time : " + DateTime.Now.ToLongTimeString(), new Font("Lucida Bright", 16, FontStyle.Bold), Brushes.Black, new Point(20, 210));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------", new Font("Lucida Bright", 16, FontStyle.Bold), Brushes.Black, new Point(20, 240));
            e.Graphics.DrawString("Employee ID: " + textBoxEID.Text, new Font("Lucida Bright", 16, FontStyle.Bold), Brushes.Black, new Point(20, 280));
            e.Graphics.DrawString("Employee Name : " +textBoxEmployeeName.Text, new Font("Lucida Bright", 16, FontStyle.Bold), Brushes.Black, new Point(20, 310));
            e.Graphics.DrawString("Department: " + textBoxDepartment.Text, new Font("Lucida Bright", 16, FontStyle.Bold), Brushes.Black, new Point(20, 340));
            e.Graphics.DrawString("City : " + textBoxCity.Text, new Font("Lucida Bright", 16, FontStyle.Bold), Brushes.Black, new Point(20, 370));
            e.Graphics.DrawString("Phone No: " + textBoxPhoneNo.Text, new Font("Lucida Bright", 16, FontStyle.Bold), Brushes.Black, new Point(20, 400));
   
            e.Graphics.DrawString("Basic Salary : " +textBoxBasicSalary.Text, new Font("Lucida Bright", 16, FontStyle.Bold), Brushes.Black, new Point(300, 480));
            e.Graphics.DrawString("D.A: " + textBoxDA.Text, new Font("Lucida Bright", 16, FontStyle.Bold), Brushes.Black, new Point(300, 510));
            e.Graphics.DrawString("H.R.A : " +textBoxHRA.Text, new Font("Lucida Bright", 16, FontStyle.Bold), Brushes.Black, new Point(300, 540));
            e.Graphics.DrawString("Gross Salary : "+textBoxGS.Text, new Font("Lucida Bright", 16, FontStyle.Bold), Brushes.Black, new Point(300, 570));
            e.Graphics.DrawString("P.F : "+textBoxPF.Text, new Font("Lucida Bright", 16, FontStyle.Bold), Brushes.Black, new Point(300, 600));
            e.Graphics.DrawString("Net Salary : "+textBoxNS.Text, new Font("Lucida Bright", 16, FontStyle.Bold), Brushes.Black, new Point(300, 630));

        }

        private void pRINTToolStripMenuItem_Click(object sender, EventArgs e)
        {

            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void textBoxBasicSalary_KeyPress(object sender, KeyPressEventArgs e)
        {

            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 6 && e.KeyChar != (char)Keys.Space && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void buttonCal_Click(object sender, EventArgs e)
        {
            basicsalary = int.Parse(textBoxBasicSalary.Text);
            if (basicsalary >= 0)

            {


                da = basicsalary * 10 / 100;
                textBoxDA.Text = da.ToString();

                hra = basicsalary * 15 / 100;
                textBoxHRA.Text = hra.ToString();

                grossalary = basicsalary + da + hra;
                textBoxGS.Text = grossalary.ToString();

                pf = grossalary * 10 / 100;
                textBoxPF.Text = pf.ToString();

                netsalary = grossalary - pf;
                textBoxNS.Text = netsalary.ToString();
                MessageBox.Show("Net Salary:" + netsalary.ToString());
            }
            else { }

        }

        void getSalarySlipNo()
        {

            // command.connection.Open();
            string sql;
            string query = "select SlipNo from EmployeeSalary order by SlipNo desc";
            connection.Open();
            OleDbCommand command = new OleDbCommand(query, connection);
            OleDbDataReader dr = command.ExecuteReader();

            if (dr.Read())
            {
                int id = int.Parse(dr[0].ToString()) + 1;
                sql = id.ToString("0");

            }
            else if (Convert.IsDBNull(dr))
            {
                sql = ("1");

            }
            else
            {
                sql = ("1");
            }

            connection.Close();
            textBoxSalarySlip.Text = sql.ToString();

        }
        private void EmployeeSalary2_Load(object sender, EventArgs e)
        {
            getSalarySlipNo();

            connection.Open();
            OleDbCommand c1 = new OleDbCommand("select EID,EmployeeName,Department,PhoneNo,City from EmployeeDetails where EID=@param", connection);
            c1.Parameters.AddWithValue("@param", textBoxEID.Text);
            OleDbDataReader reader1;
            reader1 = c1.ExecuteReader();
            if (reader1.Read())
            {
                textBoxEID.Text = reader1["EID"].ToString();
                textBoxEmployeeName.Text = reader1["EmployeeName"].ToString();
                textBoxDepartment.Text = reader1["Department"].ToString();
                textBoxPhoneNo.Text = reader1["PhoneNo"].ToString();
                textBoxCity.Text = reader1["City"].ToString();

            }
            else
            {
                MessageBox.Show("No Data Found");
            }
            connection.Close();
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeSearch f2 = new EmployeeSearch();
            f2.Show();
            this.Hide();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "insert into EmployeeSalary (SlipNo,EID,EmployeeName,Department,PhoneNo,City,SalaryDate,BasicSalary,DA,HRA,GrossSalary,ProvidentFund,NetSalary) " +
                    "values('" +textBoxSalarySlip.Text + "','" + textBoxEID.Text + "','" + textBoxEmployeeName.Text + "','"+textBoxDepartment.Text+"','"+textBoxPhoneNo.Text+"','"+textBoxCity.Text+"','"+dateTimePicker1.Value.Date+"','" + textBoxBasicSalary.Text + "'," +
                    "'" + textBoxDA.Text + "','" + textBoxHRA.Text + "','" +textBoxGS.Text + "','" + textBoxPF.Text + "','" + textBoxPF.Text + "')";


                command.ExecuteNonQuery();
                MessageBox.Show("Data Saved Successfully");

            }
            catch
            {
                MessageBox.Show("Data Not Saved");
            }
            //  resetControls();
            connection.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
            
        }  
    }
}
