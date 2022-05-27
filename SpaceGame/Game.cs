using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceGame
{
    public partial class Game : Form
    {

        public int newX = 0;
        public int newY = 0;
        public const int pxlMoveX = 2;
        public const int pxlMoveY = 2;
        public List<PictureBox> lst;
        bool inroom = false;
        public int scr = 2;
        bool roomMath = false;
        bool roomPhy = false;
        bool roomProg = false;
        bool roomChem = false;
        string x = null;
        bool ok = false;
        public int pointsCount = 20;

        public Game()
        {
            using (StreamWriter writetext = new StreamWriter("score.txt"))
            {
                writetext.WriteLine("0");
            }
            
            InitializeComponent();
            scoreBoard.Text = "Score: 0/20";
        }

        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                upTimer.Enabled = true;
            }
            if (e.KeyCode == Keys.S)
            {
                downTimer.Enabled = true;
            }
            if (e.KeyCode == Keys.A)
            {
                leftTimer.Enabled = true;
            }
            if (e.KeyCode == Keys.D)
            {
                rightTimer.Enabled = true;
            }
            e.SuppressKeyPress = true;
            controlButton.Enabled = false;
        }

        private void Game_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                upTimer.Enabled = false;
            }
            if (e.KeyCode == Keys.S)
            {
                downTimer.Enabled = false;
            }
            if (e.KeyCode == Keys.A)
            {
                leftTimer.Enabled = false;
            }
            if (e.KeyCode == Keys.D)
            {
                rightTimer.Enabled = false;
            }
        }

        private void upTimer_Tick(object sender, EventArgs e)
        {
            if (character.Location.Y > 150)
            {
                newY = character.Location.Y - pxlMoveY;
                character.Location = new Point(character.Location.X, newY);
                if (Interaction(character, upRoomEntrance) == "Door")
                    controlButton.Enabled = true;
                if (Interaction(character, downRoomEntrance) == "Door")
                    controlButton.Enabled = true;
                if (Interaction(character, leftRoomEntrance) == "Door")
                    controlButton.Enabled = true; 
                if (Interaction(character, rightRoomEntrance) == "Door")
                    controlButton.Enabled = true;
                if (Interaction(character, testMath) == "Test")
                    controlButton.Enabled = true;
                if (Interaction(character, testPhy) == "Test")
                    controlButton.Enabled = true;
                if (Interaction(character, testProg) == "Test")
                    controlButton.Enabled = true;
                if (Interaction(character, testChem) == "Test")
                    controlButton.Enabled = true;
                if (Interaction(character, rocket) == "Rocket")
                    controlButton.Enabled = true;
            }
        }

        private void downTimer_Tick(object sender, EventArgs e)
        {
            if (character.Location.Y < this.Height - 250)
            {
                newY = character.Location.Y + pxlMoveY;
                character.Location = new Point(character.Location.X, newY);
                if (Interaction(character, upRoomEntrance) == "Door")
                    controlButton.Enabled = true;
                if (Interaction(character, downRoomEntrance) == "Door")
                    controlButton.Enabled = true;
                if (Interaction(character, leftRoomEntrance) == "Door")
                    controlButton.Enabled = true;
                if (Interaction(character, rightRoomEntrance) == "Door")
                    controlButton.Enabled = true;
                if (Interaction(character, testMath) == "Test")
                    controlButton.Enabled = true;
                if (Interaction(character, testPhy) == "Test")
                    controlButton.Enabled = true;
                if (Interaction(character, testProg) == "Test")
                    controlButton.Enabled = true;
                if (Interaction(character, testChem) == "Test")
                    controlButton.Enabled = true;
                if (Interaction(character, rocket) == "Rocket")
                    controlButton.Enabled = true;
            }
        }

        private void rightTimer_Tick(object sender, EventArgs e)
        {
            if (character.Location.X < this.Width - 250)
            {
                newX = character.Location.X + pxlMoveX;
                character.Location = new Point(newX, character.Location.Y);
                if (Interaction(character, upRoomEntrance) == "Door")
                    controlButton.Enabled = true;
                if (Interaction(character, downRoomEntrance) == "Door")
                    controlButton.Enabled = true;
                if (Interaction(character, leftRoomEntrance) == "Door")
                    controlButton.Enabled = true;
                if (Interaction(character, rightRoomEntrance) == "Door")
                    controlButton.Enabled = true;
                if (Interaction(character, testMath) == "Test")
                    controlButton.Enabled = true;
                if (Interaction(character, testPhy) == "Test")
                    controlButton.Enabled = true;
                if (Interaction(character, testProg) == "Test")
                    controlButton.Enabled = true;
                if (Interaction(character, testChem) == "Test")
                    controlButton.Enabled = true;
                if (Interaction(character, rocket) == "Rocket")
                    controlButton.Enabled = true;
            }
        }

        private void leftTimer_Tick(object sender, EventArgs e)
        {
            if (character.Location.X > 200)
            {
                newX = character.Location.X - pxlMoveX;
                character.Location = new Point(newX, character.Location.Y);
                //character.Image = global::SpaceGame.Properties.Resources.try100000;
                if (Interaction(character, upRoomEntrance) == "Door")
                    controlButton.Enabled = true;
                if (Interaction(character, downRoomEntrance) == "Door")
                    controlButton.Enabled = true;
                if (Interaction(character, leftRoomEntrance) == "Door")
                    controlButton.Enabled = true;
                if (Interaction(character, rightRoomEntrance) == "Door")
                    controlButton.Enabled = true;
                if (Interaction(character, testMath) == "Test")
                    controlButton.Enabled = true;
                if (Interaction(character, testPhy) == "Test")
                    controlButton.Enabled = true;
                if (Interaction(character, testProg) == "Test")
                    controlButton.Enabled = true;
                if (Interaction(character, testChem) == "Test")
                    controlButton.Enabled = true;
                if (Interaction(character, rocket) == "Rocket")
                    controlButton.Enabled = true;
            }
        }

        private static double GetDistance(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
        }

        public string Interaction(PictureBox player, PictureBox obj)
        {
            double dist = GetDistance(player.Location.X + player.Width / 2, player.Location.Y + player.Height / 2, obj.Location.X + obj.Width / 2, obj.Location.Y + obj.Height / 2);
            if (dist <= 200)
            {
                if (obj.Enabled == true)
                    return obj.Tag.ToString();
                else
                    return null;
            }
            else
            {
                return null;
            }
                
        }

        private void character_LocationChanged(object sender, EventArgs e)
        {

        }


        public void controlButton_Click(object sender, EventArgs e)
        {
            lst = new List<PictureBox>() { upRoomEntrance, downRoomEntrance, leftRoomEntrance, rightRoomEntrance, testMath, testPhy, testChem, testProg, rocket};
            foreach (PictureBox i in lst)
            {
                if (Interaction(character, i) == "Rocket")
                {
                    MessageBox.Show("BRAVO");
                    this.Close();
                }
                if (Interaction(character, i) == "Door")
                {
                    interactionDoor(i);
                }
                if (Interaction(character, i) == "Test")
                {
                    if (roomMath == true)
                        x = "math";
                    if (roomChem == true)
                        x = "chem";
                    if (roomPhy == true)
                        x = "phy";
                    if (roomProg == true)
                        x = "prog";
                    new Questions(x).ShowDialog();
                    string score = File.ReadAllText("score.txt");
                    scr += Convert.ToInt32(score);
                    scoreBoard.Text = "Score: " + scr.ToString() + "/20";
                    if (scr >= 20)
                        ok = true;
                }
                
            }
            controlButton.Enabled = false;
        }

        public void interactionDoor(PictureBox obj)
        {
            int objX = obj.Location.X;
            int objY = obj.Location.Y;
            int playerX = character.Location.X;
            int playerY = character.Location.Y;
            if (obj == upRoomEntrance)
            {
                roomMath = true;
                if (inroom == false)
                {
                    inroom = true;
                    obj.Location = new Point(objX, this.Height - 100);
                    character.Location = new Point(playerX, this.Height - 300);
                    Turn(false, obj);
                    testMath.Enabled = true;
                    testMath.Visible = true;
                    this.BackgroundImage = SpaceGame.Properties.Resources.background1;
                }
                else
                {
                    inroom = false;
                    obj.Location = new Point(objX, 0);
                    character.Location = new Point(playerX, 100);
                    Turn(true, obj);
                    testMath.Enabled = false;
                    testMath.Visible = false;
                    rocketShow();
                    this.BackgroundImage = SpaceGame.Properties.Resources.map;
                }
            }
            if (obj == downRoomEntrance)
            {
                
                if (inroom == false)
                {
                    roomChem = true;
                    inroom = true;
                    obj.Location = new Point(objX, 10);
                    character.Location = new Point(playerX, 150);
                    Turn(false, obj);
                    testChem.Enabled = true;
                    testChem.Visible = true;
                    this.BackgroundImage = SpaceGame.Properties.Resources.background1;
                }
                else
                {
                    roomChem = false;
                    inroom = false;
                    obj.Location = new Point(objX, this.Height - 100);
                    character.Location = new Point(playerX, this.Height - 300);
                    Turn(true, obj);
                    testChem.Enabled = false;
                    testChem.Visible = false;
                    rocketShow();
                    this.BackgroundImage = SpaceGame.Properties.Resources.map;
                }
                
            }
            if (obj == leftRoomEntrance)
            {
                
                if (inroom == false)
                {
                    roomPhy = true;
                    inroom = true;
                    obj.Image = SpaceGame.Properties.Resources.door4;
                    obj.Location = new Point(1600, objY);
                    character.Location = new Point(1650, playerY);
                    
                    Turn(false, obj);
                    testPhy.Enabled = true;
                    testPhy.Visible = true;
                    this.BackgroundImage = SpaceGame.Properties.Resources.background1;
                }
                else
                {
                    roomPhy = false;
                    inroom = false;
                    obj.Image = SpaceGame.Properties.Resources.door5;
                    obj.Location = new Point(-100, objY);
                    character.Location = new Point(200, playerY);
                    Turn(true, obj);
                    testPhy.Enabled = false;
                    testPhy.Visible = false;
                    rocketShow();
                    this.BackgroundImage = SpaceGame.Properties.Resources.map;
                }
                
            }
            if (obj == rightRoomEntrance)
            {
                
                if (inroom == false)
                {
                    roomProg = true;
                    inroom = true;
                    obj.Location = new Point(-100, objY);
                    character.Location = new Point(200, playerY);
                    obj.Image = SpaceGame.Properties.Resources.door5;
                    Turn(false, obj);
                    testProg.Enabled = true;
                    testProg.Visible = true;
                    this.BackgroundImage = SpaceGame.Properties.Resources.background1;
                }
                else
                {
                    roomProg = false;
                    inroom = false;
                    obj.Image = SpaceGame.Properties.Resources.door4;
                    obj.Location = new Point(1600, objY);
                    character.Location = new Point(1600, playerY);
                    Turn(true, obj);
                    testProg.Enabled = false;
                    testProg.Visible = false;
                    rocketShow();
                    this.BackgroundImage = SpaceGame.Properties.Resources.map;
                }
                
            }
        }

        public void Turn(bool x, PictureBox obj)
        {
            
            lst = new List<PictureBox>() { upRoomEntrance, downRoomEntrance, leftRoomEntrance, rightRoomEntrance };
            
            foreach(PictureBox i in lst)
            {
                if (i != obj)
                {
                    i.Visible = x;
                    i.Enabled = x;
                }
            }
        }

        public void rocketShow()
        {
            if (ok == true)
            {
                rocket.Enabled = true;
                rocket.Visible = true;
            }
                
        }
    }
}
