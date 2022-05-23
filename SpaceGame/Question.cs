using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using SpaceGame.DatabaseDataSetTableAdapters;

namespace SpaceGame
{
    public class Question
    {
        private int idQuestion;
        private string question, expl;
        private List<Answer> lstans;

        public Question(int _idQuestion)
        {
            this.idQuestion = _idQuestion;
            var question = new QuestionsTableAdapter();
            DataTable dataTable = question.GetData();
            DataView dataView = dataTable.DefaultView;

            dataView.RowFilter = String.Format("IdQuestion = {0}", _idQuestion);
            
            this.question = Convert.ToString(dataView[0]["Question"]);

            var answers = new AnswersTableAdapter();
            dataTable = answers.GetData();
            dataView = dataTable.DefaultView;
            dataView.RowFilter = String.Format("IdQuestion = {0}", _idQuestion);

            lstans = new List<Answer>();
            foreach (DataRowView drView in dataView)
            {
                lstans.Add(new Answer(Convert.ToInt32(drView["IdAnswer"])));
            }
        }

        public Question(string _question, string _expl)
        {
            this.question = _question;
            this.expl = _expl;

            QuestionsTableAdapter question = new QuestionsTableAdapter();
            question.Insert(this.question, this.expl);
            this.idQuestion = Convert.ToInt32(question.GetData().Last()["IdQuestion"]);
        }

        public int IdQuestion
        {
            get { return IdQuestion; }
        }

        public string Quest
        {
            get { return question; }
            set
            {
                this.question = value;
                QuestionsTableAdapter questionTableAdapter = new QuestionsTableAdapter();
                SpaceGame.DatabaseDataSet.QuestionsDataTable data = questionTableAdapter.GetData();
                data.Rows.Find(this.idQuestion)["Question"] = value;
                questionTableAdapter.Update(data);
            }
        }

        public List<Answer> LastAns
        {
            get { return this.lstans; }
            set { this.lstans = value; }
        }
    }
}
