using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExam
{
    abstract class Questions : IQuestion
    {
        public override string ToString() => $"Header: {Header}\nBody: {Body}\nMark: {Mark}";

        public abstract string Header { get; }
        public string Body { get; set; } = string.Empty;
        public int Mark { get; set; }
        public List<Answer> Answers { get; private set; } = new();
        public Answer RightAnswer { get; set; } = new();
        public Answer UserAnswer { get; set; } = new(); 

        public abstract void AddQuestion();

    }
}
