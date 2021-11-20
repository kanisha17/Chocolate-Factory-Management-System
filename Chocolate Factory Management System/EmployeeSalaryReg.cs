using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace Chocolate_Factory_Management_System
{
    public partial class EmployeeSalaryReg : Form
    {
        public EmployeeSalaryReg()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            ReportDocument cryst = new ReportDocument();
            cryst.Load(@"C:\Users\hp\source\repos\Chocolate Factory Management System\Chocolate-Factory-Management-System\Chocolate Factory Management System\EmployeeSalary.rpt");
            crystalReportViewer1.ReportSource = cryst;
            crystalReportViewer1.Refresh();
            cryst.Refresh();
        }

        private void EmployeeSalaryReport1_InitReport(object sender, EventArgs e)
        {

        }
    }
}
