using System;

namespace CS016列出組合委派中的委派方法
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            Action myHandler = null;
            myHandler += StaticMethod;
            myHandler += program.InstanceMethod1;
            myHandler += program.InstanceMethod2;
            myHandler += program.InstanceMethod1;
            foreach (var item in myHandler.GetInvocationList())
            {
                string methodType = item.Method.IsStatic == true ? "靜態方法" : "執行個體方法";
                Console.WriteLine($"{methodType} / {item.Method.Name}" +
                    $" / {item.Target?.GetType().Name}");
            }

            Console.WriteLine("Press any key for continuing...");
            Console.ReadKey();
        }
        public static void StaticMethod()
        {
        }
        public void InstanceMethod1()
        {
        }
        public void InstanceMethod2()
        {
        }
    }
}
