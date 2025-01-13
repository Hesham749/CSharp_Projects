using ExaminationSystem.MidLayer.Answer;
using ExaminationSystem.MidLayer.Question;
using ExaminationSystem.MidLayer.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.MidLayer.Exam
{
    public class ClsFinalExam : ClsExam<ClsSubject>
    {
        public ClsFinalExam()
        {
            Name = "Final";
            Time = TimeSpan.FromSeconds(30);
        }

        public override void StartExam(ClsSubject sub, ClsStudent st)
        {
            base.StartExam(sub, st);
            var ql = GetQuestionList(sub, 4);
            foreach (var q in ql)
            {
                Console.WriteLine();
                q.Print();
                ClsAnswer answer = GetUserAnswer(q);
                if (Mode == enExamMode.Finished)
                    break;
                StdAnswers.Add(q, answer);
                Console.WriteLine();
                StdGrade += answer.Mark;
                Console.WriteLine("\n=================================================================================================");
            }
            Mode = enExamMode.Finished;
            if (StdGrade > TotalGrade / 2)
                ClsColorText.ColorText($"                                    You got {StdGrade} out of {TotalGrade}", ConsoleColor.DarkGreen);
            else
                ClsColorText.ColorText($"                                    You got {StdGrade} out of {TotalGrade}", ConsoleColor.DarkRed);
            Console.WriteLine("=================================================================================================");
            Name = $"{st.Name} {Name}";
        }
    }


}
