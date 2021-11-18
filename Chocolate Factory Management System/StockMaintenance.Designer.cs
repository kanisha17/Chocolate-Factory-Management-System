
namespace Chocolate_Factory_Management_System
{
    partial class StockMaintenance
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
            this.labelDate = new System.Windows.Forms.Label();
            this.labelProductID = new System.Windows.Forms.Label();
            this.labelProductName = new System.Windows.Forms.Label();
            this.textBoxProductID = new System.Windows.Forms.TextBox();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.eXITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonEDIT = new System.Windows.Forms.Button();
            this.cachedCustomerComplaintReport1 = new Chocolate_Factory_Management_System.CachedCustomerComplaintReport();
            this.labelAvailableStock = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelStockInward = new System.Windows.Forms.Label();
            this.labelNetStock = new System.Windows.Forms.Label();
            this.labelStockOutward = new System.Windows.Forms.Label();
            this.textBoxNetStock = new System.Windows.Forms.TextBox();
            this.textBoxStockOutward = new System.Windows.Forms.TextBox();
            this.textBoxStockInward = new System.Windows.Forms.TextBox();
            this.comboBoxRawMaterialName = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.BackColor = System.Drawing.Color.Transparent;
            this.labelDate.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(474, 246);
            this.labelDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(78, 31);
            this.labelDate.TabIndex = 2;
            this.labelDate.Text = "Date";
            // 
            // labelProductID
            // 
            this.labelProductID.AutoSize = true;
            this.labelProductID.BackColor = System.Drawing.Color.Transparent;
            this.labelProductID.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductID.Location = new System.Drawing.Point(458, 151);
            this.labelProductID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProductID.Name = "labelProductID";
            this.labelProductID.Size = new System.Drawing.Size(239, 31);
            this.labelProductID.TabIndex = 3;
            this.labelProductID.Text = "Enter ProductID";
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.BackColor = System.Drawing.Color.Transparent;
            this.labelProductName.Location = new System.Drawing.Point(476, 206);
            this.labelProductName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(153, 23);
            this.labelProductName.TabIndex = 4;
            this.labelProductName.Text = "Product Name";
            // 
            // textBoxProductID
            // 
            this.textBoxProductID.Location = new System.Drawing.Point(715, 151);
            this.textBoxProductID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxProductID.Name = "textBoxProductID";
            this.textBoxProductID.Size = new System.Drawing.Size(361, 31);
            this.textBoxProductID.TabIndex = 10;
            this.textBoxProductID.TextChanged += new System.EventHandler(this.textBoxProductID_TextChanged);
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Location = new System.Drawing.Point(715, 246);
            this.dateTimePickerDate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(361, 31);
            this.dateTimePickerDate.TabIndex = 12;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Sienna;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eXITToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(13, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1310, 42);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // eXITToolStripMenuItem
            // 
            this.eXITToolStripMenuItem.BackColor = System.Drawing.Color.LightSalmon;
            this.eXITToolStripMenuItem.Image = global::Chocolate_Factory_Management_System.Properties.Resources.exit1;
            this.eXITToolStripMenuItem.Name = "eXITToolStripMenuItem";
            this.eXITToolStripMenuItem.Size = new System.Drawing.Size(106, 36);
            this.eXITToolStripMenuItem.Text = "EXIT";
            this.eXITToolStripMenuItem.Click += new System.EventHandler(this.eXITToolStripMenuItem_Click);
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.BackColor = System.Drawing.Color.BurlyWood;
            this.buttonCalculate.Font = new System.Drawing.Font("Lucida Bright", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalculate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCalculate.Location = new System.Drawing.Point(715, 504);
            this.buttonCalculate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(361, 60);
            this.buttonCalculate.TabIndex = 14;
            this.buttonCalculate.Text = "CALCULATE";
            this.buttonCalculate.UseVisualStyleBackColor = false;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(191, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(998, 54);
            this.label1.TabIndex = 15;
            this.label1.Text = "RAW MATERIAL STOCK MAINTENANCE";
            // 
            // buttonEDIT
            // 
            this.buttonEDIT.Location = new System.Drawing.Point(159, 516);
            this.buttonEDIT.Name = "buttonEDIT";
            this.buttonEDIT.Size = new System.Drawing.Size(116, 48);
            this.buttonEDIT.TabIndex = 17;
            this.buttonEDIT.Text = "EDIT";
            this.buttonEDIT.UseVisualStyleBackColor = true;
            this.buttonEDIT.Click += new System.EventHandler(this.buttonEDIT_Click);
            // 
            // labelAvailableStock
            // 
            this.labelAvailableStock.AutoSize = true;
            this.labelAvailableStock.Location = new System.Drawing.Point(482, 299);
            this.labelAvailableStock.Name = "labelAvailableStock";
            this.labelAvailableStock.Size = new System.Drawing.Size(164, 23);
            this.labelAvailableStock.TabIndex = 19;
            this.labelAvailableStock.Text = "Available Stock";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(715, 299);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(361, 31);
            this.textBox1.TabIndex = 20;
            // 
            // labelStockInward
            // 
            this.labelStockInward.AutoSize = true;
            this.labelStockInward.BackColor = System.Drawing.Color.Transparent;
            this.labelStockInward.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStockInward.Location = new System.Drawing.Point(474, 336);
            this.labelStockInward.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStockInward.Name = "labelStockInward";
            this.labelStockInward.Size = new System.Drawing.Size(198, 31);
            this.labelStockInward.TabIndex = 1;
            this.labelStockInward.Text = "Stock Inward";
            // 
            // labelNetStock
            // 
            this.labelNetStock.AutoSize = true;
            this.labelNetStock.BackColor = System.Drawing.Color.Transparent;
            this.labelNetStock.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNetStock.Location = new System.Drawing.Point(474, 435);
            this.labelNetStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNetStock.Name = "labelNetStock";
            this.labelNetStock.Size = new System.Drawing.Size(147, 31);
            this.labelNetStock.TabIndex = 5;
            this.labelNetStock.Text = "Net Stock";
            // 
            // labelStockOutward
            // 
            this.labelStockOutward.AutoSize = true;
            this.labelStockOutward.BackColor = System.Drawing.Color.Transparent;
            this.labelStockOutward.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStockOutward.Location = new System.Drawing.Point(474, 384);
            this.labelStockOutward.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStockOutward.Name = "labelStockOutward";
            this.labelStockOutward.Size = new System.Drawing.Size(223, 31);
            this.labelStockOutward.TabIndex = 6;
            this.labelStockOutward.Text = "Stock Outward";
            // 
            // textBoxNetStock
            // 
            this.textBoxNetStock.Location = new System.Drawing.Point(715, 435);
            this.textBoxNetStock.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxNetStock.Name = "textBoxNetStock";
            this.textBoxNetStock.Size = new System.Drawing.Size(361, 31);
            this.textBoxNetStock.TabIndex = 7;
            // 
            // textBoxStockOutward
            // 
            this.textBoxStockOutward.Location = new System.Drawing.Point(715, 384);
            this.textBoxStockOutward.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxStockOutward.Name = "textBoxStockOutward";
            this.textBoxStockOutward.Size = new System.Drawing.Size(361, 31);
            this.textBoxStockOutward.TabIndex = 8;
            // 
            // textBoxStockInward
            // 
            this.textBoxStockInward.Location = new System.Drawing.Point(715, 336);
            this.textBoxStockInward.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxStockInward.Name = "textBoxStockInward";
            this.textBoxStockInward.Size = new System.Drawing.Size(361, 31);
            this.textBoxStockInward.TabIndex = 9;
            // 
            // comboBoxRawMaterialName
            // 
            this.comboBoxRawMaterialName.FormattingEnabled = true;
            this.comboBoxRawMaterialName.Location = new System.Drawing.Point(715, 198);
            this.comboBoxRawMaterialName.Name = "comboBoxRawMaterialName";
            this.comboBoxRawMaterialName.Size = new System.Drawing.Size(361, 31);
            this.comboBoxRawMaterialName.TabIndex = 21;
            // 
            // StockMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Chocolate_Factory_Management_System.Properties.Resources.brown;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1310, 574);
            this.Controls.Add(this.comboBoxRawMaterialName);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelAvailableStock);
            this.Controls.Add(this.buttonEDIT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.dateTimePickerDate);
            this.Controls.Add(this.textBoxProductID);
            this.Controls.Add(this.textBoxStockInward);
            this.Controls.Add(this.textBoxStockOutward);
            this.Controls.Add(this.textBoxNetStock);
            this.Controls.Add(this.labelStockOutward);
            this.Controls.Add(this.labelNetStock);
            this.Controls.Add(this.labelProductName);
            this.Controls.Add(this.labelProductID);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelStockInward);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "StockMaintenance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StockMaintenance";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelProductID;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.TextBox textBoxProductID;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem eXITToolStripMenuItem;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonEDIT;
        private CachedCustomerComplaintReport cachedCustomerComplaintReport1;
        private System.Windows.Forms.Label labelAvailableStock;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelStockInward;
        private System.Windows.Forms.Label labelNetStock;
        private System.Windows.Forms.Label labelStockOutward;
        private System.Windows.Forms.TextBox textBoxNetStock;
        private System.Windows.Forms.TextBox textBoxStockOutward;
        private System.Windows.Forms.TextBox textBoxStockInward;
        private System.Windows.Forms.ComboBox comboBoxRawMaterialName;
    }
}