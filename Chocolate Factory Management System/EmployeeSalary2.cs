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
                command.CommandText = "insert into EmployeeSalary (SlipNo,EID,EmployeeName,BasicSalary,DA,HRA,GrossSalary,ProvidentFund,NetSalary) " +
                    "values('" +textBoxSalarySlip.Text + "','" + textBoxEID.Text + "','" + textBoxEmployeeName.Text + "','" + textBoxBasicSalary.Text + "'," +
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
            else
            {
                MessageBox.Show("Enter a valid input");
            }
        }
    }
}
