
namespace Chocolate_Factory_Management_System
{
    partial class RawMaterial
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.menuStripRawMaterial = new System.Windows.Forms.MenuStrip();
            this.eXITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxRawMaterialName = new System.Windows.Forms.TextBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelRawMaterialName = new System.Windows.Forms.Label();
            this.labelReview = new System.Windows.Forms.Label();
            this.labelRawMaterailDetails = new System.Windows.Forms.Label();
            this.comboBoxRawMaterial = new System.Windows.Forms.ComboBox();
            this.labelRawMaterialID = new System.Windows.Forms.Label();
            this.labelDiscount = new System.Windows.Forms.Label();
            this.textBoxDicsount = new System.Windows.Forms.TextBox();
            this.menuStripRawMaterial.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.GreenYellow;
            this.buttonAdd.Font = new System.Drawing.Font("Lucida Bright", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(641, 500);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(348, 68);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "SUBMIT";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // menuStripRawMaterial
            // 
            this.menuStripRawMaterial.BackColor = System.Drawing.Color.GreenYellow;
            this.menuStripRawMaterial.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStripRawMaterial.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStripRawMaterial.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStripRawMaterial.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eXITToolStripMenuItem});
            this.menuStripRawMaterial.Location = new System.Drawing.Point(0, 0);
            this.menuStripRawMaterial.Name = "menuStripRawMaterial";
            this.menuStripRawMaterial.Padding = new System.Windows.Forms.Padding(13, 4, 0, 4);
            this.menuStripRawMaterial.Size = new System.Drawing.Size(1295, 44);
            this.menuStripRawMaterial.TabIndex = 4;
            this.menuStripRawMaterial.Text = "menuStripRawMaterial";
            // 
            // eXITToolStripMenuItem
            // 
            this.eXITToolStripMenuItem.BackColor = System.Drawing.Color.LightGreen;
            this.eXITToolStripMenuItem.Image = global::Chocolate_Factory_Management_System.Properties.Resources.exit1;
            this.eXITToolStripMenuItem.Name = "eXITToolStripMenuItem";
            this.eXITToolStripMenuItem.Size = new System.Drawing.Size(106, 36);
            this.eXITToolStripMenuItem.Text = "EXIT";
            this.eXITToolStripMenuItem.Click += new System.EventHandler(this.eXITToolStripMenuItem_Click);
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(641, 330);
            this.textBoxPrice.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(348, 31);
            this.textBoxPrice.TabIndex = 5;
            this.textBoxPrice.TextChanged += new System.EventHandler(this.textBoxPrice_TextChanged);
            this.textBoxPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPrice_KeyPress);
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(641, 269);
            this.textBoxDescription.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(348, 31);
            this.textBoxDescription.TabIndex = 6;
            this.textBoxDescription.TextChanged += new System.EventHandler(this.textBoxDescription_TextChanged);
            // 
            // textBoxRawMaterialName
            // 
            this.textBoxRawMaterialName.Location = new System.Drawing.Point(641, 210);
            this.textBoxRawMaterialName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxRawMaterialName.Name = "textBoxRawMaterialName";
            this.textBoxRawMaterialName.Size = new System.Drawing.Size(348, 31);
            this.textBoxRawMaterialName.TabIndex = 7;
            this.textBoxRawMaterialName.TextChanged += new System.EventHandler(this.textBoxRawMaterialName_TextChanged);
            this.textBoxRawMaterialName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxRawMaterialName_KeyPress);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(641, 141);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(348, 31);
            this.textBoxSearch.TabIndex = 8;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            this.textBoxSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSearch_KeyPress);
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.BackColor = System.Drawing.Color.Transparent;
            this.labelPrice.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelPrice.Location = new System.Drawing.Point(323, 330);
            this.labelPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(84, 31);
            this.labelPrice.TabIndex = 9;
            this.labelPrice.Text = "Price";
            this.labelPrice.Click += new System.EventHandler(this.labelPrice_Click);
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.BackColor = System.Drawing.Color.Transparent;
            this.labelDescription.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelDescription.Location = new System.Drawing.Point(323, 269);
            this.labelDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(173, 31);
            this.labelDescription.TabIndex = 10;
            this.labelDescription.Text = "Description";
            this.labelDescription.Click += new System.EventHandler(this.labelDescription_Click);
            // 
            // labelRawMaterialName
            // 
            this.labelRawMaterialName.AutoSize = true;
            this.labelRawMaterialName.BackColor = System.Drawing.Color.Transparent;
            this.labelRawMaterialName.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRawMaterialName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelRawMaterialName.Location = new System.Drawing.Point(323, 210);
            this.labelRawMaterialName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRawMaterialName.Name = "labelRawMaterialName";
            this.labelRawMaterialName.Size = new System.Drawing.Size(286, 31);
            this.labelRawMaterialName.TabIndex = 11;
            this.labelRawMaterialName.Text = "Raw Material Name";
            this.labelRawMaterialName.Click += new System.EventHandler(this.labelRawMaterialName_Click);
            // 
            // labelReview
            // 
            this.labelReview.AutoSize = true;
            this.labelReview.BackColor = System.Drawing.Color.Transparent;
            this.labelReview.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReview.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelReview.Location = new System.Drawing.Point(323, 439);
            this.labelReview.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelReview.Name = "labelReview";
            this.labelReview.Size = new System.Drawing.Size(117, 31);
            this.labelReview.TabIndex = 12;
            this.labelReview.Text = "Review";
            this.labelReview.Click += new System.EventHandler(this.labelReview_Click);
            // 
            // labelRawMaterailDetails
            // 
            this.labelRawMaterailDetails.AutoSize = true;
            this.labelRawMaterailDetails.BackColor = System.Drawing.Color.Transparent;
            this.labelRawMaterailDetails.Font = new System.Drawing.Font("Lucida Bright", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRawMaterailDetails.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelRawMaterailDetails.Location = new System.Drawing.Point(339, 56);
            this.labelRawMaterailDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRawMaterailDetails.Name = "labelRawMaterailDetails";
            this.labelRawMaterailDetails.Size = new System.Drawing.Size(650, 54);
            this.labelRawMaterailDetails.TabIndex = 15;
            this.labelRawMaterailDetails.Text = "RAW MATERIAL DETAILS";
            this.labelRawMaterailDetails.Click += new System.EventHandler(this.labelRawMaterailDetails_Click);
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
            this.comboBoxRawMaterial.Location = new System.Drawing.Point(641, 439);
            this.comboBoxRawMaterial.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxRawMaterial.Name = "comboBoxRawMaterial";
            this.comboBoxRawMaterial.Size = new System.Drawing.Size(348, 31);
            this.comboBoxRawMaterial.TabIndex = 16;
            this.comboBoxRawMaterial.SelectedIndexChanged += new System.EventHandler(this.comboBoxRawMaterial_SelectedIndexChanged);
            // 
            // labelRawMaterialID
            // 
            this.labelRawMaterialID.AutoSize = true;
            this.labelRawMaterialID.BackColor = System.Drawing.Color.Transparent;
            this.labelRawMaterialID.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRawMaterialID.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelRawMaterialID.Location = new System.Drawing.Point(323, 141);
            this.labelRawMaterialID.Name = "labelRawMaterialID";
            this.labelRawMaterialID.Size = new System.Drawing.Size(238, 31);
            this.labelRawMaterialID.TabIndex = 17;
            this.labelRawMaterialID.Text = "Raw Material ID";
            this.labelRawMaterialID.Click += new System.EventHandler(this.labelRawMaterialID_Click);
            // 
            // labelDiscount
            // 
            this.labelDiscount.AutoSize = true;
            this.labelDiscount.BackColor = System.Drawing.Color.Transparent;
            this.labelDiscount.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiscount.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelDiscount.Location = new System.Drawing.Point(325, 388);
            this.labelDiscount.Name = "labelDiscount";
            this.labelDiscount.Size = new System.Drawing.Size(137, 31);
            this.labelDiscount.TabIndex = 18;
            this.labelDiscount.Text = "Discount";
            this.labelDiscount.Click += new System.EventHandler(this.labelDiscount_Click);
            // 
            // textBoxDicsount
            // 
            this.textBoxDicsount.Location = new System.Drawing.Point(641, 380);
            this.textBoxDicsount.Name = "textBoxDicsount";
            this.textBoxDicsount.Size = new System.Drawing.Size(348, 31);
            this.textBoxDicsount.TabIndex = 19;
            this.textBoxDicsount.TextChanged += new System.EventHandler(this.textBoxDicsount_TextChanged);
            this.textBoxDicsount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDicsount_KeyPress);
            // 
            // RawMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Chocolate_Factory_Management_System.Properties.Resources.b8;
            this.ClientSize = new System.Drawing.Size(1295, 581);
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
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.menuStripRawMaterial);
            this.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStripRawMaterial;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RawMaterial";
            this.Text = "RawMaterial";
            this.Load += new System.EventHandler(this.RawMaterial_Load);
            this.menuStripRawMaterial.ResumeLayout(false);
            this.menuStripRawMaterial.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.MenuStrip menuStripRawMaterial;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxRawMaterialName;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelRawMaterialName;
        private System.Windows.Forms.Label labelReview;
        private System.Windows.Forms.ToolStripMenuItem eXITToolStripMenuItem;
        private System.Windows.Forms.Label labelRawMaterailDetails;
        private System.Windows.Forms.ComboBox comboBoxRawMaterial;
        private System.Windows.Forms.Label labelRawMaterialID;
        private System.Windows.Forms.Label labelDiscount;
        private System.Windows.Forms.TextBox textBoxDicsount;
    }
}