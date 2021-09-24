
namespace Chocolate_Factory_Management_System
{
    partial class Form1
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
            this.labelCheckConnection = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.groupBoxUserLogin = new System.Windows.Forms.GroupBox();
            this.buttonClose1 = new System.Windows.Forms.Button();
            this.groupBoxUserLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelCheckConnection
            // 
            this.labelCheckConnection.AutoSize = true;
            this.labelCheckConnection.Font = new System.Drawing.Font("Lucida Bright", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCheckConnection.Location = new System.Drawing.Point(0, 0);
            this.labelCheckConnection.Name = "labelCheckConnection";
            this.labelCheckConnection.Size = new System.Drawing.Size(185, 20);
            this.labelCheckConnection.TabIndex = 0;
            this.labelCheckConnection.Text = "Connection Successful";
            // 
            // buttonLogin
            // 
            this.buttonLogin.Font = new System.Drawing.Font("Lucida Bright", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.Location = new System.Drawing.Point(386, 302);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(251, 65);
            this.buttonLogin.TabIndex = 1;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Lucida Bright", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.Location = new System.Drawing.Point(116, 99);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(178, 36);
            this.labelUsername.TabIndex = 2;
            this.labelUsername.Text = "Username";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Lucida Bright", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(116, 190);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(172, 36);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "Password";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsername.Location = new System.Drawing.Point(386, 99);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(402, 36);
            this.textBoxUsername.TabIndex = 4;
            this.textBoxUsername.TextChanged += new System.EventHandler(this.textBoxUsername_TextChanged);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(386, 190);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '$';
            this.textBoxPassword.Size = new System.Drawing.Size(402, 36);
            this.textBoxPassword.TabIndex = 5;
            // 
            // groupBoxUserLogin
            // 
            this.groupBoxUserLogin.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxUserLogin.Controls.Add(this.textBoxUsername);
            this.groupBoxUserLogin.Controls.Add(this.buttonLogin);
            this.groupBoxUserLogin.Controls.Add(this.labelPassword);
            this.groupBoxUserLogin.Controls.Add(this.textBoxPassword);
            this.groupBoxUserLogin.Controls.Add(this.labelUsername);
            this.groupBoxUserLogin.Font = new System.Drawing.Font("Lucida Bright", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxUserLogin.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.groupBoxUserLogin.Location = new System.Drawing.Point(478, 163);
            this.groupBoxUserLogin.Name = "groupBoxUserLogin";
            this.groupBoxUserLogin.Size = new System.Drawing.Size(847, 457);
            this.groupBoxUserLogin.TabIndex = 6;
            this.groupBoxUserLogin.TabStop = false;
            this.groupBoxUserLogin.Text = "User Login";
            this.groupBoxUserLogin.Enter += new System.EventHandler(this.groupBoxUserLogin_Enter);
            // 
            // buttonClose1
            // 
            this.buttonClose1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose1.Location = new System.Drawing.Point(1630, 12);
            this.buttonClose1.Name = "buttonClose1";
            this.buttonClose1.Size = new System.Drawing.Size(40, 40);
            this.buttonClose1.TabIndex = 7;
            this.buttonClose1.Text = "X";
            this.buttonClose1.UseVisualStyleBackColor = true;
            this.buttonClose1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Chocolate_Factory_Management_System.Properties.Resources.c2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1739, 855);
            this.Controls.Add(this.buttonClose1);
            this.Controls.Add(this.labelCheckConnection);
            this.Controls.Add(this.groupBoxUserLogin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxUserLogin.ResumeLayout(false);
            this.groupBoxUserLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCheckConnection;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.GroupBox groupBoxUserLogin;
        private System.Windows.Forms.Button buttonClose1;
    }
}

