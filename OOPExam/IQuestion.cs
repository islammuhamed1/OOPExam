using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExam
{
    interface IQuestion
    {
        string Body { get; set; }
        int Mark { get; set; }
        void AddQuestion();
    }
}
