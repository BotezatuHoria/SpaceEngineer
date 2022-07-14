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
        Users user = null;

        public MainScreen(Users _user)
        {
            user = _user;
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Game(user).ShowDialog();
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            if (user.IsAdmin == true)
            {
                settingsButton.Enabled = true;
                settingsButton.Visible = true;
            }
        }

        private void statsButton_Click(object sender, EventArgs e)
        {
            new HighScore().ShowDialog();
        }

        private void storyButton_Click(object sender, EventArgs e)
        {
            new Intro().ShowDialog();
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            new AdminSelect().ShowDialog();
        }

        private void MainScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void controlsButton_Click(object sender, EventArgs e)
        {
            new Controls().ShowDialog();
        }
    }
}
