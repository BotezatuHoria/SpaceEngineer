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
    public partial class AdminSelect : Form
    {
        public AdminSelect()
        {
            InitializeComponent();
        }

        private void questionButton_Click(object sender, EventArgs e)
        {
            new Admin().ShowDialog();
        }

        private void materialsButton_Click(object sender, EventArgs e)
        {
            new AdminMaterials().ShowDialog();
        }

        private void statsButton_Click(object sender, EventArgs e)
        {
            new Statistics().ShowDialog();
        }
    }
}
