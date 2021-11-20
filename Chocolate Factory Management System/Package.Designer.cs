
namespace Chocolate_Factory_Management_System
{
    partial class Package
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
            this.labelPackaging = new System.Windows.Forms.Label();
            this.labelNewStock = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxProductID = new System.Windows.Forms.TextBox();
            this.textBoxNewStock = new System.Windows.Forms.TextBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.dateTimePickerPackage = new System.Windows.Forms.DateTimePicker();
            this.labelDate = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.eXITToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.labelProductName = new System.Windows.Forms.Label();
            this.comboBoxProductName = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelPackaging
            // 
            this.labelPackaging.AutoSize = true;
            this.labelPackaging.BackColor = System.Drawing.Color.Transparent;
            this.labelPackaging.Font = new System.Drawing.Font("Lucida Bright", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPackaging.ForeColor = System.Drawing.Color.Maroon;
            this.labelPackaging.Location = new System.Drawing.Point(441, 60);
            this.labelPackaging.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPackaging.Name = "labelPackaging";
            this.labelPackaging.Size = new System.Drawing.Size(588, 54);
            this.labelPackaging.TabIndex = 0;
            this.labelPackaging.Text = "PRODUCT PACKAGING";
            // 
            // labelNewStock
            // 
            this.labelNewStock.AutoSize = true;
            this.labelNewStock.BackColor = System.Drawing.Color.Transparent;
            this.labelNewStock.Font = new System.Drawing.Font("Lucida Bright", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewStock.ForeColor = System.Drawing.Color.Maroon;
            this.labelNewStock.Location = new System.Drawing.Point(374, 307);
            this.labelNewStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNewStock.Name = "labelNewStock";
            this.labelNewStock.Size = new System.Drawing.Size(187, 36);
            this.labelNewStock.TabIndex = 2;
            this.labelNewStock.Text = "New Stock";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(374, 240);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 36);
            this.label3.TabIndex = 3;
            this.label3.Text = "Product ID";
            // 
            // textBoxProductID
            // 
            this.textBoxProductID.Location = new System.Drawing.Point(649, 245);
            this.textBoxProductID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxProductID.Name = "textBoxProductID";
            this.textBoxProductID.Size = new System.Drawing.Size(417, 31);
            this.textBoxProductID.TabIndex = 13;
            this.textBoxProductID.TextChanged += new System.EventHandler(this.textBoxProductID_TextChanged);
            this.textBoxProductID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxProductID_KeyPress);
            // 
            // textBoxNewStock
            // 
            this.textBoxNewStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNewStock.Location = new System.Drawing.Point(649, 313);
            this.textBoxNewStock.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxNewStock.Name = "textBoxNewStock";
            this.textBoxNewStock.Size = new System.Drawing.Size(417, 30);
            this.textBoxNewStock.TabIndex = 6;
            this.textBoxNewStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNewStock_KeyPress);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSubmit.Font = new System.Drawing.Font("Lucida Bright", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.ForeColor = System.Drawing.Color.Maroon;
            this.buttonSubmit.Location = new System.Drawing.Point(644, 448);
            this.buttonSubmit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(422, 68);
            this.buttonSubmit.TabIndex = 7;
            this.buttonSubmit.Text = "SUBMIT";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // dateTimePickerPackage
            // 
            this.dateTimePickerPackage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerPackage.Location = new System.Drawing.Point(649, 381);
            this.dateTimePickerPackage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dateTimePickerPackage.Name = "dateTimePickerPackage";
            this.dateTimePickerPackage.Size = new System.Drawing.Size(417, 30);
            this.dateTimePickerPackage.TabIndex = 8;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.BackColor = System.Drawing.Color.Transparent;
            this.labelDate.Font = new System.Drawing.Font("Lucida Bright", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.ForeColor = System.Drawing.Color.Maroon;
            this.labelDate.Location = new System.Drawing.Point(374, 375);
            this.labelDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(89, 36);
            this.labelDate.TabIndex = 9;
            this.labelDate.Text = "Date";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eXITToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(13, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1328, 42);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // eXITToolStripMenuItem1
            // 
            this.eXITToolStripMenuItem1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.eXITToolStripMenuItem1.Image = global::Chocolate_Factory_Management_System.Properties.Resources.exit1;
            this.eXITToolStripMenuItem1.Name = "eXITToolStripMenuItem1";
            this.eXITToolStripMenuItem1.Size = new System.Drawing.Size(106, 36);
            this.eXITToolStripMenuItem1.Text = "EXIT";
            this.eXITToolStripMenuItem1.Click += new System.EventHandler(this.eXITToolStripMenuItem1_Click);
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.BackColor = System.Drawing.Color.Transparent;
            this.labelProductName.Font = new System.Drawing.Font("Lucida Bright", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductName.ForeColor = System.Drawing.Color.Maroon;
            this.labelProductName.Location = new System.Drawing.Point(374, 173);
            this.labelProductName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(248, 36);
            this.labelProductName.TabIndex = 11;
            this.labelProductName.Text = "Product Name";
            // 
            // comboBoxProductName
            // 
            this.comboBoxProductName.FormattingEnabled = true;
            this.comboBoxProductName.Location = new System.Drawing.Point(649, 178);
            this.comboBoxProductName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxProductName.Name = "comboBoxProductName";
            this.comboBoxProductName.Size = new System.Drawing.Size(417, 31);
            this.comboBoxProductName.TabIndex = 14;
            this.comboBoxProductName.SelectedIndexChanged += new System.EventHandler(this.comboBoxProductName_SelectedIndexChanged);
            // 
            // Package
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Chocolate_Factory_Management_System.Properties.Resources.peacch;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1328, 569);
            this.Controls.Add(this.comboBoxProductName);
            this.Controls.Add(this.labelProductName);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.dateTimePickerPackage);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.textBoxNewStock);
            this.Controls.Add(this.textBoxProductID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelNewStock);
            this.Controls.Add(this.labelPackaging);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Package";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Package";
            this.Load += new System.EventHandler(this.Package_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPackaging;
        private System.Windows.Forms.Label labelNewStock;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxProductID;
        private System.Windows.Forms.TextBox textBoxNewStock;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.DateTimePicker dateTimePickerPackage;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.ToolStripMenuItem eXITToolStripMenuItem1;
        private System.Windows.Forms.ComboBox comboBoxProductName;
    }
}