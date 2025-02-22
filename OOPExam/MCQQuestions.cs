using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExam
{
    class MCQQuestions : Questions
    {
        public override string Header => "MCQ Question";

        public override void AddQuestion()
        {
            Console.WriteLine(Header);
            do
            {
                Console.WriteLine("Enter Question Body:");
                Body = Console.ReadLine() ?? "";
            } while (string.IsNullOrWhiteSpace(Body));

            Mark = InputIntValidator.ValidateInt("Enter Question Mark:", 1);

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Enter Answer {i + 1}:");
                Answers.Add(new Answer(i + 1, Console.ReadLine() ?? ""));
            }

            int rightAnswerId = InputIntValidator.ValidateInt("Enter Right Answer (1, 2, or 3):", 1, 3);
            RightAnswer = Answers[rightAnswerId - 1];
            Console.Clear();
        }

    }
}
