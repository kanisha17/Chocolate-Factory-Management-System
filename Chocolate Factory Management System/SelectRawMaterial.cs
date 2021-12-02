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
    public partial class SelectRawMaterial : Form
    {
        private OleDbConnection connection = new OleDbConnection();
       // OleDbCommand command;
        public SelectRawMaterial()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\hp\source\Access\ChocolateFactory17.accdb;Persist Security Info=False;";
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "Sr No";
            dataGridView1.Columns[1].Name = "Raw Material ID";
            dataGridView1.Columns[2].Name = "Item Name";
            dataGridView1.Columns[3].Name = "Quantity";
        }

        int SrNo = 0;
        private void lOADTABLEToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {

        }

        private void SelectRawMaterial_Load(object sender, EventArgs e)
        {
            getInvoiceID();
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "select RawMaterialName from RawMaterialDetails";
                command.CommandText = query;
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    comboBox1.Items.Add(reader["RawMaterialName"].ToString());
                }
                connection.Close();
            }
            catch
            {

            }

        }
        void getInvoiceID()
        {
            try
            {
                // command.connection.Open();
                string sql;
                string query = "select CartNo from RawMaterialSelection order by CartNo desc";
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
                textBoxCartNo.Text = sql.ToString();
            }
            catch { }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {

        }

        private void cLEARToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {

            }
            else
            {
                try
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                    string query = "select RawMaterialID,NetStock from RawMaterialDetails where RawMaterialName='" + comboBox1.Text + "';";
                    command.CommandText = query;
                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string p = (string)reader["RawMaterialID"].ToString();
                        textBoxSearch.Text = p;
                        string dis = (string)reader["NetStock"].ToString();
                        textBoxAvailableStock.Text = dis;
                    }
                    connection.Close();
                }
                catch
                {
                    MessageBox.Show("Error");
                }
            }
            textBoxQuantity.Enabled = true;
        }
        void addDataToGridView(string Sr_No, string Raw_Material_ID, string Item_Name, string Quantity)
        {
            string[] row = { Sr_No, Raw_Material_ID, Item_Name, Quantity };
            dataGridView1.Rows.Add(row);

        }
        void resetControls()
        {
            textBoxAvailableStock.Clear();
            textBoxQuantity.Clear();
            textBoxSearch.Clear();
            comboBox1.ResetText();
        }
        private void buttonAddToCart_Click(object sender, EventArgs e)
        {
            try
            {

                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;

                string query = "update RawMaterialDetails set AvailableStock='"+textBoxAvailableStock.Text+"' where RawMaterialID=" + textBoxSearch.Text + "";

                command.CommandText = query;

                command.ExecuteNonQuery();

             
                connection.Close();
            }
            catch
            {
               
            }
           
            if (comboBox1.SelectedItem != null)
            {
                addDataToGridView((++SrNo).ToString(), textBoxSearch.Text, comboBox1.SelectedItem.ToString(), textBoxQuantity.Text);
                resetControls();

            }
            else
            {
                MessageBox.Show("Please Select An Item");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            SrNo = 0;
            getInvoiceID();
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand command;

                connection.Open();
                command = new OleDbCommand("insert into RawMaterialSelection(CartNo,RDate) " +
                    "values(@cart,@date)", connection);

                command.Parameters.AddWithValue("@cart", textBoxCartNo.Text);
                command.Parameters.AddWithValue("@date", DateTime.Now.ToString());
                //  command.Parameters.AddWithValue("@rid", textBoxSearch.Text);
                //command.Parameters.AddWithValue("@rname",comboBox1.Text);
                //command.Parameters.AddWithValue("@qty", textBoxQuantity.Text);
                //int a= command.ExecuteNonQuery();


                command.ExecuteNonQuery();

                resetControls();
                connection.Close();
                MessageBox.Show("Inserted Succesfully");
            }

            catch
            {
                MessageBox.Show("Insertion Failed");
            }
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
           
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("CHOCOLATE FACTORY", new Font("Lucida Bright", 30, FontStyle.Bold), Brushes.Blue, new Point(200, 50));
            e.Graphics.DrawString("Cart No : " + textBoxCartNo.Text, new Font("Lucida Bright", 16, FontStyle.Bold), Brushes.Black, new Point(20, 150));
            // e.Graphics.DrawString("Name : " + te.Text, new Font("Lucida Bright", 16, FontStyle.Bold), Brushes.Black, new Point(20, 180));
            e.Graphics.DrawString("Date : " + DateTime.Now.ToShortDateString(), new Font("Lucida Bright", 16, FontStyle.Bold), Brushes.Black, new Point(20, 180));
            e.Graphics.DrawString("Time : " + DateTime.Now.ToLongTimeString(), new Font("Lucida Bright", 16, FontStyle.Bold), Brushes.Black, new Point(20, 210));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------", new Font("Lucida Bright", 16, FontStyle.Bold), Brushes.Black, new Point(20, 240));
            e.Graphics.DrawString("SR NO", new Font("Lucida Bright", 16, FontStyle.Bold), Brushes.Black, new Point(20, 260));
            e.Graphics.DrawString("MATERIAL ID", new Font("Lucida Bright", 16, FontStyle.Bold), Brushes.Black, new Point(150, 260));
            e.Graphics.DrawString("MATERIAL NAME", new Font("Lucida Bright", 16, FontStyle.Bold), Brushes.Black, new Point(350, 260));
            e.Graphics.DrawString("QUANTITY", new Font("Lucida Bright", 16, FontStyle.Bold), Brushes.Black, new Point(640, 260));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------", new Font("Lucida Bright", 16, FontStyle.Bold), Brushes.Black, new Point(20, 280));


            int gap = 310;
            if (dataGridView1.Rows.Count > 0)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    try
                    {
                        e.Graphics.DrawString(dataGridView1.Rows[i].Cells[0].Value.ToString(), new Font("Lucida Bright", 16, FontStyle.Bold), Brushes.Black, new Point(20, gap));
                        gap = gap + 30;
                    }
                    catch
                    {

                    }
                }

            }
            int gap1 = 310;
            if (dataGridView1.Rows.Count > 0)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    try
                    {
                        e.Graphics.DrawString(dataGridView1.Rows[i].Cells[1].Value.ToString(), new Font("Lucida Bright", 16, FontStyle.Bold), Brushes.Black, new Point(150, gap1));
                        gap1 = gap1 + 30;
                    }
                    catch
                    {

                    }
                }
                int gap2 = 310;
                if (dataGridView1.Rows.Count > 0)
                {
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        try
                        {
                            e.Graphics.DrawString(dataGridView1.Rows[i].Cells[2].Value.ToString(), new Font("Lucida Bright", 16, FontStyle.Bold), Brushes.Black, new Point(350, gap2));
                            gap2 = gap2 + 30;
                        }
                        catch
                        {

                        }
                    }
                    int gap3 = 310;
                    if (dataGridView1.Rows.Count > 0)
                    {
                        for (int i = 0; i < dataGridView1.Rows.Count; i++)
                        {
                            try
                            {
                                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[3].Value.ToString(), new Font("Lucida Bright", 16, FontStyle.Bold), Brushes.Black, new Point(640, gap3));
                                gap3 = gap3 + 30;
                            }
                            catch
                            {

                            }
                        }

                    }
                }
            }
        }

        private void textBoxQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 6 && e.KeyChar != (char)Keys.Space && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void textBoxQuantity_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxQuantity.Text) == true)
            {

            }
            else
            {

                int a = Convert.ToInt32(textBoxAvailableStock.Text);
                int qty = Convert.ToInt32(textBoxQuantity.Text);

                int x = a - qty;

                textBoxAvailableStock.Text = x.ToString();
            }

         
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
            
        }

        private void pRINTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
    }
}   