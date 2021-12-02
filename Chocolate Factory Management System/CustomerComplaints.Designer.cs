
namespace Chocolate_Factory_Management_System
{
    partial class CustomerComplaints
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
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxPhoneNo = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelPhoneNo = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.eXITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelProductName = new System.Windows.Forms.Label();
            this.textBoximprovement = new System.Windows.Forms.TextBox();
            this.textBoxDefectmsg = new System.Windows.Forms.TextBox();
            this.labelimprovement = new System.Windows.Forms.Label();
            this.labelDescDefect = new System.Windows.Forms.Label();
            this.labelcheckcomplaint = new System.Windows.Forms.Label();
            this.labeltakenby = new System.Windows.Forms.Label();
            this.textBoxtakenby = new System.Windows.Forms.TextBox();
            this.checkedListBoxapprcomplaint = new System.Windows.Forms.CheckedListBox();
            this.labelCC = new System.Windows.Forms.Label();
            this.textBoxCID = new System.Windows.Forms.TextBox();
            this.labelCID = new System.Windows.Forms.Label();
            this.comboBoxProductName = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(332, 321);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(356, 31);
            this.textBoxEmail.TabIndex = 1;
            // 
            // textBoxPhoneNo
            // 
            this.textBoxPhoneNo.Location = new System.Drawing.Point(332, 262);
            this.textBoxPhoneNo.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPhoneNo.Name = "textBoxPhoneNo";
            this.textBoxPhoneNo.Size = new System.Drawing.Size(356, 31);
            this.textBoxPhoneNo.TabIndex = 2;
            this.textBoxPhoneNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPhoneNo_KeyPress);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(332, 202);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(356, 31);
            this.textBoxName.TabIndex = 3;
            this.textBoxName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxName_KeyPress);
            // 
            // labelPhoneNo
            // 
            this.labelPhoneNo.AutoSize = true;
            this.labelPhoneNo.BackColor = System.Drawing.Color.Transparent;
            this.labelPhoneNo.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhoneNo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelPhoneNo.Location = new System.Drawing.Point(39, 262);
            this.labelPhoneNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPhoneNo.Name = "labelPhoneNo";
            this.labelPhoneNo.Size = new System.Drawing.Size(149, 31);
            this.labelPhoneNo.TabIndex = 4;
            this.labelPhoneNo.Text = "Phone No";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.BackColor = System.Drawing.Color.Transparent;
            this.labelEmail.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelEmail.Location = new System.Drawing.Point(39, 321);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(89, 31);
            this.labelEmail.TabIndex = 5;
            this.labelEmail.Text = "Email";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelName.Location = new System.Drawing.Point(39, 202);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(239, 31);
            this.labelName.TabIndex = 6;
            this.labelName.Text = "Customer Name";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eXITToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(13, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(1303, 44);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // eXITToolStripMenuItem
            // 
            this.eXITToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.eXITToolStripMenuItem.Image = global::Chocolate_Factory_Management_System.Properties.Resources.exit1;
            this.eXITToolStripMenuItem.Name = "eXITToolStripMenuItem";
            this.eXITToolStripMenuItem.Size = new System.Drawing.Size(106, 36);
            this.eXITToolStripMenuItem.Text = "EXIT";
            this.eXITToolStripMenuItem.Click += new System.EventHandler(this.eXITToolStripMenuItem_Click);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonSubmit.Font = new System.Drawing.Font("Lucida Bright", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSubmit.Location = new System.Drawing.Point(769, 500);
            this.buttonSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(495, 58);
            this.buttonSubmit.TabIndex = 8;
            this.buttonSubmit.Text = "SUBMIT";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Location = new System.Drawing.Point(332, 382);
            this.dateTimePickerDate.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(356, 31);
            this.dateTimePickerDate.TabIndex = 10;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.BackColor = System.Drawing.Color.Transparent;
            this.labelDate.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelDate.Location = new System.Drawing.Point(39, 381);
            this.labelDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(78, 31);
            this.labelDate.TabIndex = 11;
            this.labelDate.Text = "Date";
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.BackColor = System.Drawing.Color.Transparent;
            this.labelProductName.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelProductName.Location = new System.Drawing.Point(39, 442);
            this.labelProductName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(214, 31);
            this.labelProductName.TabIndex = 14;
            this.labelProductName.Text = "Product Name";
            // 
            // textBoximprovement
            // 
            this.textBoximprovement.Location = new System.Drawing.Point(769, 286);
            this.textBoximprovement.Margin = new System.Windows.Forms.Padding(4);
            this.textBoximprovement.Multiline = true;
            this.textBoximprovement.Name = "textBoximprovement";
            this.textBoximprovement.Size = new System.Drawing.Size(495, 81);
            this.textBoximprovement.TabIndex = 16;
            // 
            // textBoxDefectmsg
            // 
            this.textBoxDefectmsg.Location = new System.Drawing.Point(769, 152);
            this.textBoxDefectmsg.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDefectmsg.Multiline = true;
            this.textBoxDefectmsg.Name = "textBoxDefectmsg";
            this.textBoxDefectmsg.Size = new System.Drawing.Size(495, 81);
            this.textBoxDefectmsg.TabIndex = 17;
            // 
            // labelimprovement
            // 
            this.labelimprovement.AutoSize = true;
            this.labelimprovement.BackColor = System.Drawing.Color.Transparent;
            this.labelimprovement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelimprovement.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelimprovement.Location = new System.Drawing.Point(752, 262);
            this.labelimprovement.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelimprovement.Name = "labelimprovement";
            this.labelimprovement.Size = new System.Drawing.Size(224, 25);
            this.labelimprovement.TabIndex = 18;
            this.labelimprovement.Text = "Suggested improvement";
            // 
            // labelDescDefect
            // 
            this.labelDescDefect.AutoSize = true;
            this.labelDescDefect.BackColor = System.Drawing.Color.Transparent;
            this.labelDescDefect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescDefect.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelDescDefect.Location = new System.Drawing.Point(752, 123);
            this.labelDescDefect.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDescDefect.Name = "labelDescDefect";
            this.labelDescDefect.Size = new System.Drawing.Size(259, 25);
            this.labelDescDefect.TabIndex = 19;
            this.labelDescDefect.Text = "Specific description of defect";
            // 
            // labelcheckcomplaint
            // 
            this.labelcheckcomplaint.AutoSize = true;
            this.labelcheckcomplaint.BackColor = System.Drawing.Color.Transparent;
            this.labelcheckcomplaint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcheckcomplaint.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelcheckcomplaint.Location = new System.Drawing.Point(752, 388);
            this.labelcheckcomplaint.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelcheckcomplaint.Name = "labelcheckcomplaint";
            this.labelcheckcomplaint.Size = new System.Drawing.Size(320, 25);
            this.labelcheckcomplaint.TabIndex = 20;
            this.labelcheckcomplaint.Text = "Please check appropriate complaint";
            // 
            // labeltakenby
            // 
            this.labeltakenby.AutoSize = true;
            this.labeltakenby.BackColor = System.Drawing.Color.Transparent;
            this.labeltakenby.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltakenby.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labeltakenby.Location = new System.Drawing.Point(39, 500);
            this.labeltakenby.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labeltakenby.Name = "labeltakenby";
            this.labeltakenby.Size = new System.Drawing.Size(286, 31);
            this.labeltakenby.TabIndex = 21;
            this.labeltakenby.Text = "Complaint taken by";
            // 
            // textBoxtakenby
            // 
            this.textBoxtakenby.Location = new System.Drawing.Point(332, 504);
            this.textBoxtakenby.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxtakenby.Name = "textBoxtakenby";
            this.textBoxtakenby.Size = new System.Drawing.Size(356, 31);
            this.textBoxtakenby.TabIndex = 22;
            this.textBoxtakenby.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxtakenby_KeyPress);
            // 
            // checkedListBoxapprcomplaint
            // 
            this.checkedListBoxapprcomplaint.FormattingEnabled = true;
            this.checkedListBoxapprcomplaint.Items.AddRange(new object[] {
            "Poor Quality",
            "Expire",
            "Change in taste",
            "No address of maker",
            "Incorrect packaging",
            "Improper information on label",
            "Any form of adulteration",
            "Other"});
            this.checkedListBoxapprcomplaint.Location = new System.Drawing.Point(769, 419);
            this.checkedListBoxapprcomplaint.Margin = new System.Windows.Forms.Padding(4);
            this.checkedListBoxapprcomplaint.Name = "checkedListBoxapprcomplaint";
            this.checkedListBoxapprcomplaint.Size = new System.Drawing.Size(495, 32);
            this.checkedListBoxapprcomplaint.TabIndex = 23;
            // 
            // labelCC
            // 
            this.labelCC.AutoSize = true;
            this.labelCC.BackColor = System.Drawing.Color.Transparent;
            this.labelCC.Font = new System.Drawing.Font("Lucida Bright", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCC.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelCC.Location = new System.Drawing.Point(458, 44);
            this.labelCC.Name = "labelCC";
            this.labelCC.Size = new System.Drawing.Size(646, 54);
            this.labelCC.TabIndex = 24;
            this.labelCC.Text = "CUSTOMER COMPLAINTS";
            // 
            // textBoxCID
            // 
            this.textBoxCID.Location = new System.Drawing.Point(332, 137);
            this.textBoxCID.Name = "textBoxCID";
            this.textBoxCID.Size = new System.Drawing.Size(356, 31);
            this.textBoxCID.TabIndex = 25;
            this.textBoxCID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCID_KeyPress);
            // 
            // labelCID
            // 
            this.labelCID.AutoSize = true;
            this.labelCID.BackColor = System.Drawing.Color.Transparent;
            this.labelCID.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCID.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelCID.Location = new System.Drawing.Point(39, 133);
            this.labelCID.Name = "labelCID";
            this.labelCID.Size = new System.Drawing.Size(191, 31);
            this.labelCID.TabIndex = 26;
            this.labelCID.Text = "Customer ID";
            // 
            // comboBoxProductName
            // 
            this.comboBoxProductName.FormattingEnabled = true;
            this.comboBoxProductName.Location = new System.Drawing.Point(332, 442);
            this.comboBoxProductName.Name = "comboBoxProductName";
            this.comboBoxProductName.Size = new System.Drawing.Size(356, 31);
            this.comboBoxProductName.TabIndex = 27;
            // 
            // CustomerComplaints
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Chocolate_Factory_Management_System.Properties.Resources.b51;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1303, 571);
            this.Controls.Add(this.comboBoxProductName);
            this.Controls.Add(this.labelCID);
            this.Controls.Add(this.textBoxCID);
            this.Controls.Add(this.labelCC);
            this.Controls.Add(this.checkedListBoxapprcomplaint);
            this.Controls.Add(this.textBoxtakenby);
            this.Controls.Add(this.labeltakenby);
            this.Controls.Add(this.labelcheckcomplaint);
            this.Controls.Add(this.labelDescDefect);
            this.Controls.Add(this.labelimprovement);
            this.Controls.Add(this.textBoxDefectmsg);
            this.Controls.Add(this.textBoximprovement);
            this.Controls.Add(this.labelProductName);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.dateTimePickerDate);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelPhoneNo);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxPhoneNo);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CustomerComplaints";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerComplaints";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CustomerComplaints_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxPhoneNo;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelPhoneNo;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.ToolStripMenuItem eXITToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.TextBox textBoximprovement;
        private System.Windows.Forms.TextBox textBoxDefectmsg;
        private System.Windows.Forms.Label labelimprovement;
        private System.Windows.Forms.Label labelDescDefect;
        private System.Windows.Forms.Label labelcheckcomplaint;
        private System.Windows.Forms.Label labeltakenby;
        private System.Windows.Forms.TextBox textBoxtakenby;
        private System.Windows.Forms.CheckedListBox checkedListBoxapprcomplaint;
        private System.Windows.Forms.Label labelCC;
        private System.Windows.Forms.TextBox textBoxCID;
        private System.Windows.Forms.Label labelCID;
        private System.Windows.Forms.ComboBox comboBoxProductName;
    }
}