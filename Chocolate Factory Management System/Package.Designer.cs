
namespace Chocolate_Factory_Management_System
{
    partial class QualityTesting
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
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelSampleName = new System.Windows.Forms.Label();
            this.textBoxSampleDetails = new System.Windows.Forms.TextBox();
            this.textBoxLaboratoryTesting = new System.Windows.Forms.TextBox();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelFinalConclusionTest = new System.Windows.Forms.Label();
            this.textBoxFinalConclusion = new System.Windows.Forms.TextBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.checkedListBoxResult = new System.Windows.Forms.CheckedListBox();
            this.labelQualityTesting = new System.Windows.Forms.Label();
            this.labelTestedBy = new System.Windows.Forms.Label();
            this.textBoxTestedBy = new System.Windows.Forms.TextBox();
            this.labelNonCompliance = new System.Windows.Forms.Label();
            this.textBoxNonCompliance = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(616, 531);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(218, 52);
            this.buttonSubmit.TabIndex = 0;
            this.buttonSubmit.Text = "SUBMIT";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sample Details";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(80, 169);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(44, 20);
            this.labelDate.TabIndex = 2;
            this.labelDate.Text = "Date";
            // 
            // labelSampleName
            // 
            this.labelSampleName.AutoSize = true;
            this.labelSampleName.Location = new System.Drawing.Point(80, 110);
            this.labelSampleName.Name = "labelSampleName";
            this.labelSampleName.Size = new System.Drawing.Size(109, 20);
            this.labelSampleName.TabIndex = 3;
            this.labelSampleName.Text = "Sample Name";
            // 
            // textBoxSampleDetails
            // 
            this.textBoxSampleDetails.Location = new System.Drawing.Point(246, 227);
            this.textBoxSampleDetails.Multiline = true;
            this.textBoxSampleDetails.Name = "textBoxSampleDetails";
            this.textBoxSampleDetails.Size = new System.Drawing.Size(344, 86);
            this.textBoxSampleDetails.TabIndex = 4;
            // 
            // textBoxLaboratoryTesting
            // 
            this.textBoxLaboratoryTesting.Location = new System.Drawing.Point(246, 351);
            this.textBoxLaboratoryTesting.Multiline = true;
            this.textBoxLaboratoryTesting.Name = "textBoxLaboratoryTesting";
            this.textBoxLaboratoryTesting.Size = new System.Drawing.Size(344, 142);
            this.textBoxLaboratoryTesting.TabIndex = 5;
            this.textBoxLaboratoryTesting.Text = "Test Condition:\r\n\r\n\r\nResult Of Testing:\r\n\r\n\r\n";
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.Location = new System.Drawing.Point(246, 104);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(344, 26);
            this.textBoxProductName.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Laboratory Testing";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(246, 163);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(344, 26);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // labelFinalConclusionTest
            // 
            this.labelFinalConclusionTest.AutoSize = true;
            this.labelFinalConclusionTest.Location = new System.Drawing.Point(687, 104);
            this.labelFinalConclusionTest.Name = "labelFinalConclusionTest";
            this.labelFinalConclusionTest.Size = new System.Drawing.Size(260, 20);
            this.labelFinalConclusionTest.TabIndex = 9;
            this.labelFinalConclusionTest.Text = "Final Conclusion Of Sample Testing";
            this.labelFinalConclusionTest.Click += new System.EventHandler(this.labelFinalConclusionTest_Click);
            // 
            // textBoxFinalConclusion
            // 
            this.textBoxFinalConclusion.Location = new System.Drawing.Point(691, 128);
            this.textBoxFinalConclusion.Multiline = true;
            this.textBoxFinalConclusion.Name = "textBoxFinalConclusion";
            this.textBoxFinalConclusion.Size = new System.Drawing.Size(450, 92);
            this.textBoxFinalConclusion.TabIndex = 10;
            this.textBoxFinalConclusion.TextChanged += new System.EventHandler(this.textBoxFinalConclusion_TextChanged);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(687, 418);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(55, 20);
            this.labelResult.TabIndex = 12;
            this.labelResult.Text = "Result";
            // 
            // checkedListBoxResult
            // 
            this.checkedListBoxResult.FormattingEnabled = true;
            this.checkedListBoxResult.Items.AddRange(new object[] {
            "Approved",
            "Rejected"});
            this.checkedListBoxResult.Location = new System.Drawing.Point(867, 418);
            this.checkedListBoxResult.Name = "checkedListBoxResult";
            this.checkedListBoxResult.Size = new System.Drawing.Size(274, 50);
            this.checkedListBoxResult.TabIndex = 13;
            this.checkedListBoxResult.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // labelQualityTesting
            // 
            this.labelQualityTesting.AutoSize = true;
            this.labelQualityTesting.Font = new System.Drawing.Font("Lucida Bright", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQualityTesting.Location = new System.Drawing.Point(481, 9);
            this.labelQualityTesting.Name = "labelQualityTesting";
            this.labelQualityTesting.Size = new System.Drawing.Size(483, 54);
            this.labelQualityTesting.TabIndex = 14;
            this.labelQualityTesting.Text = "QUALITY TESTING";
            // 
            // labelTestedBy
            // 
            this.labelTestedBy.AutoSize = true;
            this.labelTestedBy.Location = new System.Drawing.Point(687, 352);
            this.labelTestedBy.Name = "labelTestedBy";
            this.labelTestedBy.Size = new System.Drawing.Size(84, 20);
            this.labelTestedBy.TabIndex = 15;
            this.labelTestedBy.Text = "Tested By:";
            this.labelTestedBy.Click += new System.EventHandler(this.labelTestedBy_Click);
            // 
            // textBoxTestedBy
            // 
            this.textBoxTestedBy.Location = new System.Drawing.Point(867, 346);
            this.textBoxTestedBy.Name = "textBoxTestedBy";
            this.textBoxTestedBy.Size = new System.Drawing.Size(274, 26);
            this.textBoxTestedBy.TabIndex = 16;
            this.textBoxTestedBy.TextChanged += new System.EventHandler(this.textBoxTestedBy_TextChanged);
            // 
            // labelNonCompliance
            // 
            this.labelNonCompliance.AutoSize = true;
            this.labelNonCompliance.Location = new System.Drawing.Point(687, 262);
            this.labelNonCompliance.Name = "labelNonCompliance";
            this.labelNonCompliance.Size = new System.Drawing.Size(160, 20);
            this.labelNonCompliance.TabIndex = 17;
            this.labelNonCompliance.Text = "Any Non Compliance:";
            // 
            // textBoxNonCompliance
            // 
            this.textBoxNonCompliance.Location = new System.Drawing.Point(867, 262);
            this.textBoxNonCompliance.Name = "textBoxNonCompliance";
            this.textBoxNonCompliance.Size = new System.Drawing.Size(274, 26);
            this.textBoxNonCompliance.TabIndex = 18;
            // 
            // QualityTesting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1349, 614);
            this.Controls.Add(this.textBoxNonCompliance);
            this.Controls.Add(this.labelNonCompliance);
            this.Controls.Add(this.textBoxTestedBy);
            this.Controls.Add(this.labelTestedBy);
            this.Controls.Add(this.labelQualityTesting);
            this.Controls.Add(this.checkedListBoxResult);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.textBoxFinalConclusion);
            this.Controls.Add(this.labelFinalConclusionTest);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxProductName);
            this.Controls.Add(this.textBoxLaboratoryTesting);
            this.Controls.Add(this.textBoxSampleDetails);
            this.Controls.Add(this.labelSampleName);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSubmit);
            this.Name = "QualityTesting";
            this.Text = "QualityTesting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelSampleName;
        private System.Windows.Forms.TextBox textBoxSampleDetails;
        private System.Windows.Forms.TextBox textBoxLaboratoryTesting;
        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label labelFinalConclusionTest;
        private System.Windows.Forms.TextBox textBoxFinalConclusion;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.CheckedListBox checkedListBoxResult;
        private System.Windows.Forms.Label labelQualityTesting;
        private System.Windows.Forms.Label labelTestedBy;
        private System.Windows.Forms.TextBox textBoxTestedBy;
        private System.Windows.Forms.Label labelNonCompliance;
        private System.Windows.Forms.TextBox textBoxNonCompliance;
    }
}