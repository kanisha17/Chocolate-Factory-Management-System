
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
            this.dataGridViewEmpAttendance = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mENUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eDITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dELETEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEFRESHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cLEARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vIEWToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sEARCHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eMPDETAILSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eMPATTENDANCEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpAttendance)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(490, 7);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(214, 26);
            this.textBoxSearch.TabIndex = 2;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridViewEmpAttendance
            // 
            this.dataGridViewEmpAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmpAttendance.Location = new System.Drawing.Point(12, 329);
            this.dataGridViewEmpAttendance.Name = "dataGridViewEmpAttendance";
            this.dataGridViewEmpAttendance.RowHeadersWidth = 62;
            this.dataGridViewEmpAttendance.RowTemplate.Height = 28;
            this.dataGridViewEmpAttendance.Size = new System.Drawing.Size(1268, 182);
            this.dataGridViewEmpAttendance.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mENUToolStripMenuItem,
            this.rEFRESHToolStripMenuItem,
            this.cLEARToolStripMenuItem,
            this.vIEWToolStripMenuItem,
            this.eXITToolStripMenuItem,
            this.sEARCHToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1292, 33);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // mENUToolStripMenuItem
            // 
            this.mENUToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aDDToolStripMenuItem,
            this.eDITToolStripMenuItem,
            this.dELETEToolStripMenuItem});
            this.mENUToolStripMenuItem.Name = "mENUToolStripMenuItem";
            this.mENUToolStripMenuItem.Size = new System.Drawing.Size(78, 29);
            this.mENUToolStripMenuItem.Text = "MENU";
            this.mENUToolStripMenuItem.Click += new System.EventHandler(this.mENUToolStripMenuItem_Click);
            // 
            // aDDToolStripMenuItem
            // 
            this.aDDToolStripMenuItem.Name = "aDDToolStripMenuItem";
            this.aDDToolStripMenuItem.Size = new System.Drawing.Size(171, 34);
            this.aDDToolStripMenuItem.Text = "ADD";
            this.aDDToolStripMenuItem.Click += new System.EventHandler(this.aDDToolStripMenuItem_Click);
            // 
            // eDITToolStripMenuItem
            // 
            this.eDITToolStripMenuItem.Name = "eDITToolStripMenuItem";
            this.eDITToolStripMenuItem.Size = new System.Drawing.Size(171, 34);
            this.eDITToolStripMenuItem.Text = "EDIT";
            this.eDITToolStripMenuItem.Click += new System.EventHandler(this.eDITToolStripMenuItem_Click);
            // 
            // dELETEToolStripMenuItem
            // 
            this.dELETEToolStripMenuItem.Name = "dELETEToolStripMenuItem";
            this.dELETEToolStripMenuItem.Size = new System.Drawing.Size(171, 34);
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
            // cLEARToolStripMenuItem
            // 
            this.cLEARToolStripMenuItem.Name = "cLEARToolStripMenuItem";
            this.cLEARToolStripMenuItem.Size = new System.Drawing.Size(79, 29);
            this.cLEARToolStripMenuItem.Text = "CLEAR";
            this.cLEARToolStripMenuItem.Click += new System.EventHandler(this.cLEARToolStripMenuItem_Click);
            // 
            // vIEWToolStripMenuItem
            // 
            this.vIEWToolStripMenuItem.Name = "vIEWToolStripMenuItem";
            this.vIEWToolStripMenuItem.Size = new System.Drawing.Size(70, 29);
            this.vIEWToolStripMenuItem.Text = "VIEW";
            this.vIEWToolStripMenuItem.Click += new System.EventHandler(this.vIEWToolStripMenuItem_Click);
            // 
            // eXITToolStripMenuItem
            // 
            this.eXITToolStripMenuItem.Name = "eXITToolStripMenuItem";
            this.eXITToolStripMenuItem.Size = new System.Drawing.Size(62, 29);
            this.eXITToolStripMenuItem.Text = "EXIT";
            this.eXITToolStripMenuItem.Click += new System.EventHandler(this.eXITToolStripMenuItem_Click);
            // 
            // sEARCHToolStripMenuItem
            // 
            this.sEARCHToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eMPDETAILSToolStripMenuItem,
            this.eMPATTENDANCEToolStripMenuItem});
            this.sEARCHToolStripMenuItem.Name = "sEARCHToolStripMenuItem";
            this.sEARCHToolStripMenuItem.Size = new System.Drawing.Size(94, 29);
            this.sEARCHToolStripMenuItem.Text = "SEARCH";
            // 
            // eMPDETAILSToolStripMenuItem
            // 
            this.eMPDETAILSToolStripMenuItem.Name = "eMPDETAILSToolStripMenuItem";
            this.eMPDETAILSToolStripMenuItem.Size = new System.Drawing.Size(263, 34);
            this.eMPDETAILSToolStripMenuItem.Text = "EMP DETAILS";
            this.eMPDETAILSToolStripMenuItem.Click += new System.EventHandler(this.eMPDETAILSToolStripMenuItem_Click);
            // 
            // eMPATTENDANCEToolStripMenuItem
            // 
            this.eMPATTENDANCEToolStripMenuItem.Name = "eMPATTENDANCEToolStripMenuItem";
            this.eMPATTENDANCEToolStripMenuItem.Size = new System.Drawing.Size(263, 34);
            this.eMPATTENDANCEToolStripMenuItem.Text = "EMP ATTENDANCE";
            this.eMPATTENDANCEToolStripMenuItem.Click += new System.EventHandler(this.eMPATTENDANCEToolStripMenuItem_Click);
            // 
            // labelCurrentDate
            // 
            this.labelCurrentDate.AutoSize = true;
            this.labelCurrentDate.Location = new System.Drawing.Point(95, 186);
            this.labelCurrentDate.Name = "labelCurrentDate";
            this.labelCurrentDate.Size = new System.Drawing.Size(101, 20);
            this.labelCurrentDate.TabIndex = 5;
            this.labelCurrentDate.Text = "Current Date";
            // 
            // labelEID
            // 
            this.labelEID.AutoSize = true;
            this.labelEID.Location = new System.Drawing.Point(95, 128);
            this.labelEID.Name = "labelEID";
            this.labelEID.Size = new System.Drawing.Size(37, 20);
            this.labelEID.TabIndex = 6;
            this.labelEID.Text = "EID";
            // 
            // labelMark
            // 
            this.labelMark.AutoSize = true;
            this.labelMark.Location = new System.Drawing.Point(95, 242);
            this.labelMark.Name = "labelMark";
            this.labelMark.Size = new System.Drawing.Size(44, 20);
            this.labelMark.TabIndex = 7;
            this.labelMark.Text = "Mark";
            this.labelMark.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBoxEID
            // 
            this.textBoxEID.Location = new System.Drawing.Point(254, 125);
            this.textBoxEID.Name = "textBoxEID";
            this.textBoxEID.Size = new System.Drawing.Size(247, 26);
            this.textBoxEID.TabIndex = 9;
            // 
            // dateTimePickerCurrentDate
            // 
            this.dateTimePickerCurrentDate.Location = new System.Drawing.Point(254, 180);
            this.dateTimePickerCurrentDate.Name = "dateTimePickerCurrentDate";
            this.dateTimePickerCurrentDate.Size = new System.Drawing.Size(247, 26);
            this.dateTimePickerCurrentDate.TabIndex = 10;
            // 
            // labelReason
            // 
            this.labelReason.AutoSize = true;
            this.labelReason.Location = new System.Drawing.Point(665, 189);
            this.labelReason.Name = "labelReason";
            this.labelReason.Size = new System.Drawing.Size(65, 20);
            this.labelReason.TabIndex = 12;
            this.labelReason.Text = "Reason";
            // 
            // labelPermission
            // 
            this.labelPermission.AutoSize = true;
            this.labelPermission.Location = new System.Drawing.Point(665, 125);
            this.labelPermission.Name = "labelPermission";
            this.labelPermission.Size = new System.Drawing.Size(86, 20);
            this.labelPermission.TabIndex = 13;
            this.labelPermission.Text = "Permission";
            // 
            // textBoxReason
            // 
            this.textBoxReason.Location = new System.Drawing.Point(795, 189);
            this.textBoxReason.Name = "textBoxReason";
            this.textBoxReason.Size = new System.Drawing.Size(219, 26);
            this.textBoxReason.TabIndex = 14;
            // 
            // checkedListBoxPermission
            // 
            this.checkedListBoxPermission.FormattingEnabled = true;
            this.checkedListBoxPermission.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.checkedListBoxPermission.Location = new System.Drawing.Point(795, 118);
            this.checkedListBoxPermission.Name = "checkedListBoxPermission";
            this.checkedListBoxPermission.Size = new System.Drawing.Size(219, 27);
            this.checkedListBoxPermission.TabIndex = 17;
            // 
            // checkedListBoxMark
            // 
            this.checkedListBoxMark.FormattingEnabled = true;
            this.checkedListBoxMark.Items.AddRange(new object[] {
            "Absent",
            "Present"});
            this.checkedListBoxMark.Location = new System.Drawing.Point(254, 242);
            this.checkedListBoxMark.Name = "checkedListBoxMark";
            this.checkedListBoxMark.Size = new System.Drawing.Size(247, 27);
            this.checkedListBoxMark.TabIndex = 18;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(319, 96);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 19;
            this.buttonSearch.Text = "SEARCH";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click_1);
            // 
            // EmployeeAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 523);
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
            this.Controls.Add(this.dataGridViewEmpAttendance);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "EmployeeAttendance";
            this.Text = "EmployeeAttendance";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpAttendance)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.DataGridView dataGridViewEmpAttendance;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mENUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aDDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eDITToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dELETEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rEFRESHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cLEARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vIEWToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXITToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sEARCHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eMPDETAILSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eMPATTENDANCEToolStripMenuItem;
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
    }
}