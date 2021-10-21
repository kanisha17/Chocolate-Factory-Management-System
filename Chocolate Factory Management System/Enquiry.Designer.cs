
namespace Chocolate_Factory_Management_System
{
    partial class Enquiry
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
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelEnquiry = new System.Windows.Forms.Label();
            this.labelPhoneNo = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxPhoneNo = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.comboBoxProduct = new System.Windows.Forms.ComboBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.buttonSUBMIT = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cLEARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelEnquiryForm = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(330, 317);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(48, 20);
            this.labelEmail.TabIndex = 0;
            this.labelEmail.Text = "Email";
            // 
            // labelEnquiry
            // 
            this.labelEnquiry.AutoSize = true;
            this.labelEnquiry.Location = new System.Drawing.Point(330, 372);
            this.labelEnquiry.Name = "labelEnquiry";
            this.labelEnquiry.Size = new System.Drawing.Size(113, 20);
            this.labelEnquiry.TabIndex = 1;
            this.labelEnquiry.Text = "Select Product";
            // 
            // labelPhoneNo
            // 
            this.labelPhoneNo.AutoSize = true;
            this.labelPhoneNo.Location = new System.Drawing.Point(330, 261);
            this.labelPhoneNo.Name = "labelPhoneNo";
            this.labelPhoneNo.Size = new System.Drawing.Size(79, 20);
            this.labelPhoneNo.TabIndex = 2;
            this.labelPhoneNo.Text = "Phone No";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(330, 203);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(68, 20);
            this.labelAddress.TabIndex = 3;
            this.labelAddress.Text = "Address";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(330, 146);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(51, 20);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "Name";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(488, 311);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(308, 26);
            this.textBoxEmail.TabIndex = 5;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(488, 140);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(308, 26);
            this.textBoxName.TabIndex = 6;
            // 
            // textBoxPhoneNo
            // 
            this.textBoxPhoneNo.Location = new System.Drawing.Point(488, 255);
            this.textBoxPhoneNo.Name = "textBoxPhoneNo";
            this.textBoxPhoneNo.Size = new System.Drawing.Size(308, 26);
            this.textBoxPhoneNo.TabIndex = 8;
            this.textBoxPhoneNo.TextChanged += new System.EventHandler(this.textBoxPhoneNo_TextChanged);
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(488, 197);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(308, 26);
            this.textBoxAddress.TabIndex = 9;
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Location = new System.Drawing.Point(488, 431);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(308, 26);
            this.dateTimePickerDate.TabIndex = 10;
            // 
            // comboBoxProduct
            // 
            this.comboBoxProduct.FormattingEnabled = true;
            this.comboBoxProduct.Items.AddRange(new object[] {
            "Choco Bar",
            "Choco Charms",
            "Choco Delight",
            "King Candy",
            "Milky Goodness",
            "Sugar Candy",
            "Sugar And Smiles"});
            this.comboBoxProduct.Location = new System.Drawing.Point(488, 364);
            this.comboBoxProduct.Name = "comboBoxProduct";
            this.comboBoxProduct.Size = new System.Drawing.Size(308, 28);
            this.comboBoxProduct.TabIndex = 11;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(330, 437);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(44, 20);
            this.labelDate.TabIndex = 12;
            this.labelDate.Text = "Date";
            // 
            // buttonSUBMIT
            // 
            this.buttonSUBMIT.Location = new System.Drawing.Point(488, 493);
            this.buttonSUBMIT.Name = "buttonSUBMIT";
            this.buttonSUBMIT.Size = new System.Drawing.Size(154, 43);
            this.buttonSUBMIT.TabIndex = 13;
            this.buttonSUBMIT.Text = "SUBMIT";
            this.buttonSUBMIT.UseVisualStyleBackColor = true;
            this.buttonSUBMIT.Click += new System.EventHandler(this.buttonSUBMIT_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cLEARToolStripMenuItem,
            this.eXITToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1276, 33);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cLEARToolStripMenuItem
            // 
            this.cLEARToolStripMenuItem.Name = "cLEARToolStripMenuItem";
            this.cLEARToolStripMenuItem.Size = new System.Drawing.Size(79, 29);
            this.cLEARToolStripMenuItem.Text = "CLEAR";
            this.cLEARToolStripMenuItem.Click += new System.EventHandler(this.cLEARToolStripMenuItem_Click);
            // 
            // eXITToolStripMenuItem
            // 
            this.eXITToolStripMenuItem.Name = "eXITToolStripMenuItem";
            this.eXITToolStripMenuItem.Size = new System.Drawing.Size(62, 29);
            this.eXITToolStripMenuItem.Text = "EXIT";
            this.eXITToolStripMenuItem.Click += new System.EventHandler(this.eXITToolStripMenuItem_Click);
            // 
            // labelEnquiryForm
            // 
            this.labelEnquiryForm.AutoSize = true;
            this.labelEnquiryForm.Font = new System.Drawing.Font("Lucida Bright", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnquiryForm.Location = new System.Drawing.Point(443, 36);
            this.labelEnquiryForm.Name = "labelEnquiryForm";
            this.labelEnquiryForm.Size = new System.Drawing.Size(390, 55);
            this.labelEnquiryForm.TabIndex = 15;
            this.labelEnquiryForm.Text = "ENQUIRY FORM";
            // 
            // Enquiry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 653);
            this.Controls.Add(this.labelEnquiryForm);
            this.Controls.Add(this.buttonSUBMIT);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.comboBoxProduct);
            this.Controls.Add(this.dateTimePickerDate);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxPhoneNo);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelPhoneNo);
            this.Controls.Add(this.labelEnquiry);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Enquiry";
            this.Text = "Enquiry";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelEnquiry;
        private System.Windows.Forms.Label labelPhoneNo;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxPhoneNo;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.ComboBox comboBoxProduct;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Button buttonSUBMIT;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cLEARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXITToolStripMenuItem;
        private System.Windows.Forms.Label labelEnquiryForm;
    }
}