using ExaminationSystem.MidLayer.Question;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ExaminationSystem.MidLayer.Answer
{
    public class ClsAnswerList
    {

        public Dictionary<ClsQuestion, ClsAnswer> AnswerList { get; private set; } = [];

        public bool Add(ClsQuestion q, ClsAnswer a)
        {
            if (q != null && a != null && AnswerList.Count < 5)
            {
                int c = AnswerList.Count;
                AnswerList.Add(q, a);
                if (AnswerList.Count == c + 1)
                    return true;
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Answer List is Full , Can't Add Answer");
                    Console.ResetColor();
                    return false;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Answer Didn't Add");
                Console.ResetColor();
                return false;
            }
        }

        //public bool Remove(ClsQuestion q)
        //{
        //    if (q != null)
        //    {
        //        int c = AnswerList.Count;
        //        AnswerList.Remove(q);
        //        if (AnswerList.Count == c - 1)
        //            return true;
        //        else
        //        {
        //            Console.ForegroundColor = ConsoleColor.Red;
        //            Console.WriteLine("Answer Didn't Remove");
        //            Console.ResetColor();
        //            return false;
        //        }

        //    }
        //    else
        //    {
        //        Console.ForegroundColor = ConsoleColor.Red;
        //        Console.WriteLine("Question is not exist");
        //        Console.ResetColor();
        //        return false;
        //    }

        //}

    }
}
