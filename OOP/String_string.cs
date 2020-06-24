/*
 * Ref: https://www.youtube.com/watch?v=KAIYom46FCU&list=PLNLbdN-_vroNA4eWzJanw9ynCsAYY9KHp&index=3
 * string is an alias of String
 */
using System;
namespace LeetCode.OOP
{
    public class String_string
    {
        public void Test()
        {
            Console.WriteLine(typeof(string));
            Console.WriteLine(typeof(String));

            string name1 = "Duc 1"; // Work and good with coding convention
            String name2 = "Duc 2"; // Work but not coding convention

            Console.WriteLine(string.Concat(name1, name2));// Work but not coding convention
            Console.WriteLine(String.Concat(name1, name2));// Work and good with coding convention
        }
    }
}
