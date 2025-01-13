using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.MidLayer.Question
{
    public class ClsTrueFalse : ClsQuestion
    {

        public ClsTrueFalse(string body, params int [] correctAnswer) : base(body, new Dictionary<int, string> { [1] = "True", [2] = "False" }, correctAnswer)
        {
            Header = "Answer the following True or False questions (Enter 1 for True, 2 for False):";
            Mark = 2;
        }
    }
}
