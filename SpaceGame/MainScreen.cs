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
            new Questions().ShowDialog();
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            //LoadQandA();
        }
    }
}
