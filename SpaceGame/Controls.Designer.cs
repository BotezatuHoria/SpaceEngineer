
namespace SpaceGame
{
    partial class Controls
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Controls));
            this.upLabel = new System.Windows.Forms.Label();
            this.downLabel = new System.Windows.Forms.Label();
            this.leftLabel = new System.Windows.Forms.Label();
            this.rightLabel = new System.Windows.Forms.Label();
            this.interactLabel = new System.Windows.Forms.Label();
            this.closeLabel = new System.Windows.Forms.Label();
            this.upPic = new System.Windows.Forms.PictureBox();
            this.interactPic = new System.Windows.Forms.PictureBox();
            this.rightPic = new System.Windows.Forms.PictureBox();
            this.leftPic = new System.Windows.Forms.PictureBox();
            this.downPic = new System.Windows.Forms.PictureBox();
            this.closePic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.upPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.interactPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.downPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePic)).BeginInit();
            this.SuspendLayout();
            // 
            // upLabel
            // 
            this.upLabel.AutoSize = true;
            this.upLabel.BackColor = System.Drawing.Color.Transparent;
            this.upLabel.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.upLabel.ForeColor = System.Drawing.Color.White;
            this.upLabel.Location = new System.Drawing.Point(80, 75);
            this.upLabel.Name = "upLabel";
            this.upLabel.Size = new System.Drawing.Size(239, 32);
            this.upLabel.TabIndex = 0;
            this.upLabel.Text = "Mișcarea în sus";
            // 
            // downLabel
            // 
            this.downLabel.AutoSize = true;
            this.downLabel.BackColor = System.Drawing.Color.Transparent;
            this.downLabel.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.downLabel.ForeColor = System.Drawing.Color.White;
            this.downLabel.Location = new System.Drawing.Point(80, 144);
            this.downLabel.Name = "downLabel";
            this.downLabel.Size = new System.Drawing.Size(239, 32);
            this.downLabel.TabIndex = 1;
            this.downLabel.Text = "Mișcarea în jos";
            // 
            // leftLabel
            // 
            this.leftLabel.AutoSize = true;
            this.leftLabel.BackColor = System.Drawing.Color.Transparent;
            this.leftLabel.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.leftLabel.ForeColor = System.Drawing.Color.White;
            this.leftLabel.Location = new System.Drawing.Point(80, 206);
            this.leftLabel.Name = "leftLabel";
            this.leftLabel.Size = new System.Drawing.Size(284, 32);
            this.leftLabel.TabIndex = 2;
            this.leftLabel.Text = "Mișcarea în stânga";
            // 
            // rightLabel
            // 
            this.rightLabel.AutoSize = true;
            this.rightLabel.BackColor = System.Drawing.Color.Transparent;
            this.rightLabel.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rightLabel.ForeColor = System.Drawing.Color.White;
            this.rightLabel.Location = new System.Drawing.Point(80, 277);
            this.rightLabel.Name = "rightLabel";
            this.rightLabel.Size = new System.Drawing.Size(299, 32);
            this.rightLabel.TabIndex = 3;
            this.rightLabel.Text = "Mișcarea în dreapta";
            // 
            // interactLabel
            // 
            this.interactLabel.AutoSize = true;
            this.interactLabel.BackColor = System.Drawing.Color.Transparent;
            this.interactLabel.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.interactLabel.ForeColor = System.Drawing.Color.White;
            this.interactLabel.Location = new System.Drawing.Point(80, 345);
            this.interactLabel.Name = "interactLabel";
            this.interactLabel.Size = new System.Drawing.Size(404, 32);
            this.interactLabel.TabIndex = 4;
            this.interactLabel.Text = "Interacțiunea cu obiectele";
            // 
            // closeLabel
            // 
            this.closeLabel.AutoSize = true;
            this.closeLabel.BackColor = System.Drawing.Color.Transparent;
            this.closeLabel.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.closeLabel.ForeColor = System.Drawing.Color.White;
            this.closeLabel.Location = new System.Drawing.Point(80, 417);
            this.closeLabel.Name = "closeLabel";
            this.closeLabel.Size = new System.Drawing.Size(284, 32);
            this.closeLabel.TabIndex = 5;
            this.closeLabel.Text = "Închiderea jocului";
            // 
            // upPic
            // 
            this.upPic.BackColor = System.Drawing.Color.Transparent;
            this.upPic.Image = global::SpaceGame.Properties.Resources.icons8_w_key_48;
            this.upPic.Location = new System.Drawing.Point(351, 75);
            this.upPic.Name = "upPic";
            this.upPic.Size = new System.Drawing.Size(48, 48);
            this.upPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.upPic.TabIndex = 6;
            this.upPic.TabStop = false;
            // 
            // interactPic
            // 
            this.interactPic.BackColor = System.Drawing.Color.Transparent;
            this.interactPic.Image = global::SpaceGame.Properties.Resources.icons8_e_key_48;
            this.interactPic.Location = new System.Drawing.Point(500, 345);
            this.interactPic.Name = "interactPic";
            this.interactPic.Size = new System.Drawing.Size(48, 48);
            this.interactPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.interactPic.TabIndex = 7;
            this.interactPic.TabStop = false;
            // 
            // rightPic
            // 
            this.rightPic.BackColor = System.Drawing.Color.Transparent;
            this.rightPic.Image = global::SpaceGame.Properties.Resources.icons8_d_key_48;
            this.rightPic.Location = new System.Drawing.Point(395, 277);
            this.rightPic.Name = "rightPic";
            this.rightPic.Size = new System.Drawing.Size(48, 48);
            this.rightPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.rightPic.TabIndex = 8;
            this.rightPic.TabStop = false;
            // 
            // leftPic
            // 
            this.leftPic.BackColor = System.Drawing.Color.Transparent;
            this.leftPic.Image = global::SpaceGame.Properties.Resources.icons8_a_key_48;
            this.leftPic.Location = new System.Drawing.Point(395, 203);
            this.leftPic.Name = "leftPic";
            this.leftPic.Size = new System.Drawing.Size(48, 48);
            this.leftPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.leftPic.TabIndex = 9;
            this.leftPic.TabStop = false;
            // 
            // downPic
            // 
            this.downPic.BackColor = System.Drawing.Color.Transparent;
            this.downPic.Image = global::SpaceGame.Properties.Resources.icons8_s_key_48;
            this.downPic.Location = new System.Drawing.Point(351, 136);
            this.downPic.Name = "downPic";
            this.downPic.Size = new System.Drawing.Size(48, 48);
            this.downPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.downPic.TabIndex = 10;
            this.downPic.TabStop = false;
            // 
            // closePic
            // 
            this.closePic.BackColor = System.Drawing.Color.Transparent;
            this.closePic.Image = global::SpaceGame.Properties.Resources.icons8_esc_48;
            this.closePic.Location = new System.Drawing.Point(395, 417);
            this.closePic.Name = "closePic";
            this.closePic.Size = new System.Drawing.Size(48, 48);
            this.closePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.closePic.TabIndex = 11;
            this.closePic.TabStop = false;
            // 
            // Controls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SpaceGame.Properties.Resources.Black_Sky_Galaxy_Stars_Desktop_Wallpaper;
            this.ClientSize = new System.Drawing.Size(626, 525);
            this.Controls.Add(this.closePic);
            this.Controls.Add(this.downPic);
            this.Controls.Add(this.leftPic);
            this.Controls.Add(this.rightPic);
            this.Controls.Add(this.interactPic);
            this.Controls.Add(this.upPic);
            this.Controls.Add(this.closeLabel);
            this.Controls.Add(this.interactLabel);
            this.Controls.Add(this.rightLabel);
            this.Controls.Add(this.leftLabel);
            this.Controls.Add(this.downLabel);
            this.Controls.Add(this.upLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Controls";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controale";
            ((System.ComponentModel.ISupportInitialize)(this.upPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.interactPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.downPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label upLabel;
        private System.Windows.Forms.Label downLabel;
        private System.Windows.Forms.Label leftLabel;
        private System.Windows.Forms.Label rightLabel;
        private System.Windows.Forms.Label interactLabel;
        private System.Windows.Forms.Label closeLabel;
        private System.Windows.Forms.PictureBox upPic;
        private System.Windows.Forms.PictureBox interactPic;
        private System.Windows.Forms.PictureBox rightPic;
        private System.Windows.Forms.PictureBox leftPic;
        private System.Windows.Forms.PictureBox downPic;
        private System.Windows.Forms.PictureBox closePic;
    }
}