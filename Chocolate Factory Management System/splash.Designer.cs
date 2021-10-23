
namespace Chocolate_Factory_Management_System
{
    partial class splash
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.labelCFMS = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(0, 555);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1412, 13);
            this.progressBar1.TabIndex = 1;
            // 
            // labelCFMS
            // 
            this.labelCFMS.AutoSize = true;
            this.labelCFMS.BackColor = System.Drawing.Color.Transparent;
            this.labelCFMS.Font = new System.Drawing.Font("Microsoft Uighur", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCFMS.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelCFMS.Location = new System.Drawing.Point(449, 448);
            this.labelCFMS.Name = "labelCFMS";
            this.labelCFMS.Size = new System.Drawing.Size(1214, 85);
            this.labelCFMS.TabIndex = 2;
            this.labelCFMS.Text = "CHOCOLATE FACTORY MANAGEMENT SYSTEM";
            this.labelCFMS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.BackgroundImage = global::Chocolate_Factory_Management_System.Properties.Resources.splash1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1412, 568);
            this.Controls.Add(this.labelCFMS);
            this.Controls.Add(this.progressBar1);
            this.DoubleBuffered = true;
            this.Name = "splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "splash";
            this.Load += new System.EventHandler(this.splash_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label labelCFMS;
    }
}