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
    public partial class Employee1 : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public Employee1()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\hp\source\Access\Cdata.accdb;Persist Security Info=False;";

        }


        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        Bitmap bitmap;

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        private void pRINTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void dELETEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "delete from EmployeeDetails where EID=" + textBoxEID.Text + "";
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

        private void aDDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "insert into EmployeeDetails (EID,EmployeeName,Department,DOB,Gender,Address,Pincode,City,State,Phone,Qualification) " +
                    "values('" + textBoxEID.Text + "','" + textBoxEmployeeName.Text + "','" + comboBoxDepartment.Text + "','" + dateTimePickerDOB.Value.Date + "','" + comboBoxGender.Text + "','" + textBoxAddress.Text + "','" + textBoxPincode.Text + "','" + textBoxCity.Text + "','" + textBoxState.Text + "','" + textBoxPhone.Text + "','" + textBoxQualification.Text + "')";


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
                string query = "update EmployeeDetails set EmployeeName='" + textBoxEmployeeName.Text + "', Department='" + comboBoxDepartment.Text + "',DOB='" + dateTimePickerDOB.Value.Date + "', Gender='" + comboBoxGender.Text + "', Address='" + textBoxAddress.Text + "', Pincode='" + textBoxPincode.Text + "', City='" + textBoxCity.Text + "',State='" + textBoxState.Text + "',Phone='" + textBoxPhone.Text + "',Qualification='" + textBoxQualification.Text + "' where EID=" + textBoxEID.Text + "";
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
                string query = "select *from EmployeeDetails";
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

        private void pRINTToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Panel pan = new Panel();
            this.Controls.Add(pan);

            Graphics graph = pan.CreateGraphics();
            Size si = this.ClientSize;
            bitmap = new Bitmap(si.Width, si.Height, graph);
            graph = Graphics.FromImage(bitmap);

            Point pt = PointToScreen(pan.Location);
            graph.CopyFromScreen(pt.X, pt.Y, 0, 0, si);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
    }
}
