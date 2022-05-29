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
    public partial class HighScore : Form
    {
        public HighScore()
        {
            InitializeComponent();
            string user = File.ReadAllText("user.txt");
            string file = user.Replace("\n", "").Replace("\r", "")  + ".txt";
            highScoreLabel.Text = "Highscore-ul tau este: " + File.ReadAllText(file);
        }
    }
}
