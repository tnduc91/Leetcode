using System;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeStruct employee = new EmployeeStruct();
            
            employee.EventChildrenNameChanged += StructEventHandler;
            employee.ChildrenName = "Hello";
        }

        public static void StructEventHandler(string val){
            Console.WriteLine("Value changed: " + val);
        }
    }
}
