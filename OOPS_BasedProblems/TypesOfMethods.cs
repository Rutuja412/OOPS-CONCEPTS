using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS_BasedProblems
{
    public class TypesOfMethods
    {
        public static void CreateStaticMethod()//Static
        {
            Console.WriteLine("Static method is created");
        }
        public void CreateInstanceMethod()//Instance
        {
            Console.WriteLine("Instance Method Is Created");
        }
        public virtual void CreateVirtualMethod()//Virtual 
        {
            Console.WriteLine("Virtual Method is created which will be override in base class");
        }
    }
    public class Demo:TypesOfMethods
    {
        public override void CreateVirtualMethod()
        {
            base.CreateVirtualMethod();
            Console.WriteLine("Virtual Method Overrided");
        }
        
    }
}
