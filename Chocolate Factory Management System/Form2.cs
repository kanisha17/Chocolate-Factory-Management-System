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
            
        }

        private void registrationToolStripMenuItem3_Click(object sender, EventArgs e)
        {
           
        }

        private void customerRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form1 f2 = new Form1();
            f2.Show();
            this.Hide();
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllReports a1 = new AllReports();
            a1.ShowDialog();
        }

        private void registrationToolStripMenuItem4_Click(object sender, EventArgs e)
        {
           
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
            
        }

        private void feedbackToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void productDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductDetailsReg p1 = new ProductDetailsReg();
            p1.ShowDialog();
        }

        private void complaintsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
          
        }

        private void stockMaintenanceToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            StockMaintenanceReg s1 = new StockMaintenanceReg();
            s1.ShowDialog();
        }

        private void salesOrderToolStripMenuItem1_Click(object sender, EventArgs e)
        {
          
        }

        private void billAndPaymentToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            PurchaseOrderReg p1 = new PurchaseOrderReg();
            p1.ShowDialog();
        }

        private void attendanceToolStripMenuItem2_Click(object sender, EventArgs e)
        {
           
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
           
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem16_Click(object sender, EventArgs e)
        {
           
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
            FinalProductDelete f1 = new FinalProductDelete();
            f1.ShowDialog();
        }

        private void aDDToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            StockMaintenance m1 = new StockMaintenance();
            m1.ShowDialog();
        }

        private void updateToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            StockAdd s1 = new StockAdd();
            s1.ShowDialog();
        }

        private void addToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            RawMaterial r1 = new RawMaterial();
            r1.ShowDialog();
        }

        private void addToolStripMenuItem3_Click(object sender, EventArgs e)
        {
           
        }

        private void addToolStripMenuItem4_Click(object sender, EventArgs e)
        {
           
        }

        private void updateToolStripMenuItem4_Click(object sender, EventArgs e)
        {
          
        }

        private void updateToolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void updateToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            RawMaterialUpdate r1 = new RawMaterialUpdate();
            r1.ShowDialog();
        }

        private void deleteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            RawMaterialDelete d1 = new RawMaterialDelete();
            d1.ShowDialog();
        }
    }
}
