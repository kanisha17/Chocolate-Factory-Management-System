
namespace Chocolate_Factory_Management_System
{
    partial class StockAdd
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
            this.labelRawMaterial = new System.Windows.Forms.Label();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.textBoxProductID = new System.Windows.Forms.TextBox();
            this.labelProductID = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.labelAvailableStock = new System.Windows.Forms.Label();
            this.textBoxAvailableStock = new System.Windows.Forms.TextBox();
            this.labelProductName = new System.Windows.Forms.Label();
            this.comboBoxProductName = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.eXITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxStockInward = new System.Windows.Forms.TextBox();
            this.textBoxStockOutward = new System.Windows.Forms.TextBox();
            this.textBoxNetStock = new System.Windows.Forms.TextBox();
            this.labelStockOutward = new System.Windows.Forms.Label();
            this.labelNetStock = new System.Windows.Forms.Label();
            this.labelStockInward = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelRawMaterial
            // 
            this.labelRawMaterial.AutoSize = true;
            this.labelRawMaterial.BackColor = System.Drawing.Color.Transparent;
            this.labelRawMaterial.Font = new System.Drawing.Font("Lucida Bright", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRawMaterial.Location = new System.Drawing.Point(176, 44);
            this.labelRawMaterial.Name = "labelRawMaterial";
            this.labelRawMaterial.Size = new System.Drawing.Size(1092, 54);
            this.labelRawMaterial.TabIndex = 20;
            this.labelRawMaterial.Text = "FINISHED PRODUCT STOCK MAINTENANCE";
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Location = new System.Drawing.Point(633, 237);
            this.dateTimePickerDate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(361, 26);
            this.dateTimePickerDate.TabIndex = 19;
            // 
            // textBoxProductID
            // 
            this.textBoxProductID.Location = new System.Drawing.Point(633, 144);
            this.textBoxProductID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxProductID.Name = "textBoxProductID";
            this.textBoxProductID.Size = new System.Drawing.Size(361, 26);
            this.textBoxProductID.TabIndex = 18;
            this.textBoxProductID.TextChanged += new System.EventHandler(this.textBoxProductID_TextChanged);
            // 
            // labelProductID
            // 
            this.labelProductID.AutoSize = true;
            this.labelProductID.BackColor = System.Drawing.Color.Transparent;
            this.labelProductID.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductID.Location = new System.Drawing.Point(392, 144);
            this.labelProductID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProductID.Name = "labelProductID";
            this.labelProductID.Size = new System.Drawing.Size(157, 31);
            this.labelProductID.TabIndex = 17;
            this.labelProductID.Text = "ProductID";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.BackColor = System.Drawing.Color.Transparent;
            this.labelDate.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(392, 237);
            this.labelDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(78, 31);
            this.labelDate.TabIndex = 16;
            this.labelDate.Text = "Date";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(700, 487);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(183, 54);
            this.buttonUpdate.TabIndex = 22;
            this.buttonUpdate.Text = "UPDATE";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelAvailableStock
            // 
            this.labelAvailableStock.AutoSize = true;
            this.labelAvailableStock.Location = new System.Drawing.Point(394, 296);
            this.labelAvailableStock.Name = "labelAvailableStock";
            this.labelAvailableStock.Size = new System.Drawing.Size(117, 20);
            this.labelAvailableStock.TabIndex = 23;
            this.labelAvailableStock.Text = "Available Stock";
            // 
            // textBoxAvailableStock
            // 
            this.textBoxAvailableStock.Location = new System.Drawing.Point(633, 290);
            this.textBoxAvailableStock.Name = "textBoxAvailableStock";
            this.textBoxAvailableStock.Size = new System.Drawing.Size(361, 26);
            this.textBoxAvailableStock.TabIndex = 24;
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Location = new System.Drawing.Point(394, 196);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(110, 20);
            this.labelProductName.TabIndex = 25;
            this.labelProductName.Text = "Product Name";
            // 
            // comboBoxProductName
            // 
            this.comboBoxProductName.FormattingEnabled = true;
            this.comboBoxProductName.Location = new System.Drawing.Point(633, 188);
            this.comboBoxProductName.Name = "comboBoxProductName";
            this.comboBoxProductName.Size = new System.Drawing.Size(361, 28);
            this.comboBoxProductName.TabIndex = 26;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eXITToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1323, 36);
            this.menuStrip1.TabIndex = 29;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // eXITToolStripMenuItem
            // 
            this.eXITToolStripMenuItem.Name = "eXITToolStripMenuItem";
            this.eXITToolStripMenuItem.Size = new System.Drawing.Size(62, 32);
            this.eXITToolStripMenuItem.Text = "EXIT";
            this.eXITToolStripMenuItem.Click += new System.EventHandler(this.eXITToolStripMenuItem_Click);
            // 
            // textBoxStockInward
            // 
            this.textBoxStockInward.Location = new System.Drawing.Point(633, 332);
            this.textBoxStockInward.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxStockInward.Name = "textBoxStockInward";
            this.textBoxStockInward.Size = new System.Drawing.Size(361, 26);
            this.textBoxStockInward.TabIndex = 35;
            // 
            // textBoxStockOutward
            // 
            this.textBoxStockOutward.Location = new System.Drawing.Point(633, 380);
            this.textBoxStockOutward.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxStockOutward.Name = "textBoxStockOutward";
            this.textBoxStockOutward.Size = new System.Drawing.Size(361, 26);
            this.textBoxStockOutward.TabIndex = 34;
            // 
            // textBoxNetStock
            // 
            this.textBoxNetStock.Location = new System.Drawing.Point(633, 431);
            this.textBoxNetStock.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxNetStock.Name = "textBoxNetStock";
            this.textBoxNetStock.Size = new System.Drawing.Size(361, 26);
            this.textBoxNetStock.TabIndex = 33;
            // 
            // labelStockOutward
            // 
            this.labelStockOutward.AutoSize = true;
            this.labelStockOutward.BackColor = System.Drawing.Color.Transparent;
            this.labelStockOutward.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStockOutward.Location = new System.Drawing.Point(392, 380);
            this.labelStockOutward.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStockOutward.Name = "labelStockOutward";
            this.labelStockOutward.Size = new System.Drawing.Size(223, 31);
            this.labelStockOutward.TabIndex = 32;
            this.labelStockOutward.Text = "Stock Outward";
            // 
            // labelNetStock
            // 
            this.labelNetStock.AutoSize = true;
            this.labelNetStock.BackColor = System.Drawing.Color.Transparent;
            this.labelNetStock.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNetStock.Location = new System.Drawing.Point(392, 431);
            this.labelNetStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNetStock.Name = "labelNetStock";
            this.labelNetStock.Size = new System.Drawing.Size(147, 31);
            this.labelNetStock.TabIndex = 31;
            this.labelNetStock.Text = "Net Stock";
            // 
            // labelStockInward
            // 
            this.labelStockInward.AutoSize = true;
            this.labelStockInward.BackColor = System.Drawing.Color.Transparent;
            this.labelStockInward.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStockInward.Location = new System.Drawing.Point(392, 332);
            this.labelStockInward.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStockInward.Name = "labelStockInward";
            this.labelStockInward.Size = new System.Drawing.Size(198, 31);
            this.labelStockInward.TabIndex = 30;
            this.labelStockInward.Text = "Stock Inward";
            // 
            // StockAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 585);
            this.Controls.Add(this.textBoxStockInward);
            this.Controls.Add(this.textBoxStockOutward);
            this.Controls.Add(this.textBoxNetStock);
            this.Controls.Add(this.labelStockOutward);
            this.Controls.Add(this.labelNetStock);
            this.Controls.Add(this.labelStockInward);
            this.Controls.Add(this.comboBoxProductName);
            this.Controls.Add(this.labelProductName);
            this.Controls.Add(this.textBoxAvailableStock);
            this.Controls.Add(this.labelAvailableStock);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.labelRawMaterial);
            this.Controls.Add(this.dateTimePickerDate);
            this.Controls.Add(this.textBoxProductID);
            this.Controls.Add(this.labelProductID);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "StockAdd";
            this.Text = "StockAdd";
            this.Load += new System.EventHandler(this.StockAdd_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRawMaterial;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.TextBox textBoxProductID;
        private System.Windows.Forms.Label labelProductID;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Label labelAvailableStock;
        private System.Windows.Forms.TextBox textBoxAvailableStock;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.ComboBox comboBoxProductName;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem eXITToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxStockInward;
        private System.Windows.Forms.TextBox textBoxStockOutward;
        private System.Windows.Forms.TextBox textBoxNetStock;
        private System.Windows.Forms.Label labelStockOutward;
        private System.Windows.Forms.Label labelNetStock;
        private System.Windows.Forms.Label labelStockInward;
    }
}