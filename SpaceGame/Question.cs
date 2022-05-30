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

        public Question(int _idQuestion)
        {
            this.idQuestion = _idQuestion;
            var question = new QuestionsTableAdapter();
            DataTable dataTable = question.GetData();
            DataView dataView = dataTable.DefaultView;

            dataView.RowFilter = String.Format("IdQuestion = {0}", _idQuestion);
            
            this.question = Convert.ToString(dataView[0]["Question"]);

        }

        public Question(string _question, string _expl)
        {
            this.question = _question;
            this.expl = _expl;

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

    }
}
