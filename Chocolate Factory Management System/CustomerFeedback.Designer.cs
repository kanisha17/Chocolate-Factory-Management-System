
namespace Chocolate_Factory_Management_System
{
    partial class CustomerFeedback
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
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.labelDate = new System.Windows.Forms.Label();
            this.textBoxPhoneNo = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelPhoneNo = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cLEARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.labelQ1 = new System.Windows.Forms.Label();
            this.checkedListBoxQ1 = new System.Windows.Forms.CheckedListBox();
            this.labelQ2 = new System.Windows.Forms.Label();
            this.textBoxQ2 = new System.Windows.Forms.TextBox();
            this.labelQ3 = new System.Windows.Forms.Label();
            this.checkedListBoxReview = new System.Windows.Forms.CheckedListBox();
            this.labeltosearch = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCID = new System.Windows.Forms.Label();
            this.textBoxCID = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Location = new System.Drawing.Point(277, 487);
            this.dateTimePickerDate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(287, 31);
            this.dateTimePickerDate.TabIndex = 13;
            this.dateTimePickerDate.ValueChanged += new System.EventHandler(this.dateTimePickerDate_ValueChanged);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.BackColor = System.Drawing.Color.Transparent;
            this.labelDate.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelDate.Location = new System.Drawing.Point(18, 487);
            this.labelDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(78, 31);
            this.labelDate.TabIndex = 1;
            this.labelDate.Text = "Date";
            this.labelDate.Click += new System.EventHandler(this.labelDate_Click);
            // 
            // textBoxPhoneNo
            // 
            this.textBoxPhoneNo.Location = new System.Drawing.Point(277, 423);
            this.textBoxPhoneNo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxPhoneNo.Name = "textBoxPhoneNo";
            this.textBoxPhoneNo.Size = new System.Drawing.Size(287, 31);
            this.textBoxPhoneNo.TabIndex = 12;
            this.textBoxPhoneNo.TextChanged += new System.EventHandler(this.textBoxPhoneNo_TextChanged);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(277, 297);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(287, 31);
            this.textBoxName.TabIndex = 11;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(277, 358);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(287, 31);
            this.textBoxEmail.TabIndex = 10;
            this.textBoxEmail.TextChanged += new System.EventHandler(this.textBoxEmail_TextChanged);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.BackColor = System.Drawing.Color.Transparent;
            this.labelEmail.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelEmail.Location = new System.Drawing.Point(18, 358);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(89, 31);
            this.labelEmail.TabIndex = 5;
            this.labelEmail.Text = "Email";
            this.labelEmail.Click += new System.EventHandler(this.labelEmail_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelName.Location = new System.Drawing.Point(18, 297);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(239, 31);
            this.labelName.TabIndex = 6;
            this.labelName.Text = "Customer Name";
            this.labelName.Click += new System.EventHandler(this.labelName_Click);
            // 
            // labelPhoneNo
            // 
            this.labelPhoneNo.AutoSize = true;
            this.labelPhoneNo.BackColor = System.Drawing.Color.Transparent;
            this.labelPhoneNo.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhoneNo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelPhoneNo.Location = new System.Drawing.Point(18, 423);
            this.labelPhoneNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPhoneNo.Name = "labelPhoneNo";
            this.labelPhoneNo.Size = new System.Drawing.Size(149, 31);
            this.labelPhoneNo.TabIndex = 7;
            this.labelPhoneNo.Text = "Phone No";
            this.labelPhoneNo.Click += new System.EventHandler(this.labelPhoneNo_Click);
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
            this.menuStrip1.Size = new System.Drawing.Size(1362, 42);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cLEARToolStripMenuItem
            // 
            this.cLEARToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cLEARToolStripMenuItem.Image = global::Chocolate_Factory_Management_System.Properties.Resources.clear;
            this.cLEARToolStripMenuItem.Name = "cLEARToolStripMenuItem";
            this.cLEARToolStripMenuItem.Size = new System.Drawing.Size(128, 36);
            this.cLEARToolStripMenuItem.Text = "CLEAR";
            this.cLEARToolStripMenuItem.Click += new System.EventHandler(this.cLEARToolStripMenuItem_Click);
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(25, 534);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(539, 60);
            this.button1.TabIndex = 9;
            this.button1.Text = "SUBMIT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonSearch.Font = new System.Drawing.Font("Lucida Bright", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Location = new System.Drawing.Point(25, 141);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(174, 55);
            this.buttonSearch.TabIndex = 14;
            this.buttonSearch.Text = "SEARCH";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(207, 167);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(286, 29);
            this.textBoxSearch.TabIndex = 15;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // labelQ1
            // 
            this.labelQ1.AutoSize = true;
            this.labelQ1.BackColor = System.Drawing.Color.Transparent;
            this.labelQ1.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQ1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelQ1.Location = new System.Drawing.Point(622, 141);
            this.labelQ1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQ1.Name = "labelQ1";
            this.labelQ1.Size = new System.Drawing.Size(641, 23);
            this.labelQ1.TabIndex = 16;
            this.labelQ1.Text = "Q1) Overall, how satisfied were you with the product/service?";
            // 
            // checkedListBoxQ1
            // 
            this.checkedListBoxQ1.FormattingEnabled = true;
            this.checkedListBoxQ1.Items.AddRange(new object[] {
            "Very Satisfied",
            "Satisfied",
            "Undecided",
            "Unsatisfied",
            "Very Unsatisfied"});
            this.checkedListBoxQ1.Location = new System.Drawing.Point(630, 174);
            this.checkedListBoxQ1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkedListBoxQ1.Name = "checkedListBoxQ1";
            this.checkedListBoxQ1.Size = new System.Drawing.Size(633, 144);
            this.checkedListBoxQ1.TabIndex = 17;
            this.checkedListBoxQ1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // labelQ2
            // 
            this.labelQ2.AutoSize = true;
            this.labelQ2.BackColor = System.Drawing.Color.Transparent;
            this.labelQ2.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQ2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelQ2.Location = new System.Drawing.Point(626, 330);
            this.labelQ2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQ2.Name = "labelQ2";
            this.labelQ2.Size = new System.Drawing.Size(728, 23);
            this.labelQ2.TabIndex = 18;
            this.labelQ2.Text = "Q2) Do you have any suggestions to improve our product and service?";
            // 
            // textBoxQ2
            // 
            this.textBoxQ2.Location = new System.Drawing.Point(631, 356);
            this.textBoxQ2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxQ2.Multiline = true;
            this.textBoxQ2.Name = "textBoxQ2";
            this.textBoxQ2.Size = new System.Drawing.Size(633, 124);
            this.textBoxQ2.TabIndex = 19;
            this.textBoxQ2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelQ3
            // 
            this.labelQ3.AutoSize = true;
            this.labelQ3.BackColor = System.Drawing.Color.Transparent;
            this.labelQ3.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQ3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelQ3.Location = new System.Drawing.Point(626, 501);
            this.labelQ3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQ3.Name = "labelQ3";
            this.labelQ3.Size = new System.Drawing.Size(135, 23);
            this.labelQ3.TabIndex = 20;
            this.labelQ3.Text = "Q3) Review?";
            // 
            // checkedListBoxReview
            // 
            this.checkedListBoxReview.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBoxReview.FormattingEnabled = true;
            this.checkedListBoxReview.Items.AddRange(new object[] {
            "*****",
            "****",
            "***",
            "**",
            "*"});
            this.checkedListBoxReview.Location = new System.Drawing.Point(629, 527);
            this.checkedListBoxReview.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkedListBoxReview.Name = "checkedListBoxReview";
            this.checkedListBoxReview.Size = new System.Drawing.Size(634, 67);
            this.checkedListBoxReview.TabIndex = 21;
            // 
            // labeltosearch
            // 
            this.labeltosearch.AutoSize = true;
            this.labeltosearch.BackColor = System.Drawing.Color.Transparent;
            this.labeltosearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labeltosearch.Location = new System.Drawing.Point(207, 141);
            this.labeltosearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labeltosearch.Name = "labeltosearch";
            this.labeltosearch.Size = new System.Drawing.Size(272, 23);
            this.labeltosearch.TabIndex = 22;
            this.labeltosearch.Text = "Enter Customer Phone No";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(446, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(580, 54);
            this.label1.TabIndex = 23;
            this.label1.Text = "CUSTOMER FEEDBACK";
            // 
            // labelCID
            // 
            this.labelCID.AutoSize = true;
            this.labelCID.BackColor = System.Drawing.Color.Transparent;
            this.labelCID.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCID.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelCID.Location = new System.Drawing.Point(19, 231);
            this.labelCID.Name = "labelCID";
            this.labelCID.Size = new System.Drawing.Size(191, 31);
            this.labelCID.TabIndex = 24;
            this.labelCID.Text = "Customer ID";
            // 
            // textBoxCID
            // 
            this.textBoxCID.Location = new System.Drawing.Point(277, 231);
            this.textBoxCID.Name = "textBoxCID";
            this.textBoxCID.Size = new System.Drawing.Size(287, 31);
            this.textBoxCID.TabIndex = 25;
            // 
            // CustomerFeedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Chocolate_Factory_Management_System.Properties.Resources.b52;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1362, 630);
            this.Controls.Add(this.textBoxCID);
            this.Controls.Add(this.labelCID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labeltosearch);
            this.Controls.Add(this.checkedListBoxReview);
            this.Controls.Add(this.labelQ3);
            this.Controls.Add(this.textBoxQ2);
            this.Controls.Add(this.labelQ2);
            this.Controls.Add(this.checkedListBoxQ1);
            this.Controls.Add(this.labelQ1);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelPhoneNo);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxPhoneNo);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.dateTimePickerDate);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "CustomerFeedback";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerFeedback";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.TextBox textBoxPhoneNo;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelPhoneNo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cLEARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXITToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label labelQ1;
        private System.Windows.Forms.CheckedListBox checkedListBoxQ1;
        private System.Windows.Forms.Label labelQ2;
        private System.Windows.Forms.TextBox textBoxQ2;
        private System.Windows.Forms.Label labelQ3;
        private System.Windows.Forms.CheckedListBox checkedListBoxReview;
        private System.Windows.Forms.Label labeltosearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCID;
        private System.Windows.Forms.TextBox textBoxCID;
    }
}