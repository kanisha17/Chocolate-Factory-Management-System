
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
            this.labelProductName = new System.Windows.Forms.Label();
            this.comboBoxProductName = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.eXITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxAStock = new System.Windows.Forms.TextBox();
            this.textBoxStockInward = new System.Windows.Forms.TextBox();
            this.textBoxNetStock = new System.Windows.Forms.TextBox();
            this.labelStockInward = new System.Windows.Forms.Label();
            this.labelNetStock = new System.Windows.Forms.Label();
            this.labelAStock = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelRawMaterial
            // 
            this.labelRawMaterial.AutoSize = true;
            this.labelRawMaterial.BackColor = System.Drawing.Color.Transparent;
            this.labelRawMaterial.Font = new System.Drawing.Font("Lucida Bright", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRawMaterial.Location = new System.Drawing.Point(118, 50);
            this.labelRawMaterial.Name = "labelRawMaterial";
            this.labelRawMaterial.Size = new System.Drawing.Size(1092, 54);
            this.labelRawMaterial.TabIndex = 20;
            this.labelRawMaterial.Text = "FINISHED PRODUCT STOCK MAINTENANCE";
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDate.Location = new System.Drawing.Point(633, 250);
            this.dateTimePickerDate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(361, 31);
            this.dateTimePickerDate.TabIndex = 19;
            // 
            // textBoxProductID
            // 
            this.textBoxProductID.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProductID.Location = new System.Drawing.Point(633, 195);
            this.textBoxProductID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxProductID.Name = "textBoxProductID";
            this.textBoxProductID.Size = new System.Drawing.Size(361, 31);
            this.textBoxProductID.TabIndex = 18;
            this.textBoxProductID.TextChanged += new System.EventHandler(this.textBoxProductID_TextChanged);
            this.textBoxProductID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxProductID_KeyPress);
            // 
            // labelProductID
            // 
            this.labelProductID.AutoSize = true;
            this.labelProductID.BackColor = System.Drawing.Color.Transparent;
            this.labelProductID.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductID.Location = new System.Drawing.Point(376, 195);
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
            this.labelDate.Location = new System.Drawing.Point(376, 250);
            this.labelDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(78, 31);
            this.labelDate.TabIndex = 16;
            this.labelDate.Text = "Date";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.Tan;
            this.buttonUpdate.Font = new System.Drawing.Font("Lucida Bright", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.Location = new System.Drawing.Point(633, 481);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(361, 54);
            this.buttonUpdate.TabIndex = 22;
            this.buttonUpdate.Text = "UPDATE";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.BackColor = System.Drawing.Color.Transparent;
            this.labelProductName.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductName.Location = new System.Drawing.Point(376, 137);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(214, 31);
            this.labelProductName.TabIndex = 25;
            this.labelProductName.Text = "Select Product";
            // 
            // comboBoxProductName
            // 
            this.comboBoxProductName.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxProductName.FormattingEnabled = true;
            this.comboBoxProductName.Location = new System.Drawing.Point(633, 137);
            this.comboBoxProductName.Name = "comboBoxProductName";
            this.comboBoxProductName.Size = new System.Drawing.Size(361, 31);
            this.comboBoxProductName.TabIndex = 26;
            this.comboBoxProductName.SelectedIndexChanged += new System.EventHandler(this.comboBoxProductName_SelectedIndexChanged);
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
            this.menuStrip1.Size = new System.Drawing.Size(1269, 40);
            this.menuStrip1.TabIndex = 29;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // eXITToolStripMenuItem
            // 
            this.eXITToolStripMenuItem.BackColor = System.Drawing.Color.Tan;
            this.eXITToolStripMenuItem.Image = global::Chocolate_Factory_Management_System.Properties.Resources.exit1;
            this.eXITToolStripMenuItem.Name = "eXITToolStripMenuItem";
            this.eXITToolStripMenuItem.Size = new System.Drawing.Size(106, 36);
            this.eXITToolStripMenuItem.Text = "EXIT";
            this.eXITToolStripMenuItem.Click += new System.EventHandler(this.eXITToolStripMenuItem_Click);
            // 
            // textBoxAStock
            // 
            this.textBoxAStock.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAStock.Location = new System.Drawing.Point(633, 306);
            this.textBoxAStock.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxAStock.Name = "textBoxAStock";
            this.textBoxAStock.Size = new System.Drawing.Size(361, 31);
            this.textBoxAStock.TabIndex = 35;
            this.textBoxAStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStockInward_KeyPress);
            // 
            // textBoxStockInward
            // 
            this.textBoxStockInward.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStockInward.Location = new System.Drawing.Point(633, 363);
            this.textBoxStockInward.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxStockInward.Name = "textBoxStockInward";
            this.textBoxStockInward.Size = new System.Drawing.Size(361, 31);
            this.textBoxStockInward.TabIndex = 34;
            this.textBoxStockInward.TextChanged += new System.EventHandler(this.textBoxStockOutward_TextChanged);
            this.textBoxStockInward.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStockOutward_KeyPress);
            // 
            // textBoxNetStock
            // 
            this.textBoxNetStock.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNetStock.Location = new System.Drawing.Point(633, 421);
            this.textBoxNetStock.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxNetStock.Name = "textBoxNetStock";
            this.textBoxNetStock.Size = new System.Drawing.Size(361, 31);
            this.textBoxNetStock.TabIndex = 33;
            // 
            // labelStockInward
            // 
            this.labelStockInward.AutoSize = true;
            this.labelStockInward.BackColor = System.Drawing.Color.Transparent;
            this.labelStockInward.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStockInward.Location = new System.Drawing.Point(376, 363);
            this.labelStockInward.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStockInward.Name = "labelStockInward";
            this.labelStockInward.Size = new System.Drawing.Size(198, 31);
            this.labelStockInward.TabIndex = 32;
            this.labelStockInward.Text = "Stock Inward";
            // 
            // labelNetStock
            // 
            this.labelNetStock.AutoSize = true;
            this.labelNetStock.BackColor = System.Drawing.Color.Transparent;
            this.labelNetStock.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNetStock.Location = new System.Drawing.Point(376, 421);
            this.labelNetStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNetStock.Name = "labelNetStock";
            this.labelNetStock.Size = new System.Drawing.Size(147, 31);
            this.labelNetStock.TabIndex = 31;
            this.labelNetStock.Text = "Net Stock";
            // 
            // labelAStock
            // 
            this.labelAStock.AutoSize = true;
            this.labelAStock.BackColor = System.Drawing.Color.Transparent;
            this.labelAStock.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAStock.Location = new System.Drawing.Point(376, 306);
            this.labelAStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAStock.Name = "labelAStock";
            this.labelAStock.Size = new System.Drawing.Size(229, 31);
            this.labelAStock.TabIndex = 30;
            this.labelAStock.Text = "Available Stock";
            // 
            // StockAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Chocolate_Factory_Management_System.Properties.Resources.brown;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1269, 551);
            this.Controls.Add(this.textBoxAStock);
            this.Controls.Add(this.textBoxStockInward);
            this.Controls.Add(this.textBoxNetStock);
            this.Controls.Add(this.labelStockInward);
            this.Controls.Add(this.labelNetStock);
            this.Controls.Add(this.labelAStock);
            this.Controls.Add(this.comboBoxProductName);
            this.Controls.Add(this.labelProductName);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.labelRawMaterial);
            this.Controls.Add(this.dateTimePickerDate);
            this.Controls.Add(this.textBoxProductID);
            this.Controls.Add(this.labelProductID);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "StockAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.ComboBox comboBoxProductName;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem eXITToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxAStock;
        private System.Windows.Forms.TextBox textBoxStockInward;
        private System.Windows.Forms.TextBox textBoxNetStock;
        private System.Windows.Forms.Label labelStockInward;
        private System.Windows.Forms.Label labelNetStock;
        private System.Windows.Forms.Label labelAStock;
    }
}