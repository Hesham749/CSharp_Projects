using ExaminationSystem.MidLayer.Question;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.MidLayer.Subject
{
    public class ClsMath : ClsSubject
    {
        public ClsMath(string name, Dictionary<int, ClsStudent> stdList = null) : base(name, stdList)
        {
        }

    }
}
