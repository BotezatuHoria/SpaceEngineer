
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
            this.fnameLabel = new System.Windows.Forms.Label();
            this.snameLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fNameBox
            // 
            this.fNameBox.BackColor = System.Drawing.Color.SeaShell;
            this.fNameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fNameBox.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fNameBox.Location = new System.Drawing.Point(217, 118);
            this.fNameBox.Name = "fNameBox";
            this.fNameBox.Size = new System.Drawing.Size(263, 30);
            this.fNameBox.TabIndex = 2;
            // 
            // sNameBox
            // 
            this.sNameBox.BackColor = System.Drawing.Color.SeaShell;
            this.sNameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sNameBox.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sNameBox.Location = new System.Drawing.Point(217, 69);
            this.sNameBox.Name = "sNameBox";
            this.sNameBox.Size = new System.Drawing.Size(263, 30);
            this.sNameBox.TabIndex = 1;
            // 
            // emailBox
            // 
            this.emailBox.BackColor = System.Drawing.Color.SeaShell;
            this.emailBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailBox.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.emailBox.Location = new System.Drawing.Point(217, 169);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(263, 30);
            this.emailBox.TabIndex = 3;
            // 
            // passwordBox
            // 
            this.passwordBox.BackColor = System.Drawing.Color.SeaShell;
            this.passwordBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordBox.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.passwordBox.Location = new System.Drawing.Point(217, 225);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(263, 30);
            this.passwordBox.TabIndex = 4;
            // 
            // registerButton
            // 
            this.registerButton.BackColor = System.Drawing.Color.Coral;
            this.registerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerButton.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.registerButton.Location = new System.Drawing.Point(116, 318);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(364, 44);
            this.registerButton.TabIndex = 5;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // fnameLabel
            // 
            this.fnameLabel.AutoSize = true;
            this.fnameLabel.BackColor = System.Drawing.Color.Transparent;
            this.fnameLabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fnameLabel.ForeColor = System.Drawing.Color.Gold;
            this.fnameLabel.Location = new System.Drawing.Point(112, 120);
            this.fnameLabel.Name = "fnameLabel";
            this.fnameLabel.Size = new System.Drawing.Size(90, 22);
            this.fnameLabel.TabIndex = 5;
            this.fnameLabel.Text = "Prenume:";
            // 
            // snameLabel
            // 
            this.snameLabel.AutoSize = true;
            this.snameLabel.BackColor = System.Drawing.Color.Transparent;
            this.snameLabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.snameLabel.ForeColor = System.Drawing.Color.Gold;
            this.snameLabel.Location = new System.Drawing.Point(112, 71);
            this.snameLabel.Name = "snameLabel";
            this.snameLabel.Size = new System.Drawing.Size(60, 22);
            this.snameLabel.TabIndex = 6;
            this.snameLabel.Text = "Nume:";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.BackColor = System.Drawing.Color.Transparent;
            this.emailLabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.emailLabel.ForeColor = System.Drawing.Color.Gold;
            this.emailLabel.Location = new System.Drawing.Point(112, 171);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(80, 22);
            this.emailLabel.TabIndex = 7;
            this.emailLabel.Text = "Email: ";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordLabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.passwordLabel.ForeColor = System.Drawing.Color.Gold;
            this.passwordLabel.Location = new System.Drawing.Point(112, 227);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(90, 22);
            this.passwordLabel.TabIndex = 8;
            this.passwordLabel.Text = "Parola: ";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SpaceGame.Properties.Resources.photoo;
            this.ClientSize = new System.Drawing.Size(594, 450);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.snameLabel);
            this.Controls.Add(this.fnameLabel);
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
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fNameBox;
        private System.Windows.Forms.TextBox sNameBox;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Label fnameLabel;
        private System.Windows.Forms.Label snameLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label passwordLabel;
    }
}