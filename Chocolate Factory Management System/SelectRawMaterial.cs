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
        OleDbCommand command;
        public SelectRawMaterial()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\hp\source\Access\ChocolateFactory17.accdb;Persist Security Info=False;";

        }

        private void lOADTABLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            
        }

        private void SelectRawMaterial_Load(object sender, EventArgs e)
        {
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
    }
}
