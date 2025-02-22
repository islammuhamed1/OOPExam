using System.Diagnostics;

namespace OOPExam
{
    class Program
    {
        static void Main()
        {
            Subject subject = new(5, "OOP");
            subject.CreateExam();
            Console.Clear();

            var stopwatch = Stopwatch.StartNew();
            if (ValidateChar("Do you want to start the exam? (y/n)") == 'y')
            {
                subject.ExamSubject?.DisplayExam();
                stopwatch.Stop();
                Console.WriteLine($"Time Elapsed: {stopwatch.Elapsed}");
            }
        }

    

        private static char ValidateChar(string message)
        {
            char value;
            do { Console.WriteLine(message); }
            while (!(char.TryParse(Console.ReadLine(), out value) && (value == 'y' || value == 'n')));
            return value;
        }
    }
}
