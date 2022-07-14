
namespace SpaceGame
{
    partial class AdminSelect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminSelect));
            this.questionButton = new System.Windows.Forms.Button();
            this.materialsButton = new System.Windows.Forms.Button();
            this.statsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // questionButton
            // 
            this.questionButton.BackColor = System.Drawing.Color.Coral;
            this.questionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.questionButton.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.questionButton.Location = new System.Drawing.Point(169, 124);
            this.questionButton.Name = "questionButton";
            this.questionButton.Size = new System.Drawing.Size(283, 48);
            this.questionButton.TabIndex = 1;
            this.questionButton.Text = "Intrebari";
            this.questionButton.UseVisualStyleBackColor = false;
            this.questionButton.Click += new System.EventHandler(this.questionButton_Click);
            // 
            // materialsButton
            // 
            this.materialsButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.materialsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialsButton.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.materialsButton.Location = new System.Drawing.Point(169, 218);
            this.materialsButton.Name = "materialsButton";
            this.materialsButton.Size = new System.Drawing.Size(283, 48);
            this.materialsButton.TabIndex = 2;
            this.materialsButton.Text = "Materiale";
            this.materialsButton.UseVisualStyleBackColor = false;
            this.materialsButton.Click += new System.EventHandler(this.materialsButton_Click);
            // 
            // statsButton
            // 
            this.statsButton.BackColor = System.Drawing.Color.Coral;
            this.statsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statsButton.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.statsButton.Location = new System.Drawing.Point(169, 321);
            this.statsButton.Name = "statsButton";
            this.statsButton.Size = new System.Drawing.Size(283, 48);
            this.statsButton.TabIndex = 3;
            this.statsButton.Text = "Statistici";
            this.statsButton.UseVisualStyleBackColor = false;
            this.statsButton.Click += new System.EventHandler(this.statsButton_Click);
            // 
            // AdminSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SpaceGame.Properties.Resources.photoo;
            this.ClientSize = new System.Drawing.Size(622, 508);
            this.Controls.Add(this.statsButton);
            this.Controls.Add(this.materialsButton);
            this.Controls.Add(this.questionButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminSelect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meniu Administrator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button questionButton;
        private System.Windows.Forms.Button materialsButton;
        private System.Windows.Forms.Button statsButton;
    }
}