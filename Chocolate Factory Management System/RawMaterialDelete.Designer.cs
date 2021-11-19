
namespace Chocolate_Factory_Management_System
{
    partial class RawMaterialDelete
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
            this.buttonDelete = new System.Windows.Forms.Button();
            this.textBoxDicsount = new System.Windows.Forms.TextBox();
            this.labelDiscount = new System.Windows.Forms.Label();
            this.labelRawMaterialID = new System.Windows.Forms.Label();
            this.comboBoxRawMaterial = new System.Windows.Forms.ComboBox();
            this.labelRawMaterailDetails = new System.Windows.Forms.Label();
            this.labelReview = new System.Windows.Forms.Label();
            this.labelRawMaterialName = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.textBoxRawMaterialName = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.eXITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(551, 551);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(217, 53);
            this.buttonDelete.TabIndex = 0;
            this.buttonDelete.Text = "DELETE";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // textBoxDicsount
            // 
            this.textBoxDicsount.Location = new System.Drawing.Point(631, 382);
            this.textBoxDicsount.Name = "textBoxDicsount";
            this.textBoxDicsount.Size = new System.Drawing.Size(295, 26);
            this.textBoxDicsount.TabIndex = 47;
            // 
            // labelDiscount
            // 
            this.labelDiscount.AutoSize = true;
            this.labelDiscount.Location = new System.Drawing.Point(342, 393);
            this.labelDiscount.Name = "labelDiscount";
            this.labelDiscount.Size = new System.Drawing.Size(72, 20);
            this.labelDiscount.TabIndex = 46;
            this.labelDiscount.Text = "Discount";
            // 
            // labelRawMaterialID
            // 
            this.labelRawMaterialID.AutoSize = true;
            this.labelRawMaterialID.BackColor = System.Drawing.Color.Transparent;
            this.labelRawMaterialID.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelRawMaterialID.Location = new System.Drawing.Point(348, 134);
            this.labelRawMaterialID.Name = "labelRawMaterialID";
            this.labelRawMaterialID.Size = new System.Drawing.Size(165, 20);
            this.labelRawMaterialID.TabIndex = 45;
            this.labelRawMaterialID.Text = "Enter Raw Material ID";
            // 
            // comboBoxRawMaterial
            // 
            this.comboBoxRawMaterial.FormattingEnabled = true;
            this.comboBoxRawMaterial.Items.AddRange(new object[] {
            "*****",
            "****",
            "***",
            "**",
            "*"});
            this.comboBoxRawMaterial.Location = new System.Drawing.Point(631, 416);
            this.comboBoxRawMaterial.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxRawMaterial.Name = "comboBoxRawMaterial";
            this.comboBoxRawMaterial.Size = new System.Drawing.Size(295, 28);
            this.comboBoxRawMaterial.TabIndex = 44;
            // 
            // labelRawMaterailDetails
            // 
            this.labelRawMaterailDetails.AutoSize = true;
            this.labelRawMaterailDetails.BackColor = System.Drawing.Color.Transparent;
            this.labelRawMaterailDetails.Font = new System.Drawing.Font("Lucida Bright", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRawMaterailDetails.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelRawMaterailDetails.Location = new System.Drawing.Point(341, 28);
            this.labelRawMaterailDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRawMaterailDetails.Name = "labelRawMaterailDetails";
            this.labelRawMaterailDetails.Size = new System.Drawing.Size(650, 54);
            this.labelRawMaterailDetails.TabIndex = 43;
            this.labelRawMaterailDetails.Text = "RAW MATERIAL DETAILS";
            // 
            // labelReview
            // 
            this.labelReview.AutoSize = true;
            this.labelReview.BackColor = System.Drawing.Color.Transparent;
            this.labelReview.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReview.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelReview.Location = new System.Drawing.Point(340, 416);
            this.labelReview.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelReview.Name = "labelReview";
            this.labelReview.Size = new System.Drawing.Size(117, 31);
            this.labelReview.TabIndex = 42;
            this.labelReview.Text = "Review";
            // 
            // labelRawMaterialName
            // 
            this.labelRawMaterialName.AutoSize = true;
            this.labelRawMaterialName.BackColor = System.Drawing.Color.Transparent;
            this.labelRawMaterialName.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRawMaterialName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelRawMaterialName.Location = new System.Drawing.Point(340, 200);
            this.labelRawMaterialName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRawMaterialName.Name = "labelRawMaterialName";
            this.labelRawMaterialName.Size = new System.Drawing.Size(286, 31);
            this.labelRawMaterialName.TabIndex = 41;
            this.labelRawMaterialName.Text = "Raw Material Name";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.BackColor = System.Drawing.Color.Transparent;
            this.labelDescription.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelDescription.Location = new System.Drawing.Point(340, 269);
            this.labelDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(173, 31);
            this.labelDescription.TabIndex = 40;
            this.labelDescription.Text = "Description";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.BackColor = System.Drawing.Color.Transparent;
            this.labelPrice.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelPrice.Location = new System.Drawing.Point(340, 344);
            this.labelPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(84, 31);
            this.labelPrice.TabIndex = 39;
            this.labelPrice.Text = "Price";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(631, 134);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(237, 26);
            this.textBoxSearch.TabIndex = 38;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // textBoxRawMaterialName
            // 
            this.textBoxRawMaterialName.Location = new System.Drawing.Point(631, 200);
            this.textBoxRawMaterialName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxRawMaterialName.Name = "textBoxRawMaterialName";
            this.textBoxRawMaterialName.Size = new System.Drawing.Size(295, 26);
            this.textBoxRawMaterialName.TabIndex = 37;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(631, 269);
            this.textBoxDescription.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(295, 26);
            this.textBoxDescription.TabIndex = 36;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(631, 344);
            this.textBoxPrice.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(295, 26);
            this.textBoxPrice.TabIndex = 35;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eXITToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1278, 33);
            this.menuStrip1.TabIndex = 48;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // eXITToolStripMenuItem
            // 
            this.eXITToolStripMenuItem.Name = "eXITToolStripMenuItem";
            this.eXITToolStripMenuItem.Size = new System.Drawing.Size(62, 29);
            this.eXITToolStripMenuItem.Text = "EXIT";
            this.eXITToolStripMenuItem.Click += new System.EventHandler(this.eXITToolStripMenuItem_Click);
            // 
            // RawMaterialDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 649);
            this.Controls.Add(this.textBoxDicsount);
            this.Controls.Add(this.labelDiscount);
            this.Controls.Add(this.labelRawMaterialID);
            this.Controls.Add(this.comboBoxRawMaterial);
            this.Controls.Add(this.labelRawMaterailDetails);
            this.Controls.Add(this.labelReview);
            this.Controls.Add(this.labelRawMaterialName);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.textBoxRawMaterialName);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "RawMaterialDelete";
            this.Text = "RawMaterialDelete";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox textBoxDicsount;
        private System.Windows.Forms.Label labelDiscount;
        private System.Windows.Forms.Label labelRawMaterialID;
        private System.Windows.Forms.ComboBox comboBoxRawMaterial;
        private System.Windows.Forms.Label labelRawMaterailDetails;
        private System.Windows.Forms.Label labelReview;
        private System.Windows.Forms.Label labelRawMaterialName;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.TextBox textBoxRawMaterialName;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem eXITToolStripMenuItem;
    }
}