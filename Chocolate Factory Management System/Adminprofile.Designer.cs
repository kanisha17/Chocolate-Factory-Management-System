
namespace Chocolate_Factory_Management_System
{
    partial class Adminprofile
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
            this.labelFisrtName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelDOB = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.textBoxFIrstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.labelAdminProfile = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelPincode = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.textBoxPincode = new System.Windows.Forms.TextBox();
            this.textBoxPhoneNo = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // labelFisrtName
            // 
            this.labelFisrtName.AutoSize = true;
            this.labelFisrtName.Location = new System.Drawing.Point(88, 142);
            this.labelFisrtName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelFisrtName.Name = "labelFisrtName";
            this.labelFisrtName.Size = new System.Drawing.Size(165, 31);
            this.labelFisrtName.TabIndex = 0;
            this.labelFisrtName.Text = "First Name";
            this.labelFisrtName.Click += new System.EventHandler(this.labelFisrtName_Click);
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(88, 236);
            this.labelLastName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(159, 31);
            this.labelLastName.TabIndex = 1;
            this.labelLastName.Text = "Last Name";
            this.labelLastName.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelDOB
            // 
            this.labelDOB.AutoSize = true;
            this.labelDOB.Location = new System.Drawing.Point(88, 327);
            this.labelDOB.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelDOB.Name = "labelDOB";
            this.labelDOB.Size = new System.Drawing.Size(197, 31);
            this.labelDOB.TabIndex = 2;
            this.labelDOB.Text = "Date Of Birth";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(83, 412);
            this.labelAddress.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(129, 31);
            this.labelAddress.TabIndex = 3;
            this.labelAddress.Text = "Address";
            // 
            // textBoxFIrstName
            // 
            this.textBoxFIrstName.Location = new System.Drawing.Point(359, 142);
            this.textBoxFIrstName.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBoxFIrstName.Name = "textBoxFIrstName";
            this.textBoxFIrstName.Size = new System.Drawing.Size(447, 40);
            this.textBoxFIrstName.TabIndex = 4;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(359, 236);
            this.textBoxLastName.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(447, 40);
            this.textBoxLastName.TabIndex = 5;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(359, 409);
            this.textBoxAddress.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(447, 40);
            this.textBoxAddress.TabIndex = 7;
            // 
            // labelAdminProfile
            // 
            this.labelAdminProfile.AutoSize = true;
            this.labelAdminProfile.Location = new System.Drawing.Point(434, 9);
            this.labelAdminProfile.Name = "labelAdminProfile";
            this.labelAdminProfile.Size = new System.Drawing.Size(246, 31);
            this.labelAdminProfile.TabIndex = 8;
            this.labelAdminProfile.Text = "ADMIN PROFILE";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(280, 628);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(131, 40);
            this.buttonSave.TabIndex = 9;
            this.buttonSave.Text = "INSERT";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSaveData_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(695, 628);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(140, 40);
            this.buttonDelete.TabIndex = 10;
            this.buttonDelete.Text = "DELETE";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(481, 628);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(150, 40);
            this.buttonEdit.TabIndex = 11;
            this.buttonEdit.Text = "UPDATE";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(88, 456);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(70, 31);
            this.labelCity.TabIndex = 12;
            this.labelCity.Text = "City";
            // 
            // labelPincode
            // 
            this.labelPincode.AutoSize = true;
            this.labelPincode.Location = new System.Drawing.Point(88, 505);
            this.labelPincode.Name = "labelPincode";
            this.labelPincode.Size = new System.Drawing.Size(124, 31);
            this.labelPincode.TabIndex = 13;
            this.labelPincode.Text = "Pincode";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(88, 562);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(149, 31);
            this.labelPhone.TabIndex = 14;
            this.labelPhone.Text = "Phone No";
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(359, 456);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(447, 40);
            this.textBoxCity.TabIndex = 15;
            // 
            // textBoxPincode
            // 
            this.textBoxPincode.Location = new System.Drawing.Point(359, 507);
            this.textBoxPincode.Name = "textBoxPincode";
            this.textBoxPincode.Size = new System.Drawing.Size(447, 40);
            this.textBoxPincode.TabIndex = 16;
            // 
            // textBoxPhoneNo
            // 
            this.textBoxPhoneNo.Location = new System.Drawing.Point(359, 553);
            this.textBoxPhoneNo.Name = "textBoxPhoneNo";
            this.textBoxPhoneNo.Size = new System.Drawing.Size(447, 40);
            this.textBoxPhoneNo.TabIndex = 17;
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(359, 94);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(447, 40);
            this.textBoxID.TabIndex = 18;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(115, 111);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(46, 31);
            this.labelID.TabIndex = 19;
            this.labelID.Text = "ID";
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(0, -2);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(45, 42);
            this.buttonClose.TabIndex = 20;
            this.buttonClose.Text = "X";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(359, 327);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(447, 40);
            this.dateTimePicker1.TabIndex = 21;
            // 
            // Adminprofile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1034);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.textBoxPhoneNo);
            this.Controls.Add(this.textBoxPincode);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelPincode);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelAdminProfile);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFIrstName);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelDOB);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelFisrtName);
            this.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Adminprofile";
            this.Text = "Adminprofile";
            this.Load += new System.EventHandler(this.Adminprofile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFisrtName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelDOB;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TextBox textBoxFIrstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label labelAdminProfile;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelPincode;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.TextBox textBoxPincode;
        private System.Windows.Forms.TextBox textBoxPhoneNo;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}