using System;
using System.Threading;

namespace CS001捕捉發生於未攔截到例外狀況
{
    class Program
    {
        static void Main(string[] args)
        {
            // 註冊 預設應用程式域中擲回未處理的例外狀況時叫用的事件處理常式
            AppDomain.CurrentDomain.UnhandledException += (s, e) =>
            {
                Console.WriteLine(DateTime.Now);
                Console.WriteLine($"攔截到未處理例外異常");
                Exception exception = (Exception)e.ExceptionObject;
                Console.WriteLine($"例外:{exception.Message}");
            };
            ThreadPool.QueueUserWorkItem(_ =>
            {
                Console.WriteLine($"3秒之後將會拋出例外異常");
                Thread.Sleep(3000);
                Console.WriteLine(DateTime.Now);
                Console.WriteLine($"正在拋出例外異常");
                throw new Exception("Sorry，系統發生異常");
            });

            Console.WriteLine("Press any key for continuing...");
            Console.ReadKey();
        }
    }
}
