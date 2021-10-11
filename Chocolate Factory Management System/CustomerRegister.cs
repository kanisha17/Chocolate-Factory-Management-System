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
    public partial class CustomerRegister : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        int count = 0;
        public CustomerRegister()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\hp\source\Access\Cdata.accdb;Persist Security Info=False;";

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "update Customers set FirstName='" + textBoxcFirstName.Text + "', " +
                    "LastName='" + textBoxcLastName.Text + "',DOB='" + dateTimePickercDOB.Value.Date + "'," +
                    " Address='" + textBoxcAddress.Text + "',City='"+textBoxcCity.Text+"', " +
                    "Pincode='" + textBoxcPincode.Text + "',Email='" + textBoxcEmail.Text + "' where PhoneNo=" +textBoxcPhone.Text + "";
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

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "insert into Customers (CID,FirstName,LastName,DOB,Address,City,Pincode,PhoneNo,Email) " +
                    "values('"+textBoxCID.Text+"','" + textBoxcFirstName.Text + "','" + textBoxcLastName.Text + "','" + dateTimePickercDOB.Value.Date + "','" + textBoxcAddress.Text + "','" + textBoxcCity.Text + "','" + textBoxcPincode.Text + "','"+textBoxcPhone.Text+"','" + textBoxcEmail.Text + "')";


                command.ExecuteNonQuery();
                MessageBox.Show("Data Saved Successfully");

            }
            catch (Exception ee)
            {
                MessageBox.Show("Error" + ee);
            }
            connection.Close();
        }

        private void CustomerRegister_Load(object sender, EventArgs e)
        {

        }

        private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void rEFRESHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "select *from Customers";
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

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "delete from Customers where CID=" + textBoxCID.Text + "";
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
            Panel pan = new Panel();
            this.Controls.Add(pan);

            Graphics graph = pan.CreateGraphics();
            Size si = this.ClientSize;
            bitmap = new Bitmap(si.Width, si.Height, graph);
            graph = Graphics.FromImage(bitmap);

            Point pt = PointToScreen(pan.Location);
            graph.CopyFromScreen(pt.X, pt.Y, 0, 0, si);
            printPreviewDialog1c.Document = printDocument1c;
            printPreviewDialog1c.ShowDialog();
        }
        Bitmap bitmap;
        private void printDocument1c_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void sEARCHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            count = 0;
            connection.Open();
            OleDbCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText="select *from Customers where PhoneNo='"+textBoxSearch.Text+"'";
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
