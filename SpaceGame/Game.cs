﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;

namespace SpaceGame
{
    public partial class Game : Form
    {
        public Users user;
        public int newX = 0;
        public int newY = 0;
        public const int pxlMoveX = 6;
        public const int pxlMoveY = 6;
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
        public string userId;
        public bool pressed = false;
        public bool sound = false;
        private bool roomRocket = false;
        private bool finale = false;

        /// This function initializes all the components, sets the game in fullscreen and gathers infromation about the user's score.
        public Game(Users _user)
        {
            Fullscreen(true);
            user = _user;
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

        /// This function is used for all the controls that the player can use in the game.
        /// It can start the timer for the character to move or have other abilities like interacting with objects.
        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.E)
            {
                controlButton_Click(sender, e);
            }
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
                if (pressed == false)
                    character.Image = SpaceGame.Properties.Resources.magel;
                leftTimer.Enabled = true;
                pressed = true;
            }
            if (e.KeyCode == Keys.D)
            {
                if (pressed == false)
                    character.Image = SpaceGame.Properties.Resources.magel2;
                rightTimer.Enabled = true;
                pressed = true;
            }
            if (e.KeyCode == Keys.P)
            {
                if (user.IsAdmin == true)
                {
                    scr += 10;
                    scoreBoard.Text = "Score: " + scr.ToString();
                }
            }
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult dialogResult = MessageBox.Show("Esti sigur că vrei să închizi jocul?", "Confirmare", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            e.SuppressKeyPress = true;
            controlButton.Enabled = false;
            controlButton.BackColor = Color.Aqua;
        }

