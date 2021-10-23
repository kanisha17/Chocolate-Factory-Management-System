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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void aDMINPROFILEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Adminprofile a1 = new Adminprofile();
            a1.ShowDialog();
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
           
        }

        private void employeeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void viewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void salaryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void csutomerRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void cUSTOMERDETAILSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void sUPPLIERDETAILSToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void attendanceToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void purchaseOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void viewToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void salesOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void billAndPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void viewToolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void paymentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void rEGISTRATIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee1 e1 = new Employee1();
            e1.ShowDialog();
        }

        private void aTTENDANCEToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            EmployeeAttendance e1 = new EmployeeAttendance();
            e1.ShowDialog();
        }

        private void sALARYToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            EmployeeSalary e1 = new EmployeeSalary();
            e1.ShowDialog();
        }

        private void rEGISTRATIONToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CustomerRegister c1 = new CustomerRegister();
            c1.ShowDialog();
        }

        private void sALESORDERToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Enquiry e1 = new Enquiry();
            e1.ShowDialog();
        }

        private void rEGISTRATIONToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            SupplierRegister s1 = new SupplierRegister();
            s1.ShowDialog();
        }

        private void pURCHASEORDERToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            PurchaseOrder p1 = new PurchaseOrder();
            p1.ShowDialog();
        }

        private void eNQUIERYDETAILSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductDetails p1 = new ProductDetails();
            p1.ShowDialog();
        }

        private void enquiryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesOrder s1 = new SalesOrder();
            s1.ShowDialog();
        }

        private void proftAndLossToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void feedbackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerFeedback f1 = new CustomerFeedback();
            f1.ShowDialog();
        }

        private void complaintsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerComplaints c1 = new CustomerComplaints();
            c1.ShowDialog();
        }

        private void productsDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void stockMaintenanceToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockMaintenance s1 = new StockMaintenance();
            s1.ShowDialog();
        }
    }
}
