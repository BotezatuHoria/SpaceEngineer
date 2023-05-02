using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceGame
{
    public partial class Ending : Form
    {
        public Ending()
        {
            InitializeComponent();
        }

        /// This function displays 2 labes when loading the form.
        private void Ending_Load(object sender, EventArgs e)
        {
            endText.Text = "Bravo!!! Ai ajuns la final, Nikola îți este recunoscător pentru că l-ai ajutat să plece în cautarea unei noi planete.";
            shutDownLabel.Text = "Apasă pe X pentru a închide jocul.";
        }
    }
}
