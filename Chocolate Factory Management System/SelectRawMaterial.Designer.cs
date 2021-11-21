
namespace Chocolate_Factory_Management_System
{
    partial class SelectRawMaterial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectRawMaterial));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.eXITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pRINTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelRawMaterialName = new System.Windows.Forms.Label();
            this.labelAvailableStock = new System.Windows.Forms.Label();
            this.textBoxAvailableStock = new System.Windows.Forms.TextBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonAddToCart = new System.Windows.Forms.Button();
            this.labelRawMaterialID = new System.Windows.Forms.Label();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.labelRawMaterial = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.labelCartNo = new System.Windows.Forms.Label();
            this.textBoxCartNo = new System.Windows.Forms.TextBox();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(658, 189);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(609, 379);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.menuStrip1.Size = new System.Drawing.Size(1288, 42);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStripRawMaterial";
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
            // pRINTToolStripMenuItem
            // 
            this.pRINTToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pRINTToolStripMenuItem.Image = global::Chocolate_Factory_Management_System.Properties.Resources.a101;
            this.pRINTToolStripMenuItem.Name = "pRINTToolStripMenuItem";
            this.pRINTToolStripMenuItem.Size = new System.Drawing.Size(127, 36);
            this.pRINTToolStripMenuItem.Text = "PRINT";
            this.pRINTToolStripMenuItem.Click += new System.EventHandler(this.pRINTToolStripMenuItem_Click);
            // 
            // labelRawMaterialName
            // 
            this.labelRawMaterialName.AutoSize = true;
            this.labelRawMaterialName.BackColor = System.Drawing.Color.Transparent;
            this.labelRawMaterialName.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRawMaterialName.ForeColor = System.Drawing.Color.Maroon;
            this.labelRawMaterialName.Location = new System.Drawing.Point(11, 218);
            this.labelRawMaterialName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRawMaterialName.Name = "labelRawMaterialName";
            this.labelRawMaterialName.Size = new System.Drawing.Size(286, 31);
            this.labelRawMaterialName.TabIndex = 2;
            this.labelRawMaterialName.Text = "Select Raw Material";
            // 
            // labelAvailableStock
            // 
            this.labelAvailableStock.AutoSize = true;
            this.labelAvailableStock.BackColor = System.Drawing.Color.Transparent;
            this.labelAvailableStock.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAvailableStock.ForeColor = System.Drawing.Color.Maroon;
            this.labelAvailableStock.Location = new System.Drawing.Point(13, 344);
            this.labelAvailableStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAvailableStock.Name = "labelAvailableStock";
            this.labelAvailableStock.Size = new System.Drawing.Size(229, 31);
            this.labelAvailableStock.TabIndex = 4;
            this.labelAvailableStock.Text = "Available Stock";
            // 
            // textBoxAvailableStock
            // 
            this.textBoxAvailableStock.Location = new System.Drawing.Point(326, 344);
            this.textBoxAvailableStock.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxAvailableStock.Name = "textBoxAvailableStock";
            this.textBoxAvailableStock.Size = new System.Drawing.Size(286, 31);
            this.textBoxAvailableStock.TabIndex = 7;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(326, 280);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(286, 31);
            this.textBoxSearch.TabIndex = 8;
            // 
            // buttonAddToCart
            // 
            this.buttonAddToCart.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAddToCart.Font = new System.Drawing.Font("Lucida Bright", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddToCart.ForeColor = System.Drawing.Color.Maroon;
            this.buttonAddToCart.Location = new System.Drawing.Point(19, 514);
            this.buttonAddToCart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonAddToCart.Name = "buttonAddToCart";
            this.buttonAddToCart.Size = new System.Drawing.Size(299, 54);
            this.buttonAddToCart.TabIndex = 10;
            this.buttonAddToCart.Text = "ADD TO CART";
            this.buttonAddToCart.UseVisualStyleBackColor = false;
            this.buttonAddToCart.Click += new System.EventHandler(this.buttonAddToCart_Click);
            // 
            // labelRawMaterialID
            // 
            this.labelRawMaterialID.AutoSize = true;
            this.labelRawMaterialID.BackColor = System.Drawing.Color.Transparent;
            this.labelRawMaterialID.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRawMaterialID.ForeColor = System.Drawing.Color.Maroon;
            this.labelRawMaterialID.Location = new System.Drawing.Point(13, 280);
            this.labelRawMaterialID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRawMaterialID.Name = "labelRawMaterialID";
            this.labelRawMaterialID.Size = new System.Drawing.Size(238, 31);
            this.labelRawMaterialID.TabIndex = 12;
            this.labelRawMaterialID.Text = "Raw Material ID";
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.BackColor = System.Drawing.Color.Transparent;
            this.labelQuantity.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantity.ForeColor = System.Drawing.Color.Maroon;
            this.labelQuantity.Location = new System.Drawing.Point(13, 410);
            this.labelQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(135, 31);
            this.labelQuantity.TabIndex = 14;
            this.labelQuantity.Text = "Quantity";
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(326, 410);
            this.textBoxQuantity.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(286, 31);
            this.textBoxQuantity.TabIndex = 15;
            this.textBoxQuantity.TextChanged += new System.EventHandler(this.textBoxQuantity_TextChanged);
            this.textBoxQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxQuantity_KeyPress);
            // 
            // labelRawMaterial
            // 
            this.labelRawMaterial.AutoSize = true;
            this.labelRawMaterial.BackColor = System.Drawing.Color.Transparent;
            this.labelRawMaterial.Font = new System.Drawing.Font("Lucida Bright", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRawMaterial.ForeColor = System.Drawing.Color.Maroon;
            this.labelRawMaterial.Location = new System.Drawing.Point(252, 53);
            this.labelRawMaterial.Name = "labelRawMaterial";
            this.labelRawMaterial.Size = new System.Drawing.Size(867, 50);
            this.labelRawMaterial.TabIndex = 18;
            this.labelRawMaterial.Text = "RAW MATERIAL SELECTION PROCESS";
            this.labelRawMaterial.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(326, 218);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(286, 31);
            this.comboBox1.TabIndex = 19;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonClear.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.ForeColor = System.Drawing.Color.Maroon;
            this.buttonClear.Location = new System.Drawing.Point(1060, 143);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(198, 40);
            this.buttonClear.TabIndex = 20;
            this.buttonClear.Text = "Clear Table";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // labelCartNo
            // 
            this.labelCartNo.AutoSize = true;
            this.labelCartNo.BackColor = System.Drawing.Color.Transparent;
            this.labelCartNo.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCartNo.ForeColor = System.Drawing.Color.Maroon;
            this.labelCartNo.Location = new System.Drawing.Point(11, 152);
            this.labelCartNo.Name = "labelCartNo";
            this.labelCartNo.Size = new System.Drawing.Size(122, 31);
            this.labelCartNo.TabIndex = 22;
            this.labelCartNo.Text = "Cart No";
            // 
            // textBoxCartNo
            // 
            this.textBoxCartNo.Location = new System.Drawing.Point(326, 152);
            this.textBoxCartNo.Name = "textBoxCartNo";
            this.textBoxCartNo.Size = new System.Drawing.Size(286, 31);
            this.textBoxCartNo.TabIndex = 23;
            // 
            // buttonInsert
            // 
            this.buttonInsert.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonInsert.Font = new System.Drawing.Font("Lucida Bright", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInsert.ForeColor = System.Drawing.Color.Maroon;
            this.buttonInsert.Location = new System.Drawing.Point(419, 514);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(193, 54);
            this.buttonInsert.TabIndex = 24;
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
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // SelectRawMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Chocolate_Factory_Management_System.Properties.Resources.peacch;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1288, 605);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.textBoxCartNo);
            this.Controls.Add(this.labelCartNo);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelRawMaterial);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.labelRawMaterialID);
            this.Controls.Add(this.buttonAddToCart);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.textBoxAvailableStock);
            this.Controls.Add(this.labelAvailableStock);
            this.Controls.Add(this.labelRawMaterialName);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "SelectRawMaterial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelectRawMaterial";
            this.Load += new System.EventHandler(this.SelectRawMaterial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem eXITToolStripMenuItem;
        private System.Windows.Forms.Label labelRawMaterialName;
        private System.Windows.Forms.Label labelAvailableStock;
        private System.Windows.Forms.TextBox textBoxAvailableStock;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonAddToCart;
        private System.Windows.Forms.Label labelRawMaterialID;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.Label labelRawMaterial;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label labelCartNo;
        private System.Windows.Forms.TextBox textBoxCartNo;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.ToolStripMenuItem pRINTToolStripMenuItem;
    }
}