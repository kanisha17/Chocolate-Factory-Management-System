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
    public partial class QualityReg : Form
    {
        public QualityReg()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            ReportDocument cryst = new ReportDocument();
            cryst.Load(@"C:\Users\hp\source\repos\Chocolate Factory Management System\Chocolate-Factory-Management-System\Chocolate Factory Management System\QualityReport.rpt");
            crystalReportViewer1.ReportSource = cryst;
            crystalReportViewer1.Refresh();
            cryst.Refresh();
        }
    }
}
