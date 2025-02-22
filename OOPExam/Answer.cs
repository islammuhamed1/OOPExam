using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExam
{
    class Answer
    {
        int Id { get; set; }
        int Text { get; set; }
        public Answer(int id, int text)
        {
            this.Id = id;
            this.Text = text;
        }
        public override string ToString()
        {
            return $"AnswerID {Id} - AnswerText {Text}";
        }
    }
}
