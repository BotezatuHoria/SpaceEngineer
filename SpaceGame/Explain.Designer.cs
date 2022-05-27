
namespace SpaceGame
{
    partial class Explain
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
            this.explainLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // explainLabel
            // 
            this.explainLabel.BackColor = System.Drawing.Color.Transparent;
            this.explainLabel.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.explainLabel.ForeColor = System.Drawing.Color.White;
            this.explainLabel.Location = new System.Drawing.Point(28, 33);
            this.explainLabel.Name = "explainLabel";
            this.explainLabel.Size = new System.Drawing.Size(513, 374);
            this.explainLabel.TabIndex = 0;
            this.explainLabel.Text = "label1";
            // 
            // Explain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SpaceGame.Properties.Resources.fundal1;
            this.ClientSize = new System.Drawing.Size(597, 450);
            this.Controls.Add(this.explainLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Explain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Explain";
            this.Load += new System.EventHandler(this.Explain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label explainLabel;
    }
}