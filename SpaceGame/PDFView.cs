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
    public partial class PDFView : Form
    {
        private string file = null;

        public PDFView(string fileName)
        {
            file = fileName;
            InitializeComponent();
        }

        /// This function displays in a PDF view a certain file that has been selected by the user from the resources folder.
        private void PDFView_Load(object sender, EventArgs e)
        {
            
            string RunningPath = AppDomain.CurrentDomain.BaseDirectory;
            string FileName = string.Format("{0}Resources\\{1}.pdf", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")), file);
            axAcroPDF1.src = FileName;
            //Console.WriteLine(FileName);
        }
    }
}
