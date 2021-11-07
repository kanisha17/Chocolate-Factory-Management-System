﻿
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
            this.labelDiscount = new System.Windows.Forms.Label();
            this.textBoxDiscount = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cLEARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lOADTABLEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rECEIPTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxPaid = new System.Windows.Forms.TextBox();
            this.labelPaid = new System.Windows.Forms.Label();
            this.dateTimePickerDueDate = new System.Windows.Forms.DateTimePicker();
            this.labelDueDate = new System.Windows.Forms.Label();
            this.labelBalance = new System.Windows.Forms.Label();
            this.textBoxBalance = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelPO = new System.Windows.Forms.Label();
            this.buttonDELETE = new System.Windows.Forms.Button();
            this.buttonEDIT = new System.Windows.Forms.Button();
            this.buttonADD = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPurchaseOrder)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.BackColor = System.Drawing.Color.Transparent;
            this.labelTotal.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelTotal.Location = new System.Drawing.Point(7, 343);
            this.labelTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(85, 31);
            this.labelTotal.TabIndex = 6;
            this.labelTotal.Text = "Total";
            // 
            // labelUnitPrice
            // 
            this.labelUnitPrice.AutoSize = true;
            this.labelUnitPrice.BackColor = System.Drawing.Color.Transparent;
            this.labelUnitPrice.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUnitPrice.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelUnitPrice.Location = new System.Drawing.Point(5, 288);
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
            this.labelQuantitykg.Location = new System.Drawing.Point(5, 173);
            this.labelQuantitykg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuantitykg.Name = "labelQuantitykg";
            this.labelQuantitykg.Size = new System.Drawing.Size(135, 31);
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
            "Cinamon",
            "Dry Fruits",
            "Honey",
            "Sugar",
            "Vanilla"});
            this.comboBoxProductName.Location = new System.Drawing.Point(242, 121);
            this.comboBoxProductName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxProductName.Name = "comboBoxProductName";
            this.comboBoxProductName.Size = new System.Drawing.Size(358, 31);
            this.comboBoxProductName.TabIndex = 11;
            // 
            // textBoxQuantitykg
            // 
            this.textBoxQuantitykg.Location = new System.Drawing.Point(242, 173);
            this.textBoxQuantitykg.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxQuantitykg.Name = "textBoxQuantitykg";
            this.textBoxQuantitykg.Size = new System.Drawing.Size(358, 31);
            this.textBoxQuantitykg.TabIndex = 14;
            // 
            // textBoxUnitPrice
            // 
            this.textBoxUnitPrice.Location = new System.Drawing.Point(242, 288);
            this.textBoxUnitPrice.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxUnitPrice.Name = "textBoxUnitPrice";
            this.textBoxUnitPrice.Size = new System.Drawing.Size(358, 31);
            this.textBoxUnitPrice.TabIndex = 15;
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Location = new System.Drawing.Point(242, 343);
            this.textBoxTotal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.Size = new System.Drawing.Size(358, 31);
            this.textBoxTotal.TabIndex = 16;
            // 
            // textBoxSID
            // 
            this.textBoxSID.Location = new System.Drawing.Point(990, 121);
            this.textBoxSID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxSID.Name = "textBoxSID";
            this.textBoxSID.Size = new System.Drawing.Size(270, 31);
            this.textBoxSID.TabIndex = 17;
            // 
            // labelSID
            // 
            this.labelSID.AutoSize = true;
            this.labelSID.BackColor = System.Drawing.Color.Transparent;
            this.labelSID.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSID.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelSID.Location = new System.Drawing.Point(808, 121);
            this.labelSID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSID.Name = "labelSID";
            this.labelSID.Size = new System.Drawing.Size(170, 31);
            this.labelSID.TabIndex = 18;
            this.labelSID.Text = "Supplier ID";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.BackColor = System.Drawing.Color.Transparent;
            this.labelDate.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelDate.Location = new System.Drawing.Point(5, 74);
            this.labelDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(215, 31);
            this.labelDate.TabIndex = 19;
            this.labelDate.Text = "Purchase Date";
            // 
            // dateTimePickerOrderDate
            // 
            this.dateTimePickerOrderDate.Location = new System.Drawing.Point(242, 74);
            this.dateTimePickerOrderDate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dateTimePickerOrderDate.Name = "dateTimePickerOrderDate";
            this.dateTimePickerOrderDate.Size = new System.Drawing.Size(358, 31);
            this.dateTimePickerOrderDate.TabIndex = 20;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(986, 193);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(269, 29);
            this.textBoxSearch.TabIndex = 22;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonSearch.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonSearch.Location = new System.Drawing.Point(814, 166);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(164, 56);
            this.buttonSearch.TabIndex = 28;
            this.buttonSearch.Text = "SEARCH";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonCALCULATE
            // 
            this.buttonCALCULATE.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonCALCULATE.Font = new System.Drawing.Font("Lucida Bright", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCALCULATE.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonCALCULATE.Location = new System.Drawing.Point(13, 557);
            this.buttonCALCULATE.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonCALCULATE.Name = "buttonCALCULATE";
            this.buttonCALCULATE.Size = new System.Drawing.Size(243, 59);
            this.buttonCALCULATE.TabIndex = 27;
            this.buttonCALCULATE.Text = "CALCULATE";
            this.buttonCALCULATE.UseVisualStyleBackColor = false;
            this.buttonCALCULATE.Click += new System.EventHandler(this.buttonCALCULATE_Click);
            // 
            // labelproduct
            // 
            this.labelproduct.AutoSize = true;
            this.labelproduct.BackColor = System.Drawing.Color.Transparent;
            this.labelproduct.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelproduct.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelproduct.Location = new System.Drawing.Point(7, 121);
            this.labelproduct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelproduct.Name = "labelproduct";
            this.labelproduct.Size = new System.Drawing.Size(214, 31);
            this.labelproduct.TabIndex = 30;
            this.labelproduct.Text = "Product Name";
            // 
            // dataGridViewPurchaseOrder
            // 
            this.dataGridViewPurchaseOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPurchaseOrder.Location = new System.Drawing.Point(634, 229);
            this.dataGridViewPurchaseOrder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridViewPurchaseOrder.Name = "dataGridViewPurchaseOrder";
            this.dataGridViewPurchaseOrder.RowHeadersWidth = 62;
            this.dataGridViewPurchaseOrder.RowTemplate.Height = 28;
            this.dataGridViewPurchaseOrder.Size = new System.Drawing.Size(626, 375);
            this.dataGridViewPurchaseOrder.TabIndex = 31;
            // 
            // labelDiscount
            // 
            this.labelDiscount.AutoSize = true;
            this.labelDiscount.BackColor = System.Drawing.Color.Transparent;
            this.labelDiscount.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiscount.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelDiscount.Location = new System.Drawing.Point(5, 229);
            this.labelDiscount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDiscount.Name = "labelDiscount";
            this.labelDiscount.Size = new System.Drawing.Size(137, 31);
            this.labelDiscount.TabIndex = 34;
            this.labelDiscount.Text = "Discount";
            // 
            // textBoxDiscount
            // 
            this.textBoxDiscount.Location = new System.Drawing.Point(242, 229);
            this.textBoxDiscount.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxDiscount.Name = "textBoxDiscount";
            this.textBoxDiscount.Size = new System.Drawing.Size(358, 31);
            this.textBoxDiscount.TabIndex = 35;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkGray;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cLEARToolStripMenuItem,
            this.eXITToolStripMenuItem,
            this.lOADTABLEToolStripMenuItem,
            this.rECEIPTToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(13, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1305, 42);
            this.menuStrip1.TabIndex = 38;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cLEARToolStripMenuItem
            // 
            this.cLEARToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.cLEARToolStripMenuItem.Image = global::Chocolate_Factory_Management_System.Properties.Resources.clear;
            this.cLEARToolStripMenuItem.Name = "cLEARToolStripMenuItem";
            this.cLEARToolStripMenuItem.Size = new System.Drawing.Size(128, 36);
            this.cLEARToolStripMenuItem.Text = "CLEAR";
            this.cLEARToolStripMenuItem.Click += new System.EventHandler(this.cLEARToolStripMenuItem_Click);
            // 
            // eXITToolStripMenuItem
            // 
            this.eXITToolStripMenuItem.BackColor = System.Drawing.Color.DarkGray;
            this.eXITToolStripMenuItem.Image = global::Chocolate_Factory_Management_System.Properties.Resources.exit1;
            this.eXITToolStripMenuItem.Name = "eXITToolStripMenuItem";
            this.eXITToolStripMenuItem.Size = new System.Drawing.Size(106, 36);
            this.eXITToolStripMenuItem.Text = "EXIT";
            this.eXITToolStripMenuItem.Click += new System.EventHandler(this.eXITToolStripMenuItem_Click);
            // 
            // lOADTABLEToolStripMenuItem
            // 
            this.lOADTABLEToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.lOADTABLEToolStripMenuItem.Image = global::Chocolate_Factory_Management_System.Properties.Resources.load2;
            this.lOADTABLEToolStripMenuItem.Name = "lOADTABLEToolStripMenuItem";
            this.lOADTABLEToolStripMenuItem.Size = new System.Drawing.Size(195, 36);
            this.lOADTABLEToolStripMenuItem.Text = "LOAD TABLE";
            this.lOADTABLEToolStripMenuItem.Click += new System.EventHandler(this.lOADTABLEToolStripMenuItem_Click);
            // 
            // rECEIPTToolStripMenuItem
            // 
            this.rECEIPTToolStripMenuItem.Image = global::Chocolate_Factory_Management_System.Properties.Resources.receipt;
            this.rECEIPTToolStripMenuItem.Name = "rECEIPTToolStripMenuItem";
            this.rECEIPTToolStripMenuItem.Size = new System.Drawing.Size(149, 36);
            this.rECEIPTToolStripMenuItem.Text = "RECEIPT";
            // 
            // textBoxPaid
            // 
            this.textBoxPaid.Location = new System.Drawing.Point(242, 400);
            this.textBoxPaid.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxPaid.Name = "textBoxPaid";
            this.textBoxPaid.Size = new System.Drawing.Size(358, 31);
            this.textBoxPaid.TabIndex = 39;
            // 
            // labelPaid
            // 
            this.labelPaid.AutoSize = true;
            this.labelPaid.BackColor = System.Drawing.Color.Transparent;
            this.labelPaid.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPaid.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelPaid.Location = new System.Drawing.Point(7, 396);
            this.labelPaid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPaid.Name = "labelPaid";
            this.labelPaid.Size = new System.Drawing.Size(74, 31);
            this.labelPaid.TabIndex = 40;
            this.labelPaid.Text = "Paid";
            this.labelPaid.Click += new System.EventHandler(this.labelPaid_Click);
            // 
            // dateTimePickerDueDate
            // 
            this.dateTimePickerDueDate.Location = new System.Drawing.Point(242, 508);
            this.dateTimePickerDueDate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dateTimePickerDueDate.Name = "dateTimePickerDueDate";
            this.dateTimePickerDueDate.Size = new System.Drawing.Size(358, 31);
            this.dateTimePickerDueDate.TabIndex = 41;
            // 
            // labelDueDate
            // 
            this.labelDueDate.AutoSize = true;
            this.labelDueDate.BackColor = System.Drawing.Color.Transparent;
            this.labelDueDate.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDueDate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelDueDate.Location = new System.Drawing.Point(5, 508);
            this.labelDueDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDueDate.Name = "labelDueDate";
            this.labelDueDate.Size = new System.Drawing.Size(144, 31);
            this.labelDueDate.TabIndex = 42;
            this.labelDueDate.Text = "Due Date";
            // 
            // labelBalance
            // 
            this.labelBalance.AutoSize = true;
            this.labelBalance.BackColor = System.Drawing.Color.Transparent;
            this.labelBalance.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBalance.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelBalance.Location = new System.Drawing.Point(5, 452);
            this.labelBalance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBalance.Name = "labelBalance";
            this.labelBalance.Size = new System.Drawing.Size(120, 31);
            this.labelBalance.TabIndex = 43;
            this.labelBalance.Text = "Balance";
            // 
            // textBoxBalance
            // 
            this.textBoxBalance.Location = new System.Drawing.Point(242, 452);
            this.textBoxBalance.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxBalance.Name = "textBoxBalance";
            this.textBoxBalance.Size = new System.Drawing.Size(358, 31);
            this.textBoxBalance.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(986, 167);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 23);
            this.label1.TabIndex = 45;
            this.label1.Text = "Enter Purchase Order No";
            // 
            // labelPO
            // 
            this.labelPO.AutoSize = true;
            this.labelPO.BackColor = System.Drawing.Color.Transparent;
            this.labelPO.Font = new System.Drawing.Font("Lucida Bright", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPO.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelPO.Location = new System.Drawing.Point(625, 42);
            this.labelPO.Name = "labelPO";
            this.labelPO.Size = new System.Drawing.Size(480, 54);
            this.labelPO.TabIndex = 46;
            this.labelPO.Text = "PURCHASE ORDER";
            // 
            // buttonDELETE
            // 
            this.buttonDELETE.Location = new System.Drawing.Point(525, 557);
            this.buttonDELETE.Name = "buttonDELETE";
            this.buttonDELETE.Size = new System.Drawing.Size(102, 47);
            this.buttonDELETE.TabIndex = 47;
            this.buttonDELETE.Text = "DELETE";
            this.buttonDELETE.UseVisualStyleBackColor = true;
            this.buttonDELETE.Click += new System.EventHandler(this.buttonDELETE_Click);
            // 
            // buttonEDIT
            // 
            this.buttonEDIT.Location = new System.Drawing.Point(411, 557);
            this.buttonEDIT.Name = "buttonEDIT";
            this.buttonEDIT.Size = new System.Drawing.Size(105, 47);
            this.buttonEDIT.TabIndex = 48;
            this.buttonEDIT.Text = "EDIT";
            this.buttonEDIT.UseVisualStyleBackColor = true;
            this.buttonEDIT.Click += new System.EventHandler(this.buttonEDIT_Click_1);
            // 
            // buttonADD
            // 
            this.buttonADD.Location = new System.Drawing.Point(278, 557);
            this.buttonADD.Name = "buttonADD";
            this.buttonADD.Size = new System.Drawing.Size(114, 47);
            this.buttonADD.TabIndex = 49;
            this.buttonADD.Text = "ADD";
            this.buttonADD.UseVisualStyleBackColor = true;
            this.buttonADD.Click += new System.EventHandler(this.buttonADD_Click);
            // 
            // PurchaseOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Chocolate_Factory_Management_System.Properties.Resources.grey1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1305, 628);
            this.Controls.Add(this.buttonADD);
            this.Controls.Add(this.buttonEDIT);
            this.Controls.Add(this.buttonDELETE);
            this.Controls.Add(this.labelPO);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxBalance);
            this.Controls.Add(this.labelBalance);
            this.Controls.Add(this.labelDueDate);
            this.Controls.Add(this.dateTimePickerDueDate);
            this.Controls.Add(this.labelPaid);
            this.Controls.Add(this.textBoxPaid);
            this.Controls.Add(this.textBoxDiscount);
            this.Controls.Add(this.labelDiscount);
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
            this.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "PurchaseOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Label labelDiscount;
        private System.Windows.Forms.TextBox textBoxDiscount;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cLEARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXITToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxPaid;
        private System.Windows.Forms.Label labelPaid;
        private System.Windows.Forms.DateTimePicker dateTimePickerDueDate;
        private System.Windows.Forms.Label labelDueDate;
        private System.Windows.Forms.Label labelBalance;
        private System.Windows.Forms.TextBox textBoxBalance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPO;
        private System.Windows.Forms.ToolStripMenuItem lOADTABLEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rECEIPTToolStripMenuItem;
        private System.Windows.Forms.Button buttonDELETE;
        private System.Windows.Forms.Button buttonEDIT;
        private System.Windows.Forms.Button buttonADD;
    }
}