using System;
using System.Collections.Generic;

namespace CS011修改_CS008_練習_使用預設委派型別
{
    // 宣告一個 FilterDevelopers 委派
    //delegate bool FilterDevelopers(Developer developer);
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
        public void DisplayDevelopers(Func<Developer, bool> filter)
        {
            foreach (Developer developer in Developers)
            {
                if (filter(developer))
                {
                    Console.WriteLine(string.Format("{0} {1}!", developer.FullName, filter.Method.Name.Replace("_", " ").ToLower()));
                }
            }
            Console.WriteLine(new string('-', 45));
        }
    }
    // 宣告一個輔助類別，可以過濾出符合條件的開發者
    class ProjectTeamHelper
    {
        // 這個靜態方法將會過濾出 網頁開發者
        public static bool IsWebDeveloper(Developer developer)
        {
            return developer.Technologies.Contains("ASP.NET") ||
                developer.Technologies.Contains("HTML") ||
                developer.Technologies.Contains("MVC") ||
                developer.Technologies.Contains("CSS");
        }
        // 這個靜態方法將會過濾出 桌機應用程式開發者
        public static bool IsDesktopDeveloper(Developer developer)
        {
            return developer.Technologies.Contains("Windows Forms") ||
                developer.Technologies.Contains("WPF") ||
                developer.Technologies.Contains("MVVM");
        }
        // 這個靜態方法將會過濾出 資料庫開發者
        public static bool IsDatabaseDeveloper(Developer developer)
        {
            return developer.Technologies.Contains("SQL Server");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Action foo;
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
            // 進行各種人員專長查詢
            projectTeam.DisplayDevelopers(ProjectTeamHelper.IsWebDeveloper);
            projectTeam.DisplayDevelopers(ProjectTeamHelper.IsDesktopDeveloper);
            projectTeam.DisplayDevelopers(ProjectTeamHelper.IsDatabaseDeveloper);

            Console.WriteLine("Press any key for continuing...");
            Console.ReadKey();
        }
    }
}
