using System;
using System.Collections.Generic;

namespace CS025設計成績登錄且自動警示通知
{
    class GradeSheet
    {
        public List<string> Items { get; set; } = new List<string>();
        public void AddScore(string name, double score)
        {
            Items.Add($"{name} 得到分數 {score}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            GradeSheet gradeSheet = new GradeSheet();

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
