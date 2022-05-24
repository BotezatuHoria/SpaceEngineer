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
    public partial class Questions : Form
    {
        List<QandA> qa;
        List<bool> askedIndx;
        Random rndm = new Random();
        int score = 0;
        int questionIndex = 0;

        public Questions()
        { 
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
                answer.Location = new Point(120 , 30 + i * 50);
                answer.Text = a.Ans;
                answer.Tag = a.Valid;
                panel1.Controls.Add(answer);
                i++;
            }
        }

        private void Questions_Load(object sender, EventArgs e)
        {
            qa = QandA.LoadQandAFromDatabase();
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
            if (questionIndex + 1 < qa.Count)
            {
                questionIndex++;
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
                //MessageBox.Show(score.ToString());
                NextQandA();
            }
            
        }

        private void Questions_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show(score.ToString());
        }

        /*public int randomIndex(Obj x)
        {
            int y = rndm.Next(x.a, x.b);
            while (askedIndx[y].Equals(true)
            {
                y = rndm.Next(x.a, x.b);
            }
            if (askedIndx[y].Equals(false)
            {
                askedIndx[y] = true;
            }
            
            return y;
        }*/

        public int Score
        {
            get { return score; }
            set { score = value; }
        }
    }
}
