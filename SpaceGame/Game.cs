using System;
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
                DialogResult dialogResult = MessageBox.Show("Esti sigur ca vrei sa inchizi jocul?", "Confirmare", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            e.SuppressKeyPress = true;
            controlButton.Enabled = false;
            controlButton.BackColor = Color.Aqua;
        }

        private void Game_KeyUp(object sender, KeyEventArgs e)
        {
            //walkSound.Stop();
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

        private void upTimer_Tick(object sender, EventArgs e)
        {
            if (character.Location.Y > 150)
            {
                newY = character.Location.Y - pxlMoveY;
                character.Location = new Point(character.Location.X, newY);
                VerifInteraction();
                //Keep();
            }
        }

        private void downTimer_Tick(object sender, EventArgs e)
        {
            if (character.Location.Y < this.Height - 250)
            {
                newY = character.Location.Y + pxlMoveY;
                character.Location = new Point(character.Location.X, newY);
                VerifInteraction();
                //Keep();
            }
        }

        private void rightTimer_Tick(object sender, EventArgs e)
        {
            if (character.Location.X < this.Width - 250)
            {
                newX = character.Location.X + pxlMoveX;
                character.Location = new Point(newX, character.Location.Y);
                VerifInteraction();
                //Keep();
            }
        }

        private void leftTimer_Tick(object sender, EventArgs e)
        {
            if (character.Location.X > 200)
            {
                newX = character.Location.X - pxlMoveX;
                character.Location = new Point(newX, character.Location.Y);
                VerifInteraction();
                //Keep();
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
                    if (roomMath == true)
                        x = "math";
                    if (roomChem == true)
                        x = "chem";
                    if (roomPhy == true)
                        x = "phy";
                    if (roomProg == true)
                        x = "prog";
                    new Questions(x).ShowDialog();
                    //rocketLabel.Visible = true;
                    string score = File.ReadAllText("score.txt");
                    scr += Convert.ToInt32(score);
                    scoreBoard.Text = "Score: " + scr.ToString();
                    if (scr >= 0)
                        ok = true;
                    if (scr > 40)
                        finale = true;
                }
                if (Interaction(character, i) == "Learn")
                {
                    if (roomMath == true)
                        x = "math";
                    if (roomChem == true)
                        x = "chem";
                    if (roomPhy == true)
                        x = "phy";
                    if (roomProg == true)
                        x = "prog";
                    new Lessons(x).ShowDialog();
                }
                
            }
            controlButton.Enabled = false;
            controlButton.BackColor = Color.Aqua;
        }

        public void InteractionDoor(PictureBox obj)
        {
            //doorSound.Play();
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
                    learnMath.Enabled = true;
                    learnMath.Visible = true;
                    Turn(false, obj);
                    testMath.Enabled = true;
                    testMath.Visible = true;
                    ElevatorOnOff(false);
                    this.BackgroundImage = SpaceGame.Properties.Resources.uproom;
                    //colBoxMath1.Enabled = true;
                    //colBoxMath2.Enabled = true;
                    //colBoxMath3.Enabled = true;
                    calMath.Enabled = true;
                    shelfMath1.Enabled = true;
                    shelfMath2.Enabled = true;
                    deskMath.Enabled = true;
                    desksMath1.Enabled = true;
                    desksMath2.Enabled = true;
                    desksMath3.Enabled = true;
                    desksMath4.Enabled = true;
                    calMath.Visible = true;
                    shelfMath1.Visible = true;
                    shelfMath2.Visible = true;
                    deskMath.Visible = true;
                    desksMath1.Visible = true;
                    desksMath2.Visible = true;
                    desksMath3.Visible = true;
                    desksMath4.Visible = true;
                }
                else
                {
                    inroom = false;
                    obj.Location = new Point(objX, 0);
                    character.Location = new Point(playerX, 100);
                    learnMath.Enabled = false;
                    learnMath.Visible = false;
                    Turn(true, obj);
                    testMath.Enabled = false;
                    testMath.Visible = false;
                    //rocketShow();
                    ElevatorOnOff(true);
                    this.BackgroundImage = SpaceGame.Properties.Resources.map;
                    //colBoxMath1.Enabled = false;
                    //colBoxMath2.Enabled = false;
                    //colBoxMath3.Enabled = false;
                    calMath.Enabled = false;
                    shelfMath1.Enabled = false;
                    shelfMath2.Enabled = false;
                    deskMath.Enabled = false;
                    desksMath1.Enabled = false;
                    desksMath2.Enabled = false;
                    desksMath3.Enabled = false;
                    desksMath4.Enabled = false;
                    calMath.Visible = false;
                    shelfMath1.Visible = false;
                    shelfMath2.Visible = false;
                    deskMath.Visible = false;
                    desksMath1.Visible = false;
                    desksMath2.Visible = false;
                    desksMath3.Visible = false;
                    desksMath4.Visible = false;
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
                    learnChem.Enabled = true;
                    learnChem.Visible = true;
                    Turn(false, obj);
                    testChem.Enabled = true;
                    testChem.Visible = true;
                    ElevatorOnOff(false);
                    this.BackgroundImage = SpaceGame.Properties.Resources.downroom;
                    //colBoxChem1.Enabled = true;
                    //colBoxChem2.Enabled = true;
                    //colBoxChem2.Enabled = true;
                    brewChem1.Enabled = true;
                    brewChem2.Enabled = true;
                    chlotesChem.Enabled = true;
                    compChem.Enabled = true;
                    deskChem.Enabled = true;
                    rackChem.Enabled = true;

                    brewChem1.Visible= true;
                    brewChem2.Visible = true;
                    chlotesChem.Visible = true;
                    compChem.Visible = true;
                    deskChem.Visible = true;
                    rackChem.Visible = true;
                }
                else
                {
                    roomChem = false;
                    inroom = false;
                    obj.Location = new Point(objX, this.Height - 100);
                    character.Location = new Point(playerX, this.Height - 300);
                    learnChem.Enabled = false;
                    learnChem.Visible = false;
                    Turn(true, obj);
                    testChem.Enabled = false;
                    testChem.Visible = false;
                    //rocketShow();
                    ElevatorOnOff(true);
                    this.BackgroundImage = SpaceGame.Properties.Resources.map;
                    //colBoxChem1.Enabled = false;
                    //colBoxChem2.Enabled = false;
                    //colBoxChem2.Enabled = false;
                    brewChem1.Enabled = false;
                    brewChem2.Enabled = false;
                    chlotesChem.Enabled = false;
                    compChem.Enabled = false;
                    deskChem.Enabled = false;
                    rackChem.Enabled = false;

                    brewChem1.Visible = false;
                    brewChem2.Visible = false;
                    chlotesChem.Visible = false;
                    compChem.Visible = false;
                    deskChem.Visible = false;
                    rackChem.Visible = false;
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
                    learnPhy.Enabled = true;
                    learnPhy.Visible = true;
                    Turn(false, obj);
                    testPhy.Enabled = true;
                    testPhy.Visible = true;
                    ElevatorOnOff(false);
                    this.BackgroundImage = SpaceGame.Properties.Resources.leftroom;
                    reactor1.Enabled = true;
                    reactor2.Enabled = true;
                    reactor3.Enabled = true;
                    comp1.Enabled = true;
                    comp3.Enabled = true;
                    reactor1.Visible = true;
                    reactor2.Visible = true;
                    reactor3.Visible = true;
                    comp1.Visible = true;
                    comp3.Visible = true;
                }
                else
                {
                    roomPhy = false;
                    inroom = false;
                    obj.Image = SpaceGame.Properties.Resources.door5;
                    obj.Location = new Point(-100, objY);
                    character.Location = new Point(200, playerY);
                    learnPhy.Enabled = false;
                    learnPhy.Visible = false;
                    Turn(true, obj);
                    testPhy.Enabled = false;
                    testPhy.Visible = false;
                    //rocketShow();
                    ElevatorOnOff(true);
                    this.BackgroundImage = SpaceGame.Properties.Resources.map;
                    reactor1.Enabled = false;
                    reactor2.Enabled = false;
                    reactor3.Enabled = false;
                    comp1.Enabled = false;
                    comp3.Enabled = false;
                    reactor1.Visible = false;
                    reactor2.Visible = false;
                    reactor3.Visible = false;
                    comp1.Visible = false;
                    comp3.Visible = false;
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
                    learnProg.Enabled = true;
                    learnProg.Visible = true;
                    Turn(false, obj);
                    testProg.Enabled = true;
                    testProg.Visible = true;
                    ElevatorOnOff(false);
                    this.BackgroundImage = SpaceGame.Properties.Resources.rightroom;
                    //colBoxProg1.Enabled = true;
                    //colBoxProg2.Enabled = true;
                    //colBoxProg3.Enabled = true;
                    progComs1.Enabled = true;
                    progComs2.Enabled = true;
                    progComs3.Enabled = true;
                    progComs4.Enabled = true;
                    progComs5.Enabled = true;
                    progComs6.Enabled = true;
                    progStation1.Enabled = true;
                    progStation2.Enabled = true;
                    robot.Enabled = true;
                    progComs1.Visible = true;
                    progComs2.Visible = true;
                    progComs3.Visible = true;
                    progComs4.Visible = true;
                    progComs5.Visible = true;
                    progComs6.Visible = true;
                    progStation1.Visible = true;
                    progStation2.Visible = true;
                    robot.Visible = true;
                }
                else
                {
                    roomProg = false;
                    inroom = false;
                    obj.Image = SpaceGame.Properties.Resources.door4;
                    obj.Location = new Point(1600, objY);
                    character.Location = new Point(1600, playerY);
                    learnProg.Enabled = false;
                    learnProg.Visible = false;
                    Turn(true, obj);
                    testProg.Enabled = false;
                    testProg.Visible = false;
                    //rocketShow();
                    ElevatorOnOff(true);
                    this.BackgroundImage = SpaceGame.Properties.Resources.map;
                    //colBoxProg1.Enabled = false;
                    //colBoxProg2.Enabled = false;
                    //colBoxProg3.Enabled = false;
                    progComs1.Enabled = false;
                    progComs2.Enabled = false;
                    progComs3.Enabled = false;
                    progComs4.Enabled = false;
                    progComs5.Enabled = false;
                    progComs6.Enabled = false;
                    progStation1.Enabled = false;
                    progStation2.Enabled = false;
                    robot.Enabled = false;
                    progComs1.Visible = false;
                    progComs2.Visible = false;
                    progComs3.Visible = false;
                    progComs4.Visible = false;
                    progComs5.Visible = false;
                    progComs6.Visible = false;
                    progStation1.Visible = false;
                    progStation2.Visible = false;
                    robot.Visible = false;
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

        public void RocketShow()
        {
            if (inroom == false)
            {
                rocketLabel.Visible = true;
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
                roomRocket = true;
                dog.Location = new Point(1000, 922);
                chatBubble.Location = new Point(1140, 829);
                chatLabel.Location = new Point(1158, 848);
                if (finale == true)
                {
                    dog.Image = SpaceGame.Properties.Resources.dog1;
                }
                //pictureBox7.Enabled = true;
                if (scr >= 0 && scr <= 10)
                {
                    this.BackgroundImage = SpaceGame.Properties.Resources.rocket5;
                    rocketLabel.Text = "Inca nu ai construit nimic la racheta.";
                }
                if (scr > 10 && scr <= 20)
                {
                    rocketLabel.Text = "Ai reusit sa construiesti primul nivel al rachetei.";
                    this.BackgroundImage = SpaceGame.Properties.Resources.rocket1004_;
                }
                if (scr > 20 && scr <= 30)
                {
                    rocketLabel.Text = "Ai reusit sa construiesti al doilea nivel al rachetei.";
                    this.BackgroundImage = SpaceGame.Properties.Resources.rocket3;
                }
                if (scr > 30 && scr <= 40)
                {
                    rocketLabel.Text = "Ai reusit sa construiesti al treilea nivel al rachetei.";
                    this.BackgroundImage = SpaceGame.Properties.Resources.rocket2;
                }
                if (scr > 40)
                {
                    rocketLabel.Text = "Ai reusit sa construiesti racheta!";
                    this.BackgroundImage = SpaceGame.Properties.Resources.rocket11;
                    rocket.Enabled = true;
                }
            }
            else
            {
                rocketLabel.Visible = false;
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
                dog.Location = new Point(159, 917);
                chatBubble.Location = new Point(299, 824);
                chatLabel.Location = new Point(317, 843);
                roomRocket = false;
            }
        }

        public void ElevatorOnOff(bool x)
        {
            if (ok == true)
            {
                elevator.Enabled = x;
                elevator.Visible = x;   
            }
        }

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

        private void VerifInteraction()
        {
            //doorSound.Stop();
            if (Interaction(character, upRoomEntrance) == "Door")
            {
                controlButton.Enabled = true;
                controlButton.BackColor = Color.Yellow;
            }
                
            if (Interaction(character, downRoomEntrance) == "Door")
            {
                controlButton.Enabled = true;
                controlButton.BackColor = Color.Yellow;
            }
            if (Interaction(character, leftRoomEntrance) == "Door")
            {
                controlButton.Enabled = true;
                controlButton.BackColor = Color.Yellow;
            }
            if (Interaction(character, rightRoomEntrance) == "Door")
            {
                controlButton.Enabled = true;
                controlButton.BackColor = Color.Yellow;
            }
            if (Interaction(character, testMath) == "Test")
            {
                controlButton.Enabled = true;
                controlButton.BackColor = Color.Yellow;
            }
            if (Interaction(character, testPhy) == "Test")
            {
                controlButton.Enabled = true;
                controlButton.BackColor = Color.Yellow;
            }
            if (Interaction(character, testProg) == "Test")
            {
                controlButton.Enabled = true;
                controlButton.BackColor = Color.Yellow;
            }
            if (Interaction(character, testChem) == "Test")
            {
                controlButton.Enabled = true;
                controlButton.BackColor = Color.Yellow;
            }
            if (Interaction(character, rocket) == "Rocket")
            {
                controlButton.Enabled = true;
                controlButton.BackColor = Color.Yellow;
            }
            if (Interaction(character, elevator) == "Elevator")
            {
                controlButton.Enabled = true;
                controlButton.BackColor = Color.Yellow;
            }
            if (Interaction(character, learnPhy) == "Learn")
            {
                controlButton.Enabled = true;
                controlButton.BackColor = Color.Yellow;
            }
            if (Interaction(character, learnProg) == "Learn")
            {
                controlButton.Enabled = true;
                controlButton.BackColor = Color.Yellow;
            }
            if (Interaction(character, learnMath) == "Learn")
            {
                controlButton.Enabled = true;
                controlButton.BackColor = Color.Yellow;
            }
            if (Interaction(character, learnChem) == "Learn")
            {
                controlButton.Enabled = true;
                controlButton.BackColor = Color.Yellow;
            }
            Collision();
        }

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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

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

        private void dog_MouseHover(object sender, EventArgs e)
        {
            dog.Image = SpaceGame.Properties.Resources.dog2;
            chatBubble.Visible = true;
            chatBubble.Enabled = true;
            chatLabel.BringToFront();
            chatLabel.Visible = true;

            chatLabel.Text = "Buna! Eu sunt Edison si sunt aici ca sa te ajut! Alege una dintre camere pentru a putea incepe lucrul la racheta.";
            if (roomMath == true)
                chatLabel.Text = "Aici este laboratorul de matematica. \nPentru a invata lucruri noi una dintre bibilioteci te va ajuta, iar pentru a-ti testa cunostintele poti folosi tabla.";
            if (roomChem == true)
                chatLabel.Text = "Aceasta este laboratorul de chimie. \nPentru a invata lucruri noi verifica tabla, iar pentru a-ti vedea calitatile de om de stiinta incearca trusa de chimie.";
            if (roomPhy == true)
                chatLabel.Text = "Bine ai venit in laboratorul de fizica. \nPentru a invata lucruri noi verifica tabla, iar pentru a vedea ce fizician bun esti incearca unul dintre reactoare.";
            if (roomProg == true)
                chatLabel.Text = "Acesta este laboratorul de informatica. \nPentru a invata lucruri noi verifica tabla, iar pentri a-ti testa cunostintele de informatician poti folosi calculatorul.";
            if (roomRocket == true)
                chatLabel.Text = "Aici este ateleriul rachetei. \nPe masura ce avansezi aceasta va fi construita.";
            if (finale == true)
            {
                dog.Image = SpaceGame.Properties.Resources.dog1;
                chatLabel.Text = "Bravoo ai terminat racheta!!! Hai sa mergem sa gasim leacul!";
            }
        }

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
    }
}