﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceGame
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
            //Application.Run(new Questions());
            //Application.Run(new Game());
            //Application.Run(new Intro());
            //Application.Run(new Ending());
            //Application.Run(new Admin());
            //Application.Run(new Statistics());
            //Application.Run(new Learning());
            //Application.Run(new Lessons("phy"));
            //Application.Run(new PDFView());
        }
    }
}
