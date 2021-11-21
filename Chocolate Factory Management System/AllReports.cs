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
    public partial class AllReports : Form
    {
        public AllReports()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {

        }

        private void productDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void employeeDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeReg r1 = new EmployeeReg();
            r1.ShowDialog();
        }

        private void salaryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EmployeeSalaryReg e1 = new EmployeeSalaryReg();
            e1.ShowDialog();
        }

        private void salaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeAttendanceReg e1 = new EmployeeAttendanceReg();
            e1.ShowDialog();
        }

        private void registrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerRegRep r1 = new CustomerRegRep();
            r1.ShowDialog();
        }

        private void enquiryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerEnquiryReg c1 = new CustomerEnquiryReg();
            c1.ShowDialog();
        }

        private void feedbackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerFeedbackReg c1 = new CustomerFeedbackReg();
            c1.ShowDialog();
        }

        private void complaintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerComplaintReg c1 = new CustomerComplaintReg();
            c1.ShowDialog();
        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustSalesOrderReg c1 = new CustSalesOrderReg();
            c1.ShowDialog();
        }

        private void deliveryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustDeliveryReport c1 = new CustDeliveryReport();
            c1.ShowDialog();
        }

        private void registrationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SupplierRegisterReg s1 = new SupplierRegisterReg();
            s1.ShowDialog();
        }

        private void orderToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PurchaseOrderReg s1 = new PurchaseOrderReg();
            s1.ShowDialog();
        }

        private void qualityTestingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QualityReg q1 = new QualityReg();
            q1.ShowDialog();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            PackagingReg p1 = new PackagingReg();
            p1.ShowDialog();
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            RawReg r1 = new RawReg();
            r1.ShowDialog();
        }

        private void stockMaintenanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
           ProductReg p1 = new ProductReg();
            p1.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }
    }
}
