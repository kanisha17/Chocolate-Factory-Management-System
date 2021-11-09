
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cLEARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lOADTABLEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelRawMaterialName = new System.Windows.Forms.Label();
            this.labelGodown = new System.Windows.Forms.Label();
            this.labelAvailableStock = new System.Windows.Forms.Label();
            this.textBoxRawMaterialName = new System.Windows.Forms.TextBox();
            this.textBoxToGodown = new System.Windows.Forms.TextBox();
            this.textBoxAvailableStock = new System.Windows.Forms.TextBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonAddToCart = new System.Windows.Forms.Button();
            this.labelRawMaterialID = new System.Windows.Forms.Label();
            this.button = new System.Windows.Forms.Button();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.textBoxToCart = new System.Windows.Forms.TextBox();
            this.labelToCart = new System.Windows.Forms.Label();
            this.labelRawMaterial = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(646, 242);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(609, 351);
            this.dataGridView1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cLEARToolStripMenuItem,
            this.eXITToolStripMenuItem,
            this.lOADTABLEToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(13, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1288, 42);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStripRawMaterial";
            // 
            // cLEARToolStripMenuItem
            // 
            this.cLEARToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cLEARToolStripMenuItem.Image = global::Chocolate_Factory_Management_System.Properties.Resources.clear;
            this.cLEARToolStripMenuItem.Name = "cLEARToolStripMenuItem";
            this.cLEARToolStripMenuItem.Size = new System.Drawing.Size(128, 36);
            this.cLEARToolStripMenuItem.Text = "CLEAR";
            // 
            // eXITToolStripMenuItem
            // 
            this.eXITToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.eXITToolStripMenuItem.Image = global::Chocolate_Factory_Management_System.Properties.Resources.exit1;
            this.eXITToolStripMenuItem.Name = "eXITToolStripMenuItem";
            this.eXITToolStripMenuItem.Size = new System.Drawing.Size(106, 36);
            this.eXITToolStripMenuItem.Text = "EXIT";
            // 
            // lOADTABLEToolStripMenuItem
            // 
            this.lOADTABLEToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lOADTABLEToolStripMenuItem.Image = global::Chocolate_Factory_Management_System.Properties.Resources.load2;
            this.lOADTABLEToolStripMenuItem.Name = "lOADTABLEToolStripMenuItem";
            this.lOADTABLEToolStripMenuItem.Size = new System.Drawing.Size(195, 36);
            this.lOADTABLEToolStripMenuItem.Text = "LOAD TABLE";
            this.lOADTABLEToolStripMenuItem.Click += new System.EventHandler(this.lOADTABLEToolStripMenuItem_Click);
            // 
            // labelRawMaterialName
            // 
            this.labelRawMaterialName.AutoSize = true;
            this.labelRawMaterialName.BackColor = System.Drawing.Color.Transparent;
            this.labelRawMaterialName.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRawMaterialName.ForeColor = System.Drawing.Color.Maroon;
            this.labelRawMaterialName.Location = new System.Drawing.Point(22, 274);
            this.labelRawMaterialName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRawMaterialName.Name = "labelRawMaterialName";
            this.labelRawMaterialName.Size = new System.Drawing.Size(286, 31);
            this.labelRawMaterialName.TabIndex = 2;
            this.labelRawMaterialName.Text = "Raw Material Name";
            // 
            // labelGodown
            // 
            this.labelGodown.AutoSize = true;
            this.labelGodown.BackColor = System.Drawing.Color.Transparent;
            this.labelGodown.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGodown.ForeColor = System.Drawing.Color.Maroon;
            this.labelGodown.Location = new System.Drawing.Point(779, 161);
            this.labelGodown.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGodown.Name = "labelGodown";
            this.labelGodown.Size = new System.Drawing.Size(232, 27);
            this.labelGodown.TabIndex = 3;
            this.labelGodown.Text = "Added to Godown";
            // 
            // labelAvailableStock
            // 
            this.labelAvailableStock.AutoSize = true;
            this.labelAvailableStock.BackColor = System.Drawing.Color.Transparent;
            this.labelAvailableStock.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAvailableStock.ForeColor = System.Drawing.Color.Maroon;
            this.labelAvailableStock.Location = new System.Drawing.Point(22, 340);
            this.labelAvailableStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAvailableStock.Name = "labelAvailableStock";
            this.labelAvailableStock.Size = new System.Drawing.Size(229, 31);
            this.labelAvailableStock.TabIndex = 4;
            this.labelAvailableStock.Text = "Available Stock";
            // 
            // textBoxRawMaterialName
            // 
            this.textBoxRawMaterialName.Location = new System.Drawing.Point(326, 274);
            this.textBoxRawMaterialName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxRawMaterialName.Name = "textBoxRawMaterialName";
            this.textBoxRawMaterialName.Size = new System.Drawing.Size(286, 31);
            this.textBoxRawMaterialName.TabIndex = 5;
            // 
            // textBoxToGodown
            // 
            this.textBoxToGodown.Location = new System.Drawing.Point(1035, 161);
            this.textBoxToGodown.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxToGodown.Name = "textBoxToGodown";
            this.textBoxToGodown.Size = new System.Drawing.Size(220, 31);
            this.textBoxToGodown.TabIndex = 6;
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
            this.textBoxSearch.Location = new System.Drawing.Point(218, 187);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(286, 31);
            this.textBoxSearch.TabIndex = 8;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSearch.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.ForeColor = System.Drawing.Color.Maroon;
            this.buttonSearch.Location = new System.Drawing.Point(18, 161);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(176, 57);
            this.buttonSearch.TabIndex = 9;
            this.buttonSearch.Text = "SEARCH";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonAddToCart
            // 
            this.buttonAddToCart.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAddToCart.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddToCart.ForeColor = System.Drawing.Color.Maroon;
            this.buttonAddToCart.Location = new System.Drawing.Point(354, 513);
            this.buttonAddToCart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonAddToCart.Name = "buttonAddToCart";
            this.buttonAddToCart.Size = new System.Drawing.Size(258, 54);
            this.buttonAddToCart.TabIndex = 10;
            this.buttonAddToCart.Text = "ADD TO CART";
            this.buttonAddToCart.UseVisualStyleBackColor = false;
            // 
            // labelRawMaterialID
            // 
            this.labelRawMaterialID.AutoSize = true;
            this.labelRawMaterialID.BackColor = System.Drawing.Color.Transparent;
            this.labelRawMaterialID.ForeColor = System.Drawing.Color.Maroon;
            this.labelRawMaterialID.Location = new System.Drawing.Point(230, 161);
            this.labelRawMaterialID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRawMaterialID.Name = "labelRawMaterialID";
            this.labelRawMaterialID.Size = new System.Drawing.Size(227, 23);
            this.labelRawMaterialID.TabIndex = 12;
            this.labelRawMaterialID.Text = "Enter Raw Material ID";
            // 
            // button
            // 
            this.button.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button.ForeColor = System.Drawing.Color.Maroon;
            this.button.Location = new System.Drawing.Point(28, 513);
            this.button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(297, 54);
            this.button.TabIndex = 13;
            this.button.Text = "ADD TO GODOWN";
            this.button.UseVisualStyleBackColor = false;
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.BackColor = System.Drawing.Color.Transparent;
            this.labelQuantity.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantity.ForeColor = System.Drawing.Color.Maroon;
            this.labelQuantity.Location = new System.Drawing.Point(22, 406);
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
            // 
            // textBoxToCart
            // 
            this.textBoxToCart.Location = new System.Drawing.Point(1035, 201);
            this.textBoxToCart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxToCart.Name = "textBoxToCart";
            this.textBoxToCart.Size = new System.Drawing.Size(220, 31);
            this.textBoxToCart.TabIndex = 16;
            // 
            // labelToCart
            // 
            this.labelToCart.AutoSize = true;
            this.labelToCart.BackColor = System.Drawing.Color.Transparent;
            this.labelToCart.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelToCart.ForeColor = System.Drawing.Color.Maroon;
            this.labelToCart.Location = new System.Drawing.Point(783, 205);
            this.labelToCart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelToCart.Name = "labelToCart";
            this.labelToCart.Size = new System.Drawing.Size(182, 27);
            this.labelToCart.TabIndex = 17;
            this.labelToCart.Text = "Added to Cart";
            // 
            // labelRawMaterial
            // 
            this.labelRawMaterial.AutoSize = true;
            this.labelRawMaterial.BackColor = System.Drawing.Color.Transparent;
            this.labelRawMaterial.Font = new System.Drawing.Font("Lucida Bright", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRawMaterial.ForeColor = System.Drawing.Color.Maroon;
            this.labelRawMaterial.Location = new System.Drawing.Point(262, 58);
            this.labelRawMaterial.Name = "labelRawMaterial";
            this.labelRawMaterial.Size = new System.Drawing.Size(867, 50);
            this.labelRawMaterial.TabIndex = 18;
            this.labelRawMaterial.Text = "RAW MATERIAL SELECTION PROCESS";
            this.labelRawMaterial.Click += new System.EventHandler(this.label1_Click);
            // 
            // SelectRawMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Chocolate_Factory_Management_System.Properties.Resources.peacch;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1288, 605);
            this.Controls.Add(this.labelRawMaterial);
            this.Controls.Add(this.labelToCart);
            this.Controls.Add(this.textBoxToCart);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.button);
            this.Controls.Add(this.labelRawMaterialID);
            this.Controls.Add(this.buttonAddToCart);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.textBoxAvailableStock);
            this.Controls.Add(this.textBoxToGodown);
            this.Controls.Add(this.textBoxRawMaterialName);
            this.Controls.Add(this.labelAvailableStock);
            this.Controls.Add(this.labelGodown);
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
        private System.Windows.Forms.ToolStripMenuItem cLEARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXITToolStripMenuItem;
        private System.Windows.Forms.Label labelRawMaterialName;
        private System.Windows.Forms.Label labelGodown;
        private System.Windows.Forms.Label labelAvailableStock;
        private System.Windows.Forms.TextBox textBoxRawMaterialName;
        private System.Windows.Forms.TextBox textBoxToGodown;
        private System.Windows.Forms.TextBox textBoxAvailableStock;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonAddToCart;
        private System.Windows.Forms.ToolStripMenuItem lOADTABLEToolStripMenuItem;
        private System.Windows.Forms.Label labelRawMaterialID;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.TextBox textBoxToCart;
        private System.Windows.Forms.Label labelToCart;
        private System.Windows.Forms.Label labelRawMaterial;
    }
}