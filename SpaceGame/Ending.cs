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

        private void Ending_Load(object sender, EventArgs e)
        {
            endText.Text = "Bravo!!! Ai ajuns la final, Nikola iti este recunoscator pentru ca l-ai ajutat sa plece in cautarea unei noi planete.";
            shutDownLabel.Text = "Apasa pe X pentru a inchide jocul.";
        }
    }
}
