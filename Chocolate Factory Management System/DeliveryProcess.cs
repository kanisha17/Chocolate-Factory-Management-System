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
    public partial class DeliveryProcess : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        OleDbCommand command;
        public DeliveryProcess(string str2)
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\hp\source\Access\ChocolateFactory17.accdb;Persist Security Info=False;";
            textBoxPhoneNo.Text = str2;
        }

        private void DeliveryProcess_Load(object sender, EventArgs e)
        {
            getInvoiceID();

            try
            {
                connection.Open();
                OleDbCommand c1 = new OleDbCommand("select CustomerID,CustomerName,Address,City,Pincode from Customer where PhoneNo=@param", connection);
                c1.Parameters.AddWithValue("@param", textBoxPhoneNo.Text);
                OleDbDataReader reader1;
                reader1 = c1.ExecuteReader();
                if (reader1.Read())
                {
                    textBoxCustomerID.Text = reader1["CustomerID"].ToString();
                    textBoxDeliverTo.Text = reader1["CustomerName"].ToString();
                    textBoxAddress.Text = reader1["Address"].ToString();
                    textBoxCity.Text = reader1["City"].ToString();
                    textBoxPincode.Text = reader1["Pincode"].ToString();
                  //  textBoxAddress.Text = reader1["Email"].ToString();

                }
                else
                {
                    MessageBox.Show("No Data Found");
                }
                connection.Close();
            }
            catch
            {

            }
        }
        void getInvoiceID()
        {

            // command.connection.Open();
            string sql;
            string query = "select DeliveryID from DeliveryProcess order by DeliveryID desc";
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
            textBoxDelivery.Text = sql.ToString();

        }
        private void labelDeliveryProcess_Click(object sender, EventArgs e)
        {

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {

           
        }

        private void cLEARToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (textBoxPhoneNo.Text.Length == 10 && textBoxPincode.Text.Length==6)
            {
                try
                {
                    connection.Open();
                    command = new OleDbCommand("insert into DeliveryProcess(DeliveryID,DeliverTo,Address,City,Pincode,PhoneNo,ReceiptNo,DeliveryDate,PaymentMode,DeliveredBy) " +
                        "values(@did,@deliverto,@address,@city,@pincode,@phone,@receipt,@ddate,@paymentmode,@deliverby)", connection);
                    command.Parameters.AddWithValue("@did", textBoxDelivery.Text);
                    command.Parameters.AddWithValue("@deliverto", textBoxDeliverTo.Text);
                    command.Parameters.AddWithValue("@address", textBoxAddress.Text);
                    command.Parameters.AddWithValue("@city", textBoxCity.Text);
                    command.Parameters.AddWithValue("@pincode", textBoxPincode.Text);
                    command.Parameters.AddWithValue("@phone", textBoxPhoneNo.Text);
                    command.Parameters.AddWithValue("@receipt", textBoxReceiptNo.Text);
                    command.Parameters.AddWithValue("@ddate", dateTimePickerDate.Text);
                    command.Parameters.AddWithValue("@paymentmode", checkBoxCash.Text);
                    command.Parameters.AddWithValue("@deliverby", textBoxDeliverBy.Text);
                    command.ExecuteNonQuery();
                  
                    connection.Close();

                    MessageBox.Show("Data Saved Successfully");

                    getInvoiceID();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else { MessageBox.Show("Please Enter Only 10 Digit PhoneNo / 6 Digit Pincode"); }
        }
       
        private void buttonPrint_Click(object sender, EventArgs e)
        {
           
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("DELIVERY INFORMATION", new Font("Lucida Bright", 30, FontStyle.Bold), Brushes.Blue, new Point(200, 50));
            e.Graphics.DrawString("Delivery No : " +textBoxDelivery.Text, new Font("Lucida Bright", 16, FontStyle.Bold), Brushes.Black, new Point(20, 150));
            e.Graphics.DrawString("Date : "+dateTimePickerDate.Value.Date, new Font("Lucida Bright", 16, FontStyle.Bold), Brushes.Black, new Point(20, 180));
            e.Graphics.DrawString("Time : " + DateTime.Now.ToLongTimeString(), new Font("Lucida Bright", 16, FontStyle.Bold), Brushes.Black, new Point(20, 210));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------", new Font("Lucida Bright", 16, FontStyle.Bold), Brushes.Black, new Point(20, 240));
            e.Graphics.DrawString("Deliver To : " + textBoxDeliverTo.Text, new Font("Lucida Bright", 16, FontStyle.Bold), Brushes.Black, new Point(20, 280));
            e.Graphics.DrawString("Address : " + textBoxAddress.Text, new Font("Lucida Bright", 16, FontStyle.Bold), Brushes.Black, new Point(20, 310));
            e.Graphics.DrawString("City : " +textBoxCity.Text, new Font("Lucida Bright", 16, FontStyle.Bold), Brushes.Black, new Point(20, 340));
            e.Graphics.DrawString("Pincode : " + textBoxPincode.Text, new Font("Lucida Bright", 16, FontStyle.Bold), Brushes.Black, new Point(20, 370));
            e.Graphics.DrawString("Phone No : " +textBoxPhoneNo.Text, new Font("Lucida Bright", 16, FontStyle.Bold), Brushes.Black, new Point(20, 400));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------", new Font("Lucida Bright", 16, FontStyle.Bold), Brushes.Black, new Point(20, 430));
            e.Graphics.DrawString("Receipt No : " + textBoxReceiptNo.Text, new Font("Lucida Bright", 16, FontStyle.Bold), Brushes.Black, new Point(20, 460));
            e.Graphics.DrawString("Payment Mode: " +checkBoxCash.Text, new Font("Lucida Bright", 16, FontStyle.Bold), Brushes.Black, new Point(20, 490));
            e.Graphics.DrawString("Delivererd By : " + textBoxDeliverBy.Text, new Font("Lucida Bright", 16, FontStyle.Bold), Brushes.Black, new Point(20, 510));
            e.Graphics.DrawString("Receiving Date : _ _/_ _/_ _ _ _" , new Font("Lucida Bright", 16, FontStyle.Bold), Brushes.Black, new Point(20, 540));
            e.Graphics.DrawString("Signature Of Receiver : _________________", new Font("Lucida Bright", 16, FontStyle.Bold), Brushes.Black, new Point(20, 580));


       
        }

        private void pRINTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void textBoxCustomerID_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 6 && e.KeyChar != (char)Keys.Space && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void textBoxPincode_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 6 && e.KeyChar != (char)Keys.Space && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void textBoxPhoneNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 10 && e.KeyChar != (char)Keys.Space && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void textBoxReceiptNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 6 && e.KeyChar != (char)Keys.Space && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void textBoxDeliverTo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Space && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private void textBoxCity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Space && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private void textBoxDeliverBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Space && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }
    }
}
