using System;
using System.Collections.Generic;

namespace CS026設計成績登錄且自動警示通知_完成專案_
{
    class GradeSheetEventArgs : EventArgs
    {
        public string Name { get; set; }
        public double Score { get; set; }
    }
    class GradeSheet
    {
        public List<string> Items { get; set; } = new List<string>();
        public event EventHandler<GradeSheetEventArgs> AbnormalEventHandler;
        public void AddScore(string name, double score)
        {
            Items.Add($"{name} 得到分數 {score}");
            if (score < 0 || score > 100)
            {
                OnAbnormal(new GradeSheetEventArgs() { Name = name, Score = score });
            }
        }
        private void OnAbnormal(GradeSheetEventArgs gradeSheetEventArgs)
        {
            AbnormalEventHandler?.Invoke(this, gradeSheetEventArgs);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            GradeSheet gradeSheet = new GradeSheet();
            gradeSheet.AbnormalEventHandler += (s, e) =>
            {
                Console.WriteLine($"    發現異常分數 {e.Name} / {e.Score}");
            };

            Random random = new Random();
            for (int i = 0; i < 100; i++)
            {
                gradeSheet.AddScore($"Name{i}", random.Next(-3, 110));
            }

            Console.WriteLine("Press any key for continuing...");
            Console.ReadKey();
        }
    }
}
