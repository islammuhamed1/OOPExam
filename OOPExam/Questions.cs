using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExam
{
    abstract class Questions
    {
        public abstract string Header { get; }
         string Body { get; set; }
         int Mark { get; set; }
         List<Answer> Answers { get; set; }
         Answer RightAnswers { get; set; }
         Answer UserAnswers { get; set; }
        public Questions(string body, int mark, List<Answer> answers, Answer rightAnswers, Answer userAnswers)
        {
            Body = body;
            Mark = mark;
            Answers = answers;
            RightAnswers = rightAnswers;
            UserAnswers = userAnswers;
        }
    }
}
