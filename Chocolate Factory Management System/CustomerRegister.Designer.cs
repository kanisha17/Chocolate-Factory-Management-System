
namespace Chocolate_Factory_Management_System
{
    partial class CustomerRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerRegister));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mENUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEFRESHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pRINTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hOMEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelDOB = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelPincode = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.textBoxcCity = new System.Windows.Forms.TextBox();
            this.textBoxcAddress = new System.Windows.Forms.TextBox();
            this.textBoxcLastName = new System.Windows.Forms.TextBox();
            this.textBoxcFirstName = new System.Windows.Forms.TextBox();
            this.textBoxcPincode = new System.Windows.Forms.TextBox();
            this.textBoxcPhone = new System.Windows.Forms.TextBox();
            this.textBoxcEmail = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonClose = new System.Windows.Forms.Button();
            this.dateTimePickercDOB = new System.Windows.Forms.DateTimePicker();
            this.textBoxCID = new System.Windows.Forms.TextBox();
            this.printDocument1c = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1c = new System.Windows.Forms.PrintPreviewDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mENUToolStripMenuItem,
            this.rEFRESHToolStripMenuItem,
            this.pRINTToolStripMenuItem,
            this.hOMEToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1260, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mENUToolStripMenuItem
            // 
            this.mENUToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.mENUToolStripMenuItem.Name = "mENUToolStripMenuItem";
            this.mENUToolStripMenuItem.Size = new System.Drawing.Size(78, 29);
            this.mENUToolStripMenuItem.Text = "MENU";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.addToolStripMenuItem.Text = "ADD";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.editToolStripMenuItem.Text = "EDIT";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.deleteToolStripMenuItem.Text = "DELETE";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // rEFRESHToolStripMenuItem
            // 
            this.rEFRESHToolStripMenuItem.Name = "rEFRESHToolStripMenuItem";
            this.rEFRESHToolStripMenuItem.Size = new System.Drawing.Size(100, 29);
            this.rEFRESHToolStripMenuItem.Text = "REFRESH";
            this.rEFRESHToolStripMenuItem.Click += new System.EventHandler(this.rEFRESHToolStripMenuItem_Click);
            // 
            // pRINTToolStripMenuItem
            // 
            this.pRINTToolStripMenuItem.Name = "pRINTToolStripMenuItem";
            this.pRINTToolStripMenuItem.Size = new System.Drawing.Size(76, 29);
            this.pRINTToolStripMenuItem.Text = "PRINT";
            this.pRINTToolStripMenuItem.Click += new System.EventHandler(this.pRINTToolStripMenuItem_Click);
            // 
            // hOMEToolStripMenuItem
            // 
            this.hOMEToolStripMenuItem.Name = "hOMEToolStripMenuItem";
            this.hOMEToolStripMenuItem.Size = new System.Drawing.Size(80, 29);
            this.hOMEToolStripMenuItem.Text = "HOME";
            this.hOMEToolStripMenuItem.Click += new System.EventHandler(this.hOMEToolStripMenuItem_Click);
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(36, 76);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(86, 20);
            this.labelFirstName.TabIndex = 1;
            this.labelFirstName.Text = "First Name";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(36, 128);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(86, 20);
            this.labelLastName.TabIndex = 2;
            this.labelLastName.Text = "Last Name";
            // 
            // labelDOB
            // 
            this.labelDOB.AutoSize = true;
            this.labelDOB.Location = new System.Drawing.Point(36, 182);
            this.labelDOB.Name = "labelDOB";
            this.labelDOB.Size = new System.Drawing.Size(102, 20);
            this.labelDOB.TabIndex = 3;
            this.labelDOB.Text = "Date Of Birth";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(36, 232);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(68, 20);
            this.labelAddress.TabIndex = 5;
            this.labelAddress.Text = "Address";
            // 
            // labelCity
            // 
            this.labelCity.Location = new System.Drawing.Point(644, 76);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(51, 20);
            this.labelCity.TabIndex = 0;
            this.labelCity.Text = "City";
            // 
            // labelPincode
            // 
            this.labelPincode.AutoSize = true;
            this.labelPincode.Location = new System.Drawing.Point(644, 128);
            this.labelPincode.Name = "labelPincode";
            this.labelPincode.Size = new System.Drawing.Size(66, 20);
            this.labelPincode.TabIndex = 6;
            this.labelPincode.Text = "Pincode";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(644, 229);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(48, 20);
            this.labelEmail.TabIndex = 7;
            this.labelEmail.Text = "Email";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(644, 182);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(79, 20);
            this.labelPhone.TabIndex = 8;
            this.labelPhone.Text = "Phone No";
            // 
            // textBoxcCity
            // 
            this.textBoxcCity.Location = new System.Drawing.Point(781, 70);
            this.textBoxcCity.Name = "textBoxcCity";
            this.textBoxcCity.Size = new System.Drawing.Size(280, 26);
            this.textBoxcCity.TabIndex = 9;
            // 
            // textBoxcAddress
            // 
            this.textBoxcAddress.Location = new System.Drawing.Point(229, 223);
            this.textBoxcAddress.Name = "textBoxcAddress";
            this.textBoxcAddress.Size = new System.Drawing.Size(280, 26);
            this.textBoxcAddress.TabIndex = 10;
            // 
            // textBoxcLastName
            // 
            this.textBoxcLastName.Location = new System.Drawing.Point(229, 122);
            this.textBoxcLastName.Name = "textBoxcLastName";
            this.textBoxcLastName.Size = new System.Drawing.Size(280, 26);
            this.textBoxcLastName.TabIndex = 12;
            // 
            // textBoxcFirstName
            // 
            this.textBoxcFirstName.Location = new System.Drawing.Point(229, 70);
            this.textBoxcFirstName.Name = "textBoxcFirstName";
            this.textBoxcFirstName.Size = new System.Drawing.Size(280, 26);
            this.textBoxcFirstName.TabIndex = 13;
            // 
            // textBoxcPincode
            // 
            this.textBoxcPincode.Location = new System.Drawing.Point(781, 122);
            this.textBoxcPincode.Name = "textBoxcPincode";
            this.textBoxcPincode.Size = new System.Drawing.Size(280, 26);
            this.textBoxcPincode.TabIndex = 15;
            // 
            // textBoxcPhone
            // 
            this.textBoxcPhone.Location = new System.Drawing.Point(781, 176);
            this.textBoxcPhone.Name = "textBoxcPhone";
            this.textBoxcPhone.Size = new System.Drawing.Size(280, 26);
            this.textBoxcPhone.TabIndex = 16;
            // 
            // textBoxcEmail
            // 
            this.textBoxcEmail.Location = new System.Drawing.Point(781, 229);
            this.textBoxcEmail.Name = "textBoxcEmail";
            this.textBoxcEmail.Size = new System.Drawing.Size(280, 26);
            this.textBoxcEmail.TabIndex = 17;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 276);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1248, 232);
            this.dataGridView1.TabIndex = 18;
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(1211, 36);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(49, 33);
            this.buttonClose.TabIndex = 19;
            this.buttonClose.Text = "X";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // dateTimePickercDOB
            // 
            this.dateTimePickercDOB.Location = new System.Drawing.Point(232, 171);
            this.dateTimePickercDOB.Name = "dateTimePickercDOB";
            this.dateTimePickercDOB.Size = new System.Drawing.Size(280, 26);
            this.dateTimePickercDOB.TabIndex = 20;
            // 
            // textBoxCID
            // 
            this.textBoxCID.Location = new System.Drawing.Point(229, 39);
            this.textBoxCID.Name = "textBoxCID";
            this.textBoxCID.Size = new System.Drawing.Size(100, 26);
            this.textBoxCID.TabIndex = 21;
            // 
            // printDocument1c
            // 
            this.printDocument1c.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1c_PrintPage);
            // 
            // printPreviewDialog1c
            // 
            this.printPreviewDialog1c.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1c.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1c.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1c.Document = this.printDocument1c;
            this.printPreviewDialog1c.Enabled = true;
            this.printPreviewDialog1c.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1c.Icon")));
            this.printPreviewDialog1c.Name = "printPreviewDialog1c";
            this.printPreviewDialog1c.Visible = false;
            // 
            // CustomerRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 607);
            this.Controls.Add(this.textBoxCID);
            this.Controls.Add(this.dateTimePickercDOB);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxcEmail);
            this.Controls.Add(this.textBoxcPhone);
            this.Controls.Add(this.textBoxcPincode);
            this.Controls.Add(this.textBoxcFirstName);
            this.Controls.Add(this.textBoxcLastName);
            this.Controls.Add(this.textBoxcAddress);
            this.Controls.Add(this.textBoxcCity);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelPincode);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelDOB);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CustomerRegister";
            this.Text = "CustomerRegister";
            this.Load += new System.EventHandler(this.CustomerRegister_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mENUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rEFRESHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pRINTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hOMEToolStripMenuItem;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelDOB;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelPincode;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.TextBox textBoxcCity;
        private System.Windows.Forms.TextBox textBoxcAddress;
        private System.Windows.Forms.TextBox textBoxcLastName;
        private System.Windows.Forms.TextBox textBoxcFirstName;
        private System.Windows.Forms.TextBox textBoxcPincode;
        private System.Windows.Forms.TextBox textBoxcPhone;
        private System.Windows.Forms.TextBox textBoxcEmail;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.DateTimePicker dateTimePickercDOB;
        private System.Windows.Forms.TextBox textBoxCID;
        private System.Drawing.Printing.PrintDocument printDocument1c;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1c;
    }
}