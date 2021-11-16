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
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace Chocolate_Factory_Management_System
{
    public partial class EmployeeSalary : Form
    {
        private OleDbConnection connection = new OleDbConnection();
      
        public EmployeeSalary(string str4)
        {
            InitializeComponent();
           
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\hp\source\Access\ChocolateFactory17.accdb;Persist Security Info=False;";
            textBoxEID.Text = str4;
        }

       // public EmployeeSalary(string text)
        //{
       //     Text = text;
       // }

        double basicsalary, da, hra, grossalary, pf, netsalary;


        private void eXITToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }


     
        private void eXITToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            EmployeeSearch f2 = new EmployeeSearch();
            f2.Show();
            this.Hide();
        }

       

        

        private void pRINTToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aDDToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void eDITToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void textBoxEmployeeName_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelSalarySlip_Click(object sender, EventArgs e)
        {

        }

        private void rECEIPTToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
           
            
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
                MessageBox.Show("Net Salary:" + netsalary.ToString());
            }
            else
            {
                MessageBox.Show("Enter a valid input");
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "insert into EmployeeSalary (SlipNo,EID,EmployeeName,BasicSalary,DA,HRA,GrossSalary,ProvidentFund,NetSalary) " +
                    "values('"+textBoxSalarySlipNo.Text+"','" + textBoxEID.Text + "','" + textBoxEmployeeName.Text + "','" + textBoxBasicSalary.Text + "'," +
                    "'" + textBoxDA.Text + "','" + textBoxHRA.Text + "','" + textBoxGrossSalary.Text + "','" + textBoxPF.Text + "','" + textBoxNetSalary.Text + "')";


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

        private void buttonEdit_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonReceipt_Click(object sender, EventArgs e)
        {
            EmployeeSalaryReceipt s1 = new EmployeeSalaryReceipt();
            EmployeeSalaryReceiptReport s2 = new EmployeeSalaryReceiptReport();

            TextObject z = (TextObject)s2.ReportDefinition.Sections["Section1"].ReportObjects["Text6"];
            z.Text = textBoxSalarySlipNo.Text;
            TextObject a = (TextObject)s2.ReportDefinition.Sections["Section2"].ReportObjects["Text2"];
            a.Text = textBoxEID.Text;
            TextObject b = (TextObject)s2.ReportDefinition.Sections["Section2"].ReportObjects["Text4"];
            b.Text = textBoxEmployeeName.Text;
            TextObject c = (TextObject)s2.ReportDefinition.Sections["Section2"].ReportObjects["Text11"];
            c.Text = textBoxDepartment.Text;
            TextObject d = (TextObject)s2.ReportDefinition.Sections["Section2"].ReportObjects["Text13"];
            d.Text =textBoxCity.Text;
            TextObject e1 = (TextObject)s2.ReportDefinition.Sections["Section2"].ReportObjects["Text15"];
            e1.Text = textBoxPhoneNo.Text;
            TextObject f = (TextObject)s2.ReportDefinition.Sections["Section3"].ReportObjects["Text17"];
            f.Text = textBoxBasicSalary.Text;
            TextObject g = (TextObject)s2.ReportDefinition.Sections["Section3"].ReportObjects["Text20"];
            g.Text = textBoxDA.Text;
            TextObject h = (TextObject)s2.ReportDefinition.Sections["Section3"].ReportObjects["Text21"];
            h.Text = textBoxHRA.Text;
            TextObject i = (TextObject)s2.ReportDefinition.Sections["Section3"].ReportObjects["Text23"];
            i.Text = textBoxGrossSalary.Text;
            TextObject j = (TextObject)s2.ReportDefinition.Sections["Section3"].ReportObjects["Text25"];
            j.Text = textBoxPF.Text;
            TextObject k = (TextObject)s2.ReportDefinition.Sections["Section4"].ReportObjects["Text27"];
            k.Text = textBoxNetSalary.Text;

            s1.crystalReportViewer1.ReportSource = s2;
            s1.Show();
        }

        private void EmployeeSalary_Load(object sender, EventArgs e)
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
            textBoxSalarySlipNo.Text = sql.ToString();

        }
    }
}
