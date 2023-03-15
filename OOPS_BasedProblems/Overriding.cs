using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS_BasedProblems
{
    public class Overriding
    {
        public virtual void AnimalEat()
        {
            Console.WriteLine("Animal Eating");
        }

    }
    public class Dog : Overriding
    {
        public override void AnimalEat()
        {
            Console.WriteLine("Dog Eating Pedegree");
        }
    }
}
