using System;
using System.Threading;
using System.Threading.Tasks;

namespace CS014Lambda之非同步方法使用
{
    class Program
    {
        static Action<string> MyHandler;
        static Action MyNoArgumentHandler;
        static void Main(string[] args)
        {
            MyHandler = async x =>
            {
                await Task.Run(() =>
                {
                    Thread.Sleep(2000);
                    Console.WriteLine(x);
                });
            };
            Console.WriteLine("呼叫第1一個委派方法");
            MyHandler("Vulcan Lee");
            MyNoArgumentHandler = async () =>
            {
                await Task.Run(() =>
                {
                    Thread.Sleep(1000);
                    Console.WriteLine("沒有參數的呼叫");
                });
            };
            Console.WriteLine("呼叫第2一個委派方法");
            MyNoArgumentHandler();

            Console.WriteLine("Press any key for continuing...");
            Console.ReadKey();
        }
    }
}
