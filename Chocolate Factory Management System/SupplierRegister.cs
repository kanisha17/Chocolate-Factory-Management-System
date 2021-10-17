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
    public partial class SupplierRegister : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        int count = 0;
        public SupplierRegister()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\hp\source\Access\Cdataa.accdb;Persist Security Info=False;";

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void rEFRESHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "select *from Supplier";
                //MessageBox.Show(query);
                command.CommandText = query;

                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;



                connection.Close();
            }
            catch (Exception ef)
            {
                MessageBox.Show("Error" + ef);
            }
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxAddress.Clear();
            textBoxBankAccountNo.Clear();
            textBoxBankAddress.Clear();
            textBoxBankName.Clear();
            textBoxBusinessType.Clear();
            textBoxCity.Clear();
            textBoxCompanyName.Clear();
            textBoxEmail.Clear();
            textBoxLicenseNo.Clear();
            textBoxPhoneNo.Clear();
            textBoxPincode.Clear();
            textBoxSearch.Clear();
            textBoxSID.Clear();
            textBoxState.Clear();
            textBoxSupplierName.Clear();
            checkedListBoxInsured.ResetText();
            checkedListBoxLicensed.ResetText();
            
        }

        private void aDDToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "insert into Supplier (SID,SupplierName,CompanyName,BusinessType,DOB,Address,Pincode,City,State,PhoneNo,Email,Insured,Licensed,LicenseNo,BankName,BankAccountNo,BankAddress) " +
                    "values('" + textBoxSID.Text + "','" + textBoxSupplierName.Text + "','" + textBoxCompanyName.Text + "','" + textBoxBusinessType.Text + "','" + dateTimePickersDOB.Value.Date + "'," +
                    "'" + textBoxAddress.Text + "','" + textBoxPincode.Text + "','" + textBoxCity.Text + "','" + textBoxState.Text + "','" + textBoxPhoneNo.Text + "','" + textBoxEmail.Text + "','"+checkedListBoxInsured.Text+"','"+checkedListBoxLicensed.Text+"'," +
                    "'" +textBoxLicenseNo.Text + "','" + textBoxBankName.Text + "','" + textBoxBankAccountNo.Text + "','" + textBoxBankAddress.Text + "')";


                command.ExecuteNonQuery();
                MessageBox.Show("Data Saved Successfully");

            }
            catch (Exception ee)
            {
                MessageBox.Show("Error" + ee);
            }
            connection.Close();
        }

        private void SupplierRegister_Load(object sender, EventArgs e)
        {

        }

        private void textBoxCity_TextChanged(object sender, EventArgs e)
        {

        }

        private void eDITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "update Supplier set SupplierName='" + textBoxSupplierName.Text + "', CompanyName='" + textBoxCompanyName.Text + "',BusinessType='"+textBoxBusinessType.Text+"'," +
                    "DOB='" + dateTimePickersDOB.Value.Date + "', Address='" + textBoxAddress.Text + "', State='" + textBoxState.Text + "', Pincode='" + textBoxPincode.Text + "'," +
                    " City='" + textBoxCity.Text + "',Email='" +textBoxEmail.Text + "',Insured='"+checkedListBoxInsured.Text+"'," +
                    "Licensed='"+checkedListBoxLicensed.Text+"',LicenseNo='"+textBoxLicenseNo.Text+"',BankName='"+textBoxBankName.Text+"',BankAccountNo='"+textBoxBankAccountNo.Text+"',BankAddress='"+textBoxBankAddress.Text+"' where PhoneNo='" + textBoxPhoneNo.Text + "'";
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

        private void dELETEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "delete from Supplier where PhoneNo='" + textBoxPhoneNo.Text + "'";
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
      
        private void pRINTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void printDocumentSup_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            
        }

        private void mENUToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void vIEWToolStripMenuItem_Click(object sender, EventArgs e)
        {
            connection.Open();
            OleDbCommand c1 = new OleDbCommand("select SupplierName,CompanyName,BusinessType,DOB,Address,Pincode,City,State,,PhoneNo,Email,Insured,Licensed,LicenseNo,BankName,BankAccountNo,BankAddress  from Supplier where SID=@parm1", connection);
            c1.Parameters.AddWithValue("@parm1", textBoxSID.Text);
            OleDbDataReader reader1;
            reader1 = c1.ExecuteReader();
            if (reader1.Read())
            {
                textBoxSupplierName.Text = reader1["SupplierName"].ToString();
                textBoxCompanyName.Text = reader1["CompanyName"].ToString();
                textBoxBusinessType.Text = reader1["BusinessType"].ToString();
                dateTimePickersDOB.Text = reader1["DOB"].ToString();
                textBoxAddress.Text = reader1["Address"].ToString();
                textBoxPincode.Text = reader1["Pincode"].ToString();
                textBoxCity.Text = reader1["City"].ToString();
                textBoxState.Text = reader1["State"].ToString();
                textBoxPhoneNo.Text = reader1["PhoneNo"].ToString();
                textBoxEmail.Text = reader1["Email"].ToString();
                checkedListBoxInsured.Text = reader1["Insured"].ToString();
                checkedListBoxLicensed.Text = reader1["Licensed"].ToString();
                textBoxLicenseNo.Text = reader1["LicenseNo"].ToString();
                textBoxBankName.Text = reader1["BankName"].ToString();
                textBoxBankAccountNo.Text = reader1["BankAccountNo"].ToString();
                textBoxBankAddress.Text = reader1["BankAddress"].ToString();

            }
            else
            {
                MessageBox.Show("No Data Found");
            }
            connection.Close();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            count = 0;
            connection.Open();
            OleDbCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select *from Supplier where PhoneNo='" + textBoxSearch.Text + "'";
            command.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(command);
            da.Fill(dt);
            count = Convert.ToInt32(dt.Rows.Count.ToString());
            dataGridView1.DataSource = dt;
            connection.Close();

            if (count == 0)
            {
                MessageBox.Show("Record Not Found");
            }
            else
            {
                MessageBox.Show("Record Found");
            }
        }
    }
}
