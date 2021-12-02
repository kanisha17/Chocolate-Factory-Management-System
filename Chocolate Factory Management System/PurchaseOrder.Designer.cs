
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchaseOrder));
            this.labelSubTotal = new System.Windows.Forms.Label();
            this.labelUnitPrice = new System.Windows.Forms.Label();
            this.labelQuantitykg = new System.Windows.Forms.Label();
            this.comboBoxProductName = new System.Windows.Forms.ComboBox();
            this.textBoxQuantitykg = new System.Windows.Forms.TextBox();
            this.textBoxUnitPrice = new System.Windows.Forms.TextBox();
            this.textBoxSubTotal = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelInvoiceNo = new System.Windows.Forms.Label();
            this.labelproduct = new System.Windows.Forms.Label();
            this.dataGridViewPurchaseOrder = new System.Windows.Forms.DataGridView();
            this.labelDiscount = new System.Windows.Forms.Label();
            this.textBoxDiscount = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.eXITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pRINTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxPaid = new System.Windows.Forms.TextBox();
            this.labelPaid = new System.Windows.Forms.Label();
            this.labelChange = new System.Windows.Forms.Label();
            this.textBoxChange = new System.Windows.Forms.TextBox();
            this.labelPO = new System.Windows.Forms.Label();
            this.textBoxInvoiceID = new System.Windows.Forms.TextBox();
            this.textBoxTax = new System.Windows.Forms.TextBox();
            this.textBoxFinalCost = new System.Windows.Forms.TextBox();
            this.textBoxTotalCost = new System.Windows.Forms.TextBox();
            this.labelFinalCost = new System.Windows.Forms.Label();
            this.labelTotalCost = new System.Windows.Forms.Label();
            this.labelTax = new System.Windows.Forms.Label();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonClearTable = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.textBoxPhoneNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelStock = new System.Windows.Forms.Label();
            this.textBoxStock = new System.Windows.Forms.TextBox();
            this.textBoxSID = new System.Windows.Forms.TextBox();
            this.labelSID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPurchaseOrder)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelSubTotal
            // 
            this.labelSubTotal.AutoSize = true;
            this.labelSubTotal.BackColor = System.Drawing.Color.Transparent;
            this.labelSubTotal.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubTotal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelSubTotal.Location = new System.Drawing.Point(15, 349);
            this.labelSubTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSubTotal.Name = "labelSubTotal";
            this.labelSubTotal.Size = new System.Drawing.Size(146, 31);
            this.labelSubTotal.TabIndex = 6;
            this.labelSubTotal.Text = "Sub Total";
            // 
            // labelUnitPrice
            // 
            this.labelUnitPrice.AutoSize = true;
            this.labelUnitPrice.BackColor = System.Drawing.Color.Transparent;
            this.labelUnitPrice.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUnitPrice.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelUnitPrice.Location = new System.Drawing.Point(15, 203);
            this.labelUnitPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUnitPrice.Name = "labelUnitPrice";
            this.labelUnitPrice.Size = new System.Drawing.Size(149, 31);
            this.labelUnitPrice.TabIndex = 7;
            this.labelUnitPrice.Text = "Unit Price";
            // 
            // labelQuantitykg
            // 
            this.labelQuantitykg.AutoSize = true;
            this.labelQuantitykg.BackColor = System.Drawing.Color.Transparent;
            this.labelQuantitykg.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantitykg.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelQuantitykg.Location = new System.Drawing.Point(15, 301);
            this.labelQuantitykg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuantitykg.Name = "labelQuantitykg";
            this.labelQuantitykg.Size = new System.Drawing.Size(135, 31);
            this.labelQuantitykg.TabIndex = 8;
            this.labelQuantitykg.Text = "Quantity";
            // 
            // comboBoxProductName
            // 
            this.comboBoxProductName.FormattingEnabled = true;
            this.comboBoxProductName.Location = new System.Drawing.Point(252, 108);
            this.comboBoxProductName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxProductName.Name = "comboBoxProductName";
            this.comboBoxProductName.Size = new System.Drawing.Size(358, 31);
            this.comboBoxProductName.TabIndex = 11;
            this.comboBoxProductName.SelectedIndexChanged += new System.EventHandler(this.comboBoxProductName_SelectedIndexChanged);
            // 
            // textBoxQuantitykg
            // 
            this.textBoxQuantitykg.Enabled = false;
            this.textBoxQuantitykg.Location = new System.Drawing.Point(252, 301);
            this.textBoxQuantitykg.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxQuantitykg.Name = "textBoxQuantitykg";
            this.textBoxQuantitykg.Size = new System.Drawing.Size(358, 31);
            this.textBoxQuantitykg.TabIndex = 14;
            this.textBoxQuantitykg.TextChanged += new System.EventHandler(this.textBoxQuantitykg_TextChanged);
            this.textBoxQuantitykg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxQuantitykg_KeyPress);
            // 
            // textBoxUnitPrice
            // 
            this.textBoxUnitPrice.Location = new System.Drawing.Point(252, 203);
            this.textBoxUnitPrice.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxUnitPrice.Name = "textBoxUnitPrice";
            this.textBoxUnitPrice.Size = new System.Drawing.Size(358, 31);
            this.textBoxUnitPrice.TabIndex = 15;
            this.textBoxUnitPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxUnitPrice_KeyPress);
            // 
            // textBoxSubTotal
            // 
            this.textBoxSubTotal.Location = new System.Drawing.Point(252, 349);
            this.textBoxSubTotal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxSubTotal.Name = "textBoxSubTotal";
            this.textBoxSubTotal.Size = new System.Drawing.Size(358, 31);
            this.textBoxSubTotal.TabIndex = 16;
            this.textBoxSubTotal.TextChanged += new System.EventHandler(this.textBoxSubTotal_TextChanged);
            this.textBoxSubTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSubTotal_KeyPress);
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Lucida Bright", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(1105, 51);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(187, 26);
            this.textBoxName.TabIndex = 17;
            this.textBoxName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxName_KeyPress);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Font = new System.Drawing.Font("Lucida Bright", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelName.Location = new System.Drawing.Point(979, 52);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(77, 25);
            this.labelName.TabIndex = 18;
            this.labelName.Text = "Name";
            // 
            // labelInvoiceNo
            // 
            this.labelInvoiceNo.AutoSize = true;
            this.labelInvoiceNo.BackColor = System.Drawing.Color.Transparent;
            this.labelInvoiceNo.Font = new System.Drawing.Font("Lucida Bright", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInvoiceNo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelInvoiceNo.Location = new System.Drawing.Point(7, 51);
            this.labelInvoiceNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelInvoiceNo.Name = "labelInvoiceNo";
            this.labelInvoiceNo.Size = new System.Drawing.Size(132, 25);
            this.labelInvoiceNo.TabIndex = 19;
            this.labelInvoiceNo.Text = "Invoice No";
            // 
            // labelproduct
            // 
            this.labelproduct.AutoSize = true;
            this.labelproduct.BackColor = System.Drawing.Color.Transparent;
            this.labelproduct.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelproduct.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelproduct.Location = new System.Drawing.Point(17, 108);
            this.labelproduct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelproduct.Name = "labelproduct";
            this.labelproduct.Size = new System.Drawing.Size(214, 31);
            this.labelproduct.TabIndex = 30;
            this.labelproduct.Text = "Product Name";
            // 
            // dataGridViewPurchaseOrder
            // 
            this.dataGridViewPurchaseOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPurchaseOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPurchaseOrder.Location = new System.Drawing.Point(16, 439);
            this.dataGridViewPurchaseOrder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridViewPurchaseOrder.Name = "dataGridViewPurchaseOrder";
            this.dataGridViewPurchaseOrder.RowHeadersWidth = 62;
            this.dataGridViewPurchaseOrder.RowTemplate.Height = 28;
            this.dataGridViewPurchaseOrder.Size = new System.Drawing.Size(1276, 177);
            this.dataGridViewPurchaseOrder.TabIndex = 31;
            this.dataGridViewPurchaseOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPurchaseOrder_CellContentClick);
            // 
            // labelDiscount
            // 
            this.labelDiscount.AutoSize = true;
            this.labelDiscount.BackColor = System.Drawing.Color.Transparent;
            this.labelDiscount.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiscount.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelDiscount.Location = new System.Drawing.Point(15, 252);
            this.labelDiscount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDiscount.Name = "labelDiscount";
            this.labelDiscount.Size = new System.Drawing.Size(137, 31);
            this.labelDiscount.TabIndex = 34;
            this.labelDiscount.Text = "Discount";
            // 
            // textBoxDiscount
            // 
            this.textBoxDiscount.Location = new System.Drawing.Point(252, 252);
            this.textBoxDiscount.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxDiscount.Name = "textBoxDiscount";
            this.textBoxDiscount.Size = new System.Drawing.Size(358, 31);
            this.textBoxDiscount.TabIndex = 35;
            this.textBoxDiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDiscount_KeyPress);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkGray;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eXITToolStripMenuItem,
            this.pRINTToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(13, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1305, 42);
            this.menuStrip1.TabIndex = 38;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // eXITToolStripMenuItem
            // 
            this.eXITToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.eXITToolStripMenuItem.Image = global::Chocolate_Factory_Management_System.Properties.Resources.exit1;
            this.eXITToolStripMenuItem.Name = "eXITToolStripMenuItem";
            this.eXITToolStripMenuItem.Size = new System.Drawing.Size(106, 36);
            this.eXITToolStripMenuItem.Text = "EXIT";
            this.eXITToolStripMenuItem.Click += new System.EventHandler(this.eXITToolStripMenuItem_Click);
            // 
            // pRINTToolStripMenuItem
            // 
            this.pRINTToolStripMenuItem.BackColor = System.Drawing.Color.Gainsboro;
            this.pRINTToolStripMenuItem.Image = global::Chocolate_Factory_Management_System.Properties.Resources.a101;
            this.pRINTToolStripMenuItem.Name = "pRINTToolStripMenuItem";
            this.pRINTToolStripMenuItem.Size = new System.Drawing.Size(127, 36);
            this.pRINTToolStripMenuItem.Text = "PRINT";
            this.pRINTToolStripMenuItem.Click += new System.EventHandler(this.pRINTToolStripMenuItem_Click);
            // 
            // textBoxPaid
            // 
            this.textBoxPaid.Location = new System.Drawing.Point(901, 275);
            this.textBoxPaid.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxPaid.Name = "textBoxPaid";
            this.textBoxPaid.Size = new System.Drawing.Size(358, 31);
            this.textBoxPaid.TabIndex = 39;
            this.textBoxPaid.TextChanged += new System.EventHandler(this.textBoxPaid_TextChanged);
            this.textBoxPaid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPaid_KeyPress);
            // 
            // labelPaid
            // 
            this.labelPaid.AutoSize = true;
            this.labelPaid.BackColor = System.Drawing.Color.Transparent;
            this.labelPaid.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPaid.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelPaid.Location = new System.Drawing.Point(667, 278);
            this.labelPaid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPaid.Name = "labelPaid";
            this.labelPaid.Size = new System.Drawing.Size(74, 31);
            this.labelPaid.TabIndex = 40;
            this.labelPaid.Text = "Paid";
            this.labelPaid.Click += new System.EventHandler(this.labelPaid_Click);
            // 
            // labelChange
            // 
            this.labelChange.AutoSize = true;
            this.labelChange.BackColor = System.Drawing.Color.Transparent;
            this.labelChange.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChange.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelChange.Location = new System.Drawing.Point(667, 324);
            this.labelChange.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelChange.Name = "labelChange";
            this.labelChange.Size = new System.Drawing.Size(117, 31);
            this.labelChange.TabIndex = 43;
            this.labelChange.Text = "Change";
            // 
            // textBoxChange
            // 
            this.textBoxChange.Location = new System.Drawing.Point(901, 324);
            this.textBoxChange.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxChange.Name = "textBoxChange";
            this.textBoxChange.Size = new System.Drawing.Size(358, 31);
            this.textBoxChange.TabIndex = 44;
            this.textBoxChange.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxChange_KeyPress);
            // 
            // labelPO
            // 
            this.labelPO.AutoSize = true;
            this.labelPO.BackColor = System.Drawing.Color.Transparent;
            this.labelPO.Font = new System.Drawing.Font("Lucida Bright", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPO.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelPO.Location = new System.Drawing.Point(445, 50);
            this.labelPO.Name = "labelPO";
            this.labelPO.Size = new System.Drawing.Size(480, 54);
            this.labelPO.TabIndex = 46;
            this.labelPO.Text = "PURCHASE ORDER";
            // 
            // textBoxInvoiceID
            // 
            this.textBoxInvoiceID.Font = new System.Drawing.Font("Lucida Bright", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInvoiceID.Location = new System.Drawing.Point(146, 50);
            this.textBoxInvoiceID.Name = "textBoxInvoiceID";
            this.textBoxInvoiceID.Size = new System.Drawing.Size(163, 26);
            this.textBoxInvoiceID.TabIndex = 50;
            // 
            // textBoxTax
            // 
            this.textBoxTax.Location = new System.Drawing.Point(252, 400);
            this.textBoxTax.Name = "textBoxTax";
            this.textBoxTax.Size = new System.Drawing.Size(358, 31);
            this.textBoxTax.TabIndex = 51;
            this.textBoxTax.TextChanged += new System.EventHandler(this.textBoxTax_TextChanged);
            this.textBoxTax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTax_KeyPress);
            // 
            // textBoxFinalCost
            // 
            this.textBoxFinalCost.Location = new System.Drawing.Point(901, 226);
            this.textBoxFinalCost.Name = "textBoxFinalCost";
            this.textBoxFinalCost.Size = new System.Drawing.Size(358, 31);
            this.textBoxFinalCost.TabIndex = 52;
            this.textBoxFinalCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFinalCost_KeyPress);
            // 
            // textBoxTotalCost
            // 
            this.textBoxTotalCost.Location = new System.Drawing.Point(901, 178);
            this.textBoxTotalCost.Name = "textBoxTotalCost";
            this.textBoxTotalCost.Size = new System.Drawing.Size(358, 31);
            this.textBoxTotalCost.TabIndex = 53;
            this.textBoxTotalCost.TextChanged += new System.EventHandler(this.textBoxTotalCost_TextChanged);
            this.textBoxTotalCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTotalCost_KeyPress);
            // 
            // labelFinalCost
            // 
            this.labelFinalCost.AutoSize = true;
            this.labelFinalCost.BackColor = System.Drawing.Color.Transparent;
            this.labelFinalCost.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFinalCost.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelFinalCost.Location = new System.Drawing.Point(667, 226);
            this.labelFinalCost.Name = "labelFinalCost";
            this.labelFinalCost.Size = new System.Drawing.Size(151, 31);
            this.labelFinalCost.TabIndex = 55;
            this.labelFinalCost.Text = "Final Cost";
            // 
            // labelTotalCost
            // 
            this.labelTotalCost.AutoSize = true;
            this.labelTotalCost.BackColor = System.Drawing.Color.Transparent;
            this.labelTotalCost.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalCost.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelTotalCost.Location = new System.Drawing.Point(662, 178);
            this.labelTotalCost.Name = "labelTotalCost";
            this.labelTotalCost.Size = new System.Drawing.Size(156, 31);
            this.labelTotalCost.TabIndex = 56;
            this.labelTotalCost.Text = "Total Cost";
            // 
            // labelTax
            // 
            this.labelTax.AutoSize = true;
            this.labelTax.BackColor = System.Drawing.Color.Transparent;
            this.labelTax.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTax.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelTax.Location = new System.Drawing.Point(13, 400);
            this.labelTax.Name = "labelTax";
            this.labelTax.Size = new System.Drawing.Size(66, 31);
            this.labelTax.TabIndex = 57;
            this.labelTax.Text = "Tax";
            // 
            // buttonInsert
            // 
            this.buttonInsert.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonInsert.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInsert.Location = new System.Drawing.Point(988, 379);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(144, 51);
            this.buttonInsert.TabIndex = 59;
            this.buttonInsert.Text = "INSERT";
            this.buttonInsert.UseVisualStyleBackColor = false;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonReset.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.Location = new System.Drawing.Point(813, 380);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(132, 50);
            this.buttonReset.TabIndex = 60;
            this.buttonReset.Text = "RESET";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonAdd.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(653, 380);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(133, 50);
            this.buttonAdd.TabIndex = 61;
            this.buttonAdd.Text = "ADD";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click_1);
            // 
            // buttonClearTable
            // 
            this.buttonClearTable.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonClearTable.Location = new System.Drawing.Point(1157, 379);
            this.buttonClearTable.Name = "buttonClearTable";
            this.buttonClearTable.Size = new System.Drawing.Size(135, 51);
            this.buttonClearTable.TabIndex = 62;
            this.buttonClearTable.Text = "Clear Table";
            this.buttonClearTable.UseVisualStyleBackColor = false;
            this.buttonClearTable.Click += new System.EventHandler(this.buttonClearTable_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // textBoxPhoneNo
            // 
            this.textBoxPhoneNo.Font = new System.Drawing.Font("Lucida Bright", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPhoneNo.Location = new System.Drawing.Point(1105, 118);
            this.textBoxPhoneNo.Name = "textBoxPhoneNo";
            this.textBoxPhoneNo.Size = new System.Drawing.Size(187, 26);
            this.textBoxPhoneNo.TabIndex = 64;
            this.textBoxPhoneNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPhoneNo_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(979, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 25);
            this.label1.TabIndex = 65;
            this.label1.Text = "Phone No";
            // 
            // labelStock
            // 
            this.labelStock.AutoSize = true;
            this.labelStock.BackColor = System.Drawing.Color.Transparent;
            this.labelStock.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStock.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelStock.Location = new System.Drawing.Point(17, 154);
            this.labelStock.Name = "labelStock";
            this.labelStock.Size = new System.Drawing.Size(229, 31);
            this.labelStock.TabIndex = 66;
            this.labelStock.Text = "Available Stock";
            // 
            // textBoxStock
            // 
            this.textBoxStock.Location = new System.Drawing.Point(252, 154);
            this.textBoxStock.Name = "textBoxStock";
            this.textBoxStock.Size = new System.Drawing.Size(358, 31);
            this.textBoxStock.TabIndex = 67;
            this.textBoxStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStock_KeyPress);
            // 
            // textBoxSID
            // 
            this.textBoxSID.Font = new System.Drawing.Font("Lucida Bright", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSID.Location = new System.Drawing.Point(1105, 86);
            this.textBoxSID.Name = "textBoxSID";
            this.textBoxSID.Size = new System.Drawing.Size(187, 26);
            this.textBoxSID.TabIndex = 68;
            // 
            // labelSID
            // 
            this.labelSID.AutoSize = true;
            this.labelSID.BackColor = System.Drawing.Color.Transparent;
            this.labelSID.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelSID.Location = new System.Drawing.Point(980, 89);
            this.labelSID.Name = "labelSID";
            this.labelSID.Size = new System.Drawing.Size(45, 23);
            this.labelSID.TabIndex = 69;
            this.labelSID.Text = "SID";
            // 
            // PurchaseOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Chocolate_Factory_Management_System.Properties.Resources.grey1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1305, 628);
            this.Controls.Add(this.labelSID);
            this.Controls.Add(this.textBoxSID);
            this.Controls.Add(this.textBoxStock);
            this.Controls.Add(this.labelStock);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPhoneNo);
            this.Controls.Add(this.buttonClearTable);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.labelTax);
            this.Controls.Add(this.labelTotalCost);
            this.Controls.Add(this.labelFinalCost);
            this.Controls.Add(this.textBoxTotalCost);
            this.Controls.Add(this.textBoxFinalCost);
            this.Controls.Add(this.textBoxTax);
            this.Controls.Add(this.textBoxInvoiceID);
            this.Controls.Add(this.labelPO);
            this.Controls.Add(this.textBoxChange);
            this.Controls.Add(this.labelChange);
            this.Controls.Add(this.labelPaid);
            this.Controls.Add(this.textBoxPaid);
            this.Controls.Add(this.textBoxDiscount);
            this.Controls.Add(this.labelDiscount);
            this.Controls.Add(this.dataGridViewPurchaseOrder);
            this.Controls.Add(this.labelproduct);
            this.Controls.Add(this.labelInvoiceNo);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxSubTotal);
            this.Controls.Add(this.textBoxUnitPrice);
            this.Controls.Add(this.textBoxQuantitykg);
            this.Controls.Add(this.comboBoxProductName);
            this.Controls.Add(this.labelQuantitykg);
            this.Controls.Add(this.labelUnitPrice);
            this.Controls.Add(this.labelSubTotal);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "PurchaseOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PurchaseOrder";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PurchaseOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPurchaseOrder)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelSubTotal;
        private System.Windows.Forms.Label labelUnitPrice;
        private System.Windows.Forms.Label labelQuantitykg;
        private System.Windows.Forms.ComboBox comboBoxProductName;
        private System.Windows.Forms.TextBox textBoxQuantitykg;
        private System.Windows.Forms.TextBox textBoxUnitPrice;
        private System.Windows.Forms.TextBox textBoxSubTotal;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelInvoiceNo;
        private System.Windows.Forms.Label labelproduct;
        private System.Windows.Forms.DataGridView dataGridViewPurchaseOrder;
        private System.Windows.Forms.Label labelDiscount;
        private System.Windows.Forms.TextBox textBoxDiscount;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem eXITToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxPaid;
        private System.Windows.Forms.Label labelPaid;
        private System.Windows.Forms.Label labelChange;
        private System.Windows.Forms.TextBox textBoxChange;
        private System.Windows.Forms.Label labelPO;
        private System.Windows.Forms.TextBox textBoxInvoiceID;
        private System.Windows.Forms.TextBox textBoxTax;
        private System.Windows.Forms.TextBox textBoxFinalCost;
        private System.Windows.Forms.TextBox textBoxTotalCost;
        private System.Windows.Forms.Label labelFinalCost;
        private System.Windows.Forms.Label labelTotalCost;
        private System.Windows.Forms.Label labelTax;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonClearTable;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.TextBox textBoxPhoneNo;
        private System.Windows.Forms.ToolStripMenuItem pRINTToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelStock;
        private System.Windows.Forms.TextBox textBoxStock;
        private System.Windows.Forms.TextBox textBoxSID;
        private System.Windows.Forms.Label labelSID;
    }
}