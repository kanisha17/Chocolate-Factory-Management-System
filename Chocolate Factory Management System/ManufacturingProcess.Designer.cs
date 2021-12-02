
namespace Chocolate_Factory_Management_System
{
    partial class ManufacturingProcess
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
            this.textBoxSEARCH = new System.Windows.Forms.TextBox();
            this.buttonSEARCH = new System.Windows.Forms.Button();
            this.labelProductID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.eXITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxFermenting = new System.Windows.Forms.TextBox();
            this.textBoxDrying = new System.Windows.Forms.TextBox();
            this.textBoxGrinding = new System.Windows.Forms.TextBox();
            this.textBoxRoasting = new System.Windows.Forms.TextBox();
            this.textBoxCracking = new System.Windows.Forms.TextBox();
            this.textBoxMoulding = new System.Windows.Forms.TextBox();
            this.textBoxTempering = new System.Windows.Forms.TextBox();
            this.textBoxWrapping = new System.Windows.Forms.TextBox();
            this.labelProductName = new System.Windows.Forms.Label();
            this.comboBoxProductName = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxSEARCH
            // 
            this.textBoxSEARCH.Location = new System.Drawing.Point(712, 208);
            this.textBoxSEARCH.Name = "textBoxSEARCH";
            this.textBoxSEARCH.Size = new System.Drawing.Size(298, 26);
            this.textBoxSEARCH.TabIndex = 26;
            this.textBoxSEARCH.TextChanged += new System.EventHandler(this.textBoxSEARCH_TextChanged);
            this.textBoxSEARCH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSEARCH_KeyPress);
            // 
            // buttonSEARCH
            // 
            this.buttonSEARCH.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSEARCH.Font = new System.Drawing.Font("Lucida Bright", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSEARCH.ForeColor = System.Drawing.Color.Maroon;
            this.buttonSEARCH.Location = new System.Drawing.Point(35, 173);
            this.buttonSEARCH.Name = "buttonSEARCH";
            this.buttonSEARCH.Size = new System.Drawing.Size(223, 61);
            this.buttonSEARCH.TabIndex = 2;
            this.buttonSEARCH.Text = "SEARCH";
            this.buttonSEARCH.UseVisualStyleBackColor = false;
            this.buttonSEARCH.Click += new System.EventHandler(this.buttonSEARCH_Click);
            // 
            // labelProductID
            // 
            this.labelProductID.AutoSize = true;
            this.labelProductID.BackColor = System.Drawing.Color.Transparent;
            this.labelProductID.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductID.ForeColor = System.Drawing.Color.Maroon;
            this.labelProductID.Location = new System.Drawing.Point(707, 173);
            this.labelProductID.Name = "labelProductID";
            this.labelProductID.Size = new System.Drawing.Size(144, 27);
            this.labelProductID.TabIndex = 3;
            this.labelProductID.Text = "Product ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(358, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(710, 54);
            this.label1.TabIndex = 4;
            this.label1.Text = "MANUFACTURING PROCESS";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eXITToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1307, 40);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // eXITToolStripMenuItem
            // 
            this.eXITToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.eXITToolStripMenuItem.Image = global::Chocolate_Factory_Management_System.Properties.Resources.exit1;
            this.eXITToolStripMenuItem.Name = "eXITToolStripMenuItem";
            this.eXITToolStripMenuItem.Size = new System.Drawing.Size(106, 36);
            this.eXITToolStripMenuItem.Text = "EXIT";
            this.eXITToolStripMenuItem.Click += new System.EventHandler(this.eXITToolStripMenuItem_Click);
            // 
            // textBoxFermenting
            // 
            this.textBoxFermenting.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxFermenting.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFermenting.Location = new System.Drawing.Point(12, 390);
            this.textBoxFermenting.Name = "textBoxFermenting";
            this.textBoxFermenting.Size = new System.Drawing.Size(142, 36);
            this.textBoxFermenting.TabIndex = 25;
            this.textBoxFermenting.Text = "Fermenting";
            // 
            // textBoxDrying
            // 
            this.textBoxDrying.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxDrying.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDrying.Location = new System.Drawing.Point(194, 390);
            this.textBoxDrying.Name = "textBoxDrying";
            this.textBoxDrying.Size = new System.Drawing.Size(91, 36);
            this.textBoxDrying.TabIndex = 16;
            this.textBoxDrying.Text = "Drying";
            // 
            // textBoxGrinding
            // 
            this.textBoxGrinding.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxGrinding.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGrinding.Location = new System.Drawing.Point(676, 390);
            this.textBoxGrinding.Multiline = true;
            this.textBoxGrinding.Name = "textBoxGrinding";
            this.textBoxGrinding.Size = new System.Drawing.Size(136, 89);
            this.textBoxGrinding.TabIndex = 17;
            this.textBoxGrinding.Text = "Grinding and Conching";
            // 
            // textBoxRoasting
            // 
            this.textBoxRoasting.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxRoasting.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRoasting.Location = new System.Drawing.Point(323, 390);
            this.textBoxRoasting.Name = "textBoxRoasting";
            this.textBoxRoasting.Size = new System.Drawing.Size(110, 36);
            this.textBoxRoasting.TabIndex = 18;
            this.textBoxRoasting.Text = "Roasting";
            // 
            // textBoxCracking
            // 
            this.textBoxCracking.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxCracking.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCracking.Location = new System.Drawing.Point(468, 390);
            this.textBoxCracking.Multiline = true;
            this.textBoxCracking.Name = "textBoxCracking";
            this.textBoxCracking.Size = new System.Drawing.Size(161, 89);
            this.textBoxCracking.TabIndex = 19;
            this.textBoxCracking.Text = "Cracking and Winnowing";
            // 
            // textBoxMoulding
            // 
            this.textBoxMoulding.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxMoulding.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMoulding.Location = new System.Drawing.Point(1028, 390);
            this.textBoxMoulding.Name = "textBoxMoulding";
            this.textBoxMoulding.Size = new System.Drawing.Size(119, 36);
            this.textBoxMoulding.TabIndex = 20;
            this.textBoxMoulding.Text = "Moulding";
            // 
            // textBoxTempering
            // 
            this.textBoxTempering.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxTempering.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTempering.Location = new System.Drawing.Point(856, 390);
            this.textBoxTempering.Name = "textBoxTempering";
            this.textBoxTempering.Size = new System.Drawing.Size(141, 36);
            this.textBoxTempering.TabIndex = 21;
            this.textBoxTempering.Text = "Tempering";
            // 
            // textBoxWrapping
            // 
            this.textBoxWrapping.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxWrapping.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxWrapping.Location = new System.Drawing.Point(1170, 390);
            this.textBoxWrapping.Name = "textBoxWrapping";
            this.textBoxWrapping.Size = new System.Drawing.Size(124, 36);
            this.textBoxWrapping.TabIndex = 22;
            this.textBoxWrapping.Text = "Wrapping";
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.BackColor = System.Drawing.Color.Transparent;
            this.labelProductName.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductName.ForeColor = System.Drawing.Color.Maroon;
            this.labelProductName.Location = new System.Drawing.Point(283, 173);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(263, 27);
            this.labelProductName.TabIndex = 24;
            this.labelProductName.Text = "Select Product Name";
            // 
            // comboBoxProductName
            // 
            this.comboBoxProductName.Location = new System.Drawing.Point(288, 203);
            this.comboBoxProductName.Name = "comboBoxProductName";
            this.comboBoxProductName.Size = new System.Drawing.Size(298, 28);
            this.comboBoxProductName.TabIndex = 0;
            this.comboBoxProductName.SelectedIndexChanged += new System.EventHandler(this.comboBoxProductName_SelectedIndexChanged);
            // 
            // ManufacturingProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Chocolate_Factory_Management_System.Properties.Resources.peacch;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1307, 537);
            this.Controls.Add(this.comboBoxProductName);
            this.Controls.Add(this.labelProductName);
            this.Controls.Add(this.textBoxWrapping);
            this.Controls.Add(this.textBoxTempering);
            this.Controls.Add(this.textBoxMoulding);
            this.Controls.Add(this.textBoxCracking);
            this.Controls.Add(this.textBoxRoasting);
            this.Controls.Add(this.textBoxGrinding);
            this.Controls.Add(this.textBoxDrying);
            this.Controls.Add(this.textBoxFermenting);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelProductID);
            this.Controls.Add(this.buttonSEARCH);
            this.Controls.Add(this.textBoxSEARCH);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ManufacturingProcess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManufacturingProcess";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ManufacturingProcess_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxSEARCH;
        private System.Windows.Forms.Button buttonSEARCH;
        private System.Windows.Forms.Label labelProductID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem eXITToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxFermenting;
        private System.Windows.Forms.TextBox textBoxDrying;
        private System.Windows.Forms.TextBox textBoxGrinding;
        private System.Windows.Forms.TextBox textBoxRoasting;
        private System.Windows.Forms.TextBox textBoxCracking;
        private System.Windows.Forms.TextBox textBoxMoulding;
        private System.Windows.Forms.TextBox textBoxTempering;
        private System.Windows.Forms.TextBox textBoxWrapping;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.ComboBox comboBoxProductName;
    }
}