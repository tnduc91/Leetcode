using System;
namespace LeetCode.EventDelegate
{
    public class ActionDelegate
    {
        public static void Test()
        {
            DoSomething(PrintConsole, "Hello");
        }

        public static void PrintConsole(string str)
        {
            Console.WriteLine(str);
        }

        public static void DoSomething(Action<string> action, string str)
        {
            action(str);
        }
    }
}
