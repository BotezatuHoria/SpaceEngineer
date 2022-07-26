using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SpaceGame
{
    public partial class MainScreen : Form
    {
        public Users user = null;

        /// This fucntion initializes all the components of the form and gets the user that loged in.
        public MainScreen(Users _user)
        {
            user = _user;
            InitializeComponent();
        }

        /// This fucntion is used in order to start the game.
        private void startButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Game(user).ShowDialog();
        }

        /// This fucntion loads all the data from the mainscreen and also displays the settings button if the user is an admin.
        private void MainScreen_Load(object sender, EventArgs e)
        {
            if (user.IsAdmin == true)
            {
                settingsButton.Enabled = true;
                settingsButton.Visible = true;
            }
        }
        /// This fucntion opens the HighScore form.
        private void statsButton_Click(object sender, EventArgs e)
        {
            new HighScore().ShowDialog();
        }
        /// This fucntion opens the story form.
        private void storyButton_Click(object sender, EventArgs e)
        {
            new Intro().ShowDialog();
        }
        /// This fucntion opens the settings form.
        private void settingsButton_Click(object sender, EventArgs e)
        {
            new AdminSelect().ShowDialog();
        }
        /// This fucntion closes the application if the form is closed.
        private void MainScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        /// This fucntion opens the Controls form.
        private void controlsButton_Click(object sender, EventArgs e)
        {
            new Controls().ShowDialog();
        }
    }
}
