
namespace SpaceGame
{
    partial class Game
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
            this.components = new System.ComponentModel.Container();
            this.upTimer = new System.Windows.Forms.Timer(this.components);
            this.downTimer = new System.Windows.Forms.Timer(this.components);
            this.rightTimer = new System.Windows.Forms.Timer(this.components);
            this.leftTimer = new System.Windows.Forms.Timer(this.components);
            this.controlButton = new System.Windows.Forms.Button();
            this.testMath = new System.Windows.Forms.PictureBox();
            this.downRoomEntrance = new System.Windows.Forms.PictureBox();
            this.rightRoomEntrance = new System.Windows.Forms.PictureBox();
            this.leftRoomEntrance = new System.Windows.Forms.PictureBox();
            this.upRoomEntrance = new System.Windows.Forms.PictureBox();
            this.character = new System.Windows.Forms.PictureBox();
            this.scoreBoard = new System.Windows.Forms.Label();
            this.testPhy = new System.Windows.Forms.PictureBox();
            this.testProg = new System.Windows.Forms.PictureBox();
            this.testChem = new System.Windows.Forms.PictureBox();
            this.rocket = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.testMath)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.downRoomEntrance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightRoomEntrance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftRoomEntrance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upRoomEntrance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.character)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testPhy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testProg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testChem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rocket)).BeginInit();
            this.SuspendLayout();
            // 
            // upTimer
            // 
            this.upTimer.Interval = 1;
            this.upTimer.Tick += new System.EventHandler(this.upTimer_Tick);
            // 
            // downTimer
            // 
            this.downTimer.Interval = 1;
            this.downTimer.Tick += new System.EventHandler(this.downTimer_Tick);
            // 
            // rightTimer
            // 
            this.rightTimer.Interval = 1;
            this.rightTimer.Tick += new System.EventHandler(this.rightTimer_Tick);
            // 
            // leftTimer
            // 
            this.leftTimer.Interval = 1;
            this.leftTimer.Tick += new System.EventHandler(this.leftTimer_Tick);
            // 
            // controlButton
            // 
            this.controlButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.controlButton.Enabled = false;
            this.controlButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.controlButton.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.controlButton.Location = new System.Drawing.Point(1565, 897);
            this.controlButton.Name = "controlButton";
            this.controlButton.Size = new System.Drawing.Size(268, 98);
            this.controlButton.TabIndex = 5;
            this.controlButton.Text = "Interactioneaza";
            this.controlButton.UseVisualStyleBackColor = false;
            this.controlButton.Click += new System.EventHandler(this.controlButton_Click);
            // 
            // testMath
            // 
            this.testMath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.testMath.Enabled = false;
            this.testMath.Location = new System.Drawing.Point(690, 279);
            this.testMath.Name = "testMath";
            this.testMath.Size = new System.Drawing.Size(100, 50);
            this.testMath.TabIndex = 6;
            this.testMath.TabStop = false;
            this.testMath.Tag = "Test";
            this.testMath.Visible = false;
            // 
            // downRoomEntrance
            // 
            this.downRoomEntrance.BackColor = System.Drawing.Color.Transparent;
            this.downRoomEntrance.BackgroundImage = global::SpaceGame.Properties.Resources.door2;
            this.downRoomEntrance.Image = global::SpaceGame.Properties.Resources.door2;
            this.downRoomEntrance.Location = new System.Drawing.Point(1168, 973);
            this.downRoomEntrance.Name = "downRoomEntrance";
            this.downRoomEntrance.Size = new System.Drawing.Size(201, 126);
            this.downRoomEntrance.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.downRoomEntrance.TabIndex = 4;
            this.downRoomEntrance.TabStop = false;
            this.downRoomEntrance.Tag = "Door";
            // 
            // rightRoomEntrance
            // 
            this.rightRoomEntrance.BackColor = System.Drawing.Color.Transparent;
            this.rightRoomEntrance.BackgroundImage = global::SpaceGame.Properties.Resources.door4;
            this.rightRoomEntrance.Location = new System.Drawing.Point(1591, 478);
            this.rightRoomEntrance.Name = "rightRoomEntrance";
            this.rightRoomEntrance.Size = new System.Drawing.Size(275, 201);
            this.rightRoomEntrance.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.rightRoomEntrance.TabIndex = 3;
            this.rightRoomEntrance.TabStop = false;
            this.rightRoomEntrance.Tag = "Door";
            // 
            // leftRoomEntrance
            // 
            this.leftRoomEntrance.BackColor = System.Drawing.Color.Transparent;
            this.leftRoomEntrance.BackgroundImage = global::SpaceGame.Properties.Resources.door5;
            this.leftRoomEntrance.Location = new System.Drawing.Point(-97, 521);
            this.leftRoomEntrance.Name = "leftRoomEntrance";
            this.leftRoomEntrance.Size = new System.Drawing.Size(275, 196);
            this.leftRoomEntrance.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.leftRoomEntrance.TabIndex = 2;
            this.leftRoomEntrance.TabStop = false;
            this.leftRoomEntrance.Tag = "Door";
            // 
            // upRoomEntrance
            // 
            this.upRoomEntrance.BackColor = System.Drawing.Color.Transparent;
            this.upRoomEntrance.Image = global::SpaceGame.Properties.Resources.door2;
            this.upRoomEntrance.Location = new System.Drawing.Point(849, 12);
            this.upRoomEntrance.Name = "upRoomEntrance";
            this.upRoomEntrance.Size = new System.Drawing.Size(203, 125);
            this.upRoomEntrance.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.upRoomEntrance.TabIndex = 1;
            this.upRoomEntrance.TabStop = false;
            this.upRoomEntrance.Tag = "Door";
            // 
            // character
            // 
            this.character.BackColor = System.Drawing.Color.Transparent;
            this.character.Image = global::SpaceGame.Properties.Resources.frontPosition;
            this.character.InitialImage = global::SpaceGame.Properties.Resources.frontPosition;
            this.character.Location = new System.Drawing.Point(926, 465);
            this.character.Name = "character";
            this.character.Size = new System.Drawing.Size(68, 146);
            this.character.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.character.TabIndex = 0;
            this.character.TabStop = false;
            this.character.LocationChanged += new System.EventHandler(this.character_LocationChanged);
            // 
            // scoreBoard
            // 
            this.scoreBoard.BackColor = System.Drawing.Color.Transparent;
            this.scoreBoard.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.scoreBoard.ForeColor = System.Drawing.Color.Red;
            this.scoreBoard.Location = new System.Drawing.Point(27, 11);
            this.scoreBoard.Name = "scoreBoard";
            this.scoreBoard.Size = new System.Drawing.Size(368, 38);
            this.scoreBoard.TabIndex = 7;
            this.scoreBoard.Text = "label1";
            // 
            // testPhy
            // 
            this.testPhy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.testPhy.Enabled = false;
            this.testPhy.Location = new System.Drawing.Point(170, 340);
            this.testPhy.Name = "testPhy";
            this.testPhy.Size = new System.Drawing.Size(100, 50);
            this.testPhy.TabIndex = 8;
            this.testPhy.TabStop = false;
            this.testPhy.Tag = "Test";
            this.testPhy.Visible = false;
            // 
            // testProg
            // 
            this.testProg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.testProg.Enabled = false;
            this.testProg.Location = new System.Drawing.Point(1514, 372);
            this.testProg.Name = "testProg";
            this.testProg.Size = new System.Drawing.Size(100, 50);
            this.testProg.TabIndex = 9;
            this.testProg.TabStop = false;
            this.testProg.Tag = "Test";
            this.testProg.Visible = false;
            // 
            // testChem
            // 
            this.testChem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.testChem.Enabled = false;
            this.testChem.Location = new System.Drawing.Point(849, 945);
            this.testChem.Name = "testChem";
            this.testChem.Size = new System.Drawing.Size(100, 50);
            this.testChem.TabIndex = 10;
            this.testChem.TabStop = false;
            this.testChem.Tag = "Test";
            this.testChem.Visible = false;
            // 
            // rocket
            // 
            this.rocket.BackColor = System.Drawing.Color.Transparent;
            this.rocket.BackgroundImage = global::SpaceGame.Properties.Resources.rocket1;
            this.rocket.Enabled = false;
            this.rocket.Location = new System.Drawing.Point(1375, 173);
            this.rocket.Name = "rocket";
            this.rocket.Size = new System.Drawing.Size(91, 109);
            this.rocket.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.rocket.TabIndex = 11;
            this.rocket.TabStop = false;
            this.rocket.Tag = "Rocket";
            this.rocket.Visible = false;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BackgroundImage = global::SpaceGame.Properties.Resources.map;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.character);
            this.Controls.Add(this.rocket);
            this.Controls.Add(this.testChem);
            this.Controls.Add(this.testProg);
            this.Controls.Add(this.testPhy);
            this.Controls.Add(this.scoreBoard);
            this.Controls.Add(this.testMath);
            this.Controls.Add(this.controlButton);
            this.Controls.Add(this.rightRoomEntrance);
            this.Controls.Add(this.leftRoomEntrance);
            this.Controls.Add(this.upRoomEntrance);
            this.Controls.Add(this.downRoomEntrance);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Game_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.testMath)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.downRoomEntrance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightRoomEntrance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftRoomEntrance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upRoomEntrance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.character)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testPhy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testProg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testChem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rocket)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox character;
        private System.Windows.Forms.PictureBox upRoomEntrance;
        private System.Windows.Forms.PictureBox leftRoomEntrance;
        private System.Windows.Forms.PictureBox rightRoomEntrance;
        private System.Windows.Forms.PictureBox downRoomEntrance;
        private System.Windows.Forms.Timer upTimer;
        private System.Windows.Forms.Timer downTimer;
        private System.Windows.Forms.Timer rightTimer;
        private System.Windows.Forms.Timer leftTimer;
        private System.Windows.Forms.Button controlButton;
        private System.Windows.Forms.PictureBox testMath;
        private System.Windows.Forms.Label scoreBoard;
        private System.Windows.Forms.PictureBox testPhy;
        private System.Windows.Forms.PictureBox testProg;
        private System.Windows.Forms.PictureBox testChem;
        private System.Windows.Forms.PictureBox rocket;
    }
}