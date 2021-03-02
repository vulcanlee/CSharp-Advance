using System;
using System.Threading;

namespace CS020_委派設計事件___設計Add_Remove方法
{
    class Car
    {
        int gas = 10;
        private Action<string> logGasHandler;
        public void AddLogGasHandler(Action<string> action)
        { logGasHandler += action; }
        public void RemoveLogGasHandler(Action<string> action)
        { logGasHandler -= action; }
        public void Run()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(1000); gas--;
                if (gas <= 2) logGasHandler?
                                  .Invoke($"油量不足 : {gas}");
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
            car.AddLogGasHandler(LowGasLED);
            car.AddLogGasHandler(LowGasAlert);
            car.Run();

            Console.WriteLine("Press any key for continuing...");
            Console.ReadKey();
        }
        static void LowGasLED(string message)
        {
            Console.WriteLine($"低油量燈號亮起 : {message}");
        }
        static void LowGasAlert(string message)
        {
            Console.WriteLine($"低油量警報響起 : {message}");
        }
    }
}
