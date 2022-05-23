
namespace SpaceGame
{
    partial class Login
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
            this.loginLogo = new System.Windows.Forms.PictureBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.registerLabel = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.loginLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // loginLogo
            // 
            this.loginLogo.Location = new System.Drawing.Point(121, 31);
            this.loginLogo.Name = "loginLogo";
            this.loginLogo.Size = new System.Drawing.Size(466, 158);
            this.loginLogo.TabIndex = 0;
            this.loginLogo.TabStop = false;
            // 
            // loginButton
            // 
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Location = new System.Drawing.Point(157, 335);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(412, 60);
            this.loginButton.TabIndex = 1;
            this.loginButton.Text = "button1";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(196, 219);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(332, 20);
            this.emailBox.TabIndex = 2;
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(196, 271);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(332, 20);
            this.passwordBox.TabIndex = 3;
            // 
            // registerLabel
            // 
            this.registerLabel.AutoSize = true;
            this.registerLabel.Location = new System.Drawing.Point(45, 417);
            this.registerLabel.Name = "registerLabel";
            this.registerLabel.Size = new System.Drawing.Size(46, 13);
            this.registerLabel.TabIndex = 4;
            this.registerLabel.TabStop = true;
            this.registerLabel.Text = "Register";
            this.registerLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.registerLabel_LinkClicked);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 450);
            this.Controls.Add(this.registerLabel);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.loginLogo);
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.loginLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox loginLogo;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.LinkLabel registerLabel;
    }
}

