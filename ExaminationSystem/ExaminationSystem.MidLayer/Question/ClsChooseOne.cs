using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.MidLayer.Question
{
    public class ClsChooseOne : ClsQuestion
    {
        public ClsChooseOne(string body, Dictionary<int, string> options, params int[] correctAnswer) : base(body, options, correctAnswer)
        {
            Header = "Read each question carefully and select the best answer from the given options :";
            Mark = 3;
        }
    }
}
