using ExaminationSystem.MidLayer;
using ExaminationSystem.MidLayer.Exam;
using ExaminationSystem.MidLayer.Question;
using ExaminationSystem.MidLayer.Subject;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;

namespace ExaminationSystem.UI
{
    internal class Program
    {
        private static void DisplayHeader()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("======================================================================");
            Console.WriteLine("                   Welcome to Examination System     ");
            Console.WriteLine("======================================================================");
            Console.ResetColor();
        }

        private static ClsExam<ClsSubject> GetExam()
        {

            ClsExam<ClsSubject> Exam;
            int examType;
            ReadNum(out examType, (out int x) => !int.TryParse(Console.ReadLine(), out x), "Please enter a valid choice.");
            Exam = (examType == 1) ? new ClsFinalExam() : new ClsPracticeExam();
            return Exam;
        }

        private static ClsStudent GetStudent(int Id, ref ClsSubject sub)
        {
            int attempts = 1;
            ClsStudent std;
            while ((std = sub.GetStudent(Id)) == null && attempts < ClsSubjectList.SubList.Count)
            {
                attempts++;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\nYou are not registered in {sub.Name}. Please choose another subject.");
                Console.ResetColor();

                ClsSubjectList.Print();
                sub = GetSubject();
            }
            return std;
        }

        private static ClsSubject GetSubject()
        {
            ClsSubject sub;
            while ((sub = ClsSubjectList.GetSubject(Console.ReadLine())) == null)
            {
                Console.Clear();
                DisplayHeader();
                ClsColorText.ColorText("\nInvalid subject name. Please try again.", ConsoleColor.Red);
                ClsSubjectList.Print();
            }
            return sub;
        }

        delegate bool myDel(out int t);
        private static void ReadNum(out int id, myDel cond, string message = "")
        {
            while (cond.Invoke(out id))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(message);
                Console.ResetColor();
            }
        }

        static void StartProgram()
        {
            DisplayHeader();
            Console.Write("\nPlease enter your ID: ");
            ReadNum(out int Id, (out int x) => !int.TryParse(Console.ReadLine(), out x) || x < 0, "Please enter a valid number.");
            ClsColorText.ColorText("\nALL Subjects:\n", ConsoleColor.DarkGreen);
            ClsSubjectList.Print();
            ClsColorText.ColorText("\nPlease type the subject name:", ConsoleColor.Yellow);
            ClsSubject sub = GetSubject();

            ClsStudent std = GetStudent(Id, ref sub);
            if (std == null)
            {
                ClsColorText.ColorText("\nYou are not registered in any subject.", ConsoleColor.Red);
                return;
            }

            Console.Clear();
            ClsColorText.ColorText($"\nWelcome {std.Name}! You are about to start the {sub.Name} exam.", ConsoleColor.Green);
            DisplayHeader();
            Console.WriteLine("\nPlease choose the exam type:");
            ClsColorText.ColorText("[1] - Final Exam\n[2] - Practice Exam", ConsoleColor.Yellow);
            ClsExam<ClsSubject> Exam = GetExam();
            Console.Clear();
            Exam.StartExam(sub, std);
        }
        static void Main(string[] args)
        {
            StartProgram();

            ClsColorText.ColorText("\nThank you for using the Examination System. Goodbye!", ConsoleColor.Cyan);
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}
