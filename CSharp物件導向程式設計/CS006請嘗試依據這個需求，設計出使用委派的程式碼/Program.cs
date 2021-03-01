using System;

namespace CS006請嘗試依據這個需求_設計出使用委派的程式碼
{
    // 宣告 HelloDelegate 委派型別
    public delegate void HelloDelegate(string message);
    class MyClass
    {
        // 執行個體的方法 (函式簽章與 HelloDelegate 委派相同)
        public void SayHelloInstance(string message)
        {
            Console.WriteLine($"你好 - {message}");
        }
        // 類別靜態方法 (函式簽章與 HelloDelegate 委派相同)
        public static void SayHelloStatic(string message)
        {
            Console.WriteLine($"Hello - {message}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();

            // 指定委派物件到一個執行個體上的方法(函式簽章需要相同)
            HelloDelegate helloDelegate = myClass.SayHelloInstance;
            // 直接執行該委派物件上指定的物件方法，
            // 也就是呼叫 MyClass.SayHelloInstance
            helloDelegate("Vulcan");
            // 使用委派的 Invoke 方法來同步呼叫此方法
            helloDelegate.Invoke("Vulcan");

            // 指定委派物件到一個靜態方法(函式簽章需要相同)
            helloDelegate = new HelloDelegate(MyClass.SayHelloStatic);
            // 直接執行該委派物件上指定的靜態方法，
            // 也就是呼叫 MyClass.SayHelloStatic
            helloDelegate("Ada");
            // 使用委派的 Invoke 方法來同步呼叫此方法
            helloDelegate.Invoke("Ada");

            Console.WriteLine("Press any key for continuing...");
            Console.ReadKey();
        }
    }
}
