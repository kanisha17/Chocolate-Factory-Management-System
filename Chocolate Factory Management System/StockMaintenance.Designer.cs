
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
            this.buttonSerach = new System.Windows.Forms.Button();
            this.labelStockInward = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelProductID = new System.Windows.Forms.Label();
            this.labeltosearch = new System.Windows.Forms.Label();
            this.labelNetStock = new System.Windows.Forms.Label();
            this.labelStockOutward = new System.Windows.Forms.Label();
            this.textBoxNetStock = new System.Windows.Forms.TextBox();
            this.textBoxStockOutward = new System.Windows.Forms.TextBox();
            this.textBoxStockInward = new System.Windows.Forms.TextBox();
            this.textBoxProductID = new System.Windows.Forms.TextBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mENUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eDITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dELETEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cLEARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSerach
            // 
            this.buttonSerach.BackColor = System.Drawing.Color.BurlyWood;
            this.buttonSerach.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSerach.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSerach.Location = new System.Drawing.Point(8, 91);
            this.buttonSerach.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonSerach.Name = "buttonSerach";
            this.buttonSerach.Size = new System.Drawing.Size(182, 56);
            this.buttonSerach.TabIndex = 0;
            this.buttonSerach.Text = "SEARCH";
            this.buttonSerach.UseVisualStyleBackColor = false;
            this.buttonSerach.Click += new System.EventHandler(this.buttonSerach_Click);
            // 
            // labelStockInward
            // 
            this.labelStockInward.AutoSize = true;
            this.labelStockInward.BackColor = System.Drawing.Color.Transparent;
            this.labelStockInward.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStockInward.Location = new System.Drawing.Point(474, 297);
            this.labelStockInward.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStockInward.Name = "labelStockInward";
            this.labelStockInward.Size = new System.Drawing.Size(198, 31);
            this.labelStockInward.TabIndex = 1;
            this.labelStockInward.Text = "Stock Inward";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.BackColor = System.Drawing.Color.Transparent;
            this.labelDate.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(474, 223);
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
            this.labelProductID.Location = new System.Drawing.Point(474, 151);
            this.labelProductID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProductID.Name = "labelProductID";
            this.labelProductID.Size = new System.Drawing.Size(157, 31);
            this.labelProductID.TabIndex = 3;
            this.labelProductID.Text = "ProductID";
            // 
            // labeltosearch
            // 
            this.labeltosearch.AutoSize = true;
            this.labeltosearch.BackColor = System.Drawing.Color.Transparent;
            this.labeltosearch.Location = new System.Drawing.Point(200, 91);
            this.labeltosearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labeltosearch.Name = "labeltosearch";
            this.labeltosearch.Size = new System.Drawing.Size(158, 23);
            this.labeltosearch.TabIndex = 4;
            this.labeltosearch.Text = "Enter Stock No";
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
            this.labelStockOutward.Location = new System.Drawing.Point(474, 362);
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
            this.textBoxStockOutward.Location = new System.Drawing.Point(715, 362);
            this.textBoxStockOutward.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxStockOutward.Name = "textBoxStockOutward";
            this.textBoxStockOutward.Size = new System.Drawing.Size(361, 31);
            this.textBoxStockOutward.TabIndex = 8;
            // 
            // textBoxStockInward
            // 
            this.textBoxStockInward.Location = new System.Drawing.Point(715, 297);
            this.textBoxStockInward.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxStockInward.Name = "textBoxStockInward";
            this.textBoxStockInward.Size = new System.Drawing.Size(361, 31);
            this.textBoxStockInward.TabIndex = 9;
            // 
            // textBoxProductID
            // 
            this.textBoxProductID.Location = new System.Drawing.Point(715, 151);
            this.textBoxProductID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxProductID.Name = "textBoxProductID";
            this.textBoxProductID.Size = new System.Drawing.Size(361, 31);
            this.textBoxProductID.TabIndex = 10;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(204, 118);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(228, 29);
            this.textBoxSearch.TabIndex = 11;
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Location = new System.Drawing.Point(715, 223);
            this.dateTimePickerDate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(361, 31);
            this.dateTimePickerDate.TabIndex = 12;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mENUToolStripMenuItem,
            this.cLEARToolStripMenuItem,
            this.eXITToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(13, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1310, 36);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mENUToolStripMenuItem
            // 
            this.mENUToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aDDToolStripMenuItem,
            this.eDITToolStripMenuItem,
            this.dELETEToolStripMenuItem});
            this.mENUToolStripMenuItem.Name = "mENUToolStripMenuItem";
            this.mENUToolStripMenuItem.Size = new System.Drawing.Size(78, 30);
            this.mENUToolStripMenuItem.Text = "MENU";
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
            // cLEARToolStripMenuItem
            // 
            this.cLEARToolStripMenuItem.Name = "cLEARToolStripMenuItem";
            this.cLEARToolStripMenuItem.Size = new System.Drawing.Size(79, 30);
            this.cLEARToolStripMenuItem.Text = "CLEAR";
            this.cLEARToolStripMenuItem.Click += new System.EventHandler(this.cLEARToolStripMenuItem_Click);
            // 
            // eXITToolStripMenuItem
            // 
            this.eXITToolStripMenuItem.Name = "eXITToolStripMenuItem";
            this.eXITToolStripMenuItem.Size = new System.Drawing.Size(62, 30);
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
            this.label1.Location = new System.Drawing.Point(478, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(584, 54);
            this.label1.TabIndex = 15;
            this.label1.Text = "STOCK MAINTENANCE";
            // 
            // StockMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Chocolate_Factory_Management_System.Properties.Resources.brown;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1310, 574);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.dateTimePickerDate);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.textBoxProductID);
            this.Controls.Add(this.textBoxStockInward);
            this.Controls.Add(this.textBoxStockOutward);
            this.Controls.Add(this.textBoxNetStock);
            this.Controls.Add(this.labelStockOutward);
            this.Controls.Add(this.labelNetStock);
            this.Controls.Add(this.labeltosearch);
            this.Controls.Add(this.labelProductID);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelStockInward);
            this.Controls.Add(this.buttonSerach);
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

        private System.Windows.Forms.Button buttonSerach;
        private System.Windows.Forms.Label labelStockInward;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelProductID;
        private System.Windows.Forms.Label labeltosearch;
        private System.Windows.Forms.Label labelNetStock;
        private System.Windows.Forms.Label labelStockOutward;
        private System.Windows.Forms.TextBox textBoxNetStock;
        private System.Windows.Forms.TextBox textBoxStockOutward;
        private System.Windows.Forms.TextBox textBoxStockInward;
        private System.Windows.Forms.TextBox textBoxProductID;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mENUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aDDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eDITToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dELETEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cLEARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXITToolStripMenuItem;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label label1;
    }
}