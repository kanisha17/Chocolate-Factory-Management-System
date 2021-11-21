
namespace Chocolate_Factory_Management_System
{
    partial class EmployeeUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeUpdate));
            this.textBoxEID = new System.Windows.Forms.TextBox();
            this.labelEID = new System.Windows.Forms.Label();
            this.labelEmpUpdation = new System.Windows.Forms.Label();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.comboBoxDepartment = new System.Windows.Forms.ComboBox();
            this.textBoxPincode = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxEmployeeName = new System.Windows.Forms.TextBox();
            this.dateTimePickerDOB = new System.Windows.Forms.DateTimePicker();
            this.labelPincode = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelDOB = new System.Windows.Forms.Label();
            this.labelDepartment = new System.Windows.Forms.Label();
            this.labelEName = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.dateTimePickerJoining = new System.Windows.Forms.DateTimePicker();
            this.labelDateOfJoining = new System.Windows.Forms.Label();
            this.textBoxQualification = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.textBoxState = new System.Windows.Forms.TextBox();
            this.labelQualification = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelState = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.eXITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pRINTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxEID
            // 
            this.textBoxEID.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEID.Location = new System.Drawing.Point(306, 133);
            this.textBoxEID.Name = "textBoxEID";
            this.textBoxEID.Size = new System.Drawing.Size(320, 31);
            this.textBoxEID.TabIndex = 60;
            this.textBoxEID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxEID_KeyPress);
            // 
            // labelEID
            // 
            this.labelEID.AutoSize = true;
            this.labelEID.BackColor = System.Drawing.Color.Transparent;
            this.labelEID.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEID.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelEID.Location = new System.Drawing.Point(42, 133);
            this.labelEID.Name = "labelEID";
            this.labelEID.Size = new System.Drawing.Size(192, 31);
            this.labelEID.TabIndex = 59;
            this.labelEID.Text = "Employee ID";
            // 
            // labelEmpUpdation
            // 
            this.labelEmpUpdation.AutoSize = true;
            this.labelEmpUpdation.BackColor = System.Drawing.Color.Transparent;
            this.labelEmpUpdation.Font = new System.Drawing.Font("Imprint MT Shadow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmpUpdation.ForeColor = System.Drawing.Color.DarkRed;
            this.labelEmpUpdation.Location = new System.Drawing.Point(437, 54);
            this.labelEmpUpdation.Name = "labelEmpUpdation";
            this.labelEmpUpdation.Size = new System.Drawing.Size(620, 57);
            this.labelEmpUpdation.TabIndex = 58;
            this.labelEmpUpdation.Text = "EMPLOYEE UPDATION";
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.comboBoxGender.Location = new System.Drawing.Point(309, 373);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(317, 31);
            this.comboBoxGender.TabIndex = 57;
            this.comboBoxGender.Text = "Select";
            // 
            // comboBoxDepartment
            // 
            this.comboBoxDepartment.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDepartment.FormattingEnabled = true;
            this.comboBoxDepartment.Items.AddRange(new object[] {
            "Manager",
            "Production",
            "Quality",
            "Delivery"});
            this.comboBoxDepartment.Location = new System.Drawing.Point(306, 253);
            this.comboBoxDepartment.Name = "comboBoxDepartment";
            this.comboBoxDepartment.Size = new System.Drawing.Size(317, 31);
            this.comboBoxDepartment.TabIndex = 56;
            this.comboBoxDepartment.Text = "Select";
            // 
            // textBoxPincode
            // 
            this.textBoxPincode.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPincode.Location = new System.Drawing.Point(309, 486);
            this.textBoxPincode.Name = "textBoxPincode";
            this.textBoxPincode.Size = new System.Drawing.Size(317, 31);
            this.textBoxPincode.TabIndex = 55;
            this.textBoxPincode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPincode_KeyPress);
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAddress.Location = new System.Drawing.Point(309, 430);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(317, 31);
            this.textBoxAddress.TabIndex = 54;
            // 
            // textBoxEmployeeName
            // 
            this.textBoxEmployeeName.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmployeeName.Location = new System.Drawing.Point(309, 191);
            this.textBoxEmployeeName.Name = "textBoxEmployeeName";
            this.textBoxEmployeeName.Size = new System.Drawing.Size(317, 31);
            this.textBoxEmployeeName.TabIndex = 53;
            this.textBoxEmployeeName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxEmployeeName_KeyPress);
            // 
            // dateTimePickerDOB
            // 
            this.dateTimePickerDOB.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDOB.Location = new System.Drawing.Point(309, 308);
            this.dateTimePickerDOB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dateTimePickerDOB.Name = "dateTimePickerDOB";
            this.dateTimePickerDOB.Size = new System.Drawing.Size(317, 31);
            this.dateTimePickerDOB.TabIndex = 52;
            // 
            // labelPincode
            // 
            this.labelPincode.AutoSize = true;
            this.labelPincode.BackColor = System.Drawing.Color.Transparent;
            this.labelPincode.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPincode.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelPincode.Location = new System.Drawing.Point(42, 486);
            this.labelPincode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPincode.Name = "labelPincode";
            this.labelPincode.Size = new System.Drawing.Size(124, 31);
            this.labelPincode.TabIndex = 51;
            this.labelPincode.Text = "Pincode";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.BackColor = System.Drawing.Color.Transparent;
            this.labelAddress.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddress.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelAddress.Location = new System.Drawing.Point(42, 432);
            this.labelAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(129, 31);
            this.labelAddress.TabIndex = 50;
            this.labelAddress.Text = "Address";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.BackColor = System.Drawing.Color.Transparent;
            this.labelGender.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGender.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelGender.Location = new System.Drawing.Point(42, 374);
            this.labelGender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(116, 31);
            this.labelGender.TabIndex = 49;
            this.labelGender.Text = "Gender";
            // 
            // labelDOB
            // 
            this.labelDOB.AutoSize = true;
            this.labelDOB.BackColor = System.Drawing.Color.Transparent;
            this.labelDOB.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDOB.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelDOB.Location = new System.Drawing.Point(42, 310);
            this.labelDOB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDOB.Name = "labelDOB";
            this.labelDOB.Size = new System.Drawing.Size(197, 31);
            this.labelDOB.TabIndex = 48;
            this.labelDOB.Text = "Date Of Birth";
            // 
            // labelDepartment
            // 
            this.labelDepartment.AutoSize = true;
            this.labelDepartment.BackColor = System.Drawing.Color.Transparent;
            this.labelDepartment.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDepartment.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelDepartment.Location = new System.Drawing.Point(42, 254);
            this.labelDepartment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDepartment.Name = "labelDepartment";
            this.labelDepartment.Size = new System.Drawing.Size(178, 31);
            this.labelDepartment.TabIndex = 47;
            this.labelDepartment.Text = "Department";
            // 
            // labelEName
            // 
            this.labelEName.AutoSize = true;
            this.labelEName.BackColor = System.Drawing.Color.Transparent;
            this.labelEName.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEName.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelEName.Location = new System.Drawing.Point(42, 193);
            this.labelEName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEName.Name = "labelEName";
            this.labelEName.Size = new System.Drawing.Size(240, 31);
            this.labelEName.TabIndex = 46;
            this.labelEName.Text = "Employee Name";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.BackColor = System.Drawing.Color.Transparent;
            this.labelEmail.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelEmail.Location = new System.Drawing.Point(718, 438);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(89, 31);
            this.labelEmail.TabIndex = 71;
            this.labelEmail.Text = "Email";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.Location = new System.Drawing.Point(968, 445);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(298, 31);
            this.textBoxEmail.TabIndex = 70;
            // 
            // dateTimePickerJoining
            // 
            this.dateTimePickerJoining.CalendarFont = new System.Drawing.Font("Lucida Bright", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerJoining.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerJoining.Location = new System.Drawing.Point(968, 385);
            this.dateTimePickerJoining.Name = "dateTimePickerJoining";
            this.dateTimePickerJoining.Size = new System.Drawing.Size(298, 31);
            this.dateTimePickerJoining.TabIndex = 72;
            // 
            // labelDateOfJoining
            // 
            this.labelDateOfJoining.AutoSize = true;
            this.labelDateOfJoining.BackColor = System.Drawing.Color.Transparent;
            this.labelDateOfJoining.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateOfJoining.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelDateOfJoining.Location = new System.Drawing.Point(718, 380);
            this.labelDateOfJoining.Name = "labelDateOfJoining";
            this.labelDateOfJoining.Size = new System.Drawing.Size(229, 31);
            this.labelDateOfJoining.TabIndex = 69;
            this.labelDateOfJoining.Text = "Date Of Joining";
            // 
            // textBoxQualification
            // 
            this.textBoxQualification.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxQualification.Location = new System.Drawing.Point(968, 322);
            this.textBoxQualification.Name = "textBoxQualification";
            this.textBoxQualification.Size = new System.Drawing.Size(298, 31);
            this.textBoxQualification.TabIndex = 68;
            this.textBoxQualification.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxQualification_KeyPress);
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPhone.Location = new System.Drawing.Point(968, 264);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(298, 31);
            this.textBoxPhone.TabIndex = 67;
            this.textBoxPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPhone_KeyPress);
            // 
            // textBoxCity
            // 
            this.textBoxCity.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCity.Location = new System.Drawing.Point(968, 137);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(298, 31);
            this.textBoxCity.TabIndex = 66;
            this.textBoxCity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCity_KeyPress);
            // 
            // textBoxState
            // 
            this.textBoxState.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxState.Location = new System.Drawing.Point(968, 201);
            this.textBoxState.Name = "textBoxState";
            this.textBoxState.Size = new System.Drawing.Size(298, 31);
            this.textBoxState.TabIndex = 65;
            this.textBoxState.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxState_KeyPress);
            // 
            // labelQualification
            // 
            this.labelQualification.AutoSize = true;
            this.labelQualification.BackColor = System.Drawing.Color.Transparent;
            this.labelQualification.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQualification.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelQualification.Location = new System.Drawing.Point(718, 316);
            this.labelQualification.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQualification.Name = "labelQualification";
            this.labelQualification.Size = new System.Drawing.Size(192, 31);
            this.labelQualification.TabIndex = 64;
            this.labelQualification.Text = "Qualification";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.BackColor = System.Drawing.Color.Transparent;
            this.labelPhone.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhone.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelPhone.Location = new System.Drawing.Point(718, 260);
            this.labelPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(149, 31);
            this.labelPhone.TabIndex = 63;
            this.labelPhone.Text = "Phone No";
            // 
            // labelState
            // 
            this.labelState.AutoSize = true;
            this.labelState.BackColor = System.Drawing.Color.Transparent;
            this.labelState.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelState.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelState.Location = new System.Drawing.Point(718, 199);
            this.labelState.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(81, 31);
            this.labelState.TabIndex = 62;
            this.labelState.Text = "State";
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.BackColor = System.Drawing.Color.Transparent;
            this.labelCity.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCity.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelCity.Location = new System.Drawing.Point(718, 133);
            this.labelCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(70, 31);
            this.labelCity.TabIndex = 61;
            this.labelCity.Text = "City";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.Maroon;
            this.buttonUpdate.Font = new System.Drawing.Font("Lucida Bright", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonUpdate.Location = new System.Drawing.Point(534, 532);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(399, 62);
            this.buttonUpdate.TabIndex = 73;
            this.buttonUpdate.Text = "UPDATE";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eXITToolStripMenuItem,
            this.pRINTToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1312, 42);
            this.menuStrip1.TabIndex = 75;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // eXITToolStripMenuItem
            // 
            this.eXITToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.eXITToolStripMenuItem.Image = global::Chocolate_Factory_Management_System.Properties.Resources.exit1;
            this.eXITToolStripMenuItem.Name = "eXITToolStripMenuItem";
            this.eXITToolStripMenuItem.Size = new System.Drawing.Size(106, 36);
            this.eXITToolStripMenuItem.Text = "EXIT";
            this.eXITToolStripMenuItem.Click += new System.EventHandler(this.eXITToolStripMenuItem_Click);
            // 
            // pRINTToolStripMenuItem
            // 
            this.pRINTToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pRINTToolStripMenuItem.Image = global::Chocolate_Factory_Management_System.Properties.Resources.a101;
            this.pRINTToolStripMenuItem.Name = "pRINTToolStripMenuItem";
            this.pRINTToolStripMenuItem.Size = new System.Drawing.Size(127, 36);
            this.pRINTToolStripMenuItem.Text = "PRINT";
            this.pRINTToolStripMenuItem.Click += new System.EventHandler(this.pRINTToolStripMenuItem_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // EmployeeUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Chocolate_Factory_Management_System.Properties.Resources.Background_Color1;
            this.ClientSize = new System.Drawing.Size(1312, 592);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.dateTimePickerJoining);
            this.Controls.Add(this.labelDateOfJoining);
            this.Controls.Add(this.textBoxQualification);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.textBoxState);
            this.Controls.Add(this.labelQualification);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelState);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.textBoxEID);
            this.Controls.Add(this.labelEID);
            this.Controls.Add(this.labelEmpUpdation);
            this.Controls.Add(this.comboBoxGender);
            this.Controls.Add(this.comboBoxDepartment);
            this.Controls.Add(this.textBoxPincode);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxEmployeeName);
            this.Controls.Add(this.dateTimePickerDOB);
            this.Controls.Add(this.labelPincode);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.labelDOB);
            this.Controls.Add(this.labelDepartment);
            this.Controls.Add(this.labelEName);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Lucida Bright", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "EmployeeUpdate";
            this.Text = "EmployeeUpdate";
            this.Load += new System.EventHandler(this.EmployeeUpdate_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxEID;
        private System.Windows.Forms.Label labelEID;
        private System.Windows.Forms.Label labelEmpUpdation;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.ComboBox comboBoxDepartment;
        private System.Windows.Forms.TextBox textBoxPincode;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxEmployeeName;
        private System.Windows.Forms.DateTimePicker dateTimePickerDOB;
        private System.Windows.Forms.Label labelPincode;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelDOB;
        private System.Windows.Forms.Label labelDepartment;
        private System.Windows.Forms.Label labelEName;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.DateTimePicker dateTimePickerJoining;
        private System.Windows.Forms.Label labelDateOfJoining;
        private System.Windows.Forms.TextBox textBoxQualification;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.TextBox textBoxState;
        private System.Windows.Forms.Label labelQualification;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelState;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem eXITToolStripMenuItem;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.ToolStripMenuItem pRINTToolStripMenuItem;
    }
}