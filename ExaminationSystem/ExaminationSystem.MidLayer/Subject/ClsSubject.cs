using ExaminationSystem.MidLayer.Question;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.MidLayer.Subject
{
    public abstract class ClsSubject : IComparer<ClsSubject>, IComparable<ClsSubject>
    {
        public Dictionary<int, ClsStudent> StdList { get; private set; } = [];
        public string Name { get; init; }
        public ClsQuestionList<ClsSubject> QuestionList { get; set; }
        public ClsSubject(string name, Dictionary<int, ClsStudent> stdList = null)
        {
            Name = name;
            StdList = stdList ?? [];
            QuestionList = new(name);
        }

        public ClsStudent GetStudent(int id)
        {
            if (StdList.ContainsKey(id))
                return StdList[id];
            else return null;
        }

        public bool Add(ClsQuestion question)
        {
            return QuestionList.Add(question);
        }

        public bool Remove(ClsQuestion question)
        {
            return QuestionList.Remove(question);
        }

        public void PrintQuestionList()
        {
            QuestionList.PrintQuestionList();
        }

        public void AddStd(ClsStudent student)
        {
            if (!StdList.ContainsKey(student.Id))
                StdList.Add(student.Id, student);
        }
        public bool RemoveStd(ClsStudent student)
        {
            if (student == null) return false;
            return StdList.Remove(student.Id);
        }

        public int Compare(ClsSubject? x, ClsSubject? y)
        {
            return x.Name.CompareTo(y?.Name);
        }

        public int CompareTo(ClsSubject? o)
        {
            return Name.CompareTo(o?.Name);
        }
        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
