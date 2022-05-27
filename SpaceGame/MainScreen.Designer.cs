
namespace SpaceGame
{
    partial class MainScreen
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
            this.startButton = new System.Windows.Forms.Button();
            this.optionsButtons = new System.Windows.Forms.Button();
            this.statsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.Gold;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.startButton.Location = new System.Drawing.Point(153, 104);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(283, 48);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // optionsButtons
            // 
            this.optionsButtons.BackColor = System.Drawing.Color.Gold;
            this.optionsButtons.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.optionsButtons.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.optionsButtons.Location = new System.Drawing.Point(153, 200);
            this.optionsButtons.Name = "optionsButtons";
            this.optionsButtons.Size = new System.Drawing.Size(283, 48);
            this.optionsButtons.TabIndex = 1;
            this.optionsButtons.Text = "Optiuni";
            this.optionsButtons.UseVisualStyleBackColor = false;
            // 
            // statsButton
            // 
            this.statsButton.BackColor = System.Drawing.Color.Gold;
            this.statsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statsButton.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.statsButton.Location = new System.Drawing.Point(153, 292);
            this.statsButton.Name = "statsButton";
            this.statsButton.Size = new System.Drawing.Size(283, 48);
            this.statsButton.TabIndex = 2;
            this.statsButton.Text = "Statistici";
            this.statsButton.UseVisualStyleBackColor = false;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SpaceGame.Properties.Resources.fundal1;
            this.ClientSize = new System.Drawing.Size(588, 450);
            this.Controls.Add(this.statsButton);
            this.Controls.Add(this.optionsButtons);
            this.Controls.Add(this.startButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ecran Principal";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button optionsButtons;
        private System.Windows.Forms.Button statsButton;
    }
}