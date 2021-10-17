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
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        private void employeeRegistrationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Employee1 e1 = new Employee1();
            e1.ShowDialog();
        }

        private void employeeAttendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeAttendance e2 = new EmployeeAttendance();
            e2.ShowDialog();
        }

        private void employeeSalaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeSalary e1 = new EmployeeSalary();
            e1.ShowDialog();
        }
    }
}
