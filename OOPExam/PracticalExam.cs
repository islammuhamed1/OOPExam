using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExam
{
    class PracticalExam : Exam
    {
        public PracticalExam(int time, int numOfQuestions) : base(time, numOfQuestions) { }

        public override void GenerateListOfQuestions()
        {
            Questions.Clear(); 
            for (int i = 0; i < NumberOfQuestions; i++)
            {
                MCQQuestions question = new MCQQuestions();
                question.AddQuestion();
                Questions.Add(question);
            }
        }

        public override void DisplayExam()
        {
            var stopwatch = System.Diagnostics.Stopwatch.StartNew();
            int totalMarks = 0;
            foreach (var question in Questions)
            {
                Console.WriteLine(question);
                question.Answers.ForEach(Console.WriteLine);
                totalMarks += question.Mark;
                Console.WriteLine("___________________________________");

                int userAnswerId = InputIntValidator.ValidateInt("Enter Your Answer (1, 2, or 3):", 1, question.Answers.Count);
                question.UserAnswer = question.Answers[userAnswerId - 1];

                Console.Clear();
                Console.WriteLine("Practical Exam RightAnswers:");

                for (int i = 0; i < Questions.Count; i++)
                {
                    Console.WriteLine($"{i + 1}: {Questions[i].RightAnswer.Text}");
                }
            }
        }
    }
}