        /// This function is used to set all the timers to false so that the character doesn't move without the users action.
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
                pressed = false;
                character.Image = SpaceGame.Properties.Resources.frontPosition;
                leftTimer.Enabled = false;
            }
            if (e.KeyCode == Keys.D)
            {
                pressed = false;
                character.Image = SpaceGame.Properties.Resources.frontPosition;
                rightTimer.Enabled = false;
            }
        }

        /// These function are used to update the location of the character on the map at every timer tick and also verifies if it is there somthing that the character can interact with.
        private void upTimer_Tick(object sender, EventArgs e)
        {
            if (character.Location.Y > 150)
            {
                newY = character.Location.Y - pxlMoveY;
                character.Location = new Point(character.Location.X, newY);
                VerifInteraction();
            }
        }

        private void downTimer_Tick(object sender, EventArgs e)
        {
            if (character.Location.Y < this.Height - 250)
            {
                newY = character.Location.Y + pxlMoveY;
                character.Location = new Point(character.Location.X, newY);
                VerifInteraction();
            }
        }

        private void rightTimer_Tick(object sender, EventArgs e)
        {
            if (character.Location.X < this.Width - 250)
            {
                newX = character.Location.X + pxlMoveX;
                character.Location = new Point(newX, character.Location.Y);
                VerifInteraction();
            }
        }

        private void leftTimer_Tick(object sender, EventArgs e)
        {
            if (character.Location.X > 200)
            {
                newX = character.Location.X - pxlMoveX;
                character.Location = new Point(newX, character.Location.Y);
                VerifInteraction();
            }
        }

        /// This function calculates the distance between 2 objects.
        private static double GetDistance(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
        }

        /// This function is used to see if the character is interacting with an object in his surroundings.
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

        /// This function is used to interact with diferent objects.
        /// Each object has a different thing that it can do.
        public void controlButton_Click(object sender, EventArgs e)
        {
            lst = new List<PictureBox>() { upRoomEntrance, downRoomEntrance, leftRoomEntrance, rightRoomEntrance, testMath, testPhy, testChem, testProg, rocket, elevator, learnPhy, learnProg, learnMath, learnChem};
            foreach (PictureBox i in lst)
            {
                if (Interaction(character, i) == "Rocket")
                {                        
                    new Ending().ShowDialog();
                    this.Close();
                }
                if (Interaction(character, i) == "Elevator")
                {
                    RocketShow();
                }
                if (Interaction(character, i) == "Door")
                {
                    InteractionDoor(i);
                }
                if (Interaction(character, i) == "Test")
                {
                    x = RoomIn();
                    new Questions(x).ShowDialog();
                    ScoreAfterQandA();
                }
                if (Interaction(character, i) == "Learn")
                {
                    x = RoomIn();
                    new Lessons(x).ShowDialog();
                }
                
            }
            controlButton.Enabled = false;
            controlButton.BackColor = Color.Aqua;
        }

        /// This function is used in case the character interacts with one of the doors so it can show the specific objects of every room.
        public void InteractionDoor(PictureBox obj)
        {
            int objX = obj.Location.X;
            int objY = obj.Location.Y;
            int playerX = character.Location.X;
            int playerY = character.Location.Y;
            if (obj == upRoomEntrance)
            {
                if (inroom == false)
                {
                    obj.Location = new Point(objX, this.Height - 100);
                    character.Location = new Point(playerX, this.Height - 300);
                    Turn(false, obj);
                    ElevatorOnOff(false);
                    this.BackgroundImage = SpaceGame.Properties.Resources.uproom;
                    MathObj(true);
                }
                else
                {
                    obj.Location = new Point(objX, 0);
                    character.Location = new Point(playerX, 100);
                    Turn(true, obj);
                    ElevatorOnOff(true);
                    this.BackgroundImage = SpaceGame.Properties.Resources.map;
                    MathObj(false);
                }
            }
            if (obj == downRoomEntrance)
            {
                
                if (inroom == false)
                {
                    obj.Location = new Point(objX, 10);
                    character.Location = new Point(playerX, 150);
                    Turn(false, obj);
                    ElevatorOnOff(false);
                    this.BackgroundImage = SpaceGame.Properties.Resources.downroom;
                    ChemObj(true);
                }
                else
                {
                    obj.Location = new Point(objX, this.Height - 100);
                    character.Location = new Point(playerX, this.Height - 300);
                    Turn(true, obj);
                    ElevatorOnOff(true);
                    this.BackgroundImage = SpaceGame.Properties.Resources.map;
                    ChemObj(false);
                }
                
            }
            if (obj == leftRoomEntrance)
            {
                
                if (inroom == false)
                {
                    obj.Image = SpaceGame.Properties.Resources.door4;
                    obj.Location = new Point(1600, objY);
                    character.Location = new Point(1650, playerY);
                    Turn(false, obj);
                    ElevatorOnOff(false);
                    this.BackgroundImage = SpaceGame.Properties.Resources.leftroom;
                    PhyObj(true);
                }
                else
                {
                    obj.Image = SpaceGame.Properties.Resources.door5;
                    obj.Location = new Point(-100, objY);
                    character.Location = new Point(200, playerY);
                    Turn(true, obj);
                    ElevatorOnOff(true);
                    this.BackgroundImage = SpaceGame.Properties.Resources.map;
                    PhyObj(false);
                }
                
            }
            if (obj == rightRoomEntrance)
            {
                
                if (inroom == false)
                {
                    obj.Location = new Point(-100, objY);
                    character.Location = new Point(200, playerY);
                    obj.Image = SpaceGame.Properties.Resources.door5;
                    Turn(false, obj);
                    ElevatorOnOff(false);
                    this.BackgroundImage = SpaceGame.Properties.Resources.rightroom;
                    ProgObj(true);
                }
                else
                {
                    obj.Image = SpaceGame.Properties.Resources.door4;
                    obj.Location = new Point(1600, objY);
                    character.Location = new Point(1600, playerY);
                    Turn(true, obj);
                    ElevatorOnOff(true);
                    this.BackgroundImage = SpaceGame.Properties.Resources.map;
                    ProgObj(false);
                }
                
            }
        }

        /// This function is used in order to turn on or off the visibility of 3 of the doors in certain situations.
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

        /// This function is used in order to interact with the rocket and load the room's special objects.
        public void RocketShow()
        {
            if (inroom == false)
            {
                rocketLabel.Visible = true;
                inroom = true;
                RoomsSwitch(false);
                character.Location = new Point(200, 800);
                elevator.Location = new Point(0, 750);
                elevator.Visible = true;
                roomRocket = true;
                dog.Location = new Point(1000, 922);
                chatBubble.Location = new Point(1140, 829);
                chatLabel.Location = new Point(1158, 848);
                if (finale == true)
                {
                    dog.Image = SpaceGame.Properties.Resources.dog1;
                }
                RocketScores();
            }
            else
            {
                rocketLabel.Visible = false;
                inroom = false;
                rocket.Enabled = false;
                this.BackgroundImage = SpaceGame.Properties.Resources.map;
                RoomsSwitch(true);
                character.Location = new Point(938, 452);
                elevator.Location = new Point(864, 376);
                dog.Location = new Point(159, 917);
                chatBubble.Location = new Point(299, 824);
                chatLabel.Location = new Point(317, 843);
                roomRocket = false;
            }
        }

        /// This function is used in order to turn on and off the elevator when is needed.
        public void ElevatorOnOff(bool x)
        {
            if (ok == true)
            {
                elevator.Enabled = x;
                elevator.Visible = x;   
            }
        }

        /// This function detects colision with other objects so that the character can't walk on everything he wants.
        public void Collision()
        {
            List<PictureBox> lst = new List<PictureBox> { reactor1, reactor2, reactor3, comp1, comp3, testPhy, learnProg, testProg, progComs1, progComs2, progComs3, progComs4, progComs5, progComs6, progStation1, progStation2, robot, deskMath, desksMath1, desksMath2, desksMath3, desksMath4, calMath, learnMath, testMath, shelfMath1, shelfMath2, compChem, brewChem1, brewChem2, chlotesChem, deskChem, rackChem, learnChem, testChem, dog, chatBubble};
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

        /// This functiom is used to verify the interaction with other objects.
        private void VerifInteraction()
        {
            List<PictureBox> pics = new List<PictureBox> { upRoomEntrance, downRoomEntrance, leftRoomEntrance, rightRoomEntrance, testMath, testPhy, testProg, testChem, rocket, elevator, learnChem, learnPhy, learnMath, learnProg };
            foreach (PictureBox pic in pics)
            {
                if (Interaction(character, pic) != null)
                {
                    controlButton.Enabled = true;
                    controlButton.BackColor = Color.Yellow;
                }  
            }
            Collision();
        }

        /// This function is used to update the highscore of every user if it has to change.
        private void Game_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (highScore < scr)
            {
                highScore = scr;

                using (StreamWriter writetext = new StreamWriter(userId.Replace("\n", "").Replace("\r", "") + ".txt"))
                {
                    writetext.WriteLine(highScore);
                }
            }
            Application.Exit();
        }

        /// This functio is used to set the app in fullscreen mode.
        private void Fullscreen(bool fullscreen)
        {
            if (fullscreen)
            {
                this.WindowState = FormWindowState.Normal;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                this.Bounds = Screen.PrimaryScreen.Bounds;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            }
        }

        /// This function is used to controll what the helper can say and do.
        private void dog_MouseHover(object sender, EventArgs e)
        {
            dog.Image = SpaceGame.Properties.Resources.dog2;
            chatBubble.Visible = true;
            chatBubble.Enabled = true;
            chatLabel.BringToFront();
            chatLabel.Visible = true;

            chatLabel.Text = "Buna! Eu sunt Edison și sunt aici ca să te ajut! Alege una dintre camere pentru a putea începe lucrul la rachetă.";
            if (roomMath == true)
                chatLabel.Text = "Aici este laboratorul de matematiă. \nPentru a învăța lucruri noi una dintre bibilioteci te va ajuta, iar pentru a-ți testa cunoștințele poți folosi tabla.";
            if (roomChem == true)
                chatLabel.Text = "Aceasta este laboratorul de chimie. \nPentru a învăța lucruri noi verifică tabla, iar pentru a-ți vedea calitățile de om de știință încearcă trusa de chimie.";
            if (roomPhy == true)
                chatLabel.Text = "Bine ai venit în laboratorul de fizică. \nPentru a învăța lucruri noi verifică tabla, iar pentru a vedea ce fizician bun ești încearcă unul dintre reactoare.";
            if (roomProg == true)
                chatLabel.Text = "Acesta este laboratorul de informatică. \nPentru a învăța lucruri noi verifică tabla, iar pentru a-ți testa cunostințele de informatician poți folosi calculatorul.";
            if (roomRocket == true)
                chatLabel.Text = "Acesta este ateleriul rachetei. \nPe măsură ce avansezi aceasta va fi construită.";
            if (finale == true)
            {
                dog.Image = SpaceGame.Properties.Resources.dog1;
                chatLabel.Text = "Bravooo ai terminat racheta!!! Hai sa mergem să gasim leacul!";
            }
        }

        /// This function is used to reset the helpers inactive position
        private void dog_MouseLeave(object sender, EventArgs e)
        {
            dog.Image = SpaceGame.Properties.Resources.dog3;
            chatBubble.Visible = false;
            chatBubble.Enabled = false;
            chatLabel.Visible = false;
            if (finale == true)
            {
                dog.Image = SpaceGame.Properties.Resources.dog1;
            }
        }

        /// These functions are used to turn on or off the objects related to every room.
        private void MathObj(bool change)
        {
            roomMath = change;
            inroom = change;
            learnMath.Enabled = change;
            learnMath.Visible = change;
            testMath.Enabled = change;
            testMath.Visible = change;
            calMath.Enabled = change;
            shelfMath1.Enabled = change;
            shelfMath2.Enabled = change;
            deskMath.Enabled = change;
            desksMath1.Enabled = change;
            desksMath2.Enabled = change;
            desksMath3.Enabled = change;
            desksMath4.Enabled = change;
            calMath.Visible = change;
            shelfMath1.Visible = change;
            shelfMath2.Visible = change;
            deskMath.Visible = change;
            desksMath1.Visible = change;
            desksMath2.Visible = change;
            desksMath3.Visible = change;
            desksMath4.Visible = change;
        }
        
        private void ChemObj(bool change)
        {
            roomChem = change;
            inroom = change;
            learnChem.Enabled = change;
            learnChem.Visible = change;
            testChem.Enabled = change;
            testChem.Visible = change;
            brewChem1.Enabled = change;
            brewChem2.Enabled = change;
            chlotesChem.Enabled = change;
            compChem.Enabled = change;
            deskChem.Enabled = change;
            rackChem.Enabled = change;
            brewChem1.Visible = change;
            brewChem2.Visible = change;
            chlotesChem.Visible = change;
            compChem.Visible = change;
            deskChem.Visible = change;
            rackChem.Visible = change;
        }

        private void PhyObj(bool change)
        {
            roomPhy = change;
            inroom = change;
            learnPhy.Enabled = change;
            learnPhy.Visible = change;
            testPhy.Enabled = change;
            testPhy.Visible = change;
            reactor1.Enabled = change;
            reactor2.Enabled = change;
            reactor3.Enabled = change;
            comp1.Enabled = change;
            comp3.Enabled = change;
            reactor1.Visible = change;
            reactor2.Visible = change;
            reactor3.Visible = change;
            comp1.Visible = change;
            comp3.Visible = change;
        }

        private void ProgObj(bool changed)
        {
            roomProg = changed;
            inroom = changed;
            learnProg.Enabled = changed;
            learnProg.Visible = changed;
            testProg.Enabled = changed;
            testProg.Visible = changed;
            progComs1.Enabled = changed;
            progComs2.Enabled = changed;
            progComs3.Enabled = changed;
            progComs4.Enabled = changed;
            progComs5.Enabled = changed;
            progComs6.Enabled = changed;
            progStation1.Enabled = changed;
            progStation2.Enabled = changed;
            robot.Enabled = changed;
            progComs1.Visible = changed;
            progComs2.Visible = changed;
            progComs3.Visible = changed;
            progComs4.Visible = changed;
            progComs5.Visible = changed;
            progComs6.Visible = changed;
            progStation1.Visible = changed;
            progStation2.Visible = changed;
            robot.Visible = changed;
        }

        /// This function is used to uodate the progress on the rocket.
        private void RocketScores()
        {
            if (scr >= 0 && scr <= 10)
            {
                this.BackgroundImage = SpaceGame.Properties.Resources.rocket5;
                rocketLabel.Text = "Incă nu ai construit nimic la rachetă.";
            }
            if (scr > 10 && scr <= 20)
            {
                rocketLabel.Text = "Ai reușit să construiești primul nivel al rachetei.";
                this.BackgroundImage = SpaceGame.Properties.Resources.rocket1004_;
            }
            if (scr > 20 && scr <= 30)
            {
                rocketLabel.Text = "Ai reușit să construiești al doilea nivel al rachetei.";
                this.BackgroundImage = SpaceGame.Properties.Resources.rocket3;
            }
            if (scr > 30 && scr <= 40)
            {
                rocketLabel.Text = "Ai reușit să construiești al treilea nivel al rachetei.";
                this.BackgroundImage = SpaceGame.Properties.Resources.rocket2;
            }
            if (scr > 40)
            {
                rocketLabel.Text = "Ai reuțit să construiești racheta!";
                this.BackgroundImage = SpaceGame.Properties.Resources.rocket11;
                rocket.Enabled = true;
            }
        }

        /// This function is used to turn on and off the doors.
        private void RoomsSwitch(bool change)
        {
            upRoomEntrance.Enabled = change;
            leftRoomEntrance.Enabled = change;
            rightRoomEntrance.Enabled = change;
            downRoomEntrance.Enabled = change;
            upRoomEntrance.Visible = change;
            leftRoomEntrance.Visible = change;
            rightRoomEntrance.Visible = change;
            downRoomEntrance.Visible = change;
        }

        /// This function returns in which camera the character is in as a string.
        private string RoomIn()
        {
            if (roomMath == true)
                return "math";
            if (roomChem == true)
                return "chem";
            if (roomPhy == true)
                return "phy";
            if (roomProg == true)
                return "prog";
            return null;
        }

        /// This fucntion is used to read and update the score.
        private void ScoreAfterQandA()
        {
            string score = File.ReadAllText("score.txt");
            scr += Convert.ToInt32(score);
            scoreBoard.Text = "Score: " + scr.ToString();
            if (scr >= 0)
                ok = true;
            if (scr > 40)
                finale = true;
        }
    }
}