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

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {

                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "insert into EmployeeDetails (EID,EmployeeName,Department,DOB,Gender,Address,Pincode,City,State,Phone,Qualification) " +
                    "values('"+textBoxEID.Text+"','"+textBoxEmployeeName.Text+"','"+comboBoxDepartment.Text+"','"+dateTimePickerDOB.Value.Date+"','"+comboBoxGender.Text+"','"+textBoxAddress.Text+"','"+textBoxPincode.Text+"','"+textBoxCity.Text+"','"+textBoxState.Text+"','"+textBoxPhone.Text+"','"+textBoxQualification.Text+"')";


                command.ExecuteNonQuery();
                MessageBox.Show("Data Saved Successfully");
            }
            catch (Exception ee)
            {
                MessageBox.Show("Error" + ee);
            }
            connection.Close();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonLoadTable_Click(object sender, EventArgs e)
        {

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {

                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "update EmployeeDetails set EmployeeName='" + textBoxEmployeeName.Text + "', Department='" + comboBoxDepartment.Text + "',DOB='" + dateTimePickerDOB.Value.Date + "', Gender='" + comboBoxGender.Text + "', Address='" + textBoxAddress.Text + "', Pincode='" + textBoxPincode.Text + "', City='" + textBoxCity.Text + "',State='"+textBoxState.Text+"',Phone='"+textBoxPhone.Text+"',Qualification='"+textBoxQualification.Text+"' where EID=" + textBoxEID.Text + "";
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

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {

                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "delete from EmployeeDetails where EID=" +textBoxEID.Text+ "";
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
    }
}
