using System;
using System.Threading;

namespace CS017_使用委派來設計事件機制
{
    class Car
    {
        int gas = 10;
        public void Run()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(1000);
                gas--;
                if (gas == 0)
                {
                    Console.WriteLine($"已經沒有汽油了，無法繼續行駛");
                    return;
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Run();

            Console.WriteLine("Press any key for continuing...");
            Console.ReadKey();
        }
    }
}
