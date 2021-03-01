using System;
using System.Threading;

namespace CS005使用同步方式執行委派方法範例_.NET_Core
{
    class Program
    {
        delegate int ComputeStringLengthDel(string str);
        static void Main(string[] args)
        {
            ComputeStringLengthDel computeStringLengthHandler;
            computeStringLengthHandler = SimulateComputeLengthCallback;
            Console.WriteLine($"主執行緒" +
                $"({Thread.CurrentThread.ManagedThreadId})繼續執行");
            //int stringLength = computeStringLengthHandler
            //    .Invoke("Vulcan Lee");
            int stringLength = computeStringLengthHandler("Vulcan Lee");
            Console.WriteLine($"使用同步方式取得執行結果" +
                $"(執行緒 {Thread.CurrentThread.ManagedThreadId}):{stringLength}");

            Console.WriteLine("Press any key for continuing...");
            Console.ReadKey();
        }


        static int SimulateComputeLengthCallback(string str)
        {
            Console.WriteLine($"的執行緒:{Thread.CurrentThread.ManagedThreadId}");
            Thread.Sleep(2000);
            return str.Length;
        }
    }
}
