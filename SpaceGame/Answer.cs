using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using SpaceGame.DatabaseDataSetTableAdapters;

namespace SpaceGame
{
    public class Answer
    {
        private int idAnswer, idQuestion;
        string ans;
        bool valid;

        public Answer()
        {

        }

        public Answer(int _idAnswer)
        {
            idAnswer = _idAnswer;
            AnswersTableAdapter answers = new AnswersTableAdapter();
            var datatable = answers.GetData();
            var answer = datatable.FindByIdAnswer(_idAnswer);
            this.idQuestion = Convert.ToInt32(answer["IdQuestion"]);
            this.ans = Convert.ToString(answer["Answer"]);
            this.valid = Convert.ToBoolean(answer["isValid"]);
        }

        public Answer(int _idQuestion, string _ans, bool _valid)
        {
            this.ans = _ans;
            this.valid = _valid;
            this.idQuestion = _idQuestion;
            AnswersTableAdapter answersTableAdapter = new AnswersTableAdapter();
            answersTableAdapter.Insert(_ans, _idQuestion, _valid);
            this.idAnswer = Convert.ToInt32(answersTableAdapter.GetData().Last()["IdAnswer"]);
        }
        
        public void Delete()
        {
            AnswersTableAdapter answersTableAdapter = new AnswersTableAdapter();
            SpaceGame.DatabaseDataSet.AnswersDataTable answers = answersTableAdapter.GetData();
            answers.Rows.Remove(answers.FindByIdAnswer(this.idAnswer));
            answersTableAdapter.Delete(this.idAnswer, this.ans, this.idQuestion, this.valid);
        }

        public int IdAnswer
        {
            get { return idAnswer; }
            set { idAnswer = value; }
        }

        public int IdQuestion
        {
            get { return IdQuestion; }
            set { this.IdQuestion = value; }
        }

        public string Ans
        {
            get { return ans; }
            set { this.ans = value; }
        }

        public bool Valid
        {
            get { return valid; }
            set { this.valid = value; }
        }
    }
}
