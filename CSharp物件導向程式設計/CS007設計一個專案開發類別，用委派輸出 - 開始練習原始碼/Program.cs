using System;
using System.Collections.Generic;

namespace CS007設計一個專案開發類別_用委派輸出___開始練習原始碼
{
    // 宣告一個 Developer 類別
    class Developer
    {
        public string FullName { get; set; }
        public string Technologies { get; set; }
    }
    // 宣告一個 ProjectTeam 類別
    class ProjectTeam
    {
        public List<Developer> Developers { get; set; } = new List<Developer>();
    }
    class Program
    {
        static void Main(string[] args)
        {
            // 建立專案團隊物件與相關開發人員
            ProjectTeam projectTeam = new ProjectTeam()
            {
                Developers = new List<Developer>()
                {
                    new Developer(){ FullName = "張小三",  Technologies = "C#, .NET, ASP.NET, SQL Server, WPF, MVVM, MVC, HTML, CSS" },
                    new Developer(){ FullName = "李小四",  Technologies = "C#, Windows Forms, WPF" },
                    new Developer(){ FullName = "王小明",  Technologies = "SQL Server" },
                    new Developer(){ FullName = "店小二",  Technologies = "ASP.NET, HTML, CSS" }
                }
            };

            Console.WriteLine("Press any key for continuing...");
            Console.ReadKey();
        }
    }
}
