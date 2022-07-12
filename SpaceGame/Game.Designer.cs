
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
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
            this.elevator = new System.Windows.Forms.PictureBox();
            this.rocketLabel = new System.Windows.Forms.Label();
            this.reactor1 = new System.Windows.Forms.PictureBox();
            this.reactor2 = new System.Windows.Forms.PictureBox();
            this.reactor3 = new System.Windows.Forms.PictureBox();
            this.comp1 = new System.Windows.Forms.PictureBox();
            this.learnPhy = new System.Windows.Forms.PictureBox();
            this.comp3 = new System.Windows.Forms.PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.elevator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reactor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reactor2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reactor3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comp1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.learnPhy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comp3)).BeginInit();
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
            this.controlButton.BackColor = System.Drawing.Color.Aqua;
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
            this.testMath.BackColor = System.Drawing.Color.Transparent;
            this.testMath.Enabled = false;
            this.testMath.Image = global::SpaceGame.Properties.Resources.blackboard1;
            this.testMath.Location = new System.Drawing.Point(822, 36);
            this.testMath.Name = "testMath";
            this.testMath.Size = new System.Drawing.Size(300, 154);
            this.testMath.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
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
            this.character.Location = new System.Drawing.Point(924, 452);
            this.character.Name = "character";
            this.character.Size = new System.Drawing.Size(68, 146);
            this.character.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.character.TabIndex = 0;
            this.character.TabStop = false;
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
            this.testPhy.BackColor = System.Drawing.Color.Transparent;
            this.testPhy.Enabled = false;
            this.testPhy.Image = global::SpaceGame.Properties.Resources.reactor;
            this.testPhy.Location = new System.Drawing.Point(210, 152);
            this.testPhy.Name = "testPhy";
            this.testPhy.Size = new System.Drawing.Size(209, 218);
            this.testPhy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.testPhy.TabIndex = 8;
            this.testPhy.TabStop = false;
            this.testPhy.Tag = "Test";
            this.testPhy.Visible = false;
            // 
            // testProg
            // 
            this.testProg.BackColor = System.Drawing.Color.Transparent;
            this.testProg.Enabled = false;
            this.testProg.Image = global::SpaceGame.Properties.Resources.computer;
            this.testProg.Location = new System.Drawing.Point(1301, 767);
            this.testProg.Name = "testProg";
            this.testProg.Size = new System.Drawing.Size(100, 90);
            this.testProg.TabIndex = 9;
            this.testProg.TabStop = false;
            this.testProg.Tag = "Test";
            this.testProg.Visible = false;
            // 
            // testChem
            // 
            this.testChem.BackColor = System.Drawing.Color.Transparent;
            this.testChem.Enabled = false;
            this.testChem.Image = global::SpaceGame.Properties.Resources.chimstand;
            this.testChem.Location = new System.Drawing.Point(1151, 478);
            this.testChem.Name = "testChem";
            this.testChem.Size = new System.Drawing.Size(229, 95);
            this.testChem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
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
            this.rocket.Location = new System.Drawing.Point(1194, 795);
            this.rocket.Name = "rocket";
            this.rocket.Size = new System.Drawing.Size(91, 109);
            this.rocket.TabIndex = 11;
            this.rocket.TabStop = false;
            this.rocket.Tag = "Rocket";
            this.rocket.Visible = false;
            // 
            // elevator
            // 
            this.elevator.BackColor = System.Drawing.Color.Transparent;
            this.elevator.Enabled = false;
            this.elevator.Image = global::SpaceGame.Properties.Resources.elevator2;
            this.elevator.Location = new System.Drawing.Point(864, 376);
            this.elevator.Name = "elevator";
            this.elevator.Size = new System.Drawing.Size(188, 222);
            this.elevator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.elevator.TabIndex = 12;
            this.elevator.TabStop = false;
            this.elevator.Tag = "Elevator";
            this.elevator.Visible = false;
            // 
            // rocketLabel
            // 
            this.rocketLabel.BackColor = System.Drawing.Color.Transparent;
            this.rocketLabel.Font = new System.Drawing.Font("Consolas", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rocketLabel.ForeColor = System.Drawing.Color.Yellow;
            this.rocketLabel.Location = new System.Drawing.Point(360, 11);
            this.rocketLabel.Name = "rocketLabel";
            this.rocketLabel.Size = new System.Drawing.Size(1337, 69);
            this.rocketLabel.TabIndex = 28;
            this.rocketLabel.Text = "Verifica racheta!";
            this.rocketLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rocketLabel.Visible = false;
            // 
            // reactor1
            // 
            this.reactor1.BackColor = System.Drawing.Color.Transparent;
            this.reactor1.Enabled = false;
            this.reactor1.Image = global::SpaceGame.Properties.Resources.reactor;
            this.reactor1.Location = new System.Drawing.Point(535, 356);
            this.reactor1.Name = "reactor1";
            this.reactor1.Size = new System.Drawing.Size(209, 217);
            this.reactor1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.reactor1.TabIndex = 29;
            this.reactor1.TabStop = false;
            this.reactor1.Visible = false;
            this.reactor1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // reactor2
            // 
            this.reactor2.BackColor = System.Drawing.Color.Transparent;
            this.reactor2.Enabled = false;
            this.reactor2.Image = global::SpaceGame.Properties.Resources.reactor;
            this.reactor2.Location = new System.Drawing.Point(210, 539);
            this.reactor2.Name = "reactor2";
            this.reactor2.Size = new System.Drawing.Size(209, 218);
            this.reactor2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.reactor2.TabIndex = 30;
            this.reactor2.TabStop = false;
            this.reactor2.Visible = false;
            // 
            // reactor3
            // 
            this.reactor3.BackColor = System.Drawing.Color.Transparent;
            this.reactor3.Enabled = false;
            this.reactor3.Image = global::SpaceGame.Properties.Resources.reactor;
            this.reactor3.Location = new System.Drawing.Point(535, 767);
            this.reactor3.Name = "reactor3";
            this.reactor3.Size = new System.Drawing.Size(209, 218);
            this.reactor3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.reactor3.TabIndex = 31;
            this.reactor3.TabStop = false;
            this.reactor3.Visible = false;
            // 
            // comp1
            // 
            this.comp1.Enabled = false;
            this.comp1.Image = global::SpaceGame.Properties.Resources.physet;
            this.comp1.Location = new System.Drawing.Point(998, 365);
            this.comp1.Name = "comp1";
            this.comp1.Size = new System.Drawing.Size(494, 145);
            this.comp1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.comp1.TabIndex = 32;
            this.comp1.TabStop = false;
            this.comp1.Visible = false;
            // 
            // learnPhy
            // 
            this.learnPhy.BackColor = System.Drawing.Color.Transparent;
            this.learnPhy.Enabled = false;
            this.learnPhy.Image = global::SpaceGame.Properties.Resources.whiteboard_fiz;
            this.learnPhy.Location = new System.Drawing.Point(998, 0);
            this.learnPhy.Name = "learnPhy";
            this.learnPhy.Size = new System.Drawing.Size(452, 137);
            this.learnPhy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.learnPhy.TabIndex = 33;
            this.learnPhy.TabStop = false;
            this.learnPhy.Tag = "Learn";
            this.learnPhy.Visible = false;
            // 
            // comp3
            // 
            this.comp3.Enabled = false;
            this.comp3.Image = global::SpaceGame.Properties.Resources.physet;
            this.comp3.Location = new System.Drawing.Point(998, 712);
            this.comp3.Name = "comp3";
            this.comp3.Size = new System.Drawing.Size(494, 145);
            this.comp3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.comp3.TabIndex = 35;
            this.comp3.TabStop = false;
            this.comp3.Visible = false;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BackgroundImage = global::SpaceGame.Properties.Resources.rightroom;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.comp3);
            this.Controls.Add(this.comp1);
            this.Controls.Add(this.reactor3);
            this.Controls.Add(this.reactor2);
            this.Controls.Add(this.reactor1);
            this.Controls.Add(this.rocketLabel);
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
            this.Controls.Add(this.elevator);
            this.Controls.Add(this.learnPhy);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Game_FormClosed);
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
            ((System.ComponentModel.ISupportInitialize)(this.elevator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reactor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reactor2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reactor3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comp1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.learnPhy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comp3)).EndInit();
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
        private System.Windows.Forms.PictureBox elevator;
        private System.Windows.Forms.Label rocketLabel;
        private System.Windows.Forms.PictureBox reactor1;
        private System.Windows.Forms.PictureBox reactor2;
        private System.Windows.Forms.PictureBox reactor3;
        private System.Windows.Forms.PictureBox comp1;
        private System.Windows.Forms.PictureBox learnPhy;
        private System.Windows.Forms.PictureBox comp3;
    }
}