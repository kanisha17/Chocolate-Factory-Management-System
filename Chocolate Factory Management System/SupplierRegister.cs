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

        void resetControls()
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
            textBoxState.Clear();
            textBoxSupplierName.Clear();
            checkedListBoxInsured.ResetText();
            checkedListBoxLicensed.ResetText();
            
        }

        void getSupplierID()
        {
            string sql;
            string query = "select SupplierID from Supplier order by SupplierID desc";
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
            textBoxSID.Text = sql.ToString();

        }
        private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void aDDToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            
        }

        private void SupplierRegister_Load(object sender, EventArgs e)
        {
            getSupplierID();
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
           SupplierSearch f2 = new SupplierSearch();
            f2.Show();
            this.Hide();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void oRDERToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void buttonADD_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                command = new OleDbCommand("insert into Supplier(SupplierID,SupplierName,CompanyName,BusinessType,DOB,Address,Pincode,City,State,PhoneNo,Email,Insured,Licensed,LicenseNo,BankName,BankAccountNo,BankAddress) " +
                    "values(@sid,@suppliername,@companyname,@businesstype,@dob,@address,@pincode,@city,@state,@phoneno,@email,@insured,@licensed,@licenseno,@bankname,@bankaccountno,@bankaddress)", connection);
                command.Parameters.AddWithValue("@sid", textBoxSID.Text);
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
                resetControls();
                connection.Close();
                MessageBox.Show("Data Saved Successfully");

                SupplierSearch f2 = new SupplierSearch();
                f2.Show();
                this.Hide();
            }
            catch 
            {
                MessageBox.Show("Data Not Saved".ToString());
            }
        }

        private void buttonEDIT_Click(object sender, EventArgs e)
        {
        
        }

        private void buttonDELETE_Click(object sender, EventArgs e)
        {
           
        }
    }
}
