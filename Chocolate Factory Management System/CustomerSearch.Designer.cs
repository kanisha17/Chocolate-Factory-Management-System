
namespace Chocolate_Factory_Management_System
{
    partial class CustomerSearch
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
            this.textBoxPhoneNo = new System.Windows.Forms.TextBox();
            this.labelPhoneNo = new System.Windows.Forms.Label();
            this.labelCustomer = new System.Windows.Forms.Label();
            this.linkLabelNewRegister = new System.Windows.Forms.LinkLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.enquiryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.feedbackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.complaintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.placeAnOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxPhoneNo
            // 
            this.textBoxPhoneNo.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPhoneNo.Location = new System.Drawing.Point(594, 184);
            this.textBoxPhoneNo.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPhoneNo.Name = "textBoxPhoneNo";
            this.textBoxPhoneNo.Size = new System.Drawing.Size(344, 36);
            this.textBoxPhoneNo.TabIndex = 5;
            // 
            // labelPhoneNo
            // 
            this.labelPhoneNo.AutoSize = true;
            this.labelPhoneNo.BackColor = System.Drawing.Color.Transparent;
            this.labelPhoneNo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelPhoneNo.Location = new System.Drawing.Point(450, 197);
            this.labelPhoneNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPhoneNo.Name = "labelPhoneNo";
            this.labelPhoneNo.Size = new System.Drawing.Size(107, 23);
            this.labelPhoneNo.TabIndex = 6;
            this.labelPhoneNo.Text = "Phone No";
            // 
            // labelCustomer
            // 
            this.labelCustomer.AutoSize = true;
            this.labelCustomer.BackColor = System.Drawing.Color.Transparent;
            this.labelCustomer.Font = new System.Drawing.Font("Lucida Bright", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelCustomer.Location = new System.Drawing.Point(555, 53);
            this.labelCustomer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCustomer.Name = "labelCustomer";
            this.labelCustomer.Size = new System.Drawing.Size(301, 54);
            this.labelCustomer.TabIndex = 7;
            this.labelCustomer.Text = "CUSTOMER";
            // 
            // linkLabelNewRegister
            // 
            this.linkLabelNewRegister.AutoSize = true;
            this.linkLabelNewRegister.BackColor = System.Drawing.Color.White;
            this.linkLabelNewRegister.Location = new System.Drawing.Point(606, 278);
            this.linkLabelNewRegister.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabelNewRegister.Name = "linkLabelNewRegister";
            this.linkLabelNewRegister.Size = new System.Drawing.Size(321, 23);
            this.linkLabelNewRegister.TabIndex = 8;
            this.linkLabelNewRegister.TabStop = true;
            this.linkLabelNewRegister.Text = "Not Registered Yet? Click Here";
            this.linkLabelNewRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelNewRegister_LinkClicked);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enquiryToolStripMenuItem,
            this.feedbackToolStripMenuItem,
            this.complaintToolStripMenuItem,
            this.placeAnOrderToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1307, 33);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // enquiryToolStripMenuItem
            // 
            this.enquiryToolStripMenuItem.Name = "enquiryToolStripMenuItem";
            this.enquiryToolStripMenuItem.Size = new System.Drawing.Size(87, 29);
            this.enquiryToolStripMenuItem.Text = "Enquiry";
            this.enquiryToolStripMenuItem.Click += new System.EventHandler(this.enquiryToolStripMenuItem_Click);
            // 
            // feedbackToolStripMenuItem
            // 
            this.feedbackToolStripMenuItem.Name = "feedbackToolStripMenuItem";
            this.feedbackToolStripMenuItem.Size = new System.Drawing.Size(103, 29);
            this.feedbackToolStripMenuItem.Text = "Feedback";
            this.feedbackToolStripMenuItem.Click += new System.EventHandler(this.feedbackToolStripMenuItem_Click);
            // 
            // complaintToolStripMenuItem
            // 
            this.complaintToolStripMenuItem.Name = "complaintToolStripMenuItem";
            this.complaintToolStripMenuItem.Size = new System.Drawing.Size(110, 29);
            this.complaintToolStripMenuItem.Text = "Complaint";
            this.complaintToolStripMenuItem.Click += new System.EventHandler(this.complaintToolStripMenuItem_Click);
            // 
            // placeAnOrderToolStripMenuItem
            // 
            this.placeAnOrderToolStripMenuItem.Name = "placeAnOrderToolStripMenuItem";
            this.placeAnOrderToolStripMenuItem.Size = new System.Drawing.Size(146, 29);
            this.placeAnOrderToolStripMenuItem.Text = "Place An Order";
            this.placeAnOrderToolStripMenuItem.Click += new System.EventHandler(this.placeAnOrderToolStripMenuItem_Click);
            // 
            // CustomerSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Chocolate_Factory_Management_System.Properties.Resources.b5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1307, 610);
            this.Controls.Add(this.linkLabelNewRegister);
            this.Controls.Add(this.labelCustomer);
            this.Controls.Add(this.labelPhoneNo);
            this.Controls.Add(this.textBoxPhoneNo);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CustomerSearch";
            this.Text = "CustomerSearch";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxPhoneNo;
        private System.Windows.Forms.Label labelPhoneNo;
        private System.Windows.Forms.Label labelCustomer;
        private System.Windows.Forms.LinkLabel linkLabelNewRegister;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem enquiryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem feedbackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem complaintToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem placeAnOrderToolStripMenuItem;
    }
}