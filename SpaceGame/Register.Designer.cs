
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
            this.fNameBox = new System.Windows.Forms.TextBox();
            this.sNameBox = new System.Windows.Forms.TextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.registerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fNameBox
            // 
            this.fNameBox.Location = new System.Drawing.Point(110, 68);
            this.fNameBox.Name = "fNameBox";
            this.fNameBox.Size = new System.Drawing.Size(146, 20);
            this.fNameBox.TabIndex = 0;
            // 
            // sNameBox
            // 
            this.sNameBox.Location = new System.Drawing.Point(360, 68);
            this.sNameBox.Name = "sNameBox";
            this.sNameBox.Size = new System.Drawing.Size(146, 20);
            this.sNameBox.TabIndex = 1;
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(110, 160);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(146, 20);
            this.emailBox.TabIndex = 2;
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(360, 160);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(146, 20);
            this.passwordBox.TabIndex = 3;
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(110, 275);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(364, 44);
            this.registerButton.TabIndex = 4;
            this.registerButton.Text = "button1";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.sNameBox);
            this.Controls.Add(this.fNameBox);
            this.Name = "Register";
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
    }
}