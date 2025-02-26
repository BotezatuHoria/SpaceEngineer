﻿using System;
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
        public QandA qa;
        public Explain(QandA _qa)
        {
            qa = _qa;
            InitializeComponent();
        }
        /// This function gets the QandA object that it is provided in the constructor and displays it's explanation.
        private void Explain_Load(object sender, EventArgs e)
        {
            explainLabel.Text = Convert.ToString(qa.Explanation);
        }
    }
}
