﻿
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
            this.buttonEDIT = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.menuStripRawMaterial = new System.Windows.Forms.MenuStrip();
            this.cLEARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.pictureBoxRawMaterial = new System.Windows.Forms.PictureBox();
            this.labelRawMaterialID = new System.Windows.Forms.Label();
            this.menuStripRawMaterial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRawMaterial)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.GreenYellow;
            this.buttonAdd.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(28, 517);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(133, 51);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "ADD";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEDIT
            // 
            this.buttonEDIT.BackColor = System.Drawing.Color.GreenYellow;
            this.buttonEDIT.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEDIT.Location = new System.Drawing.Point(249, 517);
            this.buttonEDIT.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEDIT.Name = "buttonEDIT";
            this.buttonEDIT.Size = new System.Drawing.Size(143, 51);
            this.buttonEDIT.TabIndex = 1;
            this.buttonEDIT.Text = "EDIT";
            this.buttonEDIT.UseVisualStyleBackColor = false;
            this.buttonEDIT.Click += new System.EventHandler(this.buttonEDIT_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.GreenYellow;
            this.buttonDelete.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(459, 517);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(149, 51);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "DELETE";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.GreenYellow;
            this.buttonSearch.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Location = new System.Drawing.Point(28, 139);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(201, 58);
            this.buttonSearch.TabIndex = 3;
            this.buttonSearch.Text = "SEARCH";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // menuStripRawMaterial
            // 
            this.menuStripRawMaterial.BackColor = System.Drawing.Color.GreenYellow;
            this.menuStripRawMaterial.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStripRawMaterial.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStripRawMaterial.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStripRawMaterial.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cLEARToolStripMenuItem,
            this.eXITToolStripMenuItem});
            this.menuStripRawMaterial.Location = new System.Drawing.Point(0, 0);
            this.menuStripRawMaterial.Name = "menuStripRawMaterial";
            this.menuStripRawMaterial.Padding = new System.Windows.Forms.Padding(13, 4, 0, 4);
            this.menuStripRawMaterial.Size = new System.Drawing.Size(1295, 44);
            this.menuStripRawMaterial.TabIndex = 4;
            this.menuStripRawMaterial.Text = "menuStripRawMaterial";
            // 
            // cLEARToolStripMenuItem
            // 
            this.cLEARToolStripMenuItem.BackColor = System.Drawing.Color.PaleGreen;
            this.cLEARToolStripMenuItem.Image = global::Chocolate_Factory_Management_System.Properties.Resources.clear;
            this.cLEARToolStripMenuItem.Name = "cLEARToolStripMenuItem";
            this.cLEARToolStripMenuItem.Size = new System.Drawing.Size(128, 36);
            this.cLEARToolStripMenuItem.Text = "CLEAR";
            this.cLEARToolStripMenuItem.Click += new System.EventHandler(this.cLEARToolStripMenuItem_Click);
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
            this.textBoxPrice.Location = new System.Drawing.Point(313, 376);
            this.textBoxPrice.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(295, 31);
            this.textBoxPrice.TabIndex = 5;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(313, 301);
            this.textBoxDescription.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(295, 31);
            this.textBoxDescription.TabIndex = 6;
            // 
            // textBoxRawMaterialName
            // 
            this.textBoxRawMaterialName.Location = new System.Drawing.Point(313, 232);
            this.textBoxRawMaterialName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxRawMaterialName.Name = "textBoxRawMaterialName";
            this.textBoxRawMaterialName.Size = new System.Drawing.Size(295, 31);
            this.textBoxRawMaterialName.TabIndex = 7;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(249, 166);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(237, 31);
            this.textBoxSearch.TabIndex = 8;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.BackColor = System.Drawing.Color.Transparent;
            this.labelPrice.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelPrice.Location = new System.Drawing.Point(22, 376);
            this.labelPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(84, 31);
            this.labelPrice.TabIndex = 9;
            this.labelPrice.Text = "Price";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.BackColor = System.Drawing.Color.Transparent;
            this.labelDescription.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelDescription.Location = new System.Drawing.Point(22, 301);
            this.labelDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(173, 31);
            this.labelDescription.TabIndex = 10;
            this.labelDescription.Text = "Description";
            // 
            // labelRawMaterialName
            // 
            this.labelRawMaterialName.AutoSize = true;
            this.labelRawMaterialName.BackColor = System.Drawing.Color.Transparent;
            this.labelRawMaterialName.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRawMaterialName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelRawMaterialName.Location = new System.Drawing.Point(22, 232);
            this.labelRawMaterialName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRawMaterialName.Name = "labelRawMaterialName";
            this.labelRawMaterialName.Size = new System.Drawing.Size(286, 31);
            this.labelRawMaterialName.TabIndex = 11;
            this.labelRawMaterialName.Text = "Raw Material Name";
            // 
            // labelReview
            // 
            this.labelReview.AutoSize = true;
            this.labelReview.BackColor = System.Drawing.Color.Transparent;
            this.labelReview.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReview.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelReview.Location = new System.Drawing.Point(22, 448);
            this.labelReview.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelReview.Name = "labelReview";
            this.labelReview.Size = new System.Drawing.Size(117, 31);
            this.labelReview.TabIndex = 12;
            this.labelReview.Text = "Review";
            // 
            // labelRawMaterailDetails
            // 
            this.labelRawMaterailDetails.AutoSize = true;
            this.labelRawMaterailDetails.BackColor = System.Drawing.Color.Transparent;
            this.labelRawMaterailDetails.Font = new System.Drawing.Font("Lucida Bright", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRawMaterailDetails.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelRawMaterailDetails.Location = new System.Drawing.Point(384, 53);
            this.labelRawMaterailDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRawMaterailDetails.Name = "labelRawMaterailDetails";
            this.labelRawMaterailDetails.Size = new System.Drawing.Size(650, 54);
            this.labelRawMaterailDetails.TabIndex = 15;
            this.labelRawMaterailDetails.Text = "RAW MATERIAL DETAILS";
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
            this.comboBoxRawMaterial.Location = new System.Drawing.Point(313, 448);
            this.comboBoxRawMaterial.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxRawMaterial.Name = "comboBoxRawMaterial";
            this.comboBoxRawMaterial.Size = new System.Drawing.Size(295, 31);
            this.comboBoxRawMaterial.TabIndex = 16;
            // 
            // pictureBoxRawMaterial
            // 
            this.pictureBoxRawMaterial.Location = new System.Drawing.Point(665, 126);
            this.pictureBoxRawMaterial.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxRawMaterial.Name = "pictureBoxRawMaterial";
            this.pictureBoxRawMaterial.Size = new System.Drawing.Size(600, 442);
            this.pictureBoxRawMaterial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxRawMaterial.TabIndex = 14;
            this.pictureBoxRawMaterial.TabStop = false;
            this.pictureBoxRawMaterial.Click += new System.EventHandler(this.pictureBoxRawMaterial_Click);
            // 
            // labelRawMaterialID
            // 
            this.labelRawMaterialID.AutoSize = true;
            this.labelRawMaterialID.BackColor = System.Drawing.Color.Transparent;
            this.labelRawMaterialID.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelRawMaterialID.Location = new System.Drawing.Point(245, 139);
            this.labelRawMaterialID.Name = "labelRawMaterialID";
            this.labelRawMaterialID.Size = new System.Drawing.Size(227, 23);
            this.labelRawMaterialID.TabIndex = 17;
            this.labelRawMaterialID.Text = "Enter Raw Material ID";
            // 
            // RawMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Chocolate_Factory_Management_System.Properties.Resources.b8;
            this.ClientSize = new System.Drawing.Size(1295, 581);
            this.Controls.Add(this.labelRawMaterialID);
            this.Controls.Add(this.comboBoxRawMaterial);
            this.Controls.Add(this.labelRawMaterailDetails);
            this.Controls.Add(this.pictureBoxRawMaterial);
            this.Controls.Add(this.labelReview);
            this.Controls.Add(this.labelRawMaterialName);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.textBoxRawMaterialName);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEDIT);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRawMaterial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEDIT;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.MenuStrip menuStripRawMaterial;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxRawMaterialName;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelRawMaterialName;
        private System.Windows.Forms.Label labelReview;
        private System.Windows.Forms.PictureBox pictureBoxRawMaterial;
        private System.Windows.Forms.ToolStripMenuItem cLEARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXITToolStripMenuItem;
        private System.Windows.Forms.Label labelRawMaterailDetails;
        private System.Windows.Forms.ComboBox comboBoxRawMaterial;
        private System.Windows.Forms.Label labelRawMaterialID;
    }
}