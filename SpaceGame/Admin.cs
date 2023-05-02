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
using System.Data.SqlClient;
using System.IO;

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
        List<string> controls;
        List<QandA> qa;
        List<QandA> array;
        Question quest;

        public Admin()
        {
            InitializeComponent();
            this.Width = 1437;
            this.Height = 717;
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            this.qandATableAdapter.Fill(this.databaseDataSet.QandA);
            firstAnswer();   
        }


        /// This function creates a TextBox with a RadioButton next to it.
        /// These 2 new controls are then added to the Panel so they can be displayed.

        public void NewAnswer(int pace)
        {
            var answer = new TextBox();
            var answerButton = new RadioButton();
            answer.Font = new Font("Consolas", 12);
            answer.ForeColor = Color.Black;
            answer.BackColor = Color.DarkOrange;
            answer.BorderStyle = BorderStyle.FixedSingle;
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

        /// This function counts how many answers the user has created and if it goes over the value of maxAnswers an error message will be displayed.
        private void answerButton_Click(object sender, EventArgs e)
        {
            answersNr++;
            if (answersNr <= maxAnswers)
                NewAnswer(pace);
            else
            {
                MessageBox.Show("Puteti introduce maxim 6 raspunsuri.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        /// This function gahters all the data the user has entered.
        private void GetData()
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

        /// This function creates a new Qusetion and it's answers from the data that has been gathered from the user.  
        private void sendButton_Click(object sender, EventArgs e)
        {
            if (Errors() == true)
            {
                GetData();
                quest = new Question(questionstr, explstr, subjectstr);
                for (int i = 0; i < controls.Count(); i = i + 2)
                {
                    Answer answer = new Answer(lastQuestionId(), controls[i], Convert.ToBoolean(controls[i + 1]));
                }
                refreshDataGrid();
                clearInputs();
            }
        }

        /// This function finds the last id from the Questions table.
        private int lastQuestionId()
        {
            var question = new QuestionsTableAdapter();
            DataTable dataTable = question.GetData();
            DataView dataView = dataTable.DefaultView;
            return Convert.ToInt32(dataView[dataView.Count - 1][0]);
            //return dataView.Count;
        }

        /// This function is used to refresh the DataGrid.
        private void refreshDataGrid()
        {
            QandATableAdapter qanda = new QandATableAdapter();
            DataTable table = qanda.GetData();
            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;
            dataGridView.DataSource = bSource;
            dataGridView.Update();
            dataGridView.Refresh();
        }

        /// This function is used to clear all the inputs from the user in order to add a new one.
        private void clearInputs()
        {
            question.Clear();
            answersPanel.Controls.Clear();
            explanationTextBox.Clear();
            mathsRadButton.Checked = false;
            phyRadButton.Checked = false;
            chemRadButton.Checked = false;
            progRadButton.Checked = false;
            answerButtonPosX = 0;
            answerButtonPosY = 0;
            answersNr = 1;
            firstAnswer();
        }

        /// This function is used to generate the new answer TextBox and RadioButton that the user can interact with.
        private void firstAnswer()
        {
            var answer = new TextBox();
            var answerButton = new RadioButton();
            answer.Font = new Font("Consolas", 12);
            answer.ForeColor = Color.Black;
            answer.BackColor = Color.DarkOrange;
            answer.BorderStyle = BorderStyle.FixedSingle;
            answerButtonPosX = answerButton.Location.X;
            answerButtonPosY = answerButton.Location.Y;
            answer.Location = new Point(answerButtonPosX + 20, answerButtonPosY);
            answer.Width = 600;
            answer.Height = 30;
            answer.Multiline = true;
            answersPanel.Controls.Add(answer);
            answersPanel.Controls.Add(answerButton);
        }

        /// This function deletes the question and it's answers from the database based on the cell that the user had selected before clicking the button. After this the DataGird refreshes.
        private void eraseButton_Click(object sender, EventArgs e)
        {
            int crrCell = Convert.ToInt32(dataGridView.CurrentRow.Cells[5].Value);
            //Console.WriteLine(crrCell);
            qa = QandA.LoadQandAFromDatabase();

            array = new List<QandA>();
            foreach (QandA qaa in qa)
            {
                int cnt = array.Count();
                while (qaa.IdQuestion - cnt > 1)
                {
                    array.Add(null);
                    cnt = array.Count();
                }

                array.Add(qaa);
                //Console.WriteLine(cnt + " " + array[cnt].IdQuestion + " " + qaa.IdQuestion + " " + qaa.Question);
                //Console.WriteLine(q.IdQuestion + " " + q.Question + " ");
            }

            foreach (Answer a in array[Convert.ToInt32(crrCell) - 1].Answers)
            {
                Answer answer = new Answer(a.IdAnswer);
                answer.Delete();
            }
                

            refreshDataGrid();
            //dataGridView.Rows.Remove(dataGridView.CurrentRow);

            Question q = new Question(crrCell);
            //Question q = new Question(83);
            q.Delete();
            MessageBox.Show("Intrebarea a fost stearsa cu succes", "Informare", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        /// This function encludes all the errors that might occur in case the user did not pay attention to all the fields that had to be filled.
        private bool Errors()
        {
            int cnt = 0;
            if (String.IsNullOrWhiteSpace(question.Text))
            {
                MessageBox.Show("Nu ati introdus o intrebare.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            foreach(Control c in answersPanel.Controls)
            {
                if (c is TextBox && String.IsNullOrWhiteSpace(c.Text))
                {
                    MessageBox.Show("Nu ati introdus un raspuns.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (c is RadioButton)
                {
                    var i = (RadioButton)c;
                    if (i.Checked == false)
                    {
                        cnt++;
                    }
                   
                    if (cnt == answersNr)
                    {
                        MessageBox.Show("Nu ati selectat raspunsul corect.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }

                }
            }
            if (String.IsNullOrWhiteSpace(explanationTextBox.Text))
            {
                MessageBox.Show("Nu ati introdus o explicatie.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (mathsRadButton.Checked == false && phyRadButton.Checked == false && chemRadButton.Checked == false && progRadButton.Checked == false)
            {
                MessageBox.Show("Nu ati selectat materia.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        /// This is a function that displays in the output console the value in the DataGrid that the user selected.
        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Console.WriteLine(dataGridView.CurrentCell.Value);
            //dataGridView.Rows.Remove(dataGridView.CurrentRow);
            //Console.WriteLine(dataGridView.CurrentCell.Value);
            //Console.WriteLine(dataGridView.Columns[dataGridView.CurrentRow.Index]);
            Console.WriteLine(dataGridView.CurrentRow.Cells[5].Value);
        }
    }
}
