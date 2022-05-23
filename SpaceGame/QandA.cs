using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using SpaceGame.DatabaseDataSetTableAdapters;

namespace SpaceGame
{
    public class QandA
    {
        private int idQuestion;
        private List<Question> questions;

        public QandA(int _idQuestion)
        {
            this.idQuestion = _idQuestion;
            QandATableAdapter qandaAdapter = new QandATableAdapter();
            DataTable qanda = qandaAdapter.GetData();
            DataView qandaView = qanda.DefaultView;
            qandaView.RowFilter = String.Format("IdQuestion = {0}", _idQuestion);

            questions = new List<Question>();

            QuestionsTableAdapter questTa = new QuestionsTableAdapter();
            DataTable questTable = questTa.GetData();
            DataView questView = questTable.DefaultView;
            questView.RowFilter = String.Format("IdQuestion = {0}", this.idQuestion);

            foreach (DataRowView dataRow in questView)
                questions.Add(new Question(Convert.ToInt32(dataRow["IdQuestion"])));

        }
        

        public static List<QandA> LoadQandAFromDatabase()
        {
            List<QandA> qandaList = new List<QandA>();
            QandATableAdapter qaAdapter = new QandATableAdapter();
            DataTable qaTabel = qaAdapter.GetData();
            foreach (DataRow dr in qaTabel.Rows)
                qandaList.Add(new QandA(Convert.ToInt32(dr["IdQuestion"])));

            return qandaList;
        }

        public int IdQuestion
        {
            get { return this.idQuestion; }
        }


        public List<Question> Questions
        {
            get { return this.questions; }
            set { this.questions = value; }
        }

    }
}
