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
        public int scr = 0;
        public int highScore = 0;
        bool roomMath = false;
        bool roomPhy = false;
        bool roomProg = false;
        bool roomChem = false;
        string x = null;
        bool ok = false;
        //public int pointsCount = 20;
        public string userId;

        public Game()
        {
            InitializeComponent();
            using (StreamWriter writetext = new StreamWriter("score.txt"))
            {
                writetext.WriteLine("0");
            }
            scoreBoard.Text = "Score: " + File.ReadAllText("score.txt");
            userId = File.ReadAllText("user.txt");
            string file = userId.Replace("\n", "").Replace("\r", "") + ".txt";
            highScore = Convert.ToInt32(File.ReadAllText(file));
        }

        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                character.Image = SpaceGame.Properties.Resources.back;
                upTimer.Enabled = true;
            }
            if (e.KeyCode == Keys.S)
            {
                character.Image = SpaceGame.Properties.Resources.frontPosition;
                downTimer.Enabled = true;
            }
            if (e.KeyCode == Keys.A)
            {
                character.Image = SpaceGame.Properties.Resources.magel;
                leftTimer.Enabled = true;
            }
            if (e.KeyCode == Keys.D)
            {
                character.Image = SpaceGame.Properties.Resources.magel2;
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
                character.Image = SpaceGame.Properties.Resources.frontPosition;
                leftTimer.Enabled = false;
            }
            if (e.KeyCode == Keys.D)
            {
                character.Image = SpaceGame.Properties.Resources.frontPosition;
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
                if (Interaction(character, elevator) == "Elevator")
                    controlButton.Enabled = true;
                collision();
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
                if (Interaction(character, elevator) == "Elevator")
                    controlButton.Enabled = true;
                collision();
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
                if (Interaction(character, elevator) == "Elevator")
                    controlButton.Enabled = true;
                collision();
            }
        }

        private void leftTimer_Tick(object sender, EventArgs e)
        {
            if (character.Location.X > 200)
            {
                newX = character.Location.X - pxlMoveX;
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
                if (Interaction(character, elevator) == "Elevator")
                    controlButton.Enabled = true;
                collision();
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
            lst = new List<PictureBox>() { upRoomEntrance, downRoomEntrance, leftRoomEntrance, rightRoomEntrance, testMath, testPhy, testChem, testProg, rocket, elevator};
            foreach (PictureBox i in lst)
            {
                if (Interaction(character, i) == "Rocket")
                {
                    if (highScore < scr)
                    {
                        highScore = scr;
                        
                        using (StreamWriter writetext = new StreamWriter(userId.Replace("\n", "").Replace("\r", "") + ".txt"))
                        {
                            writetext.WriteLine(highScore);
                        }
                    }
                        
                    new Ending().ShowDialog();
                    this.Close();
                }
                if (Interaction(character, i) == "Elevator")
                {
                    rocketShow();
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
                    scoreBoard.Text = "Score: " + scr.ToString();
                    if (scr >= 0)
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
                    elevatorOnOff(false);
                    this.BackgroundImage = SpaceGame.Properties.Resources.uproom1000;
                    colBoxMath1.Enabled = true;
                    colBoxMath2.Enabled = true;
                    colBoxMath3.Enabled = true;
                }
                else
                {
                    inroom = false;
                    obj.Location = new Point(objX, 0);
                    character.Location = new Point(playerX, 100);
                    Turn(true, obj);
                    testMath.Enabled = false;
                    testMath.Visible = false;
                    //rocketShow();
                    elevatorOnOff(true);
                    this.BackgroundImage = SpaceGame.Properties.Resources.map;
                    colBoxMath1.Enabled = false;
                    colBoxMath2.Enabled = false;
                    colBoxMath3.Enabled = false;
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
                    elevatorOnOff(false);
                    this.BackgroundImage = SpaceGame.Properties.Resources.downroom2;
                    colBoxChem1.Enabled = true;
                    colBoxChem2.Enabled = true;
                    colBoxChem2.Enabled = true;
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
                    //rocketShow();
                    elevatorOnOff(true);
                    this.BackgroundImage = SpaceGame.Properties.Resources.map;
                    colBoxChem1.Enabled = false;
                    colBoxChem2.Enabled = false;
                    colBoxChem2.Enabled = false;
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
                    //testPhy.Visible = true;
                    elevatorOnOff(false);
                    this.BackgroundImage = SpaceGame.Properties.Resources.leftroom1;
                    colBoxPhy1.Enabled = true;
                    colBoxPhy2.Enabled = true;
                    colBoxPhy3.Enabled = true;
                    colBoxPhy4.Enabled = true;
                    colBoxPhy5.Enabled = true;
                    colBoxPhy6.Enabled = true;
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
                    //rocketShow();
                    elevatorOnOff(true);
                    this.BackgroundImage = SpaceGame.Properties.Resources.map;
                    colBoxPhy1.Enabled = false;
                    colBoxPhy2.Enabled = false;
                    colBoxPhy3.Enabled = false;
                    colBoxPhy4.Enabled = false;
                    colBoxPhy5.Enabled = false;
                    colBoxPhy6.Enabled = false;
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
                    elevatorOnOff(false);
                    this.BackgroundImage = SpaceGame.Properties.Resources.rightroom2;
                    colBoxProg1.Enabled = true;
                    colBoxProg2.Enabled = true;
                    colBoxProg3.Enabled = true;
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
                    //rocketShow();
                    elevatorOnOff(true);
                    this.BackgroundImage = SpaceGame.Properties.Resources.map;
                    colBoxProg1.Enabled = false;
                    colBoxProg2.Enabled = false;
                    colBoxProg3.Enabled = false;
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
            if (inroom == false)
            {
                inroom = true;
                upRoomEntrance.Enabled = false;
                leftRoomEntrance.Enabled = false;
                rightRoomEntrance.Enabled = false;
                downRoomEntrance.Enabled = false;
                upRoomEntrance.Visible = false;
                leftRoomEntrance.Visible = false;
                rightRoomEntrance.Visible = false;
                downRoomEntrance.Visible = false;
                character.Location = new Point(200, 800);
                elevator.Location = new Point(0, 750);
                elevator.Visible = true;
                //pictureBox7.Enabled = true;
                if (scr >= 0 && scr <= 10)
                {
                    this.BackgroundImage = SpaceGame.Properties.Resources.rocket5;
                }
                if (scr > 10 && scr <= 20)
                {
                    this.BackgroundImage = SpaceGame.Properties.Resources.rocket1004_;
                }
                if (scr > 20 && scr <= 30)
                {
                    this.BackgroundImage = SpaceGame.Properties.Resources.rocket3;
                }
                if (scr > 30 && scr <= 40)
                {
                    this.BackgroundImage = SpaceGame.Properties.Resources.rocket2;
                }
                if (scr > 40)
                {
                    this.BackgroundImage = SpaceGame.Properties.Resources.rocket11;
                    rocket.Enabled = true;
                }
               
            }
            else
            {
                inroom = false;
                rocket.Enabled = false;
                this.BackgroundImage = SpaceGame.Properties.Resources.map;
                upRoomEntrance.Enabled = true;
                leftRoomEntrance.Enabled = true;
                rightRoomEntrance.Enabled = true;
                downRoomEntrance.Enabled = true;
                upRoomEntrance.Visible = true;
                leftRoomEntrance.Visible = true;
                rightRoomEntrance.Visible = true;
                downRoomEntrance.Visible = true;
                character.Location = new Point(938, 452);
                elevator.Location = new Point(864, 376);
            }
            
                
        }

        public void elevatorOnOff(bool x)
        {
            if (ok == true)
            {
                elevator.Enabled = x;
                elevator.Visible = x;   
            }
        }

        public void collision()
        {
            List<PictureBox> lst = new List<PictureBox> { colBoxChem2, colBoxChem3, colBoxChem1, colBoxProg1, colBoxProg2, colBoxProg3, colBoxPhy1, colBoxPhy2, colBoxPhy3, colBoxPhy4, colBoxPhy5, colBoxPhy6 };
            foreach(PictureBox box in lst)
            {
                if (box.Enabled == true)
                    if (character.Bounds.IntersectsWith(box.Bounds))
                    {
                        upTimer.Enabled = false;
                        leftTimer.Enabled = false;
                        rightTimer.Enabled = false;
                        downTimer.Enabled = false;
                    }
            }
        }

        public void loadUsersDb()
        {

        }

        private void Game_Load(object sender, EventArgs e)
        {

        }

        private void colBoxPhy4_Click(object sender, EventArgs e)
        {

        }

        private void colBoxPhy5_Click(object sender, EventArgs e)
        {

        }

        private void colBoxPhy3_Click(object sender, EventArgs e)
        {

        }

        private void testPhy_Click(object sender, EventArgs e)
        {

        }

        private void colBoxPhy6_Click(object sender, EventArgs e)
        {

        }

        private void colBoxPhy1_Click(object sender, EventArgs e)
        {

        }

        private void colBoxPhy2_Click(object sender, EventArgs e)
        {

        }
    }
}
