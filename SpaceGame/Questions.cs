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
        QandA qa;
        List<int> inpUser;

        int questionIndex = 0;

        public Questions(QandA _qa)
        {
            qa = _qa;
            InitializeComponent();
        }


        private void LoadQuestion(int indx)
        {
            textBox1.Text = qa.Questions[indx].Quest;

            foreach(Answer a in qa.Questions[indx].LastAns)
            {
                var answer = new RadioButton();
                answer.Text = a.Ans;
                answer.Tag = a.Valid;
                panel1.Controls.Add(answer);
            }
        }

        private void LoadQandA()
        {
            LoadQuestion(questionIndex);
        }

        private void Questions_Load(object sender, EventArgs e)
        {
            LoadQandA();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (questionIndex + 1 < qa.Questions.Count)
            {
                questionIndex++;
                LoadQuestion(questionIndex);
            }
        }
    }
}
