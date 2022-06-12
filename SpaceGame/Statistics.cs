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
    public partial class Statistics : Form
    {
        private int maths, physics, chemestry, programming, sum = 0;
        private string str;

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        public Statistics()
        {
            InitializeComponent();
            makeStats();
            Console.WriteLine(maths + " " + physics + " " + chemestry + " " + programming);
            dispalyChart();
        }

        private void makeStats()
        {
            str = File.ReadAllText("math.txt");
            maths = Convert.ToInt32(str.Replace("\n", "").Replace("\r", ""));
            str = File.ReadAllText("phy.txt");
            physics = Convert.ToInt32(str.Replace("\n", "").Replace("\r", ""));
            str = File.ReadAllText("chem.txt");
            chemestry = Convert.ToInt32(str.Replace("\n", "").Replace("\r", ""));
            str = File.ReadAllText("prog.txt");
            programming = Convert.ToInt32(str.Replace("\n", "").Replace("\r", ""));
            sum = maths + physics + chemestry + programming;
            maths = maths * 100 / sum;
            physics = physics * 100 / sum;
            chemestry = chemestry * 100 / sum;
            programming = programming * 100 / sum;
        }

        private void dispalyChart()
        {
            chart1.Series["s1"].IsValueShownAsLabel = true;
            chart1.Series["s1"].Points.AddXY("Matematica", maths.ToString());
            chart1.Series["s1"].Points.AddXY("Fizica", physics.ToString());
            chart1.Series["s1"].Points.AddXY("Chimie", chemestry.ToString());
            chart1.Series["s1"].Points.AddXY("Programare", programming.ToString());
        }
    }
}
