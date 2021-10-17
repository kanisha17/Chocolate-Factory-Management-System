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
    public partial class PurchaseOrder : Form
    {
       
      

        private OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\hp\source\Access\Cdataa.accdb");
        OleDbCommand command;


        public PurchaseOrder()
        {
            InitializeComponent();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxQuantitygm.Clear();
            textBoxQuantitykg.Clear();
            textBoxSearch.Clear();
            textBoxSID.Clear();
            textBoxTotal.Clear();
            textBoxUnitPrice.Clear();
            comboBoxProductName.ResetText();
            dateTimePickerOrderDate.Value = DateTime.Today;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                command = new OleDbCommand("insert into PO(SID,PDate,ProductName,Quantitygm,Quantitykg,UnitPrice,PTotal) values(@sid,@pdate,@productname,@qtyggm,@qtykgg,@unitprice,@ptotal)", connection);
                command.Parameters.AddWithValue("@sid", textBoxSID.Text);
                command.Parameters.AddWithValue("@pdate", dateTimePickerOrderDate.Text);
                command.Parameters.AddWithValue("@productname", comboBoxProductName.Text);
                command.Parameters.AddWithValue("@qtyggm", textBoxQuantitygm.Text);
                command.Parameters.AddWithValue("@qtykgg", textBoxQuantitykg.Text);
                command.Parameters.AddWithValue("@unitprice", textBoxUnitPrice.Text);
                command.Parameters.AddWithValue("@ptotal", textBoxTotal.Text);

                command.ExecuteNonQuery();

                connection.Close();
                MessageBox.Show("Saved Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void buttonEXIT_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void PurchaseOrder_Load(object sender, EventArgs e)
        {

        }

        private void buttonCALCULATE_Click(object sender, EventArgs e)
        {

        }
    }
}
