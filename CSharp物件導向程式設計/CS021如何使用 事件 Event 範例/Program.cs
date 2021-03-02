using System;

namespace CS021如何使用_事件_Event_範例
{
    class Counter
    {
        int value = 0;
        public event EventHandler ThresholdReached;
        public void Add()
        {
            value++;
            if (value % 10 == 0)
            {
                OnThresholdReached(EventArgs.Empty);
                if (value == 20)
                {
                    // 在類別內，可以使用此語法解除所有訂閱事件
                    ThresholdReached = null;
                }
            }
        }
        protected virtual void OnThresholdReached(EventArgs e)
        {
            ThresholdReached?.Invoke(this, e);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var c = new Counter();
            // 訂閱事件
            c.ThresholdReached += c_ThresholdReached;
            for (int i = 1; i < 49; i++)
            {
                c.Add();
            }
            // 解除訂閱事件
            c.ThresholdReached -= c_ThresholdReached;
            // 不能在此使用這樣語法來訂閱或清空訂閱事件
            //c.ThresholdReached = null;
            Console.WriteLine("Press any key for continuing...");
            Console.ReadKey();
        }

        static void c_ThresholdReached(object sender, EventArgs e)
        {
            Console.WriteLine("已經加到10的倍數");
        }
    }
}
