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
    public partial class Explain : Form
    {
        QandA qa;
        public Explain(QandA _qa)
        {
            qa = _qa;
            InitializeComponent();
        }

        private void Explain_Load(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(qa.Explanation);
        }
    }
}
