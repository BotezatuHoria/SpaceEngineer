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
        private string question, expl, subject;

        public Question(int _idQuestion)
        {
            this.idQuestion = _idQuestion;
            var question = new QuestionsTableAdapter();
            DataTable dataTable = question.GetData();
            DataView dataView = dataTable.DefaultView;

            dataView.RowFilter = String.Format("IdQuestion = {0}", _idQuestion);
            
            this.question = Convert.ToString(dataView[0]["Question"]);
            this.expl = Convert.ToString(dataView[0]["Explanation"]);
            this.subject = Convert.ToString(dataView[0]["Subject"]);

        }

        public Question(string _question, string _expl, string _subject)
        {
            this.question = _question;
            this.expl = _expl;
            this.subject = _subject;

            QuestionsTableAdapter question = new QuestionsTableAdapter();
            //question.Insert(this.question, this.expl);
            this.idQuestion = Convert.ToInt32(question.GetData().Last()["IdQuestion"]);
        }

        public int IdQuestion
        {
            get { return IdQuestion; }
        }

        public string Quest
        {
            get { return question; }
            set{ this.question = value;}
        }

        public string Explanation
        {
            get { return expl; }
            set { this.expl = value; }
        }

        public string Subject
        {
            get { return subject; }
            set { this.subject = value; }
        }
    }
}
