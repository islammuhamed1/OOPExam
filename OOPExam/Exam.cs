using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExam
{
    abstract class Exam
    {
        public int Time { get; private set; }
        public int NumberOfQuestions { get; private set; }
        public List<Questions> Questions { get; private set; } = new();

        protected Exam(int time, int numberOfQuestions)
        {
            Time = time;
            NumberOfQuestions = numberOfQuestions;
        }

        public abstract void DisplayExam();
        public abstract void GenerateListOfQuestions();
    }
}
