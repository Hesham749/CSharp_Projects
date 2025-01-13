using Newtonsoft.Json;

namespace ExaminationSystem.MidLayer.Question
{
    public abstract class ClsQuestion
    {
        private int _id;
        public string Header { get; protected set; }
        public int Mark { get; protected set; }
        public string Body { get; set; }
        public int Id { get => _id; set { if (value > 0) _id = value; } }
        public int[] CorrectAnswer { get; protected set; } = [];
        public Dictionary<int, string> Options { get; protected set; }



        public ClsQuestion(string body, Dictionary<int, string> options, params int[] correctAnswer)
        {
            Body = body;
            Options = options ?? [];
            CorrectAnswer = correctAnswer;
        }

        public string GetAnswer()
        {
            string answer = "";
            foreach (var i in CorrectAnswer)
                answer += Options[i] + ",";
            answer = answer != "" ? answer.Remove(answer.Length - 1, 1).Trim() : answer;
            return answer;
        }

        public string GetOptions()
        {
            string answer = "";
            if (Options == null) return answer;
            foreach (var i in Options)
                answer += $"[{i.Key}] {i.Value}\t\t";
            return answer.Trim();
        }

        public override string ToString() => $"{Header}  Mark({Mark})\n- {Body}\n{GetOptions()}\n";

        public void Print()
        {
            Console.Write($"{Header}");
            ClsColorText.ColorText($"  Mark({Mark})", ConsoleColor.DarkYellow);
            Console.WriteLine($"- {Body}\n{GetOptions()}\n");
        }
    }
}
