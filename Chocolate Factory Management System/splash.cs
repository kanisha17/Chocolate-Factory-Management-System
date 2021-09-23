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
    public partial class splash : Form
    {
        public splash()
        {
            InitializeComponent();
        }
        

        private void splash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        int startpoint=0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 1;
            progressBar1.Value = startpoint;
            if (progressBar1.Value == 100)
            {
                progressBar1.Value = 0;
                timer1.Stop();
                Form1 f1 = new Form1();
                this.Hide();
                f1.Show();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
