
namespace Chocolate_Factory_Management_System
{
    partial class EmployeeSearch
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
            this.labelEID = new System.Windows.Forms.Label();
            this.textBoxEID = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attendanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelEmployee = new System.Windows.Forms.Label();
            this.linkLabelNotRegistered = new System.Windows.Forms.LinkLabel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelEID
            // 
            this.labelEID.AutoSize = true;
            this.labelEID.BackColor = System.Drawing.Color.Transparent;
            this.labelEID.Font = new System.Drawing.Font("Lucida Bright", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEID.ForeColor = System.Drawing.Color.Maroon;
            this.labelEID.Location = new System.Drawing.Point(302, 230);
            this.labelEID.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelEID.Name = "labelEID";
            this.labelEID.Size = new System.Drawing.Size(322, 36);
            this.labelEID.TabIndex = 2;
            this.labelEID.Text = "Enter Employee ID";
            // 
            // textBoxEID
            // 
            this.textBoxEID.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEID.Location = new System.Drawing.Point(652, 230);
            this.textBoxEID.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBoxEID.Name = "textBoxEID";
            this.textBoxEID.Size = new System.Drawing.Size(344, 36);
            this.textBoxEID.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem,
            this.attendanceToolStripMenuItem,
            this.salaryToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(18, 5, 0, 5);
            this.menuStrip1.Size = new System.Drawing.Size(1294, 46);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.updateToolStripMenuItem.Image = global::Chocolate_Factory_Management_System.Properties.Resources.edit2;
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(255, 36);
            this.updateToolStripMenuItem.Text = "Update Employee";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.registerToolStripMenuItem_Click);
            // 
            // attendanceToolStripMenuItem
            // 
            this.attendanceToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.attendanceToolStripMenuItem.Image = global::Chocolate_Factory_Management_System.Properties.Resources.emp_at1;
            this.attendanceToolStripMenuItem.Name = "attendanceToolStripMenuItem";
            this.attendanceToolStripMenuItem.Size = new System.Drawing.Size(186, 36);
            this.attendanceToolStripMenuItem.Text = "Attendance";
            this.attendanceToolStripMenuItem.Click += new System.EventHandler(this.attendanceToolStripMenuItem_Click);
            // 
            // salaryToolStripMenuItem
            // 
            this.salaryToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.salaryToolStripMenuItem.Image = global::Chocolate_Factory_Management_System.Properties.Resources.emp_sal1;
            this.salaryToolStripMenuItem.Name = "salaryToolStripMenuItem";
            this.salaryToolStripMenuItem.Size = new System.Drawing.Size(125, 36);
            this.salaryToolStripMenuItem.Text = "Salary";
            this.salaryToolStripMenuItem.Click += new System.EventHandler(this.salaryToolStripMenuItem_Click);
            // 
            // labelEmployee
            // 
            this.labelEmployee.AutoSize = true;
            this.labelEmployee.BackColor = System.Drawing.Color.Transparent;
            this.labelEmployee.Font = new System.Drawing.Font("Lucida Bright", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmployee.ForeColor = System.Drawing.Color.Maroon;
            this.labelEmployee.Location = new System.Drawing.Point(536, 70);
            this.labelEmployee.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelEmployee.Name = "labelEmployee";
            this.labelEmployee.Size = new System.Drawing.Size(287, 54);
            this.labelEmployee.TabIndex = 6;
            this.labelEmployee.Text = "EMPLOYEE";
            // 
            // linkLabelNotRegistered
            // 
            this.linkLabelNotRegistered.AutoSize = true;
            this.linkLabelNotRegistered.BackColor = System.Drawing.Color.Transparent;
            this.linkLabelNotRegistered.Font = new System.Drawing.Font("Lucida Bright", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelNotRegistered.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.linkLabelNotRegistered.Location = new System.Drawing.Point(647, 324);
            this.linkLabelNotRegistered.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.linkLabelNotRegistered.Name = "linkLabelNotRegistered";
            this.linkLabelNotRegistered.Size = new System.Drawing.Size(359, 25);
            this.linkLabelNotRegistered.TabIndex = 7;
            this.linkLabelNotRegistered.TabStop = true;
            this.linkLabelNotRegistered.Text = "Registered Not Yet? Click Here";
            this.linkLabelNotRegistered.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelNotRegistered_LinkClicked);
            // 
            // EmployeeSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Chocolate_Factory_Management_System.Properties.Resources.Background_Color1;
            this.ClientSize = new System.Drawing.Size(1294, 545);
            this.Controls.Add(this.linkLabelNotRegistered);
            this.Controls.Add(this.labelEmployee);
            this.Controls.Add(this.textBoxEID);
            this.Controls.Add(this.labelEID);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "EmployeeSearch";
            this.Text = "EmployeeSearch";
            this.Load += new System.EventHandler(this.EmployeeSearch_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelEID;
        private System.Windows.Forms.TextBox textBoxEID;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem attendanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salaryToolStripMenuItem;
        private System.Windows.Forms.Label labelEmployee;
        private System.Windows.Forms.LinkLabel linkLabelNotRegistered;
    }
}