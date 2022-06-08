
namespace SpaceGame
{
    partial class Admin
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
            this.question = new System.Windows.Forms.TextBox();
            this.chemRadButton = new System.Windows.Forms.RadioButton();
            this.mathsRadButton = new System.Windows.Forms.RadioButton();
            this.phyRadButton = new System.Windows.Forms.RadioButton();
            this.progRadButton = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // question
            // 
            this.question.Location = new System.Drawing.Point(85, 12);
            this.question.Multiline = true;
            this.question.Name = "question";
            this.question.Size = new System.Drawing.Size(625, 65);
            this.question.TabIndex = 0;
            // 
            // chemRadButton
            // 
            this.chemRadButton.AutoSize = true;
            this.chemRadButton.Location = new System.Drawing.Point(445, 363);
            this.chemRadButton.Name = "chemRadButton";
            this.chemRadButton.Size = new System.Drawing.Size(56, 17);
            this.chemRadButton.TabIndex = 1;
            this.chemRadButton.TabStop = true;
            this.chemRadButton.Text = "Chimie";
            this.chemRadButton.UseVisualStyleBackColor = true;
            // 
            // mathsRadButton
            // 
            this.mathsRadButton.AutoSize = true;
            this.mathsRadButton.Location = new System.Drawing.Point(85, 363);
            this.mathsRadButton.Name = "mathsRadButton";
            this.mathsRadButton.Size = new System.Drawing.Size(80, 17);
            this.mathsRadButton.TabIndex = 2;
            this.mathsRadButton.TabStop = true;
            this.mathsRadButton.Text = "Matematica";
            this.mathsRadButton.UseVisualStyleBackColor = true;
            // 
            // phyRadButton
            // 
            this.phyRadButton.AutoSize = true;
            this.phyRadButton.Location = new System.Drawing.Point(214, 363);
            this.phyRadButton.Name = "phyRadButton";
            this.phyRadButton.Size = new System.Drawing.Size(52, 17);
            this.phyRadButton.TabIndex = 3;
            this.phyRadButton.TabStop = true;
            this.phyRadButton.Text = "Fizica";
            this.phyRadButton.UseVisualStyleBackColor = true;
            // 
            // progRadButton
            // 
            this.progRadButton.AutoSize = true;
            this.progRadButton.Location = new System.Drawing.Point(310, 363);
            this.progRadButton.Name = "progRadButton";
            this.progRadButton.Size = new System.Drawing.Size(79, 17);
            this.progRadButton.TabIndex = 4;
            this.progRadButton.TabStop = true;
            this.progRadButton.Text = "Programare";
            this.progRadButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(85, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(625, 232);
            this.panel1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(310, 424);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 46);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 482);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.progRadButton);
            this.Controls.Add(this.phyRadButton);
            this.Controls.Add(this.mathsRadButton);
            this.Controls.Add(this.chemRadButton);
            this.Controls.Add(this.question);
            this.Name = "Admin";
            this.Text = "Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox question;
        private System.Windows.Forms.RadioButton chemRadButton;
        private System.Windows.Forms.RadioButton mathsRadButton;
        private System.Windows.Forms.RadioButton phyRadButton;
        private System.Windows.Forms.RadioButton progRadButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}