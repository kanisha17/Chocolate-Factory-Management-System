
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cLEARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelCurrentDate = new System.Windows.Forms.Label();
            this.labelEID = new System.Windows.Forms.Label();
            this.labelMark = new System.Windows.Forms.Label();
            this.textBoxEID = new System.Windows.Forms.TextBox();
            this.dateTimePickerCurrentDate = new System.Windows.Forms.DateTimePicker();
            this.labelReason = new System.Windows.Forms.Label();
            this.textBoxReason = new System.Windows.Forms.TextBox();
            this.checkedListBoxMark = new System.Windows.Forms.CheckedListBox();
            this.labeleattend = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.labelCurrentDate.Location = new System.Drawing.Point(406, 255);
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
            this.labelEID.Location = new System.Drawing.Point(406, 194);
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
            this.labelMark.Location = new System.Drawing.Point(406, 320);
            this.labelMark.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMark.Name = "labelMark";
            this.labelMark.Size = new System.Drawing.Size(185, 44);
            this.labelMark.TabIndex = 20;
            this.labelMark.Text = "Mark";
            // 
            // textBoxEID
            // 
            this.textBoxEID.Location = new System.Drawing.Point(675, 194);
            this.textBoxEID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxEID.Name = "textBoxEID";
            this.textBoxEID.Size = new System.Drawing.Size(355, 31);
            this.textBoxEID.TabIndex = 9;
            // 
            // dateTimePickerCurrentDate
            // 
            this.dateTimePickerCurrentDate.Location = new System.Drawing.Point(675, 260);
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
            this.labelReason.Location = new System.Drawing.Point(406, 399);
            this.labelReason.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelReason.Name = "labelReason";
            this.labelReason.Size = new System.Drawing.Size(132, 36);
            this.labelReason.TabIndex = 12;
            this.labelReason.Text = "Reason";
            // 
            // textBoxReason
            // 
            this.textBoxReason.Location = new System.Drawing.Point(675, 404);
            this.textBoxReason.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxReason.Name = "textBoxReason";
            this.textBoxReason.Size = new System.Drawing.Size(355, 31);
            this.textBoxReason.TabIndex = 14;
            // 
            // checkedListBoxMark
            // 
            this.checkedListBoxMark.FormattingEnabled = true;
            this.checkedListBoxMark.Items.AddRange(new object[] {
            "Absent",
            "Present"});
            this.checkedListBoxMark.Location = new System.Drawing.Point(675, 332);
            this.checkedListBoxMark.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkedListBoxMark.Name = "checkedListBoxMark";
            this.checkedListBoxMark.Size = new System.Drawing.Size(355, 32);
            this.checkedListBoxMark.TabIndex = 18;
            // 
            // labeleattend
            // 
            this.labeleattend.AutoSize = true;
            this.labeleattend.BackColor = System.Drawing.Color.Transparent;
            this.labeleattend.Font = new System.Drawing.Font("Imprint MT Shadow", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeleattend.ForeColor = System.Drawing.Color.DarkRed;
            this.labeleattend.Location = new System.Drawing.Point(352, 57);
            this.labeleattend.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labeleattend.Name = "labeleattend";
            this.labeleattend.Size = new System.Drawing.Size(757, 61);
            this.labeleattend.TabIndex = 23;
            this.labeleattend.Text = "EMPLOYEE ATTENDANCE";
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BackColor = System.Drawing.Color.DarkRed;
            this.buttonSubmit.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSubmit.Location = new System.Drawing.Point(675, 466);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(355, 55);
            this.buttonSubmit.TabIndex = 24;
            this.buttonSubmit.Text = "SUBMIT";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Click += new System.EventHandler(this.button1_Click);
            // 
            // EmployeeAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Chocolate_Factory_Management_System.Properties.Resources.Background_Color12;
            this.ClientSize = new System.Drawing.Size(1314, 565);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.labeleattend);
            this.Controls.Add(this.checkedListBoxMark);
            this.Controls.Add(this.textBoxReason);
            this.Controls.Add(this.labelReason);
            this.Controls.Add(this.dateTimePickerCurrentDate);
            this.Controls.Add(this.textBoxEID);
            this.Controls.Add(this.labelMark);
            this.Controls.Add(this.labelEID);
            this.Controls.Add(this.labelCurrentDate);
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cLEARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXITToolStripMenuItem;
        private System.Windows.Forms.Label labelCurrentDate;
        private System.Windows.Forms.Label labelEID;
        private System.Windows.Forms.Label labelMark;
        private System.Windows.Forms.TextBox textBoxEID;
        private System.Windows.Forms.DateTimePicker dateTimePickerCurrentDate;
        private System.Windows.Forms.Label labelReason;
        private System.Windows.Forms.TextBox textBoxReason;
        private System.Windows.Forms.CheckedListBox checkedListBoxMark;
        private System.Windows.Forms.Label labeleattend;
        private System.Windows.Forms.Button buttonSubmit;
    }
}