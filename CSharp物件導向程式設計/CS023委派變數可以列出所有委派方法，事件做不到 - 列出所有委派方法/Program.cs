using System;
using System.Linq;

namespace CS023委派變數可以列出所有委派方法_事件做不到___列出所有委派方法
{
    class MyDelegateVSEvent
    {
        public Action<string> MyHandler;
        public event Action<string> MyEventHandler;
        public void ListEventMethod()
        {
            // 對於 event 僅能夠在定義的類別內列出委派方法清單
            Console.WriteLine($"事件方法數量 {MyEventHandler.GetInvocationList().Count()}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyDelegateVSEvent myDelegateVSEvent = new MyDelegateVSEvent();
            myDelegateVSEvent.MyHandler += MyMethod;
            Console.WriteLine($"委派方法數量 {myDelegateVSEvent.MyHandler.GetInvocationList().Count()}");
            myDelegateVSEvent.MyEventHandler += MyMethod;
            // 對於 event 不能夠在類別外取得委派方法清單
            //Console.WriteLine($"事件方法數量 {myDelegateVSEvent.MyEventHandler.GetInvocationList().Count()}");
        }
        static void MyMethod(string message)
        {
            Console.WriteLine($"{message}");
        }
    }
}
