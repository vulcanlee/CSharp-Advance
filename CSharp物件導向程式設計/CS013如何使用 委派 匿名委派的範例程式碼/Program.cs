using System;

namespace CS013如何使用_委派_匿名委派的範例程式碼
{
    public delegate void MyLogDelegate();
    public class Product
    {
        public string Name { get; set; }
        public MyLogDelegate Log;
        public void Processing()
        {
            Console.WriteLine($"正在處理商品 {Name}");
            if (Log != null)
                Log();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product() { Name = "Apple" };
            product.Log += delegate ()
            {
                Console.WriteLine("寫入資料庫中(匿名委派)");
            };
            product.Log += () =>
            {
                Console.WriteLine("寫入資料庫中(Lambda)");
            };
            product.Processing();

            Console.WriteLine("Press any key for continuing...");
            Console.ReadKey();
        }
    }
}
