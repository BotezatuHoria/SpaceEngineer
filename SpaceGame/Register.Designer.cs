
namespace SpaceGame
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.fNameBox = new System.Windows.Forms.TextBox();
            this.sNameBox = new System.Windows.Forms.TextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.registerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fNameBox
            // 
            this.fNameBox.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.fNameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fNameBox.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fNameBox.Location = new System.Drawing.Point(511, 208);
            this.fNameBox.Name = "fNameBox";
            this.fNameBox.Size = new System.Drawing.Size(263, 41);
            this.fNameBox.TabIndex = 2;
            // 
            // sNameBox
            // 
            this.sNameBox.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.sNameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sNameBox.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sNameBox.Location = new System.Drawing.Point(511, 125);
            this.sNameBox.Name = "sNameBox";
            this.sNameBox.Size = new System.Drawing.Size(263, 41);
            this.sNameBox.TabIndex = 1;
            // 
            // emailBox
            // 
            this.emailBox.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.emailBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailBox.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.emailBox.Location = new System.Drawing.Point(511, 302);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(263, 41);
            this.emailBox.TabIndex = 3;
            // 
            // passwordBox
            // 
            this.passwordBox.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.passwordBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordBox.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.passwordBox.Location = new System.Drawing.Point(511, 402);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(263, 41);
            this.passwordBox.TabIndex = 4;
            // 
            // registerButton
            // 
            this.registerButton.BackColor = System.Drawing.Color.Transparent;
            this.registerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.registerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.registerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerButton.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.registerButton.Location = new System.Drawing.Point(487, 516);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(244, 75);
            this.registerButton.TabIndex = 5;
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SpaceGame.Properties.Resources.Register;
            this.ClientSize = new System.Drawing.Size(1237, 658);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.sNameBox);
            this.Controls.Add(this.fNameBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inregistrare";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fNameBox;
        private System.Windows.Forms.TextBox sNameBox;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Button registerButton;
    }
}