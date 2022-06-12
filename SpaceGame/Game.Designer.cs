
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
            this.colBoxChem1 = new System.Windows.Forms.PictureBox();
            this.colBoxChem2 = new System.Windows.Forms.PictureBox();
            this.colBoxChem3 = new System.Windows.Forms.PictureBox();
            this.colBoxProg1 = new System.Windows.Forms.PictureBox();
            this.colBoxProg2 = new System.Windows.Forms.PictureBox();
            this.colBoxProg3 = new System.Windows.Forms.PictureBox();
            this.colBoxPhy5 = new System.Windows.Forms.PictureBox();
            this.colBoxPhy6 = new System.Windows.Forms.PictureBox();
            this.colBoxPhy1 = new System.Windows.Forms.PictureBox();
            this.colBoxPhy2 = new System.Windows.Forms.PictureBox();
            this.colBoxPhy3 = new System.Windows.Forms.PictureBox();
            this.colBoxPhy4 = new System.Windows.Forms.PictureBox();
            this.colBoxMath2 = new System.Windows.Forms.PictureBox();
            this.colBoxMath1 = new System.Windows.Forms.PictureBox();
            this.colBoxMath3 = new System.Windows.Forms.PictureBox();
            this.rocketLabel = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.colBoxChem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colBoxChem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colBoxChem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colBoxProg1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colBoxProg2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colBoxProg3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colBoxPhy5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colBoxPhy6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colBoxPhy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colBoxPhy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colBoxPhy3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colBoxPhy4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colBoxMath2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colBoxMath1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colBoxMath3)).BeginInit();
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
            this.character.Location = new System.Drawing.Point(938, 452);
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
            this.testPhy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.testPhy.Enabled = false;
            this.testPhy.Location = new System.Drawing.Point(231, 478);
            this.testPhy.Name = "testPhy";
            this.testPhy.Size = new System.Drawing.Size(164, 201);
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
            // colBoxChem1
            // 
            this.colBoxChem1.Enabled = false;
            this.colBoxChem1.Location = new System.Drawing.Point(135, 121);
            this.colBoxChem1.Name = "colBoxChem1";
            this.colBoxChem1.Size = new System.Drawing.Size(531, 45);
            this.colBoxChem1.TabIndex = 13;
            this.colBoxChem1.TabStop = false;
            this.colBoxChem1.Visible = false;
            // 
            // colBoxChem2
            // 
            this.colBoxChem2.Enabled = false;
            this.colBoxChem2.Location = new System.Drawing.Point(1151, 438);
            this.colBoxChem2.Name = "colBoxChem2";
            this.colBoxChem2.Size = new System.Drawing.Size(614, 34);
            this.colBoxChem2.TabIndex = 14;
            this.colBoxChem2.TabStop = false;
            this.colBoxChem2.Visible = false;
            // 
            // colBoxChem3
            // 
            this.colBoxChem3.Enabled = false;
            this.colBoxChem3.Location = new System.Drawing.Point(193, 767);
            this.colBoxChem3.Name = "colBoxChem3";
            this.colBoxChem3.Size = new System.Drawing.Size(531, 36);
            this.colBoxChem3.TabIndex = 15;
            this.colBoxChem3.TabStop = false;
            this.colBoxChem3.Visible = false;
            // 
            // colBoxProg1
            // 
            this.colBoxProg1.Enabled = false;
            this.colBoxProg1.Location = new System.Drawing.Point(711, 247);
            this.colBoxProg1.Name = "colBoxProg1";
            this.colBoxProg1.Size = new System.Drawing.Size(690, 50);
            this.colBoxProg1.TabIndex = 16;
            this.colBoxProg1.TabStop = false;
            this.colBoxProg1.Visible = false;
            // 
            // colBoxProg2
            // 
            this.colBoxProg2.Enabled = false;
            this.colBoxProg2.Location = new System.Drawing.Point(711, 478);
            this.colBoxProg2.Name = "colBoxProg2";
            this.colBoxProg2.Size = new System.Drawing.Size(690, 50);
            this.colBoxProg2.TabIndex = 17;
            this.colBoxProg2.TabStop = false;
            this.colBoxProg2.Visible = false;
            // 
            // colBoxProg3
            // 
            this.colBoxProg3.Enabled = false;
            this.colBoxProg3.Location = new System.Drawing.Point(711, 739);
            this.colBoxProg3.Name = "colBoxProg3";
            this.colBoxProg3.Size = new System.Drawing.Size(690, 50);
            this.colBoxProg3.TabIndex = 18;
            this.colBoxProg3.TabStop = false;
            this.colBoxProg3.Visible = false;
            // 
            // colBoxPhy5
            // 
            this.colBoxPhy5.Enabled = false;
            this.colBoxPhy5.Location = new System.Drawing.Point(176, 172);
            this.colBoxPhy5.Name = "colBoxPhy5";
            this.colBoxPhy5.Size = new System.Drawing.Size(219, 226);
            this.colBoxPhy5.TabIndex = 19;
            this.colBoxPhy5.TabStop = false;
            this.colBoxPhy5.Visible = false;
            // 
            // colBoxPhy6
            // 
            this.colBoxPhy6.Enabled = false;
            this.colBoxPhy6.Location = new System.Drawing.Point(193, 767);
            this.colBoxPhy6.Name = "colBoxPhy6";
            this.colBoxPhy6.Size = new System.Drawing.Size(219, 226);
            this.colBoxPhy6.TabIndex = 20;
            this.colBoxPhy6.TabStop = false;
            this.colBoxPhy6.Visible = false;
            // 
            // colBoxPhy1
            // 
            this.colBoxPhy1.Enabled = false;
            this.colBoxPhy1.Location = new System.Drawing.Point(585, 834);
            this.colBoxPhy1.Name = "colBoxPhy1";
            this.colBoxPhy1.Size = new System.Drawing.Size(719, 23);
            this.colBoxPhy1.TabIndex = 21;
            this.colBoxPhy1.TabStop = false;
            this.colBoxPhy1.Visible = false;
            // 
            // colBoxPhy2
            // 
            this.colBoxPhy2.Enabled = false;
            this.colBoxPhy2.Location = new System.Drawing.Point(585, 595);
            this.colBoxPhy2.Name = "colBoxPhy2";
            this.colBoxPhy2.Size = new System.Drawing.Size(719, 23);
            this.colBoxPhy2.TabIndex = 22;
            this.colBoxPhy2.TabStop = false;
            this.colBoxPhy2.Visible = false;
            // 
            // colBoxPhy3
            // 
            this.colBoxPhy3.Enabled = false;
            this.colBoxPhy3.Location = new System.Drawing.Point(585, 357);
            this.colBoxPhy3.Name = "colBoxPhy3";
            this.colBoxPhy3.Size = new System.Drawing.Size(719, 23);
            this.colBoxPhy3.TabIndex = 23;
            this.colBoxPhy3.TabStop = false;
            this.colBoxPhy3.Visible = false;
            // 
            // colBoxPhy4
            // 
            this.colBoxPhy4.Enabled = false;
            this.colBoxPhy4.Location = new System.Drawing.Point(598, 143);
            this.colBoxPhy4.Name = "colBoxPhy4";
            this.colBoxPhy4.Size = new System.Drawing.Size(719, 23);
            this.colBoxPhy4.TabIndex = 24;
            this.colBoxPhy4.TabStop = false;
            this.colBoxPhy4.Visible = false;
            // 
            // colBoxMath2
            // 
            this.colBoxMath2.Enabled = false;
            this.colBoxMath2.Location = new System.Drawing.Point(417, 575);
            this.colBoxMath2.Name = "colBoxMath2";
            this.colBoxMath2.Size = new System.Drawing.Size(1066, 23);
            this.colBoxMath2.TabIndex = 25;
            this.colBoxMath2.TabStop = false;
            this.colBoxMath2.Visible = false;
            // 
            // colBoxMath1
            // 
            this.colBoxMath1.Enabled = false;
            this.colBoxMath1.Location = new System.Drawing.Point(417, 753);
            this.colBoxMath1.Name = "colBoxMath1";
            this.colBoxMath1.Size = new System.Drawing.Size(1066, 23);
            this.colBoxMath1.TabIndex = 26;
            this.colBoxMath1.TabStop = false;
            this.colBoxMath1.Visible = false;
            // 
            // colBoxMath3
            // 
            this.colBoxMath3.Enabled = false;
            this.colBoxMath3.Location = new System.Drawing.Point(417, 400);
            this.colBoxMath3.Name = "colBoxMath3";
            this.colBoxMath3.Size = new System.Drawing.Size(1066, 23);
            this.colBoxMath3.TabIndex = 27;
            this.colBoxMath3.TabStop = false;
            this.colBoxMath3.Visible = false;
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
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BackgroundImage = global::SpaceGame.Properties.Resources.map;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.rocketLabel);
            this.Controls.Add(this.colBoxMath3);
            this.Controls.Add(this.colBoxMath1);
            this.Controls.Add(this.colBoxMath2);
            this.Controls.Add(this.colBoxPhy4);
            this.Controls.Add(this.colBoxPhy3);
            this.Controls.Add(this.colBoxPhy2);
            this.Controls.Add(this.colBoxPhy1);
            this.Controls.Add(this.colBoxPhy6);
            this.Controls.Add(this.colBoxPhy5);
            this.Controls.Add(this.colBoxProg3);
            this.Controls.Add(this.colBoxProg2);
            this.Controls.Add(this.colBoxProg1);
            this.Controls.Add(this.colBoxChem3);
            this.Controls.Add(this.colBoxChem2);
            this.Controls.Add(this.colBoxChem1);
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
            ((System.ComponentModel.ISupportInitialize)(this.colBoxChem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colBoxChem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colBoxChem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colBoxProg1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colBoxProg2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colBoxProg3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colBoxPhy5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colBoxPhy6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colBoxPhy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colBoxPhy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colBoxPhy3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colBoxPhy4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colBoxMath2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colBoxMath1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colBoxMath3)).EndInit();
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
        private System.Windows.Forms.PictureBox colBoxChem1;
        private System.Windows.Forms.PictureBox colBoxChem2;
        private System.Windows.Forms.PictureBox colBoxChem3;
        private System.Windows.Forms.PictureBox colBoxProg1;
        private System.Windows.Forms.PictureBox colBoxProg2;
        private System.Windows.Forms.PictureBox colBoxProg3;
        private System.Windows.Forms.PictureBox colBoxPhy5;
        private System.Windows.Forms.PictureBox colBoxPhy6;
        private System.Windows.Forms.PictureBox colBoxPhy1;
        private System.Windows.Forms.PictureBox colBoxPhy2;
        private System.Windows.Forms.PictureBox colBoxPhy3;
        private System.Windows.Forms.PictureBox colBoxPhy4;
        private System.Windows.Forms.PictureBox colBoxMath2;
        private System.Windows.Forms.PictureBox colBoxMath1;
        private System.Windows.Forms.PictureBox colBoxMath3;
        private System.Windows.Forms.Label rocketLabel;
    }
}