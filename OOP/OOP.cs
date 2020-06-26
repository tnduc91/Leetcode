using System;
namespace LeetCode
{

    public class ClassA
    {
        public ClassA(){
            Console.WriteLine("Class A - Constructor");
        }

        ~ClassA(){
            Console.WriteLine("Class A - De Constructor");
        }
        public virtual void Method1()
        {
            Console.WriteLine("ClassA.Method1");
        }
    }

    public class ClassB : ClassA
    {
        public ClassB(){
            Console.WriteLine("Class B - Constructor");
        }

        ~ClassB(){
            Console.WriteLine("Class B - De Constructor");
        }
        public override void Method1()
        {
            Console.WriteLine("ClassB.Method1");
        }
    }

    public class ClassC : ClassB
    {
        public ClassC(){
            Console.WriteLine("Class C - Constructor");
        }

        ~ClassC(){
            Console.WriteLine("Class C - De Constructor");
        }


        public void Method1()
        {
            Console.WriteLine("ClassC.Method1");
        }
    }

}
