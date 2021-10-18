
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
            this.labelQuantitygm = new System.Windows.Forms.Label();
            this.labelProductName = new System.Windows.Forms.Label();
            this.comboBoxProductName = new System.Windows.Forms.ComboBox();
            this.textBoxQuantitygm = new System.Windows.Forms.TextBox();
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
            this.SuspendLayout();
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(856, 410);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(44, 20);
            this.labelTotal.TabIndex = 6;
            this.labelTotal.Text = "Total";
            // 
            // labelUnitPrice
            // 
            this.labelUnitPrice.AutoSize = true;
            this.labelUnitPrice.Location = new System.Drawing.Point(856, 353);
            this.labelUnitPrice.Name = "labelUnitPrice";
            this.labelUnitPrice.Size = new System.Drawing.Size(77, 20);
            this.labelUnitPrice.TabIndex = 7;
            this.labelUnitPrice.Text = "Unit Price";
            // 
            // labelQuantitykg
            // 
            this.labelQuantitykg.AutoSize = true;
            this.labelQuantitykg.Location = new System.Drawing.Point(856, 295);
            this.labelQuantitykg.Name = "labelQuantitykg";
            this.labelQuantitykg.Size = new System.Drawing.Size(99, 20);
            this.labelQuantitykg.TabIndex = 8;
            this.labelQuantitykg.Text = "Quantity (kg)";
            // 
            // labelQuantitygm
            // 
            this.labelQuantitygm.AutoSize = true;
            this.labelQuantitygm.Location = new System.Drawing.Point(856, 239);
            this.labelQuantitygm.Name = "labelQuantitygm";
            this.labelQuantitygm.Size = new System.Drawing.Size(104, 20);
            this.labelQuantitygm.TabIndex = 9;
            this.labelQuantitygm.Text = "Quantity (gm)";
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
            // textBoxQuantitygm
            // 
            this.textBoxQuantitygm.Location = new System.Drawing.Point(995, 233);
            this.textBoxQuantitygm.Name = "textBoxQuantitygm";
            this.textBoxQuantitygm.Size = new System.Drawing.Size(249, 26);
            this.textBoxQuantitygm.TabIndex = 13;
            // 
            // textBoxQuantitykg
            // 
            this.textBoxQuantitykg.Location = new System.Drawing.Point(995, 289);
            this.textBoxQuantitykg.Name = "textBoxQuantitykg";
            this.textBoxQuantitykg.Size = new System.Drawing.Size(249, 26);
            this.textBoxQuantitykg.TabIndex = 14;
            // 
            // textBoxUnitPrice
            // 
            this.textBoxUnitPrice.Location = new System.Drawing.Point(995, 347);
            this.textBoxUnitPrice.Name = "textBoxUnitPrice";
            this.textBoxUnitPrice.Size = new System.Drawing.Size(249, 26);
            this.textBoxUnitPrice.TabIndex = 15;
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Location = new System.Drawing.Point(995, 404);
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
            // 
            // buttonEXIT
            // 
            this.buttonEXIT.Location = new System.Drawing.Point(506, 434);
            this.buttonEXIT.Name = "buttonEXIT";
            this.buttonEXIT.Size = new System.Drawing.Size(104, 38);
            this.buttonEXIT.TabIndex = 24;
            this.buttonEXIT.Text = "EXIT";
            this.buttonEXIT.UseVisualStyleBackColor = true;
            this.buttonEXIT.Click += new System.EventHandler(this.buttonEXIT_Click);
            // 
            // buttonCLEAR
            // 
            this.buttonCLEAR.Location = new System.Drawing.Point(363, 434);
            this.buttonCLEAR.Name = "buttonCLEAR";
            this.buttonCLEAR.Size = new System.Drawing.Size(98, 38);
            this.buttonCLEAR.TabIndex = 25;
            this.buttonCLEAR.Text = "CLEAR";
            this.buttonCLEAR.UseVisualStyleBackColor = true;
            this.buttonCLEAR.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonADD
            // 
            this.buttonADD.Location = new System.Drawing.Point(185, 434);
            this.buttonADD.Name = "buttonADD";
            this.buttonADD.Size = new System.Drawing.Size(123, 38);
            this.buttonADD.TabIndex = 26;
            this.buttonADD.Text = "ADD";
            this.buttonADD.UseVisualStyleBackColor = true;
            this.buttonADD.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonCALCULATE
            // 
            this.buttonCALCULATE.Location = new System.Drawing.Point(633, 434);
            this.buttonCALCULATE.Name = "buttonCALCULATE";
            this.buttonCALCULATE.Size = new System.Drawing.Size(153, 38);
            this.buttonCALCULATE.TabIndex = 27;
            this.buttonCALCULATE.Text = "CALCULATE";
            this.buttonCALCULATE.UseVisualStyleBackColor = true;
            this.buttonCALCULATE.Click += new System.EventHandler(this.buttonCALCULATE_Click);
            // 
            // PurchaseOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1299, 578);
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
            this.Controls.Add(this.textBoxQuantitygm);
            this.Controls.Add(this.comboBoxProductName);
            this.Controls.Add(this.labelProductName);
            this.Controls.Add(this.labelQuantitygm);
            this.Controls.Add(this.labelQuantitykg);
            this.Controls.Add(this.labelUnitPrice);
            this.Controls.Add(this.labelTotal);
            this.Name = "PurchaseOrder";
            this.Text = "PurchaseOrder";
            this.Load += new System.EventHandler(this.PurchaseOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelUnitPrice;
        private System.Windows.Forms.Label labelQuantitykg;
        private System.Windows.Forms.Label labelQuantitygm;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.ComboBox comboBoxProductName;
        private System.Windows.Forms.TextBox textBoxQuantitygm;
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
    }
}