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

        public Statistics()
        {
            InitializeComponent();
            MakeStats();
            Console.WriteLine(maths + " " + physics + " " + chemestry + " " + programming);
            DispalyChart();
        }

        private void MakeStats()
        {
            try
            {
                str = File.ReadAllText("math.txt");
            }
            catch(Exception e)
            {
                str = "0";
                Console.WriteLine(e);
            }
            maths = Convert.ToInt32(str.Replace("\n", "").Replace("\r", ""));
            try
            {
                str = File.ReadAllText("phy.txt");
            }
            catch (Exception e)
            {
                str = "0";
                Console.WriteLine(e);
            }
            physics = Convert.ToInt32(str.Replace("\n", "").Replace("\r", ""));
            try
            {
                str = File.ReadAllText("chem.txt");
            }
            catch (Exception e)
            {
                str = "0";
                Console.WriteLine(e);
            }
            chemestry = Convert.ToInt32(str.Replace("\n", "").Replace("\r", ""));
            try
            {
                str = File.ReadAllText("prog.txt");
            }
            catch (Exception e)
            {
                str = "0";
                Console.WriteLine(e);
            }
            programming = Convert.ToInt32(str.Replace("\n", "").Replace("\r", ""));
            sum = maths + physics + chemestry + programming;
            if (sum == 0)
                sum = 1;
            maths = maths * 100 / sum;
            physics = physics * 100 / sum;
            chemestry = chemestry * 100 / sum;
            programming = programming * 100 / sum;
        }

        private void DispalyChart()
        {
            chart1.Series["s1"].IsValueShownAsLabel = true;
            chart1.Series["s1"].Points.AddXY("Matematica", maths.ToString());
            chart1.Series["s1"].Points.AddXY("Fizica", physics.ToString());
            chart1.Series["s1"].Points.AddXY("Chimie", chemestry.ToString());
            chart1.Series["s1"].Points.AddXY("Programare", programming.ToString());
        }
    }
}
