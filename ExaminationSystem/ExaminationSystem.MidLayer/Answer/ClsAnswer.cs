using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.MidLayer.Answer
{
    public class ClsAnswer
    {
        public Dictionary<int, string> Answer { get; set; }
        public int Mark { get; set; }
        public ClsAnswer(Dictionary<int, string> answer =null)
        {
            Answer = answer ?? [];
        }

        public override string ToString()
        {
            return $"answer :\n{GetAnswer()}";
        }

        string GetAnswer()
        {
            string s = "";
            if (Answer != null) return s;
            foreach (var item in Answer)
            {
                s += $"[{item.Key}] {item.Value} ";
            }
            return s.Trim();
        }
    }
}
