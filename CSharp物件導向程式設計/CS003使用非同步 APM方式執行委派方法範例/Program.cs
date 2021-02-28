using System;
using System.Threading;

namespace CS003使用非同步_APM方式執行委派方法範例
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, int> computeStringLengthHandler;
            computeStringLengthHandler = SimulateComputeLength;
            IAsyncResult asyncResult = computeStringLengthHandler.BeginInvoke("Vulcan Lee", null, null);
            Console.WriteLine($"主執行緒({Thread.CurrentThread.ManagedThreadId})繼續執行");
            Console.WriteLine($"主執行緒休息 3 秒鐘");
            int result = computeStringLengthHandler.EndInvoke(asyncResult);
            Console.WriteLine($"非同步委派方法執行結果(執行緒 {Thread.CurrentThread.ManagedThreadId}):{result}");

            Console.WriteLine("Press any key for continuing...");
            Console.ReadKey();
        }
        static int SimulateComputeLength(string str)
        {
            Console.WriteLine($"非同步執行的執行緒:{Thread.CurrentThread.ManagedThreadId}");
            Thread.Sleep(2000);
            return str.Length;
        }
    }
}
