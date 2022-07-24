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
    public partial class Lessons : Form
    {
        private int panX;
        private int panY;
        List<Materials> materials;
        List<Materials> subject;
        public string room = null;
        string file = null;

        public Lessons(string _room)
        {
            room = _room;
            InitializeComponent();
        }

        private void GenPanel(string name)
        {
            Panel panel = new Panel();
            panel.Width = 266;
            panel.Height = 256;
            panel.BackColor = Color.Transparent;
            panel.BackgroundImage = SpaceGame.Properties.Resources.pdfs;
            panX = panel.Location.X;
            panY = panel.Location.Y;

            Button button = new Button();
            button.Location = new Point(panX + 165, panY + 160);
            button.Width = 70;
            button.Height = 70;
            button.Tag = name.Trim();
            button.Click += read_Click;
            //button.SendToBack();
            //button.BackColor = Color.Transparent;
            button.Text = "Citeste";
            button.Font = new Font("Consolas", 9);
            button.FlatStyle = FlatStyle.Flat;


            Label label = new Label();
            label.Text = name;
            //label.AutoSize = true;
            label.Width = 150;
            label.Height = 200;
            label.TextAlign = ContentAlignment.TopLeft;
            //label.TextAlign.Equals("MiddleCenter");
            label.Location = new Point(panX + 45, panY + 8);
            label.Font = new Font("Consolas", 14);

            panel.Controls.Add(button);
            panel.Controls.Add(label);
            //panel.BorderStyle = BorderStyle.None;
            
            flowLayoutPanel.Controls.Add(panel);
        }

        private void read_Click(object sender, EventArgs e)
        {
            file = ((Button)sender).Tag.ToString();
            new PDFView(file).ShowDialog();
        }

        private void LoadFromDb()
        {
            materials = Materials.GetMaterials();
            subject = new List<Materials>();
            foreach (Materials m in materials)
            {
                if (m.Subject.Trim() == room)
                    subject.Add(m);
            }

            foreach (Materials m in subject)
            {
                Console.WriteLine(m.Name + " " + m.Subject);
            }
            
        }

        private void Lessons_Load(object sender, EventArgs e)
        {
            LoadFromDb();
            foreach(Materials m in subject)
            {
                GenPanel(m.Name);
            }
        }
    }
}
