
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.startButton = new System.Windows.Forms.Button();
            this.statsButton = new System.Windows.Forms.Button();
            this.storyButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.controlsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.Transparent;
            this.startButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.startButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.startButton.Location = new System.Drawing.Point(400, 58);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(301, 101);
            this.startButton.TabIndex = 0;
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // statsButton
            // 
            this.statsButton.BackColor = System.Drawing.Color.Transparent;
            this.statsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.statsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.statsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statsButton.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.statsButton.Location = new System.Drawing.Point(400, 328);
            this.statsButton.Name = "statsButton";
            this.statsButton.Size = new System.Drawing.Size(301, 100);
            this.statsButton.TabIndex = 2;
            this.statsButton.UseVisualStyleBackColor = false;
            this.statsButton.Click += new System.EventHandler(this.statsButton_Click);
            // 
            // storyButton
            // 
            this.storyButton.BackColor = System.Drawing.Color.Transparent;
            this.storyButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.storyButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.storyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.storyButton.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.storyButton.Location = new System.Drawing.Point(400, 189);
            this.storyButton.Name = "storyButton";
            this.storyButton.Size = new System.Drawing.Size(301, 105);
            this.storyButton.TabIndex = 1;
            this.storyButton.UseVisualStyleBackColor = false;
            this.storyButton.Click += new System.EventHandler(this.storyButton_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.BackColor = System.Drawing.Color.Transparent;
            this.settingsButton.Enabled = false;
            this.settingsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.settingsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.settingsButton.Location = new System.Drawing.Point(775, 474);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(304, 98);
            this.settingsButton.TabIndex = 4;
            this.settingsButton.UseVisualStyleBackColor = false;
            this.settingsButton.Visible = false;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // controlsButton
            // 
            this.controlsButton.BackColor = System.Drawing.Color.Transparent;
            this.controlsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.controlsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.controlsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.controlsButton.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.controlsButton.Location = new System.Drawing.Point(400, 474);
            this.controlsButton.Name = "controlsButton";
            this.controlsButton.Size = new System.Drawing.Size(301, 98);
            this.controlsButton.TabIndex = 3;
            this.controlsButton.UseVisualStyleBackColor = false;
            this.controlsButton.Click += new System.EventHandler(this.controlsButton_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SpaceGame.Properties.Resources.Start;
            this.ClientSize = new System.Drawing.Size(1091, 619);
            this.Controls.Add(this.controlsButton);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.storyButton);
            this.Controls.Add(this.statsButton);
            this.Controls.Add(this.startButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ecran Principal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainScreen_FormClosed);
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button statsButton;
        private System.Windows.Forms.Button storyButton;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button controlsButton;
    }
}