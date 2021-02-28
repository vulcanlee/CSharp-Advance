using System;
using System.Threading;
using System.Threading.Tasks;

namespace CS002捕捉當錯誤工作未觀察到的例外狀況將觸發例外狀況
{
    class Program
    {
        static void Main(string[] args)
        {
            // 註冊 工作未觀察到的例外狀況將觸發例外狀況
            TaskScheduler.UnobservedTaskException += (s, e) =>
            {
                Console.WriteLine(DateTime.Now);
                Console.WriteLine($"攔截到未處理例外異常");
                AggregateException exception = e.Exception;
                Console.WriteLine($"例外:{exception.Flatten().Message}");
            };
            Task task = Task.Run(() =>
            {
                Console.WriteLine($"3秒之後將會拋出例外異常");
                Thread.Sleep(3000);
                Console.WriteLine(DateTime.Now);
                Console.WriteLine($"正在拋出例外異常");
                throw new Exception("Sorry，系統發生異常");
            });

            #region 強制讓 Task 物件進行記憶體回收，並且觸發 UnobservedTaskException
            // 要加入底下敘述，才會讓 UnobservedTaskException 被觸發
            Thread.Sleep(4000);
            task = null;
            GC.Collect();
            // 暫止目前的執行緒，直到處理完成項佇列的執行緒已經清空該佇列為止
            //GC.WaitForPendingFinalizers();
            #endregion
            Console.WriteLine("Press any key for continuing...");
            Console.ReadKey();
        }
    }
}
