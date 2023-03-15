using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS_BasedProblems
{
    abstract class Abstraction
    {
        public abstract void AnimalSound();
        public void Eat()
        {
            Console.WriteLine("Animals Eats Grass");
        }
    }
    class Cat : Abstraction
    {
        public override void AnimalSound()
        {
            Console.WriteLine("Cat sound !!!");
        }
    }
}

