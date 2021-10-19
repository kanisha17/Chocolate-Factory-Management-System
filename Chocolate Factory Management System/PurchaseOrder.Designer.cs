
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
            this.labelProductName = new System.Windows.Forms.Label();
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
            this.buttonEXIT = new System.Windows.Forms.Button();
            this.buttonCLEAR = new System.Windows.Forms.Button();
            this.buttonADD = new System.Windows.Forms.Button();
            this.buttonCALCULATE = new System.Windows.Forms.Button();
            this.labelproduct = new System.Windows.Forms.Label();
            this.dataGridViewPurchaseOrder = new System.Windows.Forms.DataGridView();
            this.buttonLoadTable = new System.Windows.Forms.Button();
            this.labelGST = new System.Windows.Forms.Label();
            this.textBoxGST = new System.Windows.Forms.TextBox();
            this.buttonDELETE = new System.Windows.Forms.Button();
            this.buttonEDIT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPurchaseOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(856, 381);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(44, 20);
            this.labelTotal.TabIndex = 6;
            this.labelTotal.Text = "Total";
            // 
            // labelUnitPrice
            // 
            this.labelUnitPrice.AutoSize = true;
            this.labelUnitPrice.Location = new System.Drawing.Point(856, 297);
            this.labelUnitPrice.Name = "labelUnitPrice";
            this.labelUnitPrice.Size = new System.Drawing.Size(77, 20);
            this.labelUnitPrice.TabIndex = 7;
            this.labelUnitPrice.Text = "Unit Price";
            // 
            // labelQuantitykg
            // 
            this.labelQuantitykg.AutoSize = true;
            this.labelQuantitykg.Location = new System.Drawing.Point(856, 239);
            this.labelQuantitykg.Name = "labelQuantitykg";
            this.labelQuantitykg.Size = new System.Drawing.Size(68, 20);
            this.labelQuantitykg.TabIndex = 8;
            this.labelQuantitykg.Text = "Quantity";
            // 
            // labelProductName
            // 
            this.labelProductName.Location = new System.Drawing.Point(0, 0);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(100, 23);
            this.labelProductName.TabIndex = 29;
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
            this.comboBoxProductName.Location = new System.Drawing.Point(995, 177);
            this.comboBoxProductName.Name = "comboBoxProductName";
            this.comboBoxProductName.Size = new System.Drawing.Size(249, 28);
            this.comboBoxProductName.TabIndex = 11;
            // 
            // textBoxQuantitykg
            // 
            this.textBoxQuantitykg.Location = new System.Drawing.Point(995, 233);
            this.textBoxQuantitykg.Name = "textBoxQuantitykg";
            this.textBoxQuantitykg.Size = new System.Drawing.Size(249, 26);
            this.textBoxQuantitykg.TabIndex = 14;
            // 
            // textBoxUnitPrice
            // 
            this.textBoxUnitPrice.Location = new System.Drawing.Point(995, 291);
            this.textBoxUnitPrice.Name = "textBoxUnitPrice";
            this.textBoxUnitPrice.Size = new System.Drawing.Size(249, 26);
            this.textBoxUnitPrice.TabIndex = 15;
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Location = new System.Drawing.Point(995, 378);
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
            // buttonEXIT
            // 
            this.buttonEXIT.Location = new System.Drawing.Point(682, 434);
            this.buttonEXIT.Name = "buttonEXIT";
            this.buttonEXIT.Size = new System.Drawing.Size(104, 38);
            this.buttonEXIT.TabIndex = 24;
            this.buttonEXIT.Text = "EXIT";
            this.buttonEXIT.UseVisualStyleBackColor = true;
            this.buttonEXIT.Click += new System.EventHandler(this.buttonEXIT_Click);
            // 
            // buttonCLEAR
            // 
            this.buttonCLEAR.Location = new System.Drawing.Point(558, 434);
            this.buttonCLEAR.Name = "buttonCLEAR";
            this.buttonCLEAR.Size = new System.Drawing.Size(98, 38);
            this.buttonCLEAR.TabIndex = 25;
            this.buttonCLEAR.Text = "CLEAR";
            this.buttonCLEAR.UseVisualStyleBackColor = true;
            this.buttonCLEAR.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonADD
            // 
            this.buttonADD.Location = new System.Drawing.Point(155, 434);
            this.buttonADD.Name = "buttonADD";
            this.buttonADD.Size = new System.Drawing.Size(123, 38);
            this.buttonADD.TabIndex = 26;
            this.buttonADD.Text = "ADD";
            this.buttonADD.UseVisualStyleBackColor = true;
            this.buttonADD.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonCALCULATE
            // 
            this.buttonCALCULATE.Location = new System.Drawing.Point(995, 446);
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
            this.labelproduct.Location = new System.Drawing.Point(856, 185);
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
            this.buttonLoadTable.Location = new System.Drawing.Point(26, 434);
            this.buttonLoadTable.Name = "buttonLoadTable";
            this.buttonLoadTable.Size = new System.Drawing.Size(112, 38);
            this.buttonLoadTable.TabIndex = 32;
            this.buttonLoadTable.Text = "Load Table";
            this.buttonLoadTable.UseVisualStyleBackColor = true;
            this.buttonLoadTable.Click += new System.EventHandler(this.buttonLoadTable_Click);
            // 
            // labelGST
            // 
            this.labelGST.AutoSize = true;
            this.labelGST.Location = new System.Drawing.Point(856, 343);
            this.labelGST.Name = "labelGST";
            this.labelGST.Size = new System.Drawing.Size(42, 20);
            this.labelGST.TabIndex = 34;
            this.labelGST.Text = "GST";
            // 
            // textBoxGST
            // 
            this.textBoxGST.Location = new System.Drawing.Point(995, 337);
            this.textBoxGST.Name = "textBoxGST";
            this.textBoxGST.Size = new System.Drawing.Size(249, 26);
            this.textBoxGST.TabIndex = 35;
            // 
            // buttonDELETE
            // 
            this.buttonDELETE.Location = new System.Drawing.Point(424, 434);
            this.buttonDELETE.Name = "buttonDELETE";
            this.buttonDELETE.Size = new System.Drawing.Size(113, 38);
            this.buttonDELETE.TabIndex = 36;
            this.buttonDELETE.Text = "DELETE";
            this.buttonDELETE.UseVisualStyleBackColor = true;
            this.buttonDELETE.Click += new System.EventHandler(this.buttonDELETE_Click);
            // 
            // buttonEDIT
            // 
            this.buttonEDIT.Location = new System.Drawing.Point(300, 434);
            this.buttonEDIT.Name = "buttonEDIT";
            this.buttonEDIT.Size = new System.Drawing.Size(106, 38);
            this.buttonEDIT.TabIndex = 37;
            this.buttonEDIT.Text = "EDIT";
            this.buttonEDIT.UseVisualStyleBackColor = true;
            this.buttonEDIT.Click += new System.EventHandler(this.buttonEDIT_Click);
            // 
            // PurchaseOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1299, 578);
            this.Controls.Add(this.buttonEDIT);
            this.Controls.Add(this.buttonDELETE);
            this.Controls.Add(this.textBoxGST);
            this.Controls.Add(this.labelGST);
            this.Controls.Add(this.buttonLoadTable);
            this.Controls.Add(this.dataGridViewPurchaseOrder);
            this.Controls.Add(this.labelproduct);
            this.Controls.Add(this.buttonCALCULATE);
            this.Controls.Add(this.buttonADD);
            this.Controls.Add(this.buttonCLEAR);
            this.Controls.Add(this.buttonEXIT);
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
            this.Controls.Add(this.labelProductName);
            this.Controls.Add(this.labelQuantitykg);
            this.Controls.Add(this.labelUnitPrice);
            this.Controls.Add(this.labelTotal);
            this.Name = "PurchaseOrder";
            this.Text = "PurchaseOrder";
            this.Load += new System.EventHandler(this.PurchaseOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPurchaseOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelUnitPrice;
        private System.Windows.Forms.Label labelQuantitykg;
        private System.Windows.Forms.Label labelProductName;
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
        private System.Windows.Forms.Button buttonEXIT;
        private System.Windows.Forms.Button buttonCLEAR;
        private System.Windows.Forms.Button buttonADD;
        private System.Windows.Forms.Button buttonCALCULATE;
        private System.Windows.Forms.Label labelproduct;
        private System.Windows.Forms.DataGridView dataGridViewPurchaseOrder;
        private System.Windows.Forms.Button buttonLoadTable;
        private System.Windows.Forms.Label labelGST;
        private System.Windows.Forms.TextBox textBoxGST;
        private System.Windows.Forms.Button buttonDELETE;
        private System.Windows.Forms.Button buttonEDIT;
    }
}