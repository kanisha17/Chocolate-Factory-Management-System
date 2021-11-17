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
            EmployeeSearch s1 = new EmployeeSearch();
            s1.ShowDialog();
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
            CustomerSearch s1 = new CustomerSearch();
            s1.ShowDialog();
        }

        private void sUPPLIERDETAILSToolStripMenuItem_Click(object sender, EventArgs e)
        {

            SupplierSearch s1 = new SupplierSearch();
            s1.ShowDialog();
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
          
        }

        private void aTTENDANCEToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void sALARYToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void rEGISTRATIONToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void sALESORDERToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
           
        }

        private void rEGISTRATIONToolStripMenuItem2_Click(object sender, EventArgs e)
        {
        }

        private void pURCHASEORDERToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
           
        }

        private void eNQUIERYDETAILSToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void enquiryToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void proftAndLossToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockMaintenance s1 = new StockMaintenance();
            s1.ShowDialog();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           

        }

        private void feedbackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void complaintsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void productsDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void stockMaintenanceToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void rawMaterialStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salaryToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            EmployeeSalaryReg e1 = new EmployeeSalaryReg();
            e1.ShowDialog();
        }

        private void registrationToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            EmployeeReg r1 = new EmployeeReg();
            r1.ShowDialog();
        }

        private void customerRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerRegRep r1 = new CustomerRegRep();
            r1.ShowDialog();
        }

        private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form1 f2 = new Form1();
            f2.Show();
            this.Hide();
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registrationToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            SupplierRegReprt s1 = new SupplierRegReprt();
            s1.ShowDialog();
        }

        private void stockMaintenanceToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
           
        }

        private void customerComplaintsToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void customerFeedbackToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void enquiryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CustomerEnquiryReg c1 = new CustomerEnquiryReg();
            c1.ShowDialog();
        }

        private void feedbackToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CustomerFeedbackReg c1 = new CustomerFeedbackReg();
            c1.ShowDialog();
        }

        private void productDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductDetailsReg p1 = new ProductDetailsReg();
            p1.ShowDialog();
        }

        private void complaintsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CustomerComplaintReg c1 = new CustomerComplaintReg();
            c1.ShowDialog();
        }

        private void stockMaintenanceToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            StockMaintenanceReg s1 = new StockMaintenanceReg();
            s1.ShowDialog();
        }

        private void salesOrderToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SalesOrderReg s1 = new SalesOrderReg();
            s1.ShowDialog();
        }

        private void billAndPaymentToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            PurchaseOrderReg p1 = new PurchaseOrderReg();
            p1.ShowDialog();
        }

        private void attendanceToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            EmployeeAttendanceReg e1 = new EmployeeAttendanceReg();
            e1.ShowDialog();
        }

        private void billAndPaymentToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void processToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void rawMaterialToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void finishedProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void cartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectRawMaterial s1 = new SelectRawMaterial();
            s1.ShowDialog();
        }

        private void machineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManufacturingProcess m1 = new ManufacturingProcess();
            m1.ShowDialog();
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QualityTesting q1 = new QualityTesting();
            q1.ShowDialog();
        }

        private void packToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Package p1 = new Package();
            p1.ShowDialog();
        }

        private void deliveryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeliveryProcess d1 = new DeliveryProcess();
            d1.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem16_Click(object sender, EventArgs e)
        {
            RawMaterial r1 = new RawMaterial();
            r1.ShowDialog();
        }

        private void aDDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductDetails p1 = new ProductDetails();
            p1.ShowDialog();
        }

        private void uPDATEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductUpdate u1 = new ProductUpdate();
            u1.ShowDialog();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductSearch s1 = new ProductSearch();
            s1.ShowDialog();
        }
    }
}
