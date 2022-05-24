using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using SpaceGame.DatabaseDataSetTableAdapters;
using System.Windows.Forms;

namespace SpaceGame
{
    public class QandA
    {
        private int idQuestion;
        private List<Answer> answers;
        private string question;
        private string explanation;

        public QandA()
        {
            answers = new List<Answer>();
        }

        public QandA(int _idQuestion)
        {
            this.idQuestion = _idQuestion;
            QandATableAdapter qandaAdapter = new QandATableAdapter();
            DataTable qanda = qandaAdapter.GetData();
            DataView qandaView = qanda.DefaultView;
            qandaView.RowFilter = String.Format("IdQuestion = {0}", _idQuestion);

            this.question = Convert.ToString(qandaView[0]["Question"]);
            this.explanation = Convert.ToString(qandaView[0]["Explanation"]);

            answers = new List<Answer>();

            AnswersTableAdapter ansTa = new AnswersTableAdapter();
            DataTable ansTable = ansTa.GetData();
            DataView ansView = ansTable.DefaultView;
            ansView.RowFilter = String.Format("IdQuestion = {0}", this.idQuestion);

            foreach (DataRowView dataRow in ansView)
                answers.Add(new Answer(Convert.ToInt32(dataRow["IdAnswer"])));
        }
        

        public static List<QandA> LoadQandAFromDatabase()
        {
            List<QandA> qandaList = new List<QandA>();
            QandATableAdapter qaAdapter = new QandATableAdapter();
            DataTable qaTabel = qaAdapter.GetData();

            int prevQuestionId = -1;
            
            foreach (DataRow dr in qaTabel.Rows)
            {
                Answer ans = new Answer();
                ans.IdAnswer = Convert.ToInt32(dr["IdAnswer"]);
                ///ans.IdQuestion = Convert.ToInt32(dr["IdQuestion"]);
                ans.Ans = dr["Answer"].ToString();
                ans.Valid = Convert.ToBoolean(dr["isValid"]);

                
                int currentQuestionId = Convert.ToInt32(dr["IdQuestion"]);
                if (prevQuestionId != currentQuestionId)
                {
                    QandA qandaItem = new QandA();
                    qandaItem.idQuestion = Convert.ToInt32(dr["IdQuestion"]);
                    qandaItem.question = dr["Question"].ToString();
                    qandaItem.explanation = dr["Explanation"].ToString();
                    if (qandaItem.answers.Count > 0)
                        qandaItem.answers.Clear();

                    qandaList.Add(qandaItem);
                    prevQuestionId = currentQuestionId;
                }

                qandaList[qandaList.Count - 1].Answers.Add(ans);                
            }
/*
            foreach (var item in qandaList)
            {
                MessageBox.Show(item.question);
                foreach (var answer in item.answers)
                {
                    MessageBox.Show(answer.Ans);
                }
                
            }
*/
            return qandaList;
        }

        public int IdQuestion
        {
            get { return this.idQuestion; }
        }

        public string Question
        {
            get { return this.question; }
            set { this.question = value; }
        }

        public List<Answer> Answers
        {
            get { return this.answers; }
            set { this.answers = value; }
        }

        public string Explanation
        {
            get { return this.explanation; }
            set { this.explanation = value; }
        }

    }
}
