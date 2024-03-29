﻿using System;
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

        /// The constructors for a new Question object.
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
            question.Insert(_question, _expl, _subject);
            this.idQuestion = Convert.ToInt32(question.GetData().Last()["IdQuestion"]);
        }

        /// This function deletes the object from the database.
        public void Delete()
        {
            QuestionsTableAdapter questionsTableAdapter = new QuestionsTableAdapter();
            SpaceGame.DatabaseDataSet.QuestionsDataTable questions = questionsTableAdapter.GetData();
            questions.Rows.Remove(questions.FindByIdQuestion(this.idQuestion));
            questionsTableAdapter.Delete(this.idQuestion, this.subject);
        }

        /// This gets and sets the id of an Question object.
        public int IdQuestion
        {
            get { return IdQuestion; }
            set { this.IdQuestion = value; }
        }

        /// This gets and sets the question string of an Question object.
        public string Quest
        {
            get { return question; }
            set{ this.question = value;}
        }

        /// This gets and sets the explanation string of an Question object.
        public string Explanation
        {
            get { return expl; }
            set { this.expl = value; }
        }

        /// This gets and sets the subject of an Question object.
        public string Subject
        {
            get { return subject; }
            set { this.subject = value; }
        }
    }
}
