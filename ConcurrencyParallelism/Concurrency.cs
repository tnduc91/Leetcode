// Ref: https://www.youtube.com/watch?v=8Je1W82vwYM
using System;
using System.Threading.Tasks;

namespace LeetCode.ConcurrencyParallelism
{
    public class Concurrency
    {
        public Concurrency()
        {
        }

        public static void RunSynchoronous()
        {
            Task.Delay(5000).Wait();
            Console.WriteLine("Download file 1");

            Task.Delay(5000).Wait();
            Console.WriteLine("Download file 2");

            Console.WriteLine("Enter your name: ");
            var name = Console.ReadLine();
            Console.WriteLine($"Name is {name}");


        }

        public static void RunAsynchoronous()
        {
            Download1();
            Download2();

            Console.WriteLine("Enter your name: ");
            var name = Console.ReadLine();
            Console.WriteLine($"Name is {name}");

        }

        public static async void Download1()
        {
            await Task.Delay(5000);
            Console.WriteLine("Download file 1");
        }

        public static async void Download2()
        {
            await Task.Delay(5000);
            Console.WriteLine("Download file 2");
        }
    }
}
