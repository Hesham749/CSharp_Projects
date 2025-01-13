using ExaminationSystem.MidLayer.Answer;
using ExaminationSystem.MidLayer.Question;
using ExaminationSystem.MidLayer.Subject;
using ExaminationSystem;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ExaminationSystem.MidLayer.Exam
{

    public abstract class ClsExam<T> where T : ClsSubject
    {
        System.Timers.Timer _timer = new(100);
        private enExamMode _mode;

        public enum enExamMode
        {
            Started = 1,
            Queued,
            Finished
        }
        public ClsAnswerList StdAnswers { get; protected set; } = new();
        public string Name { get; protected set; } = string.Empty;
        public int TotalGrade { get; set; } = 0;
        public int StdGrade { get; set; } = 0;
        public enExamMode Mode
        {
            get => _mode;
            protected set
            {
                _mode = value;
                if (value == enExamMode.Finished)
                {
                    _timer.Stop();
                    SaveToFile();
                }
                else
                {
                    TimeRemaining = Time;
                    _timer.Start();
                }
            }
        }
        public TimeSpan Time { get; protected set; }
        public TimeSpan TimeRemaining { get; protected set; }
        protected ClsExam()
        {
            Mode = enExamMode.Queued;
            _timer.Elapsed += OnTimeEvent;
        }

        private void OnTimeEvent(object? sender, EventArgs e)
        {
            if (TimeRemaining - TimeSpan.FromSeconds(1) == TimeSpan.Zero)
                Mode = enExamMode.Finished;
            TimeRemaining -= TimeSpan.FromSeconds(.1);
            int left = 100, top = 5, aleft = Console.CursorLeft, atop = Console.CursorTop;
            Console.CursorVisible = false;
            string timeFormatted = $"{TimeRemaining.Hours:D2}:{TimeRemaining.Minutes:D2}:{TimeRemaining.Seconds:D2}";
            Console.SetCursorPosition(left, top);
            if (TimeRemaining > Time / 2)
                Console.WriteLine($"Time remaining : {timeFormatted}");
            else if (TimeRemaining > Time / 3)
                ClsColorText.ColorText($"Time remaining : {timeFormatted}", ConsoleColor.Yellow);
            else
                ClsColorText.ColorText($"Time remaining : {timeFormatted}", ConsoleColor.Red);
            Console.SetCursorPosition(aleft, atop);
            Console.CursorVisible = true;
        }

        public virtual void StartExam(T sub, ClsStudent st)
        {
            Name += $" {sub.Name} exam";
            Mode = enExamMode.Started;
            ClsColorText.ColorText("=================================================================================================", ConsoleColor.Cyan);
            Console.WriteLine($"                                {Name} has {Mode}                    Time:{Time}         ");
            ClsColorText.ColorText("=================================================================================================", ConsoleColor.Cyan);
            Name = $"{st.Name} {Name}.json";
        }

        protected void PrintAnswerResult(ClsQuestion q, ClsAnswer answer)
        {
            if (answer.Mark == q.Mark)
                ClsColorText.ColorText("Great job correct answer", ConsoleColor.DarkGreen);

            else
            {
                ClsColorText.ColorText("oops wrong answer", ConsoleColor.Red);
                ClsColorText.ColorText($"correct answer is {q.GetAnswer()}", ConsoleColor.Yellow);
            }
        }

        protected ClsAnswer GetUserAnswer(ClsQuestion q)
        {
            ClsAnswer answer = new();
            int y = 0;

            string stAnswer = Console.ReadLine()?.Trim()??"";
            if (Mode == enExamMode.Finished)
                return answer;
            if (string.IsNullOrEmpty(stAnswer))
            {
                answer.Answer.Add(0, stAnswer ?? "");
                answer.Mark = 0;
                return answer;
            }

            foreach (var l in stAnswer)
            {
                int.TryParse(stAnswer, out y);
                if (!q.CorrectAnswer.Contains(y))
                {
                    answer.Answer.Add(0, stAnswer ?? "");
                    answer.Mark = 0;
                    return answer;
                }
                else
                {
                    answer.Answer.Add(y, q.Options[y]);
                }
            }
            answer.Mark = q.Mark;
            return answer;
        }

        protected List<ClsQuestion> GetQuestionList(ClsSubject sub, int size)
        {
            var ql = new List<ClsQuestion>();
            size = size < 1 ? 4 : size;
            if (size >= sub.QuestionList.Count)
                return sub.QuestionList;
            ClsQuestion q;
            do
            {
                Random random = new();
                int x = random.Next(0, sub.QuestionList.Count);
                q = sub.QuestionList[x];
                if (!ql.Contains(q))
                {
                    ql.Add(q);
                    TotalGrade += q.Mark;
                }
            } while (ql.Count < size);
            return ql;
        }

        void SaveToFile()
        {
            string json = JsonConvert.SerializeObject(this, ClsJsonSettings.Settings);
            File.WriteAllText(Name, json);
        }

    }
}
