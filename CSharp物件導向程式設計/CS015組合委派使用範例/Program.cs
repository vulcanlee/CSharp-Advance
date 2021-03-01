using System;

namespace CS015組合委派使用範例
{
    class Program
    {
        static void Main(string[] args)
        {
            CombineDelegateCase1();
            CombineDelegateCase2();
            CombineDelegateCase3();
            CombineDelegateCase4();
            CombineDelegateCase5();
            CombineDelegateCase6();
            CombineDelegateCase7();
            CombineDelegateCase8();
            CombineDelegateCase9();
            CombineDelegateCase10();
            CombineDelegateCase11();
            CombineDelegateCase12();
            Console.WriteLine("Press any key for continuing...");
            Console.ReadKey();
        }

        private static void CombineDelegateCase1()
        {
            Program program = new Program();
            Action delegate1 = null;
            Action delegate2 = null;
            Action delegate3;

            delegate2 = d1;
            delegate3 = delegate1 + delegate2;

            Console.WriteLine($"組合委派的情境1");
            delegate3();
        }

        private static void CombineDelegateCase2()
        {
            Program program = new Program();
            Action delegate1 = null;
            Action delegate2 = null;
            Action delegate3;

            delegate1 = d1;
            delegate3 = delegate1 + delegate2;

            Console.WriteLine($"組合委派的情境2");
            delegate3();
        }

        private static void CombineDelegateCase3()
        {
            Program program = new Program();
            Action delegate1 = null;
            Action delegate2 = null;
            Action delegate3;

            delegate1 = d1;
            delegate2 = d2;
            delegate3 = delegate1 + delegate2;

            Console.WriteLine($"組合委派的情境3");
            delegate3();
        }

        private static void CombineDelegateCase4()
        {
            Program program = new Program();
            Action delegate1 = null;
            Action delegate2 = null;
            Action delegate3;

            delegate1 = d1;
            delegate2 += d2;
            delegate2 += d3;
            delegate3 = delegate1 + delegate2;

            Console.WriteLine($"組合委派的情境4");
            delegate3();
        }

        private static void CombineDelegateCase5()
        {
            Program program = new Program();
            Action delegate1 = null;
            Action delegate2 = null;
            Action delegate3;

            delegate1 += d1;
            delegate1 += d2;
            delegate2 += d2;
            delegate2 += d3;
            delegate3 = delegate1 + delegate2;

            Console.WriteLine($"組合委派的情境5");
            delegate3();
        }

        private static void CombineDelegateCase6()
        {
            Program program = new Program();
            Action delegate1 = null;
            Action delegate2 = null;
            Action delegate3;

            delegate1 += d1;
            delegate1 += d2;
            delegate2 += d1;
            delegate3 = delegate1 - delegate2;

            Console.WriteLine($"組合委派的情境6");
            delegate3();
        }

        private static void CombineDelegateCase7()
        {
            Program program = new Program();
            Action delegate1 = null;
            Action delegate2 = null;
            Action delegate3;

            delegate1 += d1;
            delegate1 += d2;
            delegate2 += d2;
            delegate3 = delegate1 - delegate2;

            Console.WriteLine($"組合委派的情境7");
            delegate3();
        }

        private static void CombineDelegateCase8()
        {
            Program program = new Program();
            Action delegate1 = null;
            Action delegate2 = null;
            Action delegate3;

            delegate1 += d1;
            delegate1 += d2;
            delegate1 += d1;
            delegate2 += d1;
            delegate3 = delegate1 - delegate2;

            Console.WriteLine($"組合委派的情境8");
            delegate3();
        }

        private static void CombineDelegateCase9()
        {
            Program program = new Program();
            Action delegate1 = null;
            Action delegate2 = null;
            Action delegate3;

            delegate1 += d1;
            delegate1 += d2;
            delegate1 += d3;
            delegate2 += d1;
            delegate2 += d2;
            delegate3 = delegate1 - delegate2;

            Console.WriteLine($"組合委派的情境9");
            delegate3();
        }

        private static void CombineDelegateCase10()
        {
            Program program = new Program();
            Action delegate1 = null;
            Action delegate2 = null;
            Action delegate3;

            delegate1 += d1;
            delegate1 += d2;
            delegate1 += d3;
            delegate2 += d2;
            delegate2 += d1;
            delegate3 = delegate1 - delegate2;

            Console.WriteLine($"組合委派的情境10");
            delegate3();
        }

        private static void CombineDelegateCase11()
        {
            Program program = new Program();
            Action delegate1 = null;
            Action delegate2 = null;
            Action delegate3;

            delegate1 += d1;
            delegate1 += d2;
            delegate1 += d3;
            delegate1 += d1;
            delegate1 += d2;
            delegate2 += d1;
            delegate2 += d2;
            delegate3 = delegate1 - delegate2;

            Console.WriteLine($"組合委派的情境11");
            delegate3();
        }

        private static void CombineDelegateCase12()
        {
            Program program = new Program();
            Action delegate1 = null;
            Action delegate2 = null;
            Action delegate3;

            delegate1 += d1;
            delegate1 += d2;
            delegate2 += d1;
            delegate2 += d2;
            delegate3 = delegate1 - delegate2;

            Console.WriteLine($"組合委派的情境12");
            delegate3?.Invoke();
        }

        public static void d1()
        {
            Console.WriteLine($"靜態方法 d1");
        }
        public static void d2()
        {
            Console.WriteLine($"靜態方法 d2");
        }
        public static void d3()
        {
            Console.WriteLine($"靜態方法 d3");
        }
    }
}
