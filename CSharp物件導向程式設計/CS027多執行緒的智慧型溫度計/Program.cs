using System;
using System.Threading;

namespace CS027多執行緒的智慧型溫度計
{
    class SmartThermometer
    {
        Random random = new Random();
        bool RunningStatus = false;
        int GetCurrentTemperature() => random.Next(15, 50);
        public void TurnOn()
        {
            RunningStatus = true;
            ThreadPool.QueueUserWorkItem(x =>
            {
                while (RunningStatus)
                {
                    var currentTemperature = GetCurrentTemperature();
                    Console.WriteLine($"現在溫度 {currentTemperature} 度");

                    Thread.Sleep(1000);
                }
            });
        }
        public void TurnOff() => RunningStatus = false;
    }
    class Program
    {
        static void Main(string[] args)
        {
            SmartThermometer smartThermometer = new SmartThermometer();
            smartThermometer.TurnOn();

            Console.WriteLine("Press any key for continuing...");
            Console.ReadKey();
        }
    }
}
