/*
Ref: https://www.youtube.com/watch?v=Z4fOu7eXQWk

public static void Main(string[] args)
        {
            BaseBC bc = new BaseBC("duc");
            DeliverBC dc = new DeliverBC("duc");
            Console.WriteLine($"Base - {bc.Name}");     // => duc
            Console.WriteLine($"Deliver - {dc.Name}");  // => DUC
        }
 */

using System;
namespace LeetCode.OOP
{
    public class BaseConstructor
    {
    }

    public class BaseBC
    {
        public string Name;

        public BaseBC(string name)
        {
            Name = name;
        }
    }

    public class DeliverBC : BaseBC
    {
        public DeliverBC(string name) : base(ConvertToUpper(name))
        {

        }

        private static string ConvertToUpper(string s)
        {
            return s.ToUpper();
        }
    }
}
