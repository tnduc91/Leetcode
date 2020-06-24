/*
 * Ref: https://www.youtube.com/watch?v=iiWnn6NyKNw
 * 
 * Abstract function:
 *  - No implementation
 *  - MUST be overridden
 *  - Cannot call AbsBase.Method
 *  
 * Virtual function:
 *  - Can implement
 *  - NOT require to override
 *  - Can call VirtBase.Method()
 */

using System;
namespace LeetCode.OOP
{
    public class AbstractVsVirtual
    {
    }

    public abstract class AbsBase
    {
        public void NormalMethod()
        {
            Console.WriteLine("absBase - normal method");
        }

        public abstract void absMethod(); // Cannot implement abstract method
    }

    public class DeliverFromAbs : AbsBase
    {
        public override void absMethod()
        {
            Console.WriteLine("Deliver from base - normal method");
        }
    }

    public class VirtBase
    {
        public void NormalMethod()
        {
            Console.WriteLine("Virtual base - normal method");
        }

        public virtual void virMethod()
        {
            Console.WriteLine("Virtual base - virtual method");
        }
    }

    public class DeliverFromVirt : VirtBase
    {

    }


}
