using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExam
{
    class TrueOrFalseQuestions : Questions
    {
        public override string Header => "True or False Question";

        public TrueOrFalseQuestions()
        {
            Answers.Add(new Answer(1, "True"));
            Answers.Add(new Answer(2, "False"));
        }

        public override void AddQuestion()
        {
            Console.WriteLine(Header);
            do
            {
                Console.WriteLine("Enter Question Body:");
                Body = Console.ReadLine() ?? " ";
            } while (string.IsNullOrWhiteSpace(Body));

            Mark = InputIntValidator.ValidateInt("Enter Question Mark:", 1);

            int rightAnswerId = InputIntValidator.ValidateInt("Enter Right Answer (1 for True, 2 for False):", 1, 2);
            RightAnswer = Answers[rightAnswerId - 1];

            Console.Clear();
        }
    }
}
