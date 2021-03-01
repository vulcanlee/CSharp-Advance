using System;

namespace CS010內建的委派___Fucn_範例程式碼
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    delegate int MyFuncDelegate(string message);
    class MyActionClass
    {
        // 使用 Func 宣告一個委派變數
        Func<string, int> MyFuncHandler;
        // 使用 delegate 自訂型別來宣告一個委派變數
        MyFuncDelegate MyDelegateHandler;
        public MyActionClass()
        {
            MyFuncHandler = this.MyInstanceMethod;
            MyFuncHandler = MyActionClass.MyStaticMethod;
            MyDelegateHandler = this.MyInstanceMethod;
            MyDelegateHandler = MyActionClass.MyStaticMethod;
        }
        // 執行個體方法
        public int MyInstanceMethod(string message)
        {
            return message.Length;
        }
        // 靜態方法
        public static int MyStaticMethod(string message)
        {
            return message.Length;
        }
    }
}
