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
    public partial class Adminprofile : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public Adminprofile()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\hp\source\Access\UserLogin.accdb;Persist Security Info=False;";

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Adminprofile_Load(object sender, EventArgs e)
        {

        }

        private void buttonSaveData_Click(object sender, EventArgs e)
        {
            try
            {

                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "insert into Admin (FirstName,LastName,DOB,Address,City,Pincode,PhoneNo) " +
                    "values('"+textBoxFIrstName.Text+"','"+textBoxLastName.Text+"','"+dateTimePicker1.Value.Date+"','"+textBoxAddress.Text+"','"+textBoxCity.Text+"','"+textBoxPincode.Text+"','"+textBoxPhoneNo.Text+"' )";

                command.ExecuteNonQuery();
                MessageBox.Show("Data Saved Successfully");
            }
            catch (Exception ee)
            {
                MessageBox.Show("Error"+ee);
            }
            connection.Close();
        }

        private void labelFisrtName_Click(object sender, EventArgs e)
        {

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {

                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "update Admin set FirstName='"+textBoxFIrstName.Text+"', LastName='"+textBoxLastName.Text+"',DOB='"+dateTimePicker1.Value.Date+"', Address='"+textBoxAddress.Text+"', City='"+textBoxCity.Text+"', Pincode='"+textBoxPincode.Text+"', PhoneNo='"+textBoxPhoneNo.Text+"' where ID="+textBoxID.Text+"";
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
                string query = "delete from Admin where ID="+textBoxID.Text+"";
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

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }
    }
}
