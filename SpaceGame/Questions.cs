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
        public Random rndm = new Random();
        int score = 0;
        int questionIndex = 0;
        public string room = null;
        int pace = 1;
        const int maxpace = 5;
        List<QandA> array;
        string scr = null;
        public int finScore = 0;

        public Questions(string _room)
        {
            room = _room;
            InitializeComponent();
        }

        /// This function displays a question and it's answers from the array that contains them.
        private void LoadQuestion(int indx)
        {
            mistakeLabel.Visible = false;
            ClearInputs();
            if (array[indx - 1] != null)
            {
                //textBox1.Text = array[indx - 1].Question;
                questionLabel.Text = array[indx - 1].Question;
            }    
            else
            {
                while(array[indx - 1] == null)
                {
                    indx = RandomIndex();
                }
                //textBox1.Text = array[indx - 1].Question;
                questionLabel.Text = array[indx - 1].Question;
            }
            //if (array[indx])
            //textBox1.Text = qa[array[indx] - 1].Question;
            int i = 0;
            foreach(Answer a in array[indx - 1].Answers)
            {
                var answer = new RadioButton();
                answer.AutoSize = false;
                answer.Width = 670;
                answer.Height = 75;
                answer.Location = new Point(100 , i * 75);
                answer.Text = a.Ans;
                answer.Tag = a.Valid;
                answer.ForeColor = Color.White;
                answer.Font = new Font("Consolas", 20);
                ansPanel.Controls.Add(answer);
                i++;
            }
        }

        /// This function gets all the data from the database when the form is being loaded.
        private void Questions_Load(object sender, EventArgs e)
        {
            qa = QandA.LoadQandAFromDatabase();
            CreateNewQandA();
            CreateList();
            questionIndex = RandomIndex();
            //Console.WriteLine(questionIndex);
            LoadQuestion(questionIndex);
            ///MessageBox.Show(qa[0].Answers[2].Ans.ToString());
        }

        /// This function validates the answer.
        public bool ValidateAnswer()
        {
            foreach (Control i in ansPanel.Controls)
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

        /// This function clears the inputs.
        public void ClearInputs()
        {
            //textBox1.Clear();            
            ansPanel.Controls.Clear();
        }

        /// This function opens a new Explain form based on the question that the user got wrong.
        private void explButton_Click(object sender, EventArgs e)
        {
            new Explain(array[questionIndex - 1]).ShowDialog();
            NextQandA();
        }

        /// This function loads a new QandA.
        private void NextQandA()
        {
            BackgroundImage = SpaceGame.Properties.Resources.Explicatienobutton1;
            explButton.Visible = false;
          
            if (pace <= maxpace)
            {
                pace++;
                questionIndex = RandomIndex();
                LoadQuestion(questionIndex);
            }
            else
            {
                this.Close();
            }
            
        }

        /// This function sees if the answer is correct or not and based on that gets to the next question or makes visible and active the explanation button.

        private void validButton_Click(object sender, EventArgs e)
        {
            bool vld = ValidateAnswer();

            if (vld.Equals(false))
            {
                explButton.Visible = true;
                mistakeLabel.Visible = true;
                BackgroundImage = SpaceGame.Properties.Resources.Explicatie12;
            }
            else
            {
                score++;
                NextQandA();
            }
            
        }


        /// This function generates a new random index.
        public int RandomIndex()
        {
            int a = 0, b = indexes.Count();
            int y = rndm.Next(a, b);
            Console.WriteLine("Random index " + y);
            Console.WriteLine("index[y] : " + indexes[y]);
            return indexes[y];
        }

        /// This function is used in order to populate a list of all the indexes.
        public void CreateList()
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

        /// This function is used in order to write in a .txt file the score that the user got during the QandA session.
        private void Questions_FormClosing(object sender, FormClosingEventArgs e)
        {
            using (StreamWriter writetext = new StreamWriter("score.txt"))
            {
                writetext.Write(score.ToString());
            }
            RoomData(room);
        }

        /// This function is used to create an list of QandA objects.
        private void CreateNewQandA()
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

        /// This function is used in order to wite data in a .txt file with the room's name so it can be used to calculate the statistics.
        private void RoomData(string room)
        {
            try
            {
                scr = File.ReadAllText(room.Replace("\n", "").Replace("\r", "") + ".txt");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                if (scr == null)
                {
                    using (StreamWriter write = new StreamWriter(room.Replace("\n", "").Replace("\r", "") + ".txt"))
                    {
                        write.WriteLine("0");
                    }
                }
            }
            //Console.WriteLine("Score final " + scr.Trim());
            finScore = Convert.ToInt32(scr) + score;
            using (StreamWriter writetext = new StreamWriter(room.Replace("\n", "").Replace("\r", "") + ".txt"))
            {
                writetext.WriteLine(finScore);
            }
        }

        private void ansPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
