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
    public partial class EmployeeSalary : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public EmployeeSalary()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\hp\source\Access\Cdataa.accdb;Persist Security Info=False;";

        }
        double basicsalary, da, hra, grossalary, pf, netsalary;

        private void cLEARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (printPreviewDialogSalary.ShowDialog() == DialogResult.OK)
            {
                printDocumentSalary.Print();
            }
           
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            connection.Open();
            OleDbCommand c1 = new OleDbCommand("select EID,EmployeeName,SalaryDate,BasicSalary,DA,HRA,GrossSalary,ProvidentFund,NetSalary from EmployeeSalary where SID=@parm1", connection);
            c1.Parameters.AddWithValue("@parm1", textBoxSID.Text);
            OleDbDataReader reader1;
            reader1 = c1.ExecuteReader();
            if (reader1.Read())
            {
                textBoxEID.Text = reader1["EID"].ToString();
                textBoxEmployeeName.Text = reader1["EmployeeName"].ToString();
                dateTimePickerSalaryDate.Text = reader1["SalaryDate"].ToString();
                textBoxBasicSalary.Text = reader1["BasicSalary"].ToString();
                textBoxDA.Text = reader1["DA"].ToString();
                textBoxHRA.Text = reader1["HRA"].ToString();
                textBoxGrossSalary.Text = reader1["GrossSalary"].ToString();
                textBoxPF.Text = reader1["ProvidentFund"].ToString();
                textBoxNetSalary.Text = reader1["NetSalary"].ToString();

            }
            else
            {
                MessageBox.Show("No Data Found");
            }
            connection.Close();
            
        }

        private void printDocumentSalary_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("EMPLOYEE SALARY", new Font("Lucida Bright", 24, FontStyle.Bold), Brushes.Red, new Point(250));

            e.Graphics.DrawString("Employee ID: " + textBoxEID.Text, new Font("Lucida Bright", 18, FontStyle.Bold), Brushes.Blue, new Point(30, 120));
            e.Graphics.DrawString("Employee Name: " +textBoxEmployeeName.Text, new Font("Lucida Bright", 18, FontStyle.Bold), Brushes.Blue, new Point(30, 170));
            e.Graphics.DrawString("Employee Date Of Salary: " + dateTimePickerSalaryDate.Value.Date, new Font("Lucida Bright", 18, FontStyle.Bold), Brushes.Blue, new Point(30, 220));
            e.Graphics.DrawString("Employee Basic Salary: " + textBoxBasicSalary.Text, new Font("Lucida Bright", 18, FontStyle.Bold), Brushes.Blue, new Point(30, 270));
            e.Graphics.DrawString("Employee D.A: " + textBoxDA.Text, new Font("Lucida Bright", 18, FontStyle.Bold), Brushes.Blue, new Point(30, 320));
            e.Graphics.DrawString("Employee H.R.A: " + textBoxHRA.Text, new Font("Lucida Bright", 18, FontStyle.Bold), Brushes.Blue, new Point(30, 370));
            e.Graphics.DrawString("Employee Gross Salary: " +textBoxGrossSalary.Text, new Font("Lucida Bright", 18, FontStyle.Bold), Brushes.Blue, new Point(30, 420));
            e.Graphics.DrawString("Employee P.F: " + textBoxPF.Text, new Font("Lucida Bright", 18, FontStyle.Bold), Brushes.Blue, new Point(30, 470));
            e.Graphics.DrawString("Employee Net Salary: " + textBoxNetSalary.Text, new Font("Lucida Bright", 18, FontStyle.Bold), Brushes.Blue, new Point(30, 520));
           
        }


        private void eXITToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBoxEID.Clear();
            textBoxBasicSalary.Clear();
            textBoxDA.Clear();
            textBoxHRA.Clear();
            textBoxGrossSalary.Clear();
            textBoxPF.Clear();
            textBoxNetSalary.Clear();
            textBoxSID.Clear();
            
        }

        private void pRINTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void eXITToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void aDDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "insert into EmployeeSalary (EID,EmployeeName,SalaryDate,BasicSalary,DA,HRA,GrossSalary,ProvidentFund,NetSalary) " +
                    "values('" + textBoxEID.Text + "','" + textBoxEmployeeName.Text + "','" + dateTimePickerSalaryDate.Value.Date + "','" +textBoxBasicSalary.Text+"'," +
                    "'"+textBoxDA.Text+"','"+textBoxHRA.Text+"','"+textBoxGrossSalary.Text+"','"+textBoxPF.Text+"','"+textBoxNetSalary.Text+"')";


                command.ExecuteNonQuery();
                MessageBox.Show("Data Saved Successfully");

            }
            catch (Exception ee)
            {
                MessageBox.Show("Error" + ee);
            }
            connection.Close();
        }

        private void eDITToolStripMenuItem_Click(object sender, EventArgs e)
        {
           try
            {

                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "update EmployeeSalary set EmployeeName='" + textBoxEmployeeName.Text + "',BasicSalary='"+textBoxBasicSalary.Text+"'," +
                    "DA='"+textBoxDA.Text+"',HRA='"+textBoxHRA.Text+ "',GrossSalary='"+textBoxGrossSalary.Text+ "'," +
                    "ProvidentFund='"+textBoxPF.Text+ "',NetSalary='"+textBoxNetSalary.Text+"' where SID=" + textBoxSID.Text + "";
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

        private void rEFRESHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "select *from EmployeeSalary";
                //MessageBox.Show(query);
                command.CommandText = query;

                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewSalarySlip.DataSource = dt;



                connection.Close();
            }
            catch (Exception ef)
            {
                MessageBox.Show("Error" + ef);
            }
        }

        private void dELETEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "delete from EmployeeSalary where SID=" + textBoxSID.Text + "";
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

        private void buttonEXIT_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            
            
        }

        private void labelSalarySlip_Click(object sender, EventArgs e)
        {

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            basicsalary = int.Parse(textBoxBasicSalary.Text);

            if (basicsalary >= 0)
            {
                da = basicsalary * 10 / 100;
                textBoxDA.Text = da.ToString();

                hra = basicsalary * 15 / 100;
                textBoxHRA.Text = hra.ToString();

                grossalary = basicsalary + da + hra;
                textBoxGrossSalary.Text = grossalary.ToString();

                pf = grossalary * 10 / 100;
                textBoxPF.Text = pf.ToString();

                netsalary = grossalary - pf;
                textBoxNetSalary.Text = netsalary.ToString();
            }
            else
            {
                MessageBox.Show("Enter a valid input");
            }
           
        }
    }
}
