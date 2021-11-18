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
    public partial class FinishedStockSearch : Form
    {
        public FinishedStockSearch()
        {
            InitializeComponent();
        }

        private void aDDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockAdd s1 = new StockAdd();
            s1.ShowDialog();
        }

        private void uPDATEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockMaintenance s1 = new StockMaintenance();
            s1.ShowDialog();
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }
    }
}
