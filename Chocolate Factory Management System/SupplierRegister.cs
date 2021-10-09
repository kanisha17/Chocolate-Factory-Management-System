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
        public SupplierRegister()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\hp\source\Access\Cdata.accdb;Persist Security Info=False;";

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
                    " City='" + textBoxCity.Text + "',PhoneNo='" + textBoxPhoneNo.Text + "',Email='" +textBoxEmail.Text + "',Insured='"+checkedListBoxInsured.Text+"'," +
                    "Licensed='"+checkedListBoxLicensed.Text+"',LicenseNo='"+textBoxLicenseNo.Text+"',BankName='"+textBoxBankName.Text+"',BankAccountNo='"+textBoxBankAccountNo.Text+"',BankAddress='"+textBoxBankAddress.Text+"' where SID=" + textBoxSID.Text + "";
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
                string query = "delete from Supplier where SID=" + textBoxSID.Text + "";
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
        Bitmap bitmap;
        private void pRINTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Panel pan = new Panel();
            this.Controls.Add(pan);

            Graphics graph = pan.CreateGraphics();
            Size si = this.ClientSize;
            bitmap = new Bitmap(si.Width, si.Height, graph);
            graph = Graphics.FromImage(bitmap);

            Point pt = PointToScreen(pan.Location);
            graph.CopyFromScreen(pt.X, pt.Y, 0, 0, si);
            printPreviewDialogSup.Document = printDocumentSup;
         printPreviewDialogSup.ShowDialog();
        }

        private void printDocumentSup_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }
    }
}
