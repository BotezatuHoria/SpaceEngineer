using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpaceGame.DatabaseDataSetTableAdapters;

namespace SpaceGame
{
    public partial class Admin : Form
    {
        private int pace = 20;
        private int answersNr = 1;
        private int answerButtonPosX = 0;
        private int answerButtonPosY = 0;
        private int maxAnswers = 6;
        private string questionstr;
        private string explstr;
        private string subjectstr;
        List<string> answersstr;
        private int goodindx;
        List<string> controls;
        Question quest;

        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.QandA' table. You can move, or remove it, as needed.
            this.qandATableAdapter.Fill(this.databaseDataSet.QandA);
            var answer = new TextBox();
            var answerButton = new RadioButton();
            answerButtonPosX = answerButton.Location.X;
            answerButtonPosY = answerButton.Location.Y;
            answer.Location = new Point(answerButtonPosX + 20, answerButtonPosY);
            answer.Width = 600;
            answer.Height = 30;
            answer.Multiline = true;
            answersPanel.Controls.Add(answer);
            answersPanel.Controls.Add(answerButton);
        }
        public void newAnswer(int pace)
        {
            var answer = new TextBox();
            var answerButton = new RadioButton();
            answerButton.Location = new Point(answerButtonPosX, answerButtonPosY + 2 * pace);
            answerButtonPosY += 2 * pace;
            answer.Location = new Point(answerButtonPosX + 20, answerButtonPosY);
            //answerButtonPosY += 2 * pace;
            answer.Width = 600;
            answer.Height = 30;
            answer.Multiline = true;
            answersPanel.Controls.Add(answer);
            answersPanel.Controls.Add(answerButton);
        }

        private void answerButton_Click(object sender, EventArgs e)
        {
            answersNr++;
            if (answersNr <= maxAnswers)
                newAnswer(pace);
            else
            {
                MessageBox.Show("Puteti introduce maxim 6 raspunsuri.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void getData()
        {
            //Question part
            questionstr = question.Text;
            explstr = explanationTextBox.Text;
            if (mathsRadButton.Checked == true)
                subjectstr = "math";
            if (phyRadButton.Checked == true)
                subjectstr = "phy";
            if (progRadButton.Checked == true)
                subjectstr = "prog";
            if (chemRadButton.Checked == true)
                subjectstr = "chem";
            
            //Answers part
            answersstr = new List<string>();
            controls = new List<string>();
            int ansY = 0;
            foreach (Control c in answersPanel.Controls)
            {
                if (c is TextBox)
                {
                    answersstr.Add(c.Text);
                    ansY = c.Location.Y;
                }
                    
                if (c is RadioButton)
                {
                    var i = (RadioButton)c;
                    if (i.Checked == true)
                        c.Text = "True";
                    else
                        c.Text = "False";
                }
                controls.Add(c.Text);
            }
            for (int i = 0; i < controls.Count(); ++i)
                Console.WriteLine(controls[i]);
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            getData();
            quest = new Question(questionstr, explstr, subjectstr);
            for (int i = 0; i < controls.Count(); i = i + 2)
            {
                Answer answer = new Answer(lastQuestionId(), controls[i], Convert.ToBoolean(controls[i + 1]));
            }
            refreshDataGrid();

        }

        private int lastQuestionId()
        {
            var question = new QuestionsTableAdapter();
            DataTable dataTable = question.GetData();
            DataView dataView = dataTable.DefaultView;
            return dataView.Count;
        }

        private void refreshDataGrid()
        {
            QandATableAdapter qanda = new QandATableAdapter();
            DataTable table = qanda.GetData();
            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;
            dataGridView1.DataSource = bSource;
            dataGridView1.Update();
            dataGridView1.Refresh();
        }

    }
}
