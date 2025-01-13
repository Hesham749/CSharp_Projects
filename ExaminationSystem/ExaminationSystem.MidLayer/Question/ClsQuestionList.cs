using ExaminationSystem.MidLayer.Subject;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text.Json;

namespace ExaminationSystem.MidLayer.Question
{
    public class ClsQuestionList<ClsSubject> : List<ClsQuestion>
    {
        private string _fileName;
        public string SubjectName { get; set; }
        public ClsQuestionList(string subjectName)
        {
            SubjectName = subjectName;
            _fileName = $"{SubjectName}QuestionList.json";
            ReadFromFile();
        }

        public ClsQuestionList()
        {

        }

        public new bool Add(ClsQuestion question)
        {
            if (question == null || Exists(q => question.Body == q.Body)) return false;

            question.Id = Count + 1;
            base.Add(question);
            SaveToFile();
            return true;

        }

        public new bool Remove(ClsQuestion question)
        {
            if (base.Remove(question))
            {
                SaveToFile();
                return true;
            }
            return false;
        }


        void SaveToFile()
        {
            string json = JsonConvert.SerializeObject(this, ClsJsonSettings.Settings);
            File.WriteAllText(_fileName, json);
        }

        public void ReadFromFile()
        {
            if (File.Exists(_fileName))
            {
                string jsonString = File.ReadAllText(_fileName);
                var questions = JsonConvert.DeserializeObject<List<ClsQuestion>>(jsonString, ClsJsonSettings.Settings);
                if (questions != null)
                    AddRange(questions);
            }
        }


        public void PrintQuestionList()
        {
            if (this?.Count > 0)
            {
                Console.WriteLine($"Question List({SubjectName}) :");
                Console.WriteLine("=====================================================================================\n");
                foreach (var question in this)
                {
                    Console.WriteLine($"{question}");
                    Console.WriteLine();
                }
                Console.WriteLine("=====================================================================================\n");
            }
        }
    }
}
