
namespace Chocolate_Factory_Management_System
{
    partial class EmployeeAttendance
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
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mENUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cLEARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelCurrentDate = new System.Windows.Forms.Label();
            this.labelEID = new System.Windows.Forms.Label();
            this.labelMark = new System.Windows.Forms.Label();
            this.textBoxEID = new System.Windows.Forms.TextBox();
            this.dateTimePickerCurrentDate = new System.Windows.Forms.DateTimePicker();
            this.labelReason = new System.Windows.Forms.Label();
            this.labelPermission = new System.Windows.Forms.Label();
            this.textBoxReason = new System.Windows.Forms.TextBox();
            this.checkedListBoxPermission = new System.Windows.Forms.CheckedListBox();
            this.checkedListBoxMark = new System.Windows.Forms.CheckedListBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labeleattend = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(179, 145);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(240, 31);
            this.textBoxSearch.TabIndex = 21;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mENUToolStripMenuItem,
            this.cLEARToolStripMenuItem,
            this.eXITToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(13, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1314, 42);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // mENUToolStripMenuItem
            // 
            this.mENUToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mENUToolStripMenuItem.Image = global::Chocolate_Factory_Management_System.Properties.Resources.add2;
            this.mENUToolStripMenuItem.Name = "mENUToolStripMenuItem";
            this.mENUToolStripMenuItem.Size = new System.Drawing.Size(96, 36);
            this.mENUToolStripMenuItem.Text = "ADD";
            this.mENUToolStripMenuItem.Click += new System.EventHandler(this.mENUToolStripMenuItem_Click);
            // 
            // cLEARToolStripMenuItem
            // 
            this.cLEARToolStripMenuItem.Image = global::Chocolate_Factory_Management_System.Properties.Resources.clear;
            this.cLEARToolStripMenuItem.Name = "cLEARToolStripMenuItem";
            this.cLEARToolStripMenuItem.Size = new System.Drawing.Size(128, 36);
            this.cLEARToolStripMenuItem.Text = "CLEAR";
            this.cLEARToolStripMenuItem.Click += new System.EventHandler(this.cLEARToolStripMenuItem_Click);
            // 
            // eXITToolStripMenuItem
            // 
            this.eXITToolStripMenuItem.Image = global::Chocolate_Factory_Management_System.Properties.Resources.exit1;
            this.eXITToolStripMenuItem.Name = "eXITToolStripMenuItem";
            this.eXITToolStripMenuItem.Size = new System.Drawing.Size(106, 36);
            this.eXITToolStripMenuItem.Text = "EXIT";
            this.eXITToolStripMenuItem.Click += new System.EventHandler(this.eXITToolStripMenuItem_Click);
            // 
            // labelCurrentDate
            // 
            this.labelCurrentDate.AutoSize = true;
            this.labelCurrentDate.BackColor = System.Drawing.Color.Transparent;
            this.labelCurrentDate.Font = new System.Drawing.Font("Lucida Bright", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelCurrentDate.Location = new System.Drawing.Point(466, 266);
            this.labelCurrentDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCurrentDate.Name = "labelCurrentDate";
            this.labelCurrentDate.Size = new System.Drawing.Size(225, 36);
            this.labelCurrentDate.TabIndex = 5;
            this.labelCurrentDate.Text = "Current Date";
            // 
            // labelEID
            // 
            this.labelEID.AutoSize = true;
            this.labelEID.BackColor = System.Drawing.Color.Transparent;
            this.labelEID.Font = new System.Drawing.Font("Lucida Bright", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelEID.Location = new System.Drawing.Point(466, 191);
            this.labelEID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEID.Name = "labelEID";
            this.labelEID.Size = new System.Drawing.Size(225, 36);
            this.labelEID.TabIndex = 6;
            this.labelEID.Text = "Employee ID";
            // 
            // labelMark
            // 
            this.labelMark.BackColor = System.Drawing.Color.Transparent;
            this.labelMark.Font = new System.Drawing.Font("Lucida Bright", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMark.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelMark.Location = new System.Drawing.Point(466, 342);
            this.labelMark.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMark.Name = "labelMark";
            this.labelMark.Size = new System.Drawing.Size(185, 44);
            this.labelMark.TabIndex = 20;
            this.labelMark.Text = "Mark";
            // 
            // textBoxEID
            // 
            this.textBoxEID.Location = new System.Drawing.Point(735, 191);
            this.textBoxEID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxEID.Name = "textBoxEID";
            this.textBoxEID.Size = new System.Drawing.Size(355, 31);
            this.textBoxEID.TabIndex = 9;
            // 
            // dateTimePickerCurrentDate
            // 
            this.dateTimePickerCurrentDate.Location = new System.Drawing.Point(735, 266);
            this.dateTimePickerCurrentDate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dateTimePickerCurrentDate.Name = "dateTimePickerCurrentDate";
            this.dateTimePickerCurrentDate.Size = new System.Drawing.Size(355, 31);
            this.dateTimePickerCurrentDate.TabIndex = 10;
            // 
            // labelReason
            // 
            this.labelReason.AutoSize = true;
            this.labelReason.BackColor = System.Drawing.Color.Transparent;
            this.labelReason.Font = new System.Drawing.Font("Lucida Bright", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReason.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelReason.Location = new System.Drawing.Point(466, 485);
            this.labelReason.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelReason.Name = "labelReason";
            this.labelReason.Size = new System.Drawing.Size(132, 36);
            this.labelReason.TabIndex = 12;
            this.labelReason.Text = "Reason";
            // 
            // labelPermission
            // 
            this.labelPermission.AutoSize = true;
            this.labelPermission.BackColor = System.Drawing.Color.Transparent;
            this.labelPermission.Font = new System.Drawing.Font("Lucida Bright", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPermission.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelPermission.Location = new System.Drawing.Point(466, 409);
            this.labelPermission.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPermission.Name = "labelPermission";
            this.labelPermission.Size = new System.Drawing.Size(200, 36);
            this.labelPermission.TabIndex = 13;
            this.labelPermission.Text = "Permission";
            // 
            // textBoxReason
            // 
            this.textBoxReason.Location = new System.Drawing.Point(735, 485);
            this.textBoxReason.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxReason.Name = "textBoxReason";
            this.textBoxReason.Size = new System.Drawing.Size(355, 31);
            this.textBoxReason.TabIndex = 14;
            // 
            // checkedListBoxPermission
            // 
            this.checkedListBoxPermission.FormattingEnabled = true;
            this.checkedListBoxPermission.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.checkedListBoxPermission.Location = new System.Drawing.Point(735, 409);
            this.checkedListBoxPermission.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkedListBoxPermission.Name = "checkedListBoxPermission";
            this.checkedListBoxPermission.Size = new System.Drawing.Size(355, 32);
            this.checkedListBoxPermission.TabIndex = 17;
            // 
            // checkedListBoxMark
            // 
            this.checkedListBoxMark.FormattingEnabled = true;
            this.checkedListBoxMark.Items.AddRange(new object[] {
            "Absent",
            "Present"});
            this.checkedListBoxMark.Location = new System.Drawing.Point(735, 342);
            this.checkedListBoxMark.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkedListBoxMark.Name = "checkedListBoxMark";
            this.checkedListBoxMark.Size = new System.Drawing.Size(355, 32);
            this.checkedListBoxMark.TabIndex = 18;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.DarkRed;
            this.buttonSearch.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSearch.Location = new System.Drawing.Point(14, 118);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(157, 58);
            this.buttonSearch.TabIndex = 19;
            this.buttonSearch.Text = "SEARCH";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(179, 118);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 23);
            this.label1.TabIndex = 22;
            this.label1.Text = "Enter Attendance No";
            // 
            // labeleattend
            // 
            this.labeleattend.AutoSize = true;
            this.labeleattend.BackColor = System.Drawing.Color.Transparent;
            this.labeleattend.Font = new System.Drawing.Font("Imprint MT Shadow", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeleattend.ForeColor = System.Drawing.Color.DarkRed;
            this.labeleattend.Location = new System.Drawing.Point(455, 52);
            this.labeleattend.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labeleattend.Name = "labeleattend";
            this.labeleattend.Size = new System.Drawing.Size(757, 61);
            this.labeleattend.TabIndex = 23;
            this.labeleattend.Text = "EMPLOYEE ATTENDANCE";
            // 
            // EmployeeAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Chocolate_Factory_Management_System.Properties.Resources.Background_Color12;
            this.ClientSize = new System.Drawing.Size(1314, 565);
            this.Controls.Add(this.labeleattend);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.checkedListBoxMark);
            this.Controls.Add(this.checkedListBoxPermission);
            this.Controls.Add(this.textBoxReason);
            this.Controls.Add(this.labelPermission);
            this.Controls.Add(this.labelReason);
            this.Controls.Add(this.dateTimePickerCurrentDate);
            this.Controls.Add(this.textBoxEID);
            this.Controls.Add(this.labelMark);
            this.Controls.Add(this.labelEID);
            this.Controls.Add(this.labelCurrentDate);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "EmployeeAttendance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeAttendance";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mENUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cLEARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXITToolStripMenuItem;
        private System.Windows.Forms.Label labelCurrentDate;
        private System.Windows.Forms.Label labelEID;
        private System.Windows.Forms.Label labelMark;
        private System.Windows.Forms.TextBox textBoxEID;
        private System.Windows.Forms.DateTimePicker dateTimePickerCurrentDate;
        private System.Windows.Forms.Label labelReason;
        private System.Windows.Forms.Label labelPermission;
        private System.Windows.Forms.TextBox textBoxReason;
        private System.Windows.Forms.CheckedListBox checkedListBoxPermission;
        private System.Windows.Forms.CheckedListBox checkedListBoxMark;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labeleattend;
    }
}