using System;
using System.Net.Mail;

namespace OOPS_BasedProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("OOPS_Concepts");
            Console.WriteLine("Select given options");
            Console.WriteLine("1.Class &Objects \n2.Inheritance(Vehicle)\n3.Polymorphism - Method Overloding\n4.Overriding(poly)\n5. Encapsulation \n6.Abstraction \n7.Variables\n8.Types Of Methods\n9.Value Type \n10.Reference Type\n11.Types Of Inheritance");
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
                    case 7: Console.WriteLine("Variables Types");
                    Variables variables = new Variables();
                    variables.EmployeeAge();//Local
                    Variables.Salary = 10000;//Static
                    Console.WriteLine("Employee Salary =" + Variables.Salary);
                    Console.WriteLine("Employee Salary ; " + Variables.Monthlysalary);//Const variable
                    Console.WriteLine("Employee LastName;" + variables.LastName);//readomnly
                    variables.EmployeeName = "Rutuja";//Instance 
                    variables.EmployeeId = 1;
                    Console.WriteLine("Employee Name= " + variables.EmployeeName+ " \nEmployee ID; "+ variables.EmployeeId);
                    Variables variables1 = new Variables();
                    variables1.EmployeeName = "Radha";//Instance Second Object
                    variables1.EmployeeId = 2;
                    Console.WriteLine("Employee Name= " + variables1.EmployeeName + " \nEmployee ID; " + variables1.EmployeeId);
                    break;
                    case 8: Console.WriteLine("Types of Methods");
                    TypesOfMethods.CreateStaticMethod();//Static Method
                    TypesOfMethods type=new TypesOfMethods();
                    type.CreateInstanceMethod();//InstanceMethod
                    type.CreateVirtualMethod();//Will print only parent class method
                    Demo demo = new Demo();
                    demo.CreateVirtualMethod();//Virtual Method
                     break;
                case 9:
                    Console.WriteLine("Value type ");
                     ValueType.TestValueType();
                    ValueType.ChangeValueType(5);
                    break;
                case 10:
                    Console.WriteLine(" Reference Type");
                    ReferenceType.TestRefType();
                   // ReferenceType.ChangeRefType();
                    break;
                    case 11:
                    Console.WriteLine("Types of Inheritance");
                    Console.WriteLine("Single Inheritance");
                    //SingleInheritance singleInheritance= new SingleInheritance();
                   // singleInheritance.ShowSingleInheritance();
                    C c =new C();
                    c.RecieveGreeting();//Hierarical
                    Tester tester = new Tester();
                    tester.Function();
                    tester.programming();
                    tester.Testing();
                    break;
                    
            }


        }
    }
}
