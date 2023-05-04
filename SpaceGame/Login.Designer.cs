
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.loginButton = new System.Windows.Forms.Button();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.registerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.Transparent;
            this.loginButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.loginButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.loginButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loginButton.ForeColor = System.Drawing.Color.Transparent;
            this.loginButton.Location = new System.Drawing.Point(794, 402);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(266, 82);
            this.loginButton.TabIndex = 3;
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // emailBox
            // 
            this.emailBox.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.emailBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailBox.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.emailBox.Location = new System.Drawing.Point(782, 207);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(367, 38);
            this.emailBox.TabIndex = 1;
            // 
            // passwordBox
            // 
            this.passwordBox.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.passwordBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordBox.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.passwordBox.Location = new System.Drawing.Point(782, 284);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(367, 38);
            this.passwordBox.TabIndex = 2;
            // 
            // registerButton
            // 
            this.registerButton.BackColor = System.Drawing.Color.Transparent;
            this.registerButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.registerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.registerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.registerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerButton.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.registerButton.ForeColor = System.Drawing.Color.Transparent;
            this.registerButton.Location = new System.Drawing.Point(782, 516);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(294, 87);
            this.registerButton.TabIndex = 4;
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SpaceGame.Properties.Resources.login3;
            this.ClientSize = new System.Drawing.Size(1237, 658);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.loginButton);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Button registerButton;
    }
}

