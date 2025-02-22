using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExam
{


    class Subject
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public Exam? ExamSubject { get; private set; }

        public Subject(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void CreateExam()
        {
            int examType = InputIntValidator.ValidateInt("Enter Exam Type (1 for Practical, 2 for Final):", 1, 2);
            int time = InputIntValidator.ValidateInt("Enter Time of Exam:", 1);
            int numberOfQuestions = InputIntValidator.ValidateInt("Enter Number of Questions:", 1);

            ExamSubject = examType == 1 ? new PracticalExam(time, numberOfQuestions) : new FinalExam(time, numberOfQuestions);
            ExamSubject.GenerateListOfQuestions();
        }
    }
}
