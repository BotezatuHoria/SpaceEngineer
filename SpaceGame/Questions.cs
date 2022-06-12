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
        List<int> indexes;
        Random rndm = new Random();
        int score = 0;
        int questionIndex = 0;
        string room = null;
        int pace = 1;
        const int maxpace = 5;
        List<QandA> array;

        public Questions(string _room)
        {
            room = _room;
            InitializeComponent();
        }

        private void LoadQuestion(int indx)
        {
            mistakeLabel.Visible = false;
            ClearInputs();
            if (array[indx - 1] != null)
                textBox1.Text = array[indx - 1].Question;
            else
            {
                while(array[indx - 1] == null)
                {
                    indx = randomIndex();
                }
                textBox1.Text = array[indx - 1].Question;
            }
            //if (array[indx])
            //textBox1.Text = qa[array[indx] - 1].Question;
            int i = 0;
            foreach(Answer a in array[indx - 1].Answers)
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
            createNewQandA();
            createList();
            questionIndex = randomIndex();
            //Console.WriteLine(questionIndex);
            LoadQuestion(questionIndex);
            ///MessageBox.Show(qa[0].Answers[2].Ans.ToString());
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            /*if (questionIndex + 1 < qa.Count)
            {
                questionIndex++;
                LoadQuestion(questionIndex);
            }*/
            //createList();
            
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
            new Explain(array[questionIndex - 1]).ShowDialog();
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
          
            if (pace <= maxpace)
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
            {
                explButton.Visible = true;
                mistakeLabel.Visible = true;
            }
            else
            {
                score++;
                NextQandA();
            }
            
        }

        private void Questions_FormClosed(object sender, FormClosedEventArgs e)
        {
            //createList();
        }

        public int randomIndex()
        {
            int a = 0, b = indexes.Count();
            int y = rndm.Next(a, b);
            Console.WriteLine("Random index " + y);
            Console.WriteLine("index[y] : " + indexes[y]);
            return indexes[y];
        }

        public void createList()
        {
            indexes = new List<int>();
            foreach (QandA q in qa)
            {
                if (q.Subject.Trim() == room)
                {
                    int cnt = indexes.Count();
                    indexes.Add(q.IdQuestion);
                    Console.WriteLine("index: {0}, Question: {1}, id {2}", cnt, q.Question, q.IdQuestion);
                }

            }

            //for (int i = 0; i < indexes.Count(); ++i)
              //  Console.WriteLine(indexes[i]);

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
            roomData(room);
        }

        private void createNewQandA()
        {
            array = new List<QandA>();
            foreach (QandA q in qa)
            {
                int cnt = array.Count();
                while (q.IdQuestion - cnt > 1)
                {
                    array.Add(null);
                    cnt = array.Count();
                }

                array.Add(q);
                Console.WriteLine(cnt + " " + array[cnt].IdQuestion + " " + q.IdQuestion + " " + q.Question);
                //Console.WriteLine(q.IdQuestion + " " + q.Question + " ");
            }
            Console.WriteLine(qa.Count());
        }


        private void roomData(string room)
        {
            string scr = File.ReadAllText(room.Replace("\n", "").Replace("\r", "") + ".txt");
            using (StreamWriter writetext = new StreamWriter(room.Replace("\n", "").Replace("\r", "") + ".txt"))
            {
                if (scr == null)
                    writetext.WriteLine(0 + score);
                else
                    writetext.WriteLine(scr + score.ToString());
            }
        }
    }
}
