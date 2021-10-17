using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chocolate_Factory_Management_System
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void customerRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void customerRegistrationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CustomerRegister c1 = new CustomerRegister();
            c1.ShowDialog();
        }

        private void invoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesOrder s1 = new SalesOrder();
            s1.ShowDialog();
        }
    }
}
