using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExam
{
    class FinalExam : Exam
    {
        public FinalExam(int time, int numOfQuestions) : base(time, numOfQuestions) { }

        public override void GenerateListOfQuestions()
        {
            for (int i = 0; i < NumberOfQuestions; i++)
            {
                int choice = InputIntValidator.ValidateInt("Choose: 1 for MCQ, 2 for True/False", 1, 2);
                Questions.Add(choice == 1 ? new MCQQuestions() : new TrueOrFalseQuestions());
                Questions[i].AddQuestion();
            }
        }

        public override void DisplayExam()
        {
            int grade = 0;
            int totalMarks = 0;
            foreach (var question in Questions)
            {
                Console.WriteLine(question);
                question.Answers.ForEach(Console.WriteLine);

                int userAnswerId = InputIntValidator.ValidateInt("Enter your answer:", 1, question.Answers.Count);
                question.UserAnswer = question.Answers[userAnswerId - 1];

                if (question.UserAnswer.Id == question.RightAnswer.Id)
                    grade += question.Mark;
                totalMarks += question.Mark;
            }


            Console.WriteLine($"Your Grade: {grade}/{totalMarks}");
            Console.WriteLine($"Total Marks: {totalMarks}");
        }
    }
}

