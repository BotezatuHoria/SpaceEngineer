using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceGame
{
    public partial class Questions : Form
    {
        List<QandA> qa;
        List<bool> askedIndx;
        Random rndm = new Random();
        int score = 0;
        int questionIndex = 0;
        string room = null;
        int pace = 1;

        public Questions(string _room)
        {
            room = _room;
            InitializeComponent();
        }

        private void LoadQuestion(int indx)
        {
            ClearInputs();

            textBox1.Text = qa[indx].Question;

            int i = 0;
            foreach(Answer a in qa[indx].Answers)
            {
                var answer = new RadioButton();
                answer.AutoSize = false;
                answer.Width = 770;
                answer.Location = new Point(100 , 30 + i * 55);
                answer.Text = a.Ans;
                answer.Tag = a.Valid;
                panel1.Controls.Add(answer);
                i++;
            }
        }

        private void Questions_Load(object sender, EventArgs e)
        {
            qa = QandA.LoadQandAFromDatabase();
            questionIndex = randomIndex();
            LoadQuestion(questionIndex);
            ///MessageBox.Show(qa[0].Answers[2].Ans.ToString());
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (questionIndex + 1 < qa.Count)
            {
                questionIndex++;
                LoadQuestion(questionIndex);
            }
        }

        public bool ValidateAnswer()
        {
            foreach (Control i in panel1.Controls)
            {
                if (i is RadioButton)
                {
                    var box = (RadioButton)i;
                    if (Convert.ToBoolean(box.Checked) == Convert.ToBoolean(box.Tag) && Convert.ToBoolean(box.Tag) == true)
                        return true;
                }
            }
            return false;
        }

        public void ClearInputs()
        {
            textBox1.Clear();
            panel1.Controls.Clear();
        }

        private void explButton_Click(object sender, EventArgs e)
        {
            new Explain(qa[questionIndex]).ShowDialog();
            NextQandA();
        }

        private void prevButton_Click(object sender, EventArgs e)
        {
            if (questionIndex - 1 > -1)
            {
                questionIndex--;
                LoadQuestion(questionIndex);
            }
        }

        private void NextQandA()
        {
            
            explButton.Visible = false;
          
            if (pace <= 5)
            {
                pace++;
                questionIndex = randomIndex();
                LoadQuestion(questionIndex);
            }
            else
            {
                this.Close();
            }
            
        }

        private void validButton_Click(object sender, EventArgs e)
        {
            bool vld = ValidateAnswer();

            if (vld.Equals(false))
                explButton.Visible = true;
            else
            {
                score++;
                NextQandA();
            }
            
        }

        private void Questions_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        public int randomIndex()
        {
            int a = 0, b = 0;
            if (room == "math")
            {
                a = 10;
                b = 20;
            }
            if (room == "phy")
            {
                a = 20;
                b = 30;
            }
            if (room == "chem")
            {
                a = 30;
                b = 40;
            }
            if (room == "prog")
            {
                a = 0;
                b = 10;
            }
            int y = rndm.Next(a, b);
            /*while (askedIndx[y].Equals(true))
            {
                y = rndm.Next(a, b);
            }
            if (askedIndx[y].Equals(false))
            {
                askedIndx[y] = true;
            }
            bool ok = false;
            for (int i = 0; i <= askedIndx.Count() - 1; ++i)
                if (askedIndx[i] == false)
                    ok = true;
            if (ok == false)
                return -1;*/

            return y;
        }

        public int Score
        {
            get { return score; }
            set { score = value; }
        }

        private void Questions_FormClosing(object sender, FormClosingEventArgs e)
        {
            using (StreamWriter writetext = new StreamWriter("score.txt"))
            {
                writetext.WriteLine(score.ToString());
            }
        }
    }
}
