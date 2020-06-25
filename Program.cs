using System;
using System.Collections.Generic;
using LeetCode.Models;
using System.Collections.Specialized;
using LeetCode.OOP;

namespace LeetCode
{
    class Program
    {
        public static void Main(string[] args)
        {
            BaseBC bc = new BaseBC("duc");
            BaseBC dc = new DeliverBC("duc");
            Console.WriteLine($"Base - {bc.Name}");
            Console.WriteLine($"Deliver - {dc.Name}");
        }

    }

}

