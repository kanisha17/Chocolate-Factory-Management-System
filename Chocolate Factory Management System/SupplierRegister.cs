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
        OleDbCommand command;
        public SupplierRegister()
        {
            InitializeComponent();
           connection.ConnectionString = @"Provider =Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\hp\source\Access\ChocolateFactory17.accdb;Persist Security Info=False;";

        }


        private void labelClose_Click(object sender, EventArgs e)
        {
            Close();
        }
      

        private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
           textBoxSID.Clear();
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
           textBoxState.Clear();
           textBoxSupplierName.Clear();
           checkedListBoxInsured.ResetText();
           checkedListBoxLicensed.ResetText();
            
        }

        private void aDDToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            
        }

        private void SupplierRegister_Load(object sender, EventArgs e)
        {

        }

     
        private void eDITToolStripMenuItem_Click(object sender, EventArgs e)
        {     
           

        }

        private void dELETEToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

          
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

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            connection.Open();
            OleDbCommand c1 = new OleDbCommand("select SupplierID,SupplierName,CompanyName,BusinessType,DOB,Address,Pincode,City,State,SPhoneNo,Email,Insured,Licensed,LicenseNo,BankName,BankAccountNo,BankAddress from Supplier where SPhoneNo=@parm1", connection);
            c1.Parameters.AddWithValue("@parm1", textBoxSearch.Text);
            OleDbDataReader reader1;
            reader1 = c1.ExecuteReader();
            if (reader1.Read())
            {
                textBoxSID.Text = reader1["SupplierID"].ToString();
                textBoxSupplierName.Text = reader1["SupplierName"].ToString();
                textBoxCompanyName.Text = reader1["CompanyName"].ToString();
                textBoxBusinessType.Text = reader1["BusinessType"].ToString();
                dateTimePickersDOB.Text = reader1["DOB"].ToString();
                textBoxAddress.Text = reader1["Address"].ToString();
                textBoxPincode.Text = reader1["Pincode"].ToString();
                textBoxCity.Text = reader1["City"].ToString();
                textBoxState.Text = reader1["State"].ToString();
                textBoxPhoneNo.Text = reader1["SPhoneNo"].ToString();
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

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void oRDERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PurchaseOrder p1 = new PurchaseOrder();
            p1.ShowDialog();
        }

        private void buttonADD_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                command = new OleDbCommand("insert into Supplier(SupplierName,CompanyName,BusinessType,DOB,Address,Pincode,City,State,SPhoneNo,Email,Insured,Licensed,LicenseNo,BankName,BankAccountNo,BankAddress) " +
                    "values(@suppliername,@companyname,@businesstype,@dob,@address,@pincode,@city,@state,@phoneno,@email,@insured,@licensed,@licenseno,@bankname,@bankaccountno,@bankaddress)", connection);
                command.Parameters.AddWithValue("@suppliername", textBoxSupplierName.Text);
                command.Parameters.AddWithValue("@companyname", textBoxCompanyName.Text);
                command.Parameters.AddWithValue("@businesstype", textBoxBusinessType.Text);
                command.Parameters.AddWithValue("@dob", dateTimePickersDOB.Text);
                command.Parameters.AddWithValue("@address", textBoxAddress.Text);
                command.Parameters.AddWithValue("@pincode", textBoxPincode.Text);
                command.Parameters.AddWithValue("@city", textBoxCity.Text);
                command.Parameters.AddWithValue("@state", textBoxState.Text);
                command.Parameters.AddWithValue("@phoneno", textBoxPhoneNo.Text);
                command.Parameters.AddWithValue("@email", textBoxEmail.Text);
                command.Parameters.AddWithValue("@insured", checkedListBoxInsured.Text);
                command.Parameters.AddWithValue("@licensed", checkedListBoxLicensed.Text);
                command.Parameters.AddWithValue("@licenseno", textBoxLicenseNo.Text);
                command.Parameters.AddWithValue("@bankname", textBoxBankName.Text);
                command.Parameters.AddWithValue("@bankaccountno", textBoxBankAccountNo.Text);
                command.Parameters.AddWithValue("@bankaddress", textBoxBankAddress.Text);


                command.ExecuteNonQuery();

                connection.Close();
                MessageBox.Show("Data Added Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void buttonEDIT_Click(object sender, EventArgs e)
        {
            try
            {

                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;

                string query = "update Supplier set SupplierName='" + textBoxSupplierName.Text + "'," +
                    "CompanyName='" + textBoxCompanyName.Text + "'," +
                    "BusinessType='" + textBoxBusinessType.Text + "'," +
                    "DOB='" + dateTimePickersDOB.Value.Date + "'," +
                    "Address='" + textBoxAddress.Text + "'," +
                    "Pincode='" + textBoxPincode.Text + "'," +
                    "City='" + textBoxCity.Text + "'," +
                    "State='" + textBoxState.Text + "'," +
                    "SPhoneNo='" + textBoxPhoneNo.Text + "'," +
                    "Email='" + textBoxEmail.Text + "'," +
                    "Insured='" + checkedListBoxInsured.Text + "'," +
                    "Licensed='" + checkedListBoxLicensed.Text + "'," +
                    "LicenseNo='" + textBoxLicenseNo.Text + "'," +
                    "BankName='" + textBoxBankName.Text + "'," +
                    "BankAccountNo='" + textBoxBankAccountNo.Text + "'," +
                    "BankAddress='" + textBoxBankAddress.Text + "' where SPhoneNo=" + textBoxSearch.Text + "";
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

        private void buttonDELETE_Click(object sender, EventArgs e)
        {
            try
            {

                connection.Open();
                OleDbCommand command = connection.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "delete from Supplier where SPhoneNo=" + textBoxSearch.Text + "";
                //MessageBox.Show(query);


                command.ExecuteNonQuery();
                MessageBox.Show("Data Deleted Successfully");
            }
            catch (Exception ef)
            {
                MessageBox.Show("Error" + ef);
            }
            connection.Close();

        }
    }
}
