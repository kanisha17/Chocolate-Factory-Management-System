
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
            this.labelAttendanceID = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelEmployeeAttendance = new System.Windows.Forms.Label();
            this.labelCurrentDate = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelMark = new System.Windows.Forms.Label();
            this.labelPermission = new System.Windows.Forms.Label();
            this.labelReason = new System.Windows.Forms.Label();
            this.checkedListBoxPermission = new System.Windows.Forms.CheckedListBox();
            this.checkedListBoxMark = new System.Windows.Forms.CheckedListBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxAttendanceID = new System.Windows.Forms.TextBox();
            this.textBoxReason = new System.Windows.Forms.TextBox();
            this.dataGridViewEmpAttendance = new System.Windows.Forms.DataGridView();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.dateTimePickerCurrentDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpAttendance)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAttendanceID
            // 
            this.labelAttendanceID.AutoSize = true;
            this.labelAttendanceID.Location = new System.Drawing.Point(21, 82);
            this.labelAttendanceID.Name = "labelAttendanceID";
            this.labelAttendanceID.Size = new System.Drawing.Size(109, 20);
            this.labelAttendanceID.TabIndex = 0;
            this.labelAttendanceID.Text = "AttendanceID";
            this.labelAttendanceID.Click += new System.EventHandler(this.labelAttendanceID_Click);
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(21, 168);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(86, 20);
            this.labelLastName.TabIndex = 1;
            this.labelLastName.Text = "Last Name";
            // 
            // labelEmployeeAttendance
            // 
            this.labelEmployeeAttendance.AutoSize = true;
            this.labelEmployeeAttendance.Location = new System.Drawing.Point(501, 27);
            this.labelEmployeeAttendance.Name = "labelEmployeeAttendance";
            this.labelEmployeeAttendance.Size = new System.Drawing.Size(166, 20);
            this.labelEmployeeAttendance.TabIndex = 2;
            this.labelEmployeeAttendance.Text = "Employee Attendance";
            this.labelEmployeeAttendance.Click += new System.EventHandler(this.labelEmployeeAttendance_Click);
            // 
            // labelCurrentDate
            // 
            this.labelCurrentDate.AutoSize = true;
            this.labelCurrentDate.Location = new System.Drawing.Point(21, 218);
            this.labelCurrentDate.Name = "labelCurrentDate";
            this.labelCurrentDate.Size = new System.Drawing.Size(101, 20);
            this.labelCurrentDate.TabIndex = 3;
            this.labelCurrentDate.Text = "Current Date";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(21, 122);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(86, 20);
            this.labelFirstName.TabIndex = 4;
            this.labelFirstName.Text = "First Name";
            // 
            // labelMark
            // 
            this.labelMark.AutoSize = true;
            this.labelMark.Location = new System.Drawing.Point(732, 82);
            this.labelMark.Name = "labelMark";
            this.labelMark.Size = new System.Drawing.Size(44, 20);
            this.labelMark.TabIndex = 5;
            this.labelMark.Text = "Mark";
            // 
            // labelPermission
            // 
            this.labelPermission.AutoSize = true;
            this.labelPermission.Location = new System.Drawing.Point(732, 133);
            this.labelPermission.Name = "labelPermission";
            this.labelPermission.Size = new System.Drawing.Size(86, 20);
            this.labelPermission.TabIndex = 6;
            this.labelPermission.Text = "Permission";
            // 
            // labelReason
            // 
            this.labelReason.AutoSize = true;
            this.labelReason.Location = new System.Drawing.Point(732, 193);
            this.labelReason.Name = "labelReason";
            this.labelReason.Size = new System.Drawing.Size(65, 20);
            this.labelReason.TabIndex = 7;
            this.labelReason.Text = "Reason";
            // 
            // checkedListBoxPermission
            // 
            this.checkedListBoxPermission.FormattingEnabled = true;
            this.checkedListBoxPermission.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.checkedListBoxPermission.Location = new System.Drawing.Point(879, 130);
            this.checkedListBoxPermission.Name = "checkedListBoxPermission";
            this.checkedListBoxPermission.Size = new System.Drawing.Size(323, 27);
            this.checkedListBoxPermission.TabIndex = 9;
            // 
            // checkedListBoxMark
            // 
            this.checkedListBoxMark.FormattingEnabled = true;
            this.checkedListBoxMark.Items.AddRange(new object[] {
            "Present",
            "Absent"});
            this.checkedListBoxMark.Location = new System.Drawing.Point(879, 75);
            this.checkedListBoxMark.Name = "checkedListBoxMark";
            this.checkedListBoxMark.Size = new System.Drawing.Size(323, 27);
            this.checkedListBoxMark.TabIndex = 10;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(173, 130);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(299, 26);
            this.textBoxFirstName.TabIndex = 12;
            // 
            // textBoxAttendanceID
            // 
            this.textBoxAttendanceID.Location = new System.Drawing.Point(173, 82);
            this.textBoxAttendanceID.Name = "textBoxAttendanceID";
            this.textBoxAttendanceID.Size = new System.Drawing.Size(299, 26);
            this.textBoxAttendanceID.TabIndex = 13;
            // 
            // textBoxReason
            // 
            this.textBoxReason.Location = new System.Drawing.Point(879, 193);
            this.textBoxReason.Name = "textBoxReason";
            this.textBoxReason.Size = new System.Drawing.Size(323, 26);
            this.textBoxReason.TabIndex = 14;
            // 
            // dataGridViewEmpAttendance
            // 
            this.dataGridViewEmpAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmpAttendance.Location = new System.Drawing.Point(12, 287);
            this.dataGridViewEmpAttendance.Name = "dataGridViewEmpAttendance";
            this.dataGridViewEmpAttendance.RowHeadersWidth = 62;
            this.dataGridViewEmpAttendance.RowTemplate.Height = 28;
            this.dataGridViewEmpAttendance.Size = new System.Drawing.Size(1260, 304);
            this.dataGridViewEmpAttendance.TabIndex = 15;
            this.dataGridViewEmpAttendance.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEmpAttendance_CellContentClick);
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(173, 168);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(299, 26);
            this.textBoxLastName.TabIndex = 11;
            // 
            // dateTimePickerCurrentDate
            // 
            this.dateTimePickerCurrentDate.Location = new System.Drawing.Point(173, 218);
            this.dateTimePickerCurrentDate.Name = "dateTimePickerCurrentDate";
            this.dateTimePickerCurrentDate.Size = new System.Drawing.Size(299, 26);
            this.dateTimePickerCurrentDate.TabIndex = 8;
            // 
            // EmployeeAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 603);
            this.Controls.Add(this.dataGridViewEmpAttendance);
            this.Controls.Add(this.textBoxReason);
            this.Controls.Add(this.textBoxAttendanceID);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.checkedListBoxMark);
            this.Controls.Add(this.checkedListBoxPermission);
            this.Controls.Add(this.dateTimePickerCurrentDate);
            this.Controls.Add(this.labelReason);
            this.Controls.Add(this.labelPermission);
            this.Controls.Add(this.labelMark);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.labelCurrentDate);
            this.Controls.Add(this.labelEmployeeAttendance);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelAttendanceID);
            this.Name = "EmployeeAttendance";
            this.Text = "EmployeeAttendance";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpAttendance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAttendanceID;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelEmployeeAttendance;
        private System.Windows.Forms.Label labelCurrentDate;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelMark;
        private System.Windows.Forms.Label labelPermission;
        private System.Windows.Forms.Label labelReason;
        private System.Windows.Forms.CheckedListBox checkedListBoxPermission;
        private System.Windows.Forms.CheckedListBox checkedListBoxMark;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxAttendanceID;
        private System.Windows.Forms.TextBox textBoxReason;
        private System.Windows.Forms.DataGridView dataGridViewEmpAttendance;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.DateTimePicker dateTimePickerCurrentDate;
    }
}