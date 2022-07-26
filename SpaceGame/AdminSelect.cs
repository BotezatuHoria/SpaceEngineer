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
        /// This button opens the QandA manager.
        private void questionButton_Click(object sender, EventArgs e)
        {
            new Admin().ShowDialog();
        }
        /// This button opens the Materials manager.
        private void materialsButton_Click(object sender, EventArgs e)
        {
            new AdminMaterials().ShowDialog();
        }
        /// This button opens the Statistics form.
        private void statsButton_Click(object sender, EventArgs e)
        {
            new Statistics().ShowDialog();
        }
    }
}
