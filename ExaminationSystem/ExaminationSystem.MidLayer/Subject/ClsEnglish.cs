using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.MidLayer.Subject
{
    public class ClsEnglish : ClsSubject
    {
        public ClsEnglish(string name, Dictionary<int, ClsStudent> stdList = null) : base(name, stdList)
        {
        }
      
    }
}
