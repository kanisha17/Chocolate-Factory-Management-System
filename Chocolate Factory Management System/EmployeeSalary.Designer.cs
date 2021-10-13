
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeSalary));
            this.labelSalarySlip = new System.Windows.Forms.Label();
            this.labelSalaryDate = new System.Windows.Forms.Label();
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
            this.dateTimePickerSalaryDate = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewSalarySlip = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pRINTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cLEARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXITToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.printDocumentSalary = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialogSalary = new System.Windows.Forms.PrintPreviewDialog();
            this.labelEmployeeName = new System.Windows.Forms.Label();
            this.textBoxEmployeeName = new System.Windows.Forms.TextBox();
            this.eXITToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.aDDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eDITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dELETEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEFRESHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelSID = new System.Windows.Forms.Label();
            this.textBoxSID = new System.Windows.Forms.TextBox();
            this.groupBoxCalculateSalary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSalarySlip)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelSalarySlip
            // 
            this.labelSalarySlip.AutoSize = true;
            this.labelSalarySlip.Location = new System.Drawing.Point(543, 29);
            this.labelSalarySlip.Name = "labelSalarySlip";
            this.labelSalarySlip.Size = new System.Drawing.Size(83, 20);
            this.labelSalarySlip.TabIndex = 1;
            this.labelSalarySlip.Text = "Salary Slip";
            this.labelSalarySlip.Click += new System.EventHandler(this.labelSalarySlip_Click);
            // 
            // labelSalaryDate
            // 
            this.labelSalaryDate.AutoSize = true;
            this.labelSalaryDate.Location = new System.Drawing.Point(95, 119);
            this.labelSalaryDate.Name = "labelSalaryDate";
            this.labelSalaryDate.Size = new System.Drawing.Size(92, 20);
            this.labelSalaryDate.TabIndex = 2;
            this.labelSalaryDate.Text = "Salary Date";
            // 
            // labelEID
            // 
            this.labelEID.AutoSize = true;
            this.labelEID.Location = new System.Drawing.Point(95, 72);
            this.labelEID.Name = "labelEID";
            this.labelEID.Size = new System.Drawing.Size(37, 20);
            this.labelEID.TabIndex = 4;
            this.labelEID.Text = "EID";
            // 
            // groupBoxCalculateSalary
            // 
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
            this.groupBoxCalculateSalary.Location = new System.Drawing.Point(582, 66);
            this.groupBoxCalculateSalary.Name = "groupBoxCalculateSalary";
            this.groupBoxCalculateSalary.Size = new System.Drawing.Size(573, 329);
            this.groupBoxCalculateSalary.TabIndex = 5;
            this.groupBoxCalculateSalary.TabStop = false;
            this.groupBoxCalculateSalary.Text = "Calculate Salary";
            // 
            // textBoxPF
            // 
            this.textBoxPF.Location = new System.Drawing.Point(156, 185);
            this.textBoxPF.Name = "textBoxPF";
            this.textBoxPF.Size = new System.Drawing.Size(261, 26);
            this.textBoxPF.TabIndex = 11;
            // 
            // textBoxNetSalary
            // 
            this.textBoxNetSalary.Location = new System.Drawing.Point(156, 226);
            this.textBoxNetSalary.Name = "textBoxNetSalary";
            this.textBoxNetSalary.Size = new System.Drawing.Size(261, 26);
            this.textBoxNetSalary.TabIndex = 10;
            // 
            // textBoxGrossSalary
            // 
            this.textBoxGrossSalary.Location = new System.Drawing.Point(156, 142);
            this.textBoxGrossSalary.Name = "textBoxGrossSalary";
            this.textBoxGrossSalary.Size = new System.Drawing.Size(261, 26);
            this.textBoxGrossSalary.TabIndex = 9;
            // 
            // textBoxDA
            // 
            this.textBoxDA.Location = new System.Drawing.Point(156, 46);
            this.textBoxDA.Name = "textBoxDA";
            this.textBoxDA.Size = new System.Drawing.Size(261, 26);
            this.textBoxDA.TabIndex = 8;
            // 
            // textBoxHRA
            // 
            this.textBoxHRA.Location = new System.Drawing.Point(156, 94);
            this.textBoxHRA.Name = "textBoxHRA";
            this.textBoxHRA.Size = new System.Drawing.Size(261, 26);
            this.textBoxHRA.TabIndex = 7;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(177, 270);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(199, 36);
            this.buttonCalculate.TabIndex = 6;
            this.buttonCalculate.Text = "CALCULATE";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // labelNetSalary
            // 
            this.labelNetSalary.AutoSize = true;
            this.labelNetSalary.Location = new System.Drawing.Point(21, 226);
            this.labelNetSalary.Name = "labelNetSalary";
            this.labelNetSalary.Size = new System.Drawing.Size(82, 20);
            this.labelNetSalary.TabIndex = 5;
            this.labelNetSalary.Text = "Net Salary";
            // 
            // labelHRA
            // 
            this.labelHRA.AutoSize = true;
            this.labelHRA.Location = new System.Drawing.Point(21, 100);
            this.labelHRA.Name = "labelHRA";
            this.labelHRA.Size = new System.Drawing.Size(52, 20);
            this.labelHRA.TabIndex = 4;
            this.labelHRA.Text = "H.R.A";
            // 
            // labelPF
            // 
            this.labelPF.AutoSize = true;
            this.labelPF.Location = new System.Drawing.Point(18, 185);
            this.labelPF.Name = "labelPF";
            this.labelPF.Size = new System.Drawing.Size(33, 20);
            this.labelPF.TabIndex = 3;
            this.labelPF.Text = "P.F";
            // 
            // labelGrossSalary
            // 
            this.labelGrossSalary.AutoSize = true;
            this.labelGrossSalary.Location = new System.Drawing.Point(17, 148);
            this.labelGrossSalary.Name = "labelGrossSalary";
            this.labelGrossSalary.Size = new System.Drawing.Size(100, 20);
            this.labelGrossSalary.TabIndex = 2;
            this.labelGrossSalary.Text = "Gross Salary";
            // 
            // labelDA
            // 
            this.labelDA.AutoSize = true;
            this.labelDA.Location = new System.Drawing.Point(21, 52);
            this.labelDA.Name = "labelDA";
            this.labelDA.Size = new System.Drawing.Size(36, 20);
            this.labelDA.TabIndex = 1;
            this.labelDA.Text = "D.A";
            // 
            // labelBasicSalary
            // 
            this.labelBasicSalary.AutoSize = true;
            this.labelBasicSalary.Location = new System.Drawing.Point(98, 163);
            this.labelBasicSalary.Name = "labelBasicSalary";
            this.labelBasicSalary.Size = new System.Drawing.Size(96, 20);
            this.labelBasicSalary.TabIndex = 0;
            this.labelBasicSalary.Text = "Basic Salary";
            // 
            // textBoxBasicSalary
            // 
            this.textBoxBasicSalary.Location = new System.Drawing.Point(255, 163);
            this.textBoxBasicSalary.Name = "textBoxBasicSalary";
            this.textBoxBasicSalary.Size = new System.Drawing.Size(261, 26);
            this.textBoxBasicSalary.TabIndex = 6;
            // 
            // textBoxEID
            // 
            this.textBoxEID.Location = new System.Drawing.Point(255, 66);
            this.textBoxEID.Name = "textBoxEID";
            this.textBoxEID.Size = new System.Drawing.Size(261, 26);
            this.textBoxEID.TabIndex = 8;
            // 
            // dateTimePickerSalaryDate
            // 
            this.dateTimePickerSalaryDate.Location = new System.Drawing.Point(255, 113);
            this.dateTimePickerSalaryDate.Name = "dateTimePickerSalaryDate";
            this.dateTimePickerSalaryDate.Size = new System.Drawing.Size(261, 26);
            this.dateTimePickerSalaryDate.TabIndex = 10;
            // 
            // dataGridViewSalarySlip
            // 
            this.dataGridViewSalarySlip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSalarySlip.Location = new System.Drawing.Point(12, 401);
            this.dataGridViewSalarySlip.Name = "dataGridViewSalarySlip";
            this.dataGridViewSalarySlip.RowHeadersWidth = 62;
            this.dataGridViewSalarySlip.RowTemplate.Height = 28;
            this.dataGridViewSalarySlip.Size = new System.Drawing.Size(1251, 169);
            this.dataGridViewSalarySlip.TabIndex = 11;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pRINTToolStripMenuItem,
            this.cLEARToolStripMenuItem,
            this.eXITToolStripMenuItem,
            this.eXITToolStripMenuItem1,
            this.eXITToolStripMenuItem2,
            this.rEFRESHToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1298, 33);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pRINTToolStripMenuItem
            // 
            this.pRINTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aDDToolStripMenuItem,
            this.eDITToolStripMenuItem,
            this.dELETEToolStripMenuItem});
            this.pRINTToolStripMenuItem.Name = "pRINTToolStripMenuItem";
            this.pRINTToolStripMenuItem.Size = new System.Drawing.Size(78, 29);
            this.pRINTToolStripMenuItem.Text = "MENU";
            this.pRINTToolStripMenuItem.Click += new System.EventHandler(this.pRINTToolStripMenuItem_Click);
            // 
            // cLEARToolStripMenuItem
            // 
            this.cLEARToolStripMenuItem.Name = "cLEARToolStripMenuItem";
            this.cLEARToolStripMenuItem.Size = new System.Drawing.Size(76, 29);
            this.cLEARToolStripMenuItem.Text = "PRINT";
            this.cLEARToolStripMenuItem.Click += new System.EventHandler(this.cLEARToolStripMenuItem_Click);
            // 
            // eXITToolStripMenuItem
            // 
            this.eXITToolStripMenuItem.Name = "eXITToolStripMenuItem";
            this.eXITToolStripMenuItem.Size = new System.Drawing.Size(70, 29);
            this.eXITToolStripMenuItem.Text = "VIEW";
            this.eXITToolStripMenuItem.Click += new System.EventHandler(this.eXITToolStripMenuItem_Click);
            // 
            // eXITToolStripMenuItem1
            // 
            this.eXITToolStripMenuItem1.Name = "eXITToolStripMenuItem1";
            this.eXITToolStripMenuItem1.Size = new System.Drawing.Size(79, 29);
            this.eXITToolStripMenuItem1.Text = "CLEAR";
            this.eXITToolStripMenuItem1.Click += new System.EventHandler(this.eXITToolStripMenuItem1_Click);
            // 
            // printDocumentSalary
            // 
            this.printDocumentSalary.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocumentSalary_PrintPage);
            // 
            // printPreviewDialogSalary
            // 
            this.printPreviewDialogSalary.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialogSalary.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialogSalary.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialogSalary.Document = this.printDocumentSalary;
            this.printPreviewDialogSalary.Enabled = true;
            this.printPreviewDialogSalary.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialogSalary.Icon")));
            this.printPreviewDialogSalary.Name = "printPreviewDialogSalary";
            this.printPreviewDialogSalary.Visible = false;
            // 
            // labelEmployeeName
            // 
            this.labelEmployeeName.AutoSize = true;
            this.labelEmployeeName.Location = new System.Drawing.Point(98, 220);
            this.labelEmployeeName.Name = "labelEmployeeName";
            this.labelEmployeeName.Size = new System.Drawing.Size(125, 20);
            this.labelEmployeeName.TabIndex = 13;
            this.labelEmployeeName.Text = "Employee Name";
            // 
            // textBoxEmployeeName
            // 
            this.textBoxEmployeeName.Location = new System.Drawing.Point(255, 214);
            this.textBoxEmployeeName.Name = "textBoxEmployeeName";
            this.textBoxEmployeeName.Size = new System.Drawing.Size(261, 26);
            this.textBoxEmployeeName.TabIndex = 14;
            // 
            // eXITToolStripMenuItem2
            // 
            this.eXITToolStripMenuItem2.Name = "eXITToolStripMenuItem2";
            this.eXITToolStripMenuItem2.Size = new System.Drawing.Size(62, 29);
            this.eXITToolStripMenuItem2.Text = "EXIT";
            this.eXITToolStripMenuItem2.Click += new System.EventHandler(this.eXITToolStripMenuItem2_Click);
            // 
            // aDDToolStripMenuItem
            // 
            this.aDDToolStripMenuItem.Name = "aDDToolStripMenuItem";
            this.aDDToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.aDDToolStripMenuItem.Text = "ADD";
            this.aDDToolStripMenuItem.Click += new System.EventHandler(this.aDDToolStripMenuItem_Click);
            // 
            // eDITToolStripMenuItem
            // 
            this.eDITToolStripMenuItem.Name = "eDITToolStripMenuItem";
            this.eDITToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.eDITToolStripMenuItem.Text = "EDIT";
            this.eDITToolStripMenuItem.Click += new System.EventHandler(this.eDITToolStripMenuItem_Click);
            // 
            // dELETEToolStripMenuItem
            // 
            this.dELETEToolStripMenuItem.Name = "dELETEToolStripMenuItem";
            this.dELETEToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.dELETEToolStripMenuItem.Text = "DELETE";
            this.dELETEToolStripMenuItem.Click += new System.EventHandler(this.dELETEToolStripMenuItem_Click);
            // 
            // rEFRESHToolStripMenuItem
            // 
            this.rEFRESHToolStripMenuItem.Name = "rEFRESHToolStripMenuItem";
            this.rEFRESHToolStripMenuItem.Size = new System.Drawing.Size(100, 29);
            this.rEFRESHToolStripMenuItem.Text = "REFRESH";
            this.rEFRESHToolStripMenuItem.Click += new System.EventHandler(this.rEFRESHToolStripMenuItem_Click);
            // 
            // labelSID
            // 
            this.labelSID.AutoSize = true;
            this.labelSID.Location = new System.Drawing.Point(98, 274);
            this.labelSID.Name = "labelSID";
            this.labelSID.Size = new System.Drawing.Size(37, 20);
            this.labelSID.TabIndex = 15;
            this.labelSID.Text = "SID";
            // 
            // textBoxSID
            // 
            this.textBoxSID.Location = new System.Drawing.Point(255, 268);
            this.textBoxSID.Name = "textBoxSID";
            this.textBoxSID.Size = new System.Drawing.Size(261, 26);
            this.textBoxSID.TabIndex = 16;
            // 
            // EmployeeSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 582);
            this.Controls.Add(this.textBoxSID);
            this.Controls.Add(this.labelSID);
            this.Controls.Add(this.textBoxEmployeeName);
            this.Controls.Add(this.labelEmployeeName);
            this.Controls.Add(this.dataGridViewSalarySlip);
            this.Controls.Add(this.dateTimePickerSalaryDate);
            this.Controls.Add(this.textBoxEID);
            this.Controls.Add(this.textBoxBasicSalary);
            this.Controls.Add(this.groupBoxCalculateSalary);
            this.Controls.Add(this.labelEID);
            this.Controls.Add(this.labelBasicSalary);
            this.Controls.Add(this.labelSalaryDate);
            this.Controls.Add(this.labelSalarySlip);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "EmployeeSalary";
            this.Text = "EmployeeSalary";
            this.groupBoxCalculateSalary.ResumeLayout(false);
            this.groupBoxCalculateSalary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSalarySlip)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelSalarySlip;
        private System.Windows.Forms.Label labelSalaryDate;
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
        private System.Windows.Forms.DateTimePicker dateTimePickerSalaryDate;
        private System.Windows.Forms.DataGridView dataGridViewSalarySlip;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pRINTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cLEARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXITToolStripMenuItem;
        private System.Drawing.Printing.PrintDocument printDocumentSalary;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialogSalary;
        private System.Windows.Forms.ToolStripMenuItem eXITToolStripMenuItem1;
        private System.Windows.Forms.Label labelEmployeeName;
        private System.Windows.Forms.TextBox textBoxEmployeeName;
        private System.Windows.Forms.ToolStripMenuItem eXITToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem aDDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eDITToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dELETEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rEFRESHToolStripMenuItem;
        private System.Windows.Forms.Label labelSID;
        private System.Windows.Forms.TextBox textBoxSID;
    }
}