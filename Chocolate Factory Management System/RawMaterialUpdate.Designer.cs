
namespace Chocolate_Factory_Management_System
{
    partial class RawMaterialUpdate
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
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxDicsount
            // 
            this.textBoxDicsount.Location = new System.Drawing.Point(701, 371);
            this.textBoxDicsount.Name = "textBoxDicsount";
            this.textBoxDicsount.Size = new System.Drawing.Size(295, 26);
            this.textBoxDicsount.TabIndex = 34;
            this.textBoxDicsount.TextChanged += new System.EventHandler(this.textBoxDicsount_TextChanged);
            // 
            // labelDiscount
            // 
            this.labelDiscount.AutoSize = true;
            this.labelDiscount.Location = new System.Drawing.Point(412, 382);
            this.labelDiscount.Name = "labelDiscount";
            this.labelDiscount.Size = new System.Drawing.Size(72, 20);
            this.labelDiscount.TabIndex = 33;
            this.labelDiscount.Text = "Discount";
            this.labelDiscount.Click += new System.EventHandler(this.labelDiscount_Click);
            // 
            // labelRawMaterialID
            // 
            this.labelRawMaterialID.AutoSize = true;
            this.labelRawMaterialID.BackColor = System.Drawing.Color.Transparent;
            this.labelRawMaterialID.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelRawMaterialID.Location = new System.Drawing.Point(418, 138);
            this.labelRawMaterialID.Name = "labelRawMaterialID";
            this.labelRawMaterialID.Size = new System.Drawing.Size(165, 20);
            this.labelRawMaterialID.TabIndex = 32;
            this.labelRawMaterialID.Text = "Enter Raw Material ID";
            this.labelRawMaterialID.Click += new System.EventHandler(this.labelRawMaterialID_Click);
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
            this.comboBoxRawMaterial.Location = new System.Drawing.Point(701, 420);
            this.comboBoxRawMaterial.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxRawMaterial.Name = "comboBoxRawMaterial";
            this.comboBoxRawMaterial.Size = new System.Drawing.Size(295, 28);
            this.comboBoxRawMaterial.TabIndex = 31;
            this.comboBoxRawMaterial.SelectedIndexChanged += new System.EventHandler(this.comboBoxRawMaterial_SelectedIndexChanged);
            // 
            // labelRawMaterailDetails
            // 
            this.labelRawMaterailDetails.AutoSize = true;
            this.labelRawMaterailDetails.BackColor = System.Drawing.Color.Transparent;
            this.labelRawMaterailDetails.Font = new System.Drawing.Font("Lucida Bright", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRawMaterailDetails.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelRawMaterailDetails.Location = new System.Drawing.Point(411, 32);
            this.labelRawMaterailDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRawMaterailDetails.Name = "labelRawMaterailDetails";
            this.labelRawMaterailDetails.Size = new System.Drawing.Size(650, 54);
            this.labelRawMaterailDetails.TabIndex = 30;
            this.labelRawMaterailDetails.Text = "RAW MATERIAL DETAILS";
            this.labelRawMaterailDetails.Click += new System.EventHandler(this.labelRawMaterailDetails_Click);
            // 
            // labelReview
            // 
            this.labelReview.AutoSize = true;
            this.labelReview.BackColor = System.Drawing.Color.Transparent;
            this.labelReview.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReview.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelReview.Location = new System.Drawing.Point(410, 420);
            this.labelReview.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelReview.Name = "labelReview";
            this.labelReview.Size = new System.Drawing.Size(117, 31);
            this.labelReview.TabIndex = 28;
            this.labelReview.Text = "Review";
            this.labelReview.Click += new System.EventHandler(this.labelReview_Click);
            // 
            // labelRawMaterialName
            // 
            this.labelRawMaterialName.AutoSize = true;
            this.labelRawMaterialName.BackColor = System.Drawing.Color.Transparent;
            this.labelRawMaterialName.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRawMaterialName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelRawMaterialName.Location = new System.Drawing.Point(410, 204);
            this.labelRawMaterialName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRawMaterialName.Name = "labelRawMaterialName";
            this.labelRawMaterialName.Size = new System.Drawing.Size(286, 31);
            this.labelRawMaterialName.TabIndex = 27;
            this.labelRawMaterialName.Text = "Raw Material Name";
            this.labelRawMaterialName.Click += new System.EventHandler(this.labelRawMaterialName_Click);
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.BackColor = System.Drawing.Color.Transparent;
            this.labelDescription.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelDescription.Location = new System.Drawing.Point(410, 260);
            this.labelDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(173, 31);
            this.labelDescription.TabIndex = 26;
            this.labelDescription.Text = "Description";
            this.labelDescription.Click += new System.EventHandler(this.labelDescription_Click);
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.BackColor = System.Drawing.Color.Transparent;
            this.labelPrice.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelPrice.Location = new System.Drawing.Point(410, 312);
            this.labelPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(84, 31);
            this.labelPrice.TabIndex = 25;
            this.labelPrice.Text = "Price";
            this.labelPrice.Click += new System.EventHandler(this.labelPrice_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(701, 138);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(237, 26);
            this.textBoxSearch.TabIndex = 24;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // textBoxRawMaterialName
            // 
            this.textBoxRawMaterialName.Location = new System.Drawing.Point(701, 204);
            this.textBoxRawMaterialName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxRawMaterialName.Name = "textBoxRawMaterialName";
            this.textBoxRawMaterialName.Size = new System.Drawing.Size(295, 26);
            this.textBoxRawMaterialName.TabIndex = 23;
            this.textBoxRawMaterialName.TextChanged += new System.EventHandler(this.textBoxRawMaterialName_TextChanged);
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(701, 260);
            this.textBoxDescription.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(295, 26);
            this.textBoxDescription.TabIndex = 22;
            this.textBoxDescription.TextChanged += new System.EventHandler(this.textBoxDescription_TextChanged);
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(701, 312);
            this.textBoxPrice.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(295, 26);
            this.textBoxPrice.TabIndex = 21;
            this.textBoxPrice.TextChanged += new System.EventHandler(this.textBoxPrice_TextChanged);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(570, 479);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(156, 48);
            this.buttonUpdate.TabIndex = 35;
            this.buttonUpdate.Text = "UPDATE";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // RawMaterialUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 579);
            this.Controls.Add(this.buttonUpdate);
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
            this.Name = "RawMaterialUpdate";
            this.Text = "RawMaterialUpdate";
            this.Load += new System.EventHandler(this.RawMaterialUpdate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.Button buttonUpdate;
    }
}