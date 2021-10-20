
namespace Chocolate_Factory_Management_System
{
    partial class PurchaseOrder
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
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelUnitPrice = new System.Windows.Forms.Label();
            this.labelQuantitykg = new System.Windows.Forms.Label();
            this.comboBoxProductName = new System.Windows.Forms.ComboBox();
            this.textBoxQuantitykg = new System.Windows.Forms.TextBox();
            this.textBoxUnitPrice = new System.Windows.Forms.TextBox();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.textBoxSID = new System.Windows.Forms.TextBox();
            this.labelSID = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.dateTimePickerOrderDate = new System.Windows.Forms.DateTimePicker();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonCALCULATE = new System.Windows.Forms.Button();
            this.labelproduct = new System.Windows.Forms.Label();
            this.dataGridViewPurchaseOrder = new System.Windows.Forms.DataGridView();
            this.buttonLoadTable = new System.Windows.Forms.Button();
            this.labelDiscount = new System.Windows.Forms.Label();
            this.textBoxDiscount = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mENUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eDITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dELETEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cLEARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxPaid = new System.Windows.Forms.TextBox();
            this.labelPaid = new System.Windows.Forms.Label();
            this.dateTimePickerDueDate = new System.Windows.Forms.DateTimePicker();
            this.labelDueDate = new System.Windows.Forms.Label();
            this.labelBalance = new System.Windows.Forms.Label();
            this.textBoxBalance = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPurchaseOrder)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(856, 347);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(44, 20);
            this.labelTotal.TabIndex = 6;
            this.labelTotal.Text = "Total";
            // 
            // labelUnitPrice
            // 
            this.labelUnitPrice.AutoSize = true;
            this.labelUnitPrice.Location = new System.Drawing.Point(856, 303);
            this.labelUnitPrice.Name = "labelUnitPrice";
            this.labelUnitPrice.Size = new System.Drawing.Size(77, 20);
            this.labelUnitPrice.TabIndex = 7;
            this.labelUnitPrice.Text = "Unit Price";
            // 
            // labelQuantitykg
            // 
            this.labelQuantitykg.AutoSize = true;
            this.labelQuantitykg.Location = new System.Drawing.Point(862, 213);
            this.labelQuantitykg.Name = "labelQuantitykg";
            this.labelQuantitykg.Size = new System.Drawing.Size(68, 20);
            this.labelQuantitykg.TabIndex = 8;
            this.labelQuantitykg.Text = "Quantity";
            // 
            // comboBoxProductName
            // 
            this.comboBoxProductName.FormattingEnabled = true;
            this.comboBoxProductName.Items.AddRange(new object[] {
            "Butter",
            "Caramel",
            "Coco Powder",
            "Condensed Milk",
            "Cinnamon",
            "Dry Fruits",
            "Honey",
            "Sugar",
            "Vanilla"});
            this.comboBoxProductName.Location = new System.Drawing.Point(995, 174);
            this.comboBoxProductName.Name = "comboBoxProductName";
            this.comboBoxProductName.Size = new System.Drawing.Size(249, 28);
            this.comboBoxProductName.TabIndex = 11;
            // 
            // textBoxQuantitykg
            // 
            this.textBoxQuantitykg.Location = new System.Drawing.Point(995, 213);
            this.textBoxQuantitykg.Name = "textBoxQuantitykg";
            this.textBoxQuantitykg.Size = new System.Drawing.Size(249, 26);
            this.textBoxQuantitykg.TabIndex = 14;
            // 
            // textBoxUnitPrice
            // 
            this.textBoxUnitPrice.Location = new System.Drawing.Point(995, 297);
            this.textBoxUnitPrice.Name = "textBoxUnitPrice";
            this.textBoxUnitPrice.Size = new System.Drawing.Size(249, 26);
            this.textBoxUnitPrice.TabIndex = 15;
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Location = new System.Drawing.Point(995, 344);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.Size = new System.Drawing.Size(249, 26);
            this.textBoxTotal.TabIndex = 16;
            // 
            // textBoxSID
            // 
            this.textBoxSID.Location = new System.Drawing.Point(995, 74);
            this.textBoxSID.Name = "textBoxSID";
            this.textBoxSID.Size = new System.Drawing.Size(249, 26);
            this.textBoxSID.TabIndex = 17;
            // 
            // labelSID
            // 
            this.labelSID.AutoSize = true;
            this.labelSID.Location = new System.Drawing.Point(856, 80);
            this.labelSID.Name = "labelSID";
            this.labelSID.Size = new System.Drawing.Size(37, 20);
            this.labelSID.TabIndex = 18;
            this.labelSID.Text = "SID";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(856, 134);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(44, 20);
            this.labelDate.TabIndex = 19;
            this.labelDate.Text = "Date";
            // 
            // dateTimePickerOrderDate
            // 
            this.dateTimePickerOrderDate.Location = new System.Drawing.Point(995, 128);
            this.dateTimePickerOrderDate.Name = "dateTimePickerOrderDate";
            this.dateTimePickerOrderDate.Size = new System.Drawing.Size(249, 26);
            this.dateTimePickerOrderDate.TabIndex = 20;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(995, 42);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(186, 26);
            this.textBoxSearch.TabIndex = 22;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(849, 33);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(106, 35);
            this.buttonSearch.TabIndex = 28;
            this.buttonSearch.Text = "SEARCH";
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonCALCULATE
            // 
            this.buttonCALCULATE.Location = new System.Drawing.Point(1091, 528);
            this.buttonCALCULATE.Name = "buttonCALCULATE";
            this.buttonCALCULATE.Size = new System.Drawing.Size(153, 38);
            this.buttonCALCULATE.TabIndex = 27;
            this.buttonCALCULATE.Text = "CALCULATE";
            this.buttonCALCULATE.UseVisualStyleBackColor = true;
            this.buttonCALCULATE.Click += new System.EventHandler(this.buttonCALCULATE_Click);
            // 
            // labelproduct
            // 
            this.labelproduct.AutoSize = true;
            this.labelproduct.Location = new System.Drawing.Point(856, 177);
            this.labelproduct.Name = "labelproduct";
            this.labelproduct.Size = new System.Drawing.Size(110, 20);
            this.labelproduct.TabIndex = 30;
            this.labelproduct.Text = "Product Name";
            // 
            // dataGridViewPurchaseOrder
            // 
            this.dataGridViewPurchaseOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPurchaseOrder.Location = new System.Drawing.Point(40, 55);
            this.dataGridViewPurchaseOrder.Name = "dataGridViewPurchaseOrder";
            this.dataGridViewPurchaseOrder.RowHeadersWidth = 62;
            this.dataGridViewPurchaseOrder.RowTemplate.Height = 28;
            this.dataGridViewPurchaseOrder.Size = new System.Drawing.Size(746, 346);
            this.dataGridViewPurchaseOrder.TabIndex = 31;
            // 
            // buttonLoadTable
            // 
            this.buttonLoadTable.Location = new System.Drawing.Point(294, 429);
            this.buttonLoadTable.Name = "buttonLoadTable";
            this.buttonLoadTable.Size = new System.Drawing.Size(259, 38);
            this.buttonLoadTable.TabIndex = 32;
            this.buttonLoadTable.Text = "Load Table";
            this.buttonLoadTable.UseVisualStyleBackColor = true;
            this.buttonLoadTable.Click += new System.EventHandler(this.buttonLoadTable_Click);
            // 
            // labelDiscount
            // 
            this.labelDiscount.AutoSize = true;
            this.labelDiscount.Location = new System.Drawing.Point(856, 265);
            this.labelDiscount.Name = "labelDiscount";
            this.labelDiscount.Size = new System.Drawing.Size(72, 20);
            this.labelDiscount.TabIndex = 34;
            this.labelDiscount.Text = "Discount";
            // 
            // textBoxDiscount
            // 
            this.textBoxDiscount.Location = new System.Drawing.Point(995, 259);
            this.textBoxDiscount.Name = "textBoxDiscount";
            this.textBoxDiscount.Size = new System.Drawing.Size(249, 26);
            this.textBoxDiscount.TabIndex = 35;
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
            this.menuStrip1.Size = new System.Drawing.Size(1299, 33);
            this.menuStrip1.TabIndex = 38;
            this.menuStrip1.Text = "menuStrip1";
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
            this.cLEARToolStripMenuItem.Size = new System.Drawing.Size(79, 29);
            this.cLEARToolStripMenuItem.Text = "CLEAR";
            this.cLEARToolStripMenuItem.Click += new System.EventHandler(this.cLEARToolStripMenuItem_Click);
            // 
            // eXITToolStripMenuItem
            // 
            this.eXITToolStripMenuItem.Name = "eXITToolStripMenuItem";
            this.eXITToolStripMenuItem.Size = new System.Drawing.Size(62, 29);
            this.eXITToolStripMenuItem.Text = "EXIT";
            this.eXITToolStripMenuItem.Click += new System.EventHandler(this.eXITToolStripMenuItem_Click);
            // 
            // textBoxPaid
            // 
            this.textBoxPaid.Location = new System.Drawing.Point(995, 386);
            this.textBoxPaid.Name = "textBoxPaid";
            this.textBoxPaid.Size = new System.Drawing.Size(249, 26);
            this.textBoxPaid.TabIndex = 39;
            // 
            // labelPaid
            // 
            this.labelPaid.AutoSize = true;
            this.labelPaid.Location = new System.Drawing.Point(856, 392);
            this.labelPaid.Name = "labelPaid";
            this.labelPaid.Size = new System.Drawing.Size(40, 20);
            this.labelPaid.TabIndex = 40;
            this.labelPaid.Text = "Paid";
            this.labelPaid.Click += new System.EventHandler(this.labelPaid_Click);
            // 
            // dateTimePickerDueDate
            // 
            this.dateTimePickerDueDate.Location = new System.Drawing.Point(995, 471);
            this.dateTimePickerDueDate.Name = "dateTimePickerDueDate";
            this.dateTimePickerDueDate.Size = new System.Drawing.Size(200, 26);
            this.dateTimePickerDueDate.TabIndex = 41;
            // 
            // labelDueDate
            // 
            this.labelDueDate.AutoSize = true;
            this.labelDueDate.Location = new System.Drawing.Point(859, 477);
            this.labelDueDate.Name = "labelDueDate";
            this.labelDueDate.Size = new System.Drawing.Size(74, 20);
            this.labelDueDate.TabIndex = 42;
            this.labelDueDate.Text = "DueDate";
            // 
            // labelBalance
            // 
            this.labelBalance.AutoSize = true;
            this.labelBalance.Location = new System.Drawing.Point(856, 435);
            this.labelBalance.Name = "labelBalance";
            this.labelBalance.Size = new System.Drawing.Size(67, 20);
            this.labelBalance.TabIndex = 43;
            this.labelBalance.Text = "Balance";
            // 
            // textBoxBalance
            // 
            this.textBoxBalance.Location = new System.Drawing.Point(995, 429);
            this.textBoxBalance.Name = "textBoxBalance";
            this.textBoxBalance.Size = new System.Drawing.Size(258, 26);
            this.textBoxBalance.TabIndex = 44;
            // 
            // PurchaseOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1299, 578);
            this.Controls.Add(this.textBoxBalance);
            this.Controls.Add(this.labelBalance);
            this.Controls.Add(this.labelDueDate);
            this.Controls.Add(this.dateTimePickerDueDate);
            this.Controls.Add(this.labelPaid);
            this.Controls.Add(this.textBoxPaid);
            this.Controls.Add(this.textBoxDiscount);
            this.Controls.Add(this.labelDiscount);
            this.Controls.Add(this.buttonLoadTable);
            this.Controls.Add(this.dataGridViewPurchaseOrder);
            this.Controls.Add(this.labelproduct);
            this.Controls.Add(this.buttonCALCULATE);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.dateTimePickerOrderDate);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelSID);
            this.Controls.Add(this.textBoxSID);
            this.Controls.Add(this.textBoxTotal);
            this.Controls.Add(this.textBoxUnitPrice);
            this.Controls.Add(this.textBoxQuantitykg);
            this.Controls.Add(this.comboBoxProductName);
            this.Controls.Add(this.labelQuantitykg);
            this.Controls.Add(this.labelUnitPrice);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PurchaseOrder";
            this.Text = "PurchaseOrder";
            this.Load += new System.EventHandler(this.PurchaseOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPurchaseOrder)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelUnitPrice;
        private System.Windows.Forms.Label labelQuantitykg;
        private System.Windows.Forms.ComboBox comboBoxProductName;
        private System.Windows.Forms.TextBox textBoxQuantitykg;
        private System.Windows.Forms.TextBox textBoxUnitPrice;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.TextBox textBoxSID;
        private System.Windows.Forms.Label labelSID;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerOrderDate;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonCALCULATE;
        private System.Windows.Forms.Label labelproduct;
        private System.Windows.Forms.DataGridView dataGridViewPurchaseOrder;
        private System.Windows.Forms.Button buttonLoadTable;
        private System.Windows.Forms.Label labelDiscount;
        private System.Windows.Forms.TextBox textBoxDiscount;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mENUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aDDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eDITToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dELETEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cLEARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXITToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxPaid;
        private System.Windows.Forms.Label labelPaid;
        private System.Windows.Forms.DateTimePicker dateTimePickerDueDate;
        private System.Windows.Forms.Label labelDueDate;
        private System.Windows.Forms.Label labelBalance;
        private System.Windows.Forms.TextBox textBoxBalance;
    }
}