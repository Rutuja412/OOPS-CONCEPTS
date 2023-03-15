using System;

namespace OOPS_BasedProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("OOPS_Concepts");
            Console.WriteLine("Select given options");
            Console.WriteLine("1.Class &Objects \n2.Inheritance(Vehicle)\n3.Exit ");
            int option = Convert.ToInt16(Console.ReadLine());
            switch (option)
            {
                case 1: Console.WriteLine("Class & Objects");
                    ClassAndObjects objects = new ClassAndObjects();
                    objects.CreateClassAndObject();
                    break;
                    case 2: Console.WriteLine("Inheritance ..( Ex.Vehicle)");
                    Car car = new Car();
                    car.horn();
                    Console.WriteLine("Color:"+car.color +" \nBrand:" + car.brand);
                    break;

            }


        }
    }
}
