﻿using System;

namespace OOPS_BasedProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("OOPS_Concepts");
            Console.WriteLine("Select given options");
            Console.WriteLine("1.Class &Objects \n2.Inheritance(Vehicle)\n3.Polymorphism - Method Overloding\n4.Overriding(poly)\n5. Encapsulation \n6.Abstraction ");
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
                    case 3: Console.WriteLine("Polymorphism - Method Overloding");
                    Console.WriteLine( "Addition :"+OverlodingPoly.add(6, 6));
                    Console.WriteLine("Addition : "+OverlodingPoly.add(7, 8, 67));
                    break;
                    case 4: Console.WriteLine("Method Overriding");
                    Dog dog = new Dog();
                    dog.AnimalEat();
                    break;
                    case 5: Console.WriteLine("Encapsulation");
                    Encapsulation rectangle = new Encapsulation();
                    rectangle.l = 15;
                    rectangle.b = 10;
                    Console.WriteLine(" Length=" + rectangle.l);
                    Console.WriteLine(" Breadth=" + rectangle.b);
                    Console.WriteLine("  Area =" + rectangle.AreaOfRectangle());
                    break;
                    case 6: Console.WriteLine("Abstaction");
                    Cat cat = new Cat();    
                    cat.AnimalSound();
                    cat.Eat();
                    break;


            }


        }
    }
}
