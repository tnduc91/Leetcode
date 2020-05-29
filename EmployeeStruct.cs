// Ref: https://www.tutorialsteacher.com/csharp/csharp-struct

/*
Difference between Struct and Class:
(1) Class is reference type whereas struct is value type
(2) Struct cannot declare a default constructor or destructor. However, it can have parametrized constructors.
(3) Struct can be instasntiated without the new operator. However, you won't be able to use any of its methods, events or properties if you do so.
(4) Struct cannot be used as a base or cannot derive another struct or class.
*/

using System;
namespace  LeetCode
{
    struct EmployeeStruct
    {
        public int Id;
        public string Name;
        private string _childrenName;
        public static void PrintSomething()
        {
            Console.WriteLine("Here is something");
        }

        public string ChildrenName
        {
            get {return _childrenName;}

            set{
                _childrenName = value;
                EventChildrenNameChanged(_childrenName);
            }
        }

        public event Action<string> EventChildrenNameChanged;
    }
}

/*
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
*/