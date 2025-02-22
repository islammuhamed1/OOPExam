﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExam
{
    class Answer
    {
        public int Id { get;  set; }
        public string Text { get;  set; } 

        public Answer(int id = 0, string text = "")
        {
            Id = id;
            Text = text ?? "";
        }

        public override string ToString() => $"AnswerID {Id} - AnswerText {Text}";
    }
}
