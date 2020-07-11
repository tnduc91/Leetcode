using System;
using System.Threading.Tasks;

namespace LeetCode.ConcurrencyParallelism
{
    public class ThreadExample
    {
        public static void RunMultipleThreads()
        {
            var t1 = new System.Threading.Thread(Download1);
            var t2 = new System.Threading.Thread(Download1);
            t1.Start();
            t2.Start();
        }

        public static void Download1()
        {
            Task.Delay(5000).Wait();
            Console.WriteLine("Download file 1");
        }

        public static void Download2()
        {
            Task.Delay(5000).Wait();
            Console.WriteLine("Download file 2");
        }
    }
}
