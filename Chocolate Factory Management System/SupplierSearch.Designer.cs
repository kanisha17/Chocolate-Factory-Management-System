
namespace Chocolate_Factory_Management_System
{
    partial class SupplierSearch
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
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.labelPhoneNo = new System.Windows.Forms.Label();
            this.labelFullName = new System.Windows.Forms.Label();
            this.textBoxPhoneNo = new System.Windows.Forms.TextBox();
            this.textBoxFullName = new System.Windows.Forms.TextBox();
            this.linkLabelNotRegistered = new System.Windows.Forms.LinkLabel();
            this.labelSupplier = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Font = new System.Drawing.Font("Lucida Bright", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.Location = new System.Drawing.Point(596, 355);
            this.buttonSubmit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(270, 55);
            this.buttonSubmit.TabIndex = 0;
            this.buttonSubmit.Text = "SUBMIT";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // labelPhoneNo
            // 
            this.labelPhoneNo.AutoSize = true;
            this.labelPhoneNo.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhoneNo.Location = new System.Drawing.Point(380, 276);
            this.labelPhoneNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPhoneNo.Name = "labelPhoneNo";
            this.labelPhoneNo.Size = new System.Drawing.Size(149, 31);
            this.labelPhoneNo.TabIndex = 1;
            this.labelPhoneNo.Text = "Phone No";
            // 
            // labelFullName
            // 
            this.labelFullName.AutoSize = true;
            this.labelFullName.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFullName.Location = new System.Drawing.Point(380, 191);
            this.labelFullName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(155, 31);
            this.labelFullName.TabIndex = 2;
            this.labelFullName.Text = "Full Name";
            // 
            // textBoxPhoneNo
            // 
            this.textBoxPhoneNo.Location = new System.Drawing.Point(596, 269);
            this.textBoxPhoneNo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxPhoneNo.Name = "textBoxPhoneNo";
            this.textBoxPhoneNo.Size = new System.Drawing.Size(408, 31);
            this.textBoxPhoneNo.TabIndex = 3;
            // 
            // textBoxFullName
            // 
            this.textBoxFullName.Location = new System.Drawing.Point(596, 184);
            this.textBoxFullName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxFullName.Name = "textBoxFullName";
            this.textBoxFullName.Size = new System.Drawing.Size(408, 31);
            this.textBoxFullName.TabIndex = 4;
            // 
            // linkLabelNotRegistered
            // 
            this.linkLabelNotRegistered.AutoSize = true;
            this.linkLabelNotRegistered.Location = new System.Drawing.Point(590, 460);
            this.linkLabelNotRegistered.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabelNotRegistered.Name = "linkLabelNotRegistered";
            this.linkLabelNotRegistered.Size = new System.Drawing.Size(321, 23);
            this.linkLabelNotRegistered.TabIndex = 5;
            this.linkLabelNotRegistered.TabStop = true;
            this.linkLabelNotRegistered.Text = "Not Registered Yet? Click Here";
            this.linkLabelNotRegistered.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelNotRegistered_LinkClicked);
            // 
            // labelSupplier
            // 
            this.labelSupplier.AutoSize = true;
            this.labelSupplier.Font = new System.Drawing.Font("Lucida Bright", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSupplier.Location = new System.Drawing.Point(585, 46);
            this.labelSupplier.Name = "labelSupplier";
            this.labelSupplier.Size = new System.Drawing.Size(255, 54);
            this.labelSupplier.TabIndex = 6;
            this.labelSupplier.Text = "SUPPLIER";
            // 
            // SupplierSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 554);
            this.Controls.Add(this.labelSupplier);
            this.Controls.Add(this.linkLabelNotRegistered);
            this.Controls.Add(this.textBoxFullName);
            this.Controls.Add(this.textBoxPhoneNo);
            this.Controls.Add(this.labelFullName);
            this.Controls.Add(this.labelPhoneNo);
            this.Controls.Add(this.buttonSubmit);
            this.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "SupplierSearch";
            this.Text = "SupplierSearch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Label labelPhoneNo;
        private System.Windows.Forms.Label labelFullName;
        private System.Windows.Forms.TextBox textBoxPhoneNo;
        private System.Windows.Forms.TextBox textBoxFullName;
        private System.Windows.Forms.LinkLabel linkLabelNotRegistered;
        private System.Windows.Forms.Label labelSupplier;
    }
}