
namespace SpaceGame
{
    partial class Ending
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ending));
            this.endText = new System.Windows.Forms.Label();
            this.shutDownLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // endText
            // 
            this.endText.BackColor = System.Drawing.Color.Transparent;
            this.endText.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.endText.ForeColor = System.Drawing.Color.White;
            this.endText.Location = new System.Drawing.Point(53, 95);
            this.endText.Name = "endText";
            this.endText.Size = new System.Drawing.Size(491, 202);
            this.endText.TabIndex = 0;
            this.endText.Text = "label1";
            this.endText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // shutDownLabel
            // 
            this.shutDownLabel.BackColor = System.Drawing.Color.Transparent;
            this.shutDownLabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.shutDownLabel.ForeColor = System.Drawing.Color.White;
            this.shutDownLabel.Location = new System.Drawing.Point(63, 323);
            this.shutDownLabel.Name = "shutDownLabel";
            this.shutDownLabel.Size = new System.Drawing.Size(471, 79);
            this.shutDownLabel.TabIndex = 1;
            this.shutDownLabel.Text = "label1";
            this.shutDownLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Ending
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SpaceGame.Properties.Resources.fundal1;
            this.ClientSize = new System.Drawing.Size(594, 450);
            this.Controls.Add(this.shutDownLabel);
            this.Controls.Add(this.endText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Ending";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ending";
            this.Load += new System.EventHandler(this.Ending_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label endText;
        private System.Windows.Forms.Label shutDownLabel;
    }
}