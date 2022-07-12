
namespace SpaceGame
{
    partial class Intro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Intro));
            this.storyLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // storyLabel
            // 
            this.storyLabel.BackColor = System.Drawing.Color.Transparent;
            this.storyLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.storyLabel.ForeColor = System.Drawing.Color.White;
            this.storyLabel.Location = new System.Drawing.Point(56, 34);
            this.storyLabel.Name = "storyLabel";
            this.storyLabel.Size = new System.Drawing.Size(583, 468);
            this.storyLabel.TabIndex = 3;
            this.storyLabel.Text = "label1";
            this.storyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Intro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SpaceGame.Properties.Resources.photoo;
            this.ClientSize = new System.Drawing.Size(676, 537);
            this.Controls.Add(this.storyLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Intro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Intro";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Intro_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label storyLabel;
    }
}