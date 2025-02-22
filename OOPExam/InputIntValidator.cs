using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExam
{
    static class InputIntValidator
    {
        public static int ValidateInt(string message, int min = int.MinValue, int max = int.MaxValue)
        {
            int value;
            do { Console.WriteLine(message); }
            while (!(int.TryParse(Console.ReadLine(), out value) && value >= min && value <= max));
            return value;
        }
    }
}
