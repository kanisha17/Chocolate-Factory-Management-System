
namespace Chocolate_Factory_Management_System
{
    partial class SalesOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesOrder));
            this.labelQuantity = new System.Windows.Forms.Label();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.textBoxSubTotal = new System.Windows.Forms.TextBox();
            this.labelItemName = new System.Windows.Forms.Label();
            this.labelUnitPrice = new System.Windows.Forms.Label();
            this.labelSubTotal = new System.Windows.Forms.Label();
            this.textBoxUnitPrice = new System.Windows.Forms.TextBox();
            this.comboBoxItemName = new System.Windows.Forms.ComboBox();
            this.buttonPAY = new System.Windows.Forms.Button();
            this.dataGridViewSaleOrder = new System.Windows.Forms.DataGridView();
            this.labelDiscount = new System.Windows.Forms.Label();
            this.textBoxDiscount = new System.Windows.Forms.TextBox();
            this.textBoxChange = new System.Windows.Forms.TextBox();
            this.labelChange = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.eXITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelPaid = new System.Windows.Forms.Label();
            this.textBoxPaid = new System.Windows.Forms.TextBox();
            this.labelSO = new System.Windows.Forms.Label();
            this.labelCustomerName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelFinalCost = new System.Windows.Forms.Label();
            this.labelTotalCost = new System.Windows.Forms.Label();
            this.textBoxFinalCost = new System.Windows.Forms.TextBox();
            this.textBoxTotalCost = new System.Windows.Forms.TextBox();
            this.textBoxTax = new System.Windows.Forms.TextBox();
            this.labelTax = new System.Windows.Forms.Label();
            this.textBoxInvoiceNo = new System.Windows.Forms.TextBox();
            this.labelInvoiceNo = new System.Windows.Forms.Label();
            this.buttonADD = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonClearTable = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.textBoxPhoneNo = new System.Windows.Forms.TextBox();
            this.pRINTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelPhoneNo = new System.Windows.Forms.Label();
            this.textBoxStock = new System.Windows.Forms.TextBox();
            this.labelStock = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSaleOrder)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.BackColor = System.Drawing.Color.Transparent;
            this.labelQuantity.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantity.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelQuantity.Location = new System.Drawing.Point(23, 329);
            this.labelQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(135, 31);
            this.labelQuantity.TabIndex = 0;
            this.labelQuantity.Text = "Quantity";
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Enabled = false;
            this.textBoxQuantity.Location = new System.Drawing.Point(302, 329);
            this.textBoxQuantity.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(300, 31);
            this.textBoxQuantity.TabIndex = 1;
            this.textBoxQuantity.TextChanged += new System.EventHandler(this.textBoxQuantity_TextChanged);
            this.textBoxQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxQuantity_KeyPress);
            // 
            // textBoxSubTotal
            // 
            this.textBoxSubTotal.Location = new System.Drawing.Point(302, 382);
            this.textBoxSubTotal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxSubTotal.Name = "textBoxSubTotal";
            this.textBoxSubTotal.Size = new System.Drawing.Size(300, 31);
            this.textBoxSubTotal.TabIndex = 4;
            this.textBoxSubTotal.TextChanged += new System.EventHandler(this.textBoxSubTotal_TextChanged);
            this.textBoxSubTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSubTotal_KeyPress);
            // 
            // labelItemName
            // 
            this.labelItemName.AutoSize = true;
            this.labelItemName.BackColor = System.Drawing.Color.Transparent;
            this.labelItemName.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelItemName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelItemName.Location = new System.Drawing.Point(23, 125);
            this.labelItemName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelItemName.Name = "labelItemName";
            this.labelItemName.Size = new System.Drawing.Size(165, 31);
            this.labelItemName.TabIndex = 8;
            this.labelItemName.Text = "Item Name";
            // 
            // labelUnitPrice
            // 
            this.labelUnitPrice.AutoSize = true;
            this.labelUnitPrice.BackColor = System.Drawing.Color.Transparent;
            this.labelUnitPrice.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUnitPrice.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelUnitPrice.Location = new System.Drawing.Point(23, 219);
            this.labelUnitPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUnitPrice.Name = "labelUnitPrice";
            this.labelUnitPrice.Size = new System.Drawing.Size(149, 31);
            this.labelUnitPrice.TabIndex = 9;
            this.labelUnitPrice.Text = "Unit Price";
            // 
            // labelSubTotal
            // 
            this.labelSubTotal.AutoSize = true;
            this.labelSubTotal.BackColor = System.Drawing.Color.Transparent;
            this.labelSubTotal.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubTotal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelSubTotal.Location = new System.Drawing.Point(22, 382);
            this.labelSubTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSubTotal.Name = "labelSubTotal";
            this.labelSubTotal.Size = new System.Drawing.Size(146, 31);
            this.labelSubTotal.TabIndex = 10;
            this.labelSubTotal.Text = "Sub Total";
            // 
            // textBoxUnitPrice
            // 
            this.textBoxUnitPrice.Location = new System.Drawing.Point(302, 225);
            this.textBoxUnitPrice.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxUnitPrice.Name = "textBoxUnitPrice";
            this.textBoxUnitPrice.Size = new System.Drawing.Size(300, 31);
            this.textBoxUnitPrice.TabIndex = 3;
            this.textBoxUnitPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxUnitPrice_KeyPress);
            // 
            // comboBoxItemName
            // 
            this.comboBoxItemName.FormattingEnabled = true;
            this.comboBoxItemName.Location = new System.Drawing.Point(302, 125);
            this.comboBoxItemName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxItemName.Name = "comboBoxItemName";
            this.comboBoxItemName.Size = new System.Drawing.Size(300, 31);
            this.comboBoxItemName.TabIndex = 0;
            this.comboBoxItemName.SelectedIndexChanged += new System.EventHandler(this.comboBoxItemName_SelectedIndexChanged);
            // 
            // buttonPAY
            // 
            this.buttonPAY.Location = new System.Drawing.Point(1611, 665);
            this.buttonPAY.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonPAY.Name = "buttonPAY";
            this.buttonPAY.Size = new System.Drawing.Size(166, 38);
            this.buttonPAY.TabIndex = 25;
            this.buttonPAY.Text = "PAY";
            this.buttonPAY.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSaleOrder
            // 
            this.dataGridViewSaleOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSaleOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSaleOrder.Location = new System.Drawing.Point(19, 479);
            this.dataGridViewSaleOrder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridViewSaleOrder.Name = "dataGridViewSaleOrder";
            this.dataGridViewSaleOrder.RowHeadersWidth = 62;
            this.dataGridViewSaleOrder.RowTemplate.Height = 28;
            this.dataGridViewSaleOrder.Size = new System.Drawing.Size(1243, 158);
            this.dataGridViewSaleOrder.TabIndex = 26;
            this.dataGridViewSaleOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSaleOrder_CellContentClick);
            // 
            // labelDiscount
            // 
            this.labelDiscount.AutoSize = true;
            this.labelDiscount.BackColor = System.Drawing.Color.Transparent;
            this.labelDiscount.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiscount.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelDiscount.Location = new System.Drawing.Point(23, 271);
            this.labelDiscount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDiscount.Name = "labelDiscount";
            this.labelDiscount.Size = new System.Drawing.Size(262, 31);
            this.labelDiscount.TabIndex = 28;
            this.labelDiscount.Text = "Discount per item";
            // 
            // textBoxDiscount
            // 
            this.textBoxDiscount.Location = new System.Drawing.Point(302, 277);
            this.textBoxDiscount.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxDiscount.Name = "textBoxDiscount";
            this.textBoxDiscount.Size = new System.Drawing.Size(300, 31);
            this.textBoxDiscount.TabIndex = 2;
            this.textBoxDiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDiscount_KeyPress);
            // 
            // textBoxChange
            // 
            this.textBoxChange.Location = new System.Drawing.Point(910, 368);
            this.textBoxChange.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxChange.Name = "textBoxChange";
            this.textBoxChange.Size = new System.Drawing.Size(300, 31);
            this.textBoxChange.TabIndex = 9;
            this.textBoxChange.TextChanged += new System.EventHandler(this.textBoxBalance_TextChanged);
            this.textBoxChange.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxChange_KeyPress);
            // 
            // labelChange
            // 
            this.labelChange.AutoSize = true;
            this.labelChange.BackColor = System.Drawing.Color.Transparent;
            this.labelChange.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChange.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelChange.Location = new System.Drawing.Point(720, 369);
            this.labelChange.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelChange.Name = "labelChange";
            this.labelChange.Size = new System.Drawing.Size(117, 31);
            this.labelChange.TabIndex = 32;
            this.labelChange.Text = "Change";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eXITToolStripMenuItem,
            this.pRINTToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(13, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1275, 42);
            this.menuStrip1.TabIndex = 35;
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
            // labelPaid
            // 
            this.labelPaid.AutoSize = true;
            this.labelPaid.BackColor = System.Drawing.Color.Transparent;
            this.labelPaid.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPaid.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelPaid.Location = new System.Drawing.Point(720, 315);
            this.labelPaid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPaid.Name = "labelPaid";
            this.labelPaid.Size = new System.Drawing.Size(74, 31);
            this.labelPaid.TabIndex = 36;
            this.labelPaid.Text = "Paid";
            // 
            // textBoxPaid
            // 
            this.textBoxPaid.Location = new System.Drawing.Point(910, 315);
            this.textBoxPaid.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxPaid.Name = "textBoxPaid";
            this.textBoxPaid.Size = new System.Drawing.Size(300, 31);
            this.textBoxPaid.TabIndex = 8;
            this.textBoxPaid.TextChanged += new System.EventHandler(this.textBoxPaid_TextChanged);
            this.textBoxPaid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPaid_KeyPress);
            // 
            // labelSO
            // 
            this.labelSO.AutoSize = true;
            this.labelSO.BackColor = System.Drawing.Color.Transparent;
            this.labelSO.Font = new System.Drawing.Font("Lucida Bright", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSO.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelSO.Location = new System.Drawing.Point(453, 42);
            this.labelSO.Name = "labelSO";
            this.labelSO.Size = new System.Drawing.Size(364, 54);
            this.labelSO.TabIndex = 39;
            this.labelSO.Text = "SALES ORDER";
            // 
            // labelCustomerName
            // 
            this.labelCustomerName.AutoSize = true;
            this.labelCustomerName.BackColor = System.Drawing.Color.Transparent;
            this.labelCustomerName.Font = new System.Drawing.Font("Lucida Bright", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomerName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelCustomerName.Location = new System.Drawing.Point(853, 57);
            this.labelCustomerName.Name = "labelCustomerName";
            this.labelCustomerName.Size = new System.Drawing.Size(194, 25);
            this.labelCustomerName.TabIndex = 40;
            this.labelCustomerName.Text = "Customer Name";
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Lucida Bright", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(1053, 56);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(210, 26);
            this.textBoxName.TabIndex = 41;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            this.textBoxName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxName_KeyPress);
            // 
            // labelFinalCost
            // 
            this.labelFinalCost.AutoSize = true;
            this.labelFinalCost.BackColor = System.Drawing.Color.Transparent;
            this.labelFinalCost.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFinalCost.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelFinalCost.Location = new System.Drawing.Point(720, 264);
            this.labelFinalCost.Name = "labelFinalCost";
            this.labelFinalCost.Size = new System.Drawing.Size(151, 31);
            this.labelFinalCost.TabIndex = 45;
            this.labelFinalCost.Text = "Final Cost";
            // 
            // labelTotalCost
            // 
            this.labelTotalCost.AutoSize = true;
            this.labelTotalCost.BackColor = System.Drawing.Color.Transparent;
            this.labelTotalCost.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalCost.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelTotalCost.Location = new System.Drawing.Point(720, 209);
            this.labelTotalCost.Name = "labelTotalCost";
            this.labelTotalCost.Size = new System.Drawing.Size(156, 31);
            this.labelTotalCost.TabIndex = 46;
            this.labelTotalCost.Text = "Total Cost";
            // 
            // textBoxFinalCost
            // 
            this.textBoxFinalCost.Location = new System.Drawing.Point(910, 262);
            this.textBoxFinalCost.Name = "textBoxFinalCost";
            this.textBoxFinalCost.Size = new System.Drawing.Size(300, 31);
            this.textBoxFinalCost.TabIndex = 7;
            this.textBoxFinalCost.TextChanged += new System.EventHandler(this.textBoxFinalCost_TextChanged);
            this.textBoxFinalCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFinalCost_KeyPress);
            // 
            // textBoxTotalCost
            // 
            this.textBoxTotalCost.Location = new System.Drawing.Point(910, 209);
            this.textBoxTotalCost.Name = "textBoxTotalCost";
            this.textBoxTotalCost.Size = new System.Drawing.Size(300, 31);
            this.textBoxTotalCost.TabIndex = 6;
            this.textBoxTotalCost.TextChanged += new System.EventHandler(this.textBoxTotalCost_TextChanged);
            this.textBoxTotalCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTotalCost_KeyPress);
            // 
            // textBoxTax
            // 
            this.textBoxTax.Location = new System.Drawing.Point(302, 430);
            this.textBoxTax.Name = "textBoxTax";
            this.textBoxTax.Size = new System.Drawing.Size(300, 31);
            this.textBoxTax.TabIndex = 5;
            this.textBoxTax.TextChanged += new System.EventHandler(this.textBoxTax_TextChanged);
            this.textBoxTax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTax_KeyPress);
            // 
            // labelTax
            // 
            this.labelTax.AutoSize = true;
            this.labelTax.BackColor = System.Drawing.Color.Transparent;
            this.labelTax.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTax.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelTax.Location = new System.Drawing.Point(23, 430);
            this.labelTax.Name = "labelTax";
            this.labelTax.Size = new System.Drawing.Size(66, 31);
            this.labelTax.TabIndex = 50;
            this.labelTax.Text = "Tax";
            // 
            // textBoxInvoiceNo
            // 
            this.textBoxInvoiceNo.Font = new System.Drawing.Font("Lucida Bright", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInvoiceNo.Location = new System.Drawing.Point(150, 56);
            this.textBoxInvoiceNo.Name = "textBoxInvoiceNo";
            this.textBoxInvoiceNo.Size = new System.Drawing.Size(148, 26);
            this.textBoxInvoiceNo.TabIndex = 51;
            this.textBoxInvoiceNo.TextChanged += new System.EventHandler(this.textBoxInvoiceNo_TextChanged);
            // 
            // labelInvoiceNo
            // 
            this.labelInvoiceNo.AutoSize = true;
            this.labelInvoiceNo.BackColor = System.Drawing.Color.Transparent;
            this.labelInvoiceNo.Font = new System.Drawing.Font("Lucida Bright", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInvoiceNo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelInvoiceNo.Location = new System.Drawing.Point(12, 57);
            this.labelInvoiceNo.Name = "labelInvoiceNo";
            this.labelInvoiceNo.Size = new System.Drawing.Size(132, 25);
            this.labelInvoiceNo.TabIndex = 52;
            this.labelInvoiceNo.Text = "Invoice No";
            // 
            // buttonADD
            // 
            this.buttonADD.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonADD.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonADD.Location = new System.Drawing.Point(656, 417);
            this.buttonADD.Name = "buttonADD";
            this.buttonADD.Size = new System.Drawing.Size(123, 49);
            this.buttonADD.TabIndex = 53;
            this.buttonADD.Text = "ADD";
            this.buttonADD.UseVisualStyleBackColor = false;
            this.buttonADD.Click += new System.EventHandler(this.buttonADD_Click_1);
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonReset.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.Location = new System.Drawing.Point(817, 417);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(121, 49);
            this.buttonReset.TabIndex = 54;
            this.buttonReset.Text = "RESET";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonClearTable
            // 
            this.buttonClearTable.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonClearTable.Location = new System.Drawing.Point(1124, 420);
            this.buttonClearTable.Name = "buttonClearTable";
            this.buttonClearTable.Size = new System.Drawing.Size(138, 46);
            this.buttonClearTable.TabIndex = 55;
            this.buttonClearTable.Text = "Clear Table";
            this.buttonClearTable.UseVisualStyleBackColor = false;
            this.buttonClearTable.Click += new System.EventHandler(this.buttonClearTable_Click);
            // 
            // buttonInsert
            // 
            this.buttonInsert.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonInsert.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInsert.Location = new System.Drawing.Point(971, 417);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(134, 49);
            this.buttonInsert.TabIndex = 57;
            this.buttonInsert.Text = "INSERT";
            this.buttonInsert.UseVisualStyleBackColor = false;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
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
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // textBoxPhoneNo
            // 
            this.textBoxPhoneNo.Font = new System.Drawing.Font("Lucida Bright", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPhoneNo.Location = new System.Drawing.Point(1053, 129);
            this.textBoxPhoneNo.Name = "textBoxPhoneNo";
            this.textBoxPhoneNo.Size = new System.Drawing.Size(210, 26);
            this.textBoxPhoneNo.TabIndex = 58;
            this.textBoxPhoneNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPhoneNo_KeyPress);
            // 
            // pRINTToolStripMenuItem
            // 
            this.pRINTToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pRINTToolStripMenuItem.Image = global::Chocolate_Factory_Management_System.Properties.Resources.a101;
            this.pRINTToolStripMenuItem.Name = "pRINTToolStripMenuItem";
            this.pRINTToolStripMenuItem.Size = new System.Drawing.Size(127, 36);
            this.pRINTToolStripMenuItem.Text = "PRINT";
            this.pRINTToolStripMenuItem.Click += new System.EventHandler(this.pRINTToolStripMenuItem_Click);
            // 
            // labelPhoneNo
            // 
            this.labelPhoneNo.AutoSize = true;
            this.labelPhoneNo.BackColor = System.Drawing.Color.Transparent;
            this.labelPhoneNo.Font = new System.Drawing.Font("Lucida Bright", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhoneNo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelPhoneNo.Location = new System.Drawing.Point(927, 129);
            this.labelPhoneNo.Name = "labelPhoneNo";
            this.labelPhoneNo.Size = new System.Drawing.Size(120, 25);
            this.labelPhoneNo.TabIndex = 60;
            this.labelPhoneNo.Text = "Phone No";
            // 
            // textBoxStock
            // 
            this.textBoxStock.Location = new System.Drawing.Point(302, 176);
            this.textBoxStock.Name = "textBoxStock";
            this.textBoxStock.Size = new System.Drawing.Size(300, 31);
            this.textBoxStock.TabIndex = 61;
            this.textBoxStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStock_KeyPress);
            // 
            // labelStock
            // 
            this.labelStock.AutoSize = true;
            this.labelStock.BackColor = System.Drawing.Color.Transparent;
            this.labelStock.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStock.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelStock.Location = new System.Drawing.Point(23, 176);
            this.labelStock.Name = "labelStock";
            this.labelStock.Size = new System.Drawing.Size(229, 31);
            this.labelStock.TabIndex = 59;
            this.labelStock.Text = "Available Stock";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(894, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 25);
            this.label1.TabIndex = 62;
            this.label1.Text = "Customer ID";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Lucida Bright", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(1053, 93);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(209, 26);
            this.textBox1.TabIndex = 63;
            // 
            // SalesOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Chocolate_Factory_Management_System.Properties.Resources.b5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1275, 649);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxStock);
            this.Controls.Add(this.labelPhoneNo);
            this.Controls.Add(this.labelStock);
            this.Controls.Add(this.textBoxPhoneNo);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.buttonClearTable);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonADD);
            this.Controls.Add(this.labelInvoiceNo);
            this.Controls.Add(this.textBoxInvoiceNo);
            this.Controls.Add(this.labelTax);
            this.Controls.Add(this.textBoxTax);
            this.Controls.Add(this.textBoxTotalCost);
            this.Controls.Add(this.textBoxFinalCost);
            this.Controls.Add(this.labelTotalCost);
            this.Controls.Add(this.labelFinalCost);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelCustomerName);
            this.Controls.Add(this.labelSO);
            this.Controls.Add(this.textBoxPaid);
            this.Controls.Add(this.labelPaid);
            this.Controls.Add(this.labelChange);
            this.Controls.Add(this.textBoxChange);
            this.Controls.Add(this.textBoxDiscount);
            this.Controls.Add(this.labelDiscount);
            this.Controls.Add(this.dataGridViewSaleOrder);
            this.Controls.Add(this.buttonPAY);
            this.Controls.Add(this.comboBoxItemName);
            this.Controls.Add(this.textBoxUnitPrice);
            this.Controls.Add(this.labelSubTotal);
            this.Controls.Add(this.labelUnitPrice);
            this.Controls.Add(this.labelItemName);
            this.Controls.Add(this.textBoxSubTotal);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "SalesOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SalesOrder";
            this.Load += new System.EventHandler(this.SalesOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSaleOrder)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.TextBox textBoxSubTotal;
        private System.Windows.Forms.Label labelItemName;
        private System.Windows.Forms.Label labelUnitPrice;
        private System.Windows.Forms.Label labelSubTotal;
        private System.Windows.Forms.TextBox textBoxUnitPrice;
        private System.Windows.Forms.ComboBox comboBoxItemName;
        private System.Windows.Forms.Button buttonPAY;
        private System.Windows.Forms.DataGridView dataGridViewSaleOrder;
        private System.Windows.Forms.Label labelDiscount;
        private System.Windows.Forms.TextBox textBoxDiscount;
        private System.Windows.Forms.TextBox textBoxChange;
        private System.Windows.Forms.Label labelChange;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem eXITToolStripMenuItem;
        private System.Windows.Forms.Label labelPaid;
        private System.Windows.Forms.TextBox textBoxPaid;
        private System.Windows.Forms.Label labelSO;
        private System.Windows.Forms.Label labelCustomerName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelFinalCost;
        private System.Windows.Forms.Label labelTotalCost;
        private System.Windows.Forms.TextBox textBoxFinalCost;
        private System.Windows.Forms.TextBox textBoxTotalCost;
        private System.Windows.Forms.TextBox textBoxTax;
        private System.Windows.Forms.Label labelTax;
        private System.Windows.Forms.TextBox textBoxInvoiceNo;
        private System.Windows.Forms.Label labelInvoiceNo;
        private System.Windows.Forms.Button buttonADD;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonClearTable;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.TextBox textBoxPhoneNo;
        private System.Windows.Forms.ToolStripMenuItem pRINTToolStripMenuItem;
        private System.Windows.Forms.Label labelPhoneNo;
        private System.Windows.Forms.TextBox textBoxStock;
        private System.Windows.Forms.Label labelStock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}