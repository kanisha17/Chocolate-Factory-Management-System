
namespace Chocolate_Factory_Management_System
{
    partial class Employee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeRegistrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeRegistrationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeAttendanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeSalaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.employeeRegistrationToolStripMenuItem,
            this.employeeRegistrationToolStripMenuItem1,
            this.employeeAttendanceToolStripMenuItem,
            this.employeeSalaryToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(315, 633);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(198, 29);
            this.toolStripMenuItem1.Text = ".";
            // 
            // employeeRegistrationToolStripMenuItem
            // 
            this.employeeRegistrationToolStripMenuItem.Name = "employeeRegistrationToolStripMenuItem";
            this.employeeRegistrationToolStripMenuItem.Size = new System.Drawing.Size(198, 29);
            this.employeeRegistrationToolStripMenuItem.Text = ".";
            // 
            // employeeRegistrationToolStripMenuItem1
            // 
            this.employeeRegistrationToolStripMenuItem1.Name = "employeeRegistrationToolStripMenuItem1";
            this.employeeRegistrationToolStripMenuItem1.Size = new System.Drawing.Size(198, 29);
            this.employeeRegistrationToolStripMenuItem1.Text = "Employee Registration";
            this.employeeRegistrationToolStripMenuItem1.Click += new System.EventHandler(this.employeeRegistrationToolStripMenuItem1_Click);
            // 
            // employeeAttendanceToolStripMenuItem
            // 
            this.employeeAttendanceToolStripMenuItem.Name = "employeeAttendanceToolStripMenuItem";
            this.employeeAttendanceToolStripMenuItem.Size = new System.Drawing.Size(198, 29);
            this.employeeAttendanceToolStripMenuItem.Text = "Employee Attendance";
            this.employeeAttendanceToolStripMenuItem.Click += new System.EventHandler(this.employeeAttendanceToolStripMenuItem_Click);
            // 
            // employeeSalaryToolStripMenuItem
            // 
            this.employeeSalaryToolStripMenuItem.Name = "employeeSalaryToolStripMenuItem";
            this.employeeSalaryToolStripMenuItem.Size = new System.Drawing.Size(198, 29);
            this.employeeSalaryToolStripMenuItem.Text = "Employee Salary";
            this.employeeSalaryToolStripMenuItem.Click += new System.EventHandler(this.employeeSalaryToolStripMenuItem_Click);
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 633);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Employee";
            this.Text = "Employee";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem employeeRegistrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeRegistrationToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem employeeAttendanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeSalaryToolStripMenuItem;
    }
}