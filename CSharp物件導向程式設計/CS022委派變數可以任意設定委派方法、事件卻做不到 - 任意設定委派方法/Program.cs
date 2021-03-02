using System;

namespace CS022委派變數可以任意設定委派方法_事件卻做不到___任意設定委派方法
{
    class MyDelegateVSEvent
    {
        public Action<string> MyHandler;
        public event Action<string> MyEventHandler;
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyDelegateVSEvent myDelegateVSEvent = new MyDelegateVSEvent();
            myDelegateVSEvent.MyHandler += MyMethod;
            myDelegateVSEvent.MyHandler = null;
            myDelegateVSEvent.MyEventHandler += MyMethod;
            // 對於 event 僅能夠透過 += , -= 來加入或移除委派方法
            //myDelegateVSEvent.MyEventHandler = null;
        }
        static void MyMethod(string message)
        {
            Console.WriteLine($"{message}");
        }
    }
}
