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
    public partial class Supplier : Form
    {
        public Supplier()
        {
            InitializeComponent();
        }

        private void supplierRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SupplierRegister s1 = new SupplierRegister();
            s1.ShowDialog();
        }

        private void purchaseOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PurchaseOrder p1 = new PurchaseOrder();
            p1.ShowDialog();
        }
    }
}
