
namespace SpaceGame
{
    partial class Questions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Questions));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nextButton = new System.Windows.Forms.Button();
            this.explButton = new System.Windows.Forms.Button();
            this.prevButton = new System.Windows.Forms.Button();
            this.validButton = new System.Windows.Forms.Button();
            this.mistakeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LemonChiffon;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(34, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(863, 76);
            this.textBox1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LemonChiffon;
            this.panel1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.panel1.Location = new System.Drawing.Point(34, 127);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(863, 388);
            this.panel1.TabIndex = 1;
            // 
            // nextButton
            // 
            this.nextButton.Enabled = false;
            this.nextButton.Location = new System.Drawing.Point(822, 543);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 23);
            this.nextButton.TabIndex = 2;
            this.nextButton.Text = "button1";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Visible = false;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // explButton
            // 
            this.explButton.BackColor = System.Drawing.Color.Gold;
            this.explButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.explButton.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.explButton.Location = new System.Drawing.Point(919, 127);
            this.explButton.Name = "explButton";
            this.explButton.Size = new System.Drawing.Size(162, 65);
            this.explButton.TabIndex = 3;
            this.explButton.Text = "Explicatie";
            this.explButton.UseVisualStyleBackColor = false;
            this.explButton.Visible = false;
            this.explButton.Click += new System.EventHandler(this.explButton_Click);
            // 
            // prevButton
            // 
            this.prevButton.Enabled = false;
            this.prevButton.Location = new System.Drawing.Point(34, 543);
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(75, 23);
            this.prevButton.TabIndex = 4;
            this.prevButton.Text = "button1";
            this.prevButton.UseVisualStyleBackColor = true;
            this.prevButton.Visible = false;
            this.prevButton.Click += new System.EventHandler(this.prevButton_Click);
            // 
            // validButton
            // 
            this.validButton.BackColor = System.Drawing.Color.Gold;
            this.validButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.validButton.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.validButton.Location = new System.Drawing.Point(919, 446);
            this.validButton.Name = "validButton";
            this.validButton.Size = new System.Drawing.Size(162, 69);
            this.validButton.TabIndex = 5;
            this.validButton.Text = "Verifica";
            this.validButton.UseVisualStyleBackColor = false;
            this.validButton.Click += new System.EventHandler(this.validButton_Click);
            // 
            // mistakeLabel
            // 
            this.mistakeLabel.BackColor = System.Drawing.Color.Transparent;
            this.mistakeLabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mistakeLabel.ForeColor = System.Drawing.Color.Red;
            this.mistakeLabel.Location = new System.Drawing.Point(919, 248);
            this.mistakeLabel.Name = "mistakeLabel";
            this.mistakeLabel.Size = new System.Drawing.Size(162, 99);
            this.mistakeLabel.TabIndex = 6;
            this.mistakeLabel.Text = "Raspuns gresit, verifica explicatia.";
            this.mistakeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Questions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SpaceGame.Properties.Resources.fundal1;
            this.ClientSize = new System.Drawing.Size(1104, 578);
            this.Controls.Add(this.mistakeLabel);
            this.Controls.Add(this.validButton);
            this.Controls.Add(this.prevButton);
            this.Controls.Add(this.explButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Questions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teste";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Questions_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Questions_FormClosed);
            this.Load += new System.EventHandler(this.Questions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button explButton;
        private System.Windows.Forms.Button prevButton;
        private System.Windows.Forms.Button validButton;
        private System.Windows.Forms.Label mistakeLabel;
    }
}