
namespace Chocolate_Factory_Management_System
{
    partial class EmployeeSalary
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
            this.labelSalarySlip = new System.Windows.Forms.Label();
            this.labelEID = new System.Windows.Forms.Label();
            this.groupBoxCalculateSalary = new System.Windows.Forms.GroupBox();
            this.textBoxPF = new System.Windows.Forms.TextBox();
            this.textBoxNetSalary = new System.Windows.Forms.TextBox();
            this.textBoxGrossSalary = new System.Windows.Forms.TextBox();
            this.textBoxDA = new System.Windows.Forms.TextBox();
            this.textBoxHRA = new System.Windows.Forms.TextBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.labelNetSalary = new System.Windows.Forms.Label();
            this.labelHRA = new System.Windows.Forms.Label();
            this.labelPF = new System.Windows.Forms.Label();
            this.labelGrossSalary = new System.Windows.Forms.Label();
            this.labelDA = new System.Windows.Forms.Label();
            this.labelBasicSalary = new System.Windows.Forms.Label();
            this.textBoxBasicSalary = new System.Windows.Forms.TextBox();
            this.textBoxEID = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.eXITToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.aDDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eDITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dELETEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelEmployeeName = new System.Windows.Forms.Label();
            this.textBoxEmployeeName = new System.Windows.Forms.TextBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.buttonReceipt = new System.Windows.Forms.Button();
            this.textBoxDepartment = new System.Windows.Forms.TextBox();
            this.textBoxPhoneNo = new System.Windows.Forms.TextBox();
            this.labelPhoneNo = new System.Windows.Forms.Label();
            this.labelDepartment = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.labelSalarySlipNo = new System.Windows.Forms.Label();
            this.textBoxSalarySlipNo = new System.Windows.Forms.TextBox();
            this.groupBoxCalculateSalary.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelSalarySlip
            // 
            this.labelSalarySlip.BackColor = System.Drawing.Color.Transparent;
            this.labelSalarySlip.Font = new System.Drawing.Font("Lucida Bright", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSalarySlip.ForeColor = System.Drawing.Color.DarkRed;
            this.labelSalarySlip.Location = new System.Drawing.Point(490, 42);
            this.labelSalarySlip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSalarySlip.Name = "labelSalarySlip";
            this.labelSalarySlip.Size = new System.Drawing.Size(544, 60);
            this.labelSalarySlip.TabIndex = 19;
            this.labelSalarySlip.Text = "EMPLOYEE SALARY";
            this.labelSalarySlip.Click += new System.EventHandler(this.labelSalarySlip_Click);
            // 
            // labelEID
            // 
            this.labelEID.AutoSize = true;
            this.labelEID.BackColor = System.Drawing.Color.Transparent;
            this.labelEID.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEID.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelEID.Location = new System.Drawing.Point(30, 171);
            this.labelEID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEID.Name = "labelEID";
            this.labelEID.Size = new System.Drawing.Size(63, 31);
            this.labelEID.TabIndex = 4;
            this.labelEID.Text = "EID";
            // 
            // groupBoxCalculateSalary
            // 
            this.groupBoxCalculateSalary.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBoxCalculateSalary.Controls.Add(this.textBoxPF);
            this.groupBoxCalculateSalary.Controls.Add(this.textBoxNetSalary);
            this.groupBoxCalculateSalary.Controls.Add(this.textBoxGrossSalary);
            this.groupBoxCalculateSalary.Controls.Add(this.textBoxDA);
            this.groupBoxCalculateSalary.Controls.Add(this.textBoxHRA);
            this.groupBoxCalculateSalary.Controls.Add(this.buttonCalculate);
            this.groupBoxCalculateSalary.Controls.Add(this.labelNetSalary);
            this.groupBoxCalculateSalary.Controls.Add(this.labelHRA);
            this.groupBoxCalculateSalary.Controls.Add(this.labelPF);
            this.groupBoxCalculateSalary.Controls.Add(this.labelGrossSalary);
            this.groupBoxCalculateSalary.Controls.Add(this.labelDA);
            this.groupBoxCalculateSalary.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCalculateSalary.ForeColor = System.Drawing.SystemColors.Desktop;
            this.groupBoxCalculateSalary.Location = new System.Drawing.Point(645, 175);
            this.groupBoxCalculateSalary.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxCalculateSalary.Name = "groupBoxCalculateSalary";
            this.groupBoxCalculateSalary.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxCalculateSalary.Size = new System.Drawing.Size(561, 351);
            this.groupBoxCalculateSalary.TabIndex = 5;
            this.groupBoxCalculateSalary.TabStop = false;
            this.groupBoxCalculateSalary.Text = "Calculate Salary";
            // 
            // textBoxPF
            // 
            this.textBoxPF.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPF.Location = new System.Drawing.Point(279, 198);
            this.textBoxPF.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxPF.Name = "textBoxPF";
            this.textBoxPF.Size = new System.Drawing.Size(278, 31);
            this.textBoxPF.TabIndex = 11;
            // 
            // textBoxNetSalary
            // 
            this.textBoxNetSalary.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNetSalary.Location = new System.Drawing.Point(279, 238);
            this.textBoxNetSalary.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxNetSalary.Name = "textBoxNetSalary";
            this.textBoxNetSalary.Size = new System.Drawing.Size(278, 31);
            this.textBoxNetSalary.TabIndex = 10;
            // 
            // textBoxGrossSalary
            // 
            this.textBoxGrossSalary.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGrossSalary.Location = new System.Drawing.Point(279, 150);
            this.textBoxGrossSalary.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxGrossSalary.Name = "textBoxGrossSalary";
            this.textBoxGrossSalary.Size = new System.Drawing.Size(278, 31);
            this.textBoxGrossSalary.TabIndex = 9;
            // 
            // textBoxDA
            // 
            this.textBoxDA.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDA.Location = new System.Drawing.Point(279, 56);
            this.textBoxDA.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxDA.Name = "textBoxDA";
            this.textBoxDA.Size = new System.Drawing.Size(278, 31);
            this.textBoxDA.TabIndex = 8;
            // 
            // textBoxHRA
            // 
            this.textBoxHRA.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHRA.Location = new System.Drawing.Point(279, 102);
            this.textBoxHRA.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxHRA.Name = "textBoxHRA";
            this.textBoxHRA.Size = new System.Drawing.Size(278, 31);
            this.textBoxHRA.TabIndex = 7;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(147, 290);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(242, 45);
            this.buttonCalculate.TabIndex = 12;
            this.buttonCalculate.Text = "CALCULATE";
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // labelNetSalary
            // 
            this.labelNetSalary.AutoSize = true;
            this.labelNetSalary.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelNetSalary.Location = new System.Drawing.Point(71, 231);
            this.labelNetSalary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNetSalary.Name = "labelNetSalary";
            this.labelNetSalary.Size = new System.Drawing.Size(157, 31);
            this.labelNetSalary.TabIndex = 5;
            this.labelNetSalary.Text = "Net Salary";
            // 
            // labelHRA
            // 
            this.labelHRA.AutoSize = true;
            this.labelHRA.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelHRA.Location = new System.Drawing.Point(68, 102);
            this.labelHRA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHRA.Name = "labelHRA";
            this.labelHRA.Size = new System.Drawing.Size(92, 31);
            this.labelHRA.TabIndex = 4;
            this.labelHRA.Text = "H.R.A";
            // 
            // labelPF
            // 
            this.labelPF.AutoSize = true;
            this.labelPF.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelPF.Location = new System.Drawing.Point(64, 191);
            this.labelPF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPF.Name = "labelPF";
            this.labelPF.Size = new System.Drawing.Size(56, 31);
            this.labelPF.TabIndex = 3;
            this.labelPF.Text = "P.F";
            // 
            // labelGrossSalary
            // 
            this.labelGrossSalary.AutoSize = true;
            this.labelGrossSalary.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelGrossSalary.Location = new System.Drawing.Point(63, 150);
            this.labelGrossSalary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGrossSalary.Name = "labelGrossSalary";
            this.labelGrossSalary.Size = new System.Drawing.Size(190, 31);
            this.labelGrossSalary.TabIndex = 2;
            this.labelGrossSalary.Text = "Gross Salary";
            // 
            // labelDA
            // 
            this.labelDA.AutoSize = true;
            this.labelDA.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelDA.Location = new System.Drawing.Point(68, 56);
            this.labelDA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDA.Name = "labelDA";
            this.labelDA.Size = new System.Drawing.Size(65, 31);
            this.labelDA.TabIndex = 1;
            this.labelDA.Text = "D.A";
            // 
            // labelBasicSalary
            // 
            this.labelBasicSalary.AutoSize = true;
            this.labelBasicSalary.BackColor = System.Drawing.Color.Transparent;
            this.labelBasicSalary.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBasicSalary.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelBasicSalary.Location = new System.Drawing.Point(654, 129);
            this.labelBasicSalary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBasicSalary.Name = "labelBasicSalary";
            this.labelBasicSalary.Size = new System.Drawing.Size(180, 31);
            this.labelBasicSalary.TabIndex = 0;
            this.labelBasicSalary.Text = "Basic Salary";
            // 
            // textBoxBasicSalary
            // 
            this.textBoxBasicSalary.Location = new System.Drawing.Point(900, 133);
            this.textBoxBasicSalary.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxBasicSalary.Name = "textBoxBasicSalary";
            this.textBoxBasicSalary.Size = new System.Drawing.Size(310, 31);
            this.textBoxBasicSalary.TabIndex = 6;
            // 
            // textBoxEID
            // 
            this.textBoxEID.Location = new System.Drawing.Point(276, 175);
            this.textBoxEID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxEID.Name = "textBoxEID";
            this.textBoxEID.Size = new System.Drawing.Size(317, 31);
            this.textBoxEID.TabIndex = 8;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eXITToolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(13, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1280, 42);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // eXITToolStripMenuItem2
            // 
            this.eXITToolStripMenuItem2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.eXITToolStripMenuItem2.Image = global::Chocolate_Factory_Management_System.Properties.Resources.exit1;
            this.eXITToolStripMenuItem2.Name = "eXITToolStripMenuItem2";
            this.eXITToolStripMenuItem2.Size = new System.Drawing.Size(106, 36);
            this.eXITToolStripMenuItem2.Text = "EXIT";
            this.eXITToolStripMenuItem2.Click += new System.EventHandler(this.eXITToolStripMenuItem2_Click);
            // 
            // aDDToolStripMenuItem
            // 
            this.aDDToolStripMenuItem.Name = "aDDToolStripMenuItem";
            this.aDDToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // eDITToolStripMenuItem
            // 
            this.eDITToolStripMenuItem.Name = "eDITToolStripMenuItem";
            this.eDITToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // dELETEToolStripMenuItem
            // 
            this.dELETEToolStripMenuItem.Name = "dELETEToolStripMenuItem";
            this.dELETEToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // labelEmployeeName
            // 
            this.labelEmployeeName.AutoSize = true;
            this.labelEmployeeName.BackColor = System.Drawing.Color.Transparent;
            this.labelEmployeeName.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmployeeName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelEmployeeName.Location = new System.Drawing.Point(30, 217);
            this.labelEmployeeName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEmployeeName.Name = "labelEmployeeName";
            this.labelEmployeeName.Size = new System.Drawing.Size(240, 31);
            this.labelEmployeeName.TabIndex = 13;
            this.labelEmployeeName.Text = "Employee Name";
            // 
            // textBoxEmployeeName
            // 
            this.textBoxEmployeeName.Location = new System.Drawing.Point(276, 221);
            this.textBoxEmployeeName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxEmployeeName.Name = "textBoxEmployeeName";
            this.textBoxEmployeeName.Size = new System.Drawing.Size(317, 31);
            this.textBoxEmployeeName.TabIndex = 14;
            this.textBoxEmployeeName.TextChanged += new System.EventHandler(this.textBoxEmployeeName_TextChanged);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BackColor = System.Drawing.Color.Brown;
            this.buttonSubmit.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSubmit.Location = new System.Drawing.Point(13, 494);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(209, 54);
            this.buttonSubmit.TabIndex = 24;
            this.buttonSubmit.Text = "SUBMIT";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonReceipt
            // 
            this.buttonReceipt.Location = new System.Drawing.Point(313, 494);
            this.buttonReceipt.Name = "buttonReceipt";
            this.buttonReceipt.Size = new System.Drawing.Size(208, 54);
            this.buttonReceipt.TabIndex = 25;
            this.buttonReceipt.Text = "PRINT RECEIPT";
            this.buttonReceipt.UseVisualStyleBackColor = true;
            this.buttonReceipt.Click += new System.EventHandler(this.buttonReceipt_Click);
            // 
            // textBoxDepartment
            // 
            this.textBoxDepartment.Location = new System.Drawing.Point(276, 265);
            this.textBoxDepartment.Name = "textBoxDepartment";
            this.textBoxDepartment.Size = new System.Drawing.Size(317, 31);
            this.textBoxDepartment.TabIndex = 26;
            // 
            // textBoxPhoneNo
            // 
            this.textBoxPhoneNo.Location = new System.Drawing.Point(276, 319);
            this.textBoxPhoneNo.Name = "textBoxPhoneNo";
            this.textBoxPhoneNo.Size = new System.Drawing.Size(317, 31);
            this.textBoxPhoneNo.TabIndex = 27;
            // 
            // labelPhoneNo
            // 
            this.labelPhoneNo.AutoSize = true;
            this.labelPhoneNo.Location = new System.Drawing.Point(32, 329);
            this.labelPhoneNo.Name = "labelPhoneNo";
            this.labelPhoneNo.Size = new System.Drawing.Size(107, 23);
            this.labelPhoneNo.TabIndex = 28;
            this.labelPhoneNo.Text = "Phone No";
            // 
            // labelDepartment
            // 
            this.labelDepartment.AutoSize = true;
            this.labelDepartment.Location = new System.Drawing.Point(32, 273);
            this.labelDepartment.Name = "labelDepartment";
            this.labelDepartment.Size = new System.Drawing.Size(130, 23);
            this.labelDepartment.TabIndex = 29;
            this.labelDepartment.Text = "Department";
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(32, 379);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(51, 23);
            this.labelCity.TabIndex = 30;
            this.labelCity.Text = "City";
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(276, 371);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(317, 31);
            this.textBoxCity.TabIndex = 31;
            // 
            // labelSalarySlipNo
            // 
            this.labelSalarySlipNo.AutoSize = true;
            this.labelSalarySlipNo.Location = new System.Drawing.Point(23, 68);
            this.labelSalarySlipNo.Name = "labelSalarySlipNo";
            this.labelSalarySlipNo.Size = new System.Drawing.Size(149, 23);
            this.labelSalarySlipNo.TabIndex = 32;
            this.labelSalarySlipNo.Text = "Salary Slip No";
            // 
            // textBoxSalarySlipNo
            // 
            this.textBoxSalarySlipNo.Location = new System.Drawing.Point(194, 60);
            this.textBoxSalarySlipNo.Name = "textBoxSalarySlipNo";
            this.textBoxSalarySlipNo.Size = new System.Drawing.Size(199, 31);
            this.textBoxSalarySlipNo.TabIndex = 33;
            // 
            // EmployeeSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Chocolate_Factory_Management_System.Properties.Resources.Background_Color1;
            this.ClientSize = new System.Drawing.Size(1280, 609);
            this.Controls.Add(this.textBoxSalarySlipNo);
            this.Controls.Add(this.labelSalarySlipNo);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.labelDepartment);
            this.Controls.Add(this.labelPhoneNo);
            this.Controls.Add(this.textBoxPhoneNo);
            this.Controls.Add(this.textBoxDepartment);
            this.Controls.Add(this.buttonReceipt);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.textBoxEmployeeName);
            this.Controls.Add(this.labelEmployeeName);
            this.Controls.Add(this.textBoxEID);
            this.Controls.Add(this.textBoxBasicSalary);
            this.Controls.Add(this.groupBoxCalculateSalary);
            this.Controls.Add(this.labelEID);
            this.Controls.Add(this.labelBasicSalary);
            this.Controls.Add(this.labelSalarySlip);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "EmployeeSalary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeSalary";
            this.Load += new System.EventHandler(this.EmployeeSalary_Load);
            this.groupBoxCalculateSalary.ResumeLayout(false);
            this.groupBoxCalculateSalary.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelSalarySlip;
        private System.Windows.Forms.Label labelEID;
        private System.Windows.Forms.GroupBox groupBoxCalculateSalary;
        private System.Windows.Forms.TextBox textBoxPF;
        private System.Windows.Forms.TextBox textBoxNetSalary;
        private System.Windows.Forms.TextBox textBoxGrossSalary;
        private System.Windows.Forms.TextBox textBoxDA;
        private System.Windows.Forms.TextBox textBoxHRA;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label labelNetSalary;
        private System.Windows.Forms.Label labelHRA;
        private System.Windows.Forms.Label labelPF;
        private System.Windows.Forms.Label labelGrossSalary;
        private System.Windows.Forms.Label labelDA;
        private System.Windows.Forms.Label labelBasicSalary;
        private System.Windows.Forms.TextBox textBoxBasicSalary;
        private System.Windows.Forms.TextBox textBoxEID;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label labelEmployeeName;
        private System.Windows.Forms.TextBox textBoxEmployeeName;
        private System.Windows.Forms.ToolStripMenuItem eXITToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem aDDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eDITToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dELETEToolStripMenuItem;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Button buttonReceipt;
        private System.Windows.Forms.TextBox textBoxDepartment;
        private System.Windows.Forms.TextBox textBoxPhoneNo;
        private System.Windows.Forms.Label labelPhoneNo;
        private System.Windows.Forms.Label labelDepartment;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.Label labelSalarySlipNo;
        private System.Windows.Forms.TextBox textBoxSalarySlipNo;
    }
}