using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS_BasedProblems
{
    public class TypesOfInheritance
    {
        public void ShowDemo()
        {
            Console.WriteLine("Welcome to Inheritance demo");
        }
    }
    public class SingleInheritance : TypesOfInheritance//SingleInheritance
    {
        public void ShowSingleInheritance()
        {
            ShowDemo();
            Console.WriteLine("Shows Single level inheritance");
        }
    }

    //HierarichalInheritance
    public class A
    {
        public string message()
        {
            return "This is class A ";
        }
    }
    public class B : A
    {
        public string GiveGreeting()
        {
            message();
            return "This is Class B";
        }
    }
    public class C : A
    {
        public string RecieveGreeting()
        {
            message();
            return "Print Class B message";
        }
    }
    //Multilevel Inheritanvnce
    public class Employee
    {
        public void Function()
        {
            Console.WriteLine("Employee have many types of Roles");
        }
    }
    public class Programmer : Employee
    {
        public void programming()
        {
            Console.WriteLine("Work as Programmer");
        }
    }
    public class Tester : Programmer
    {
        public void Testing()
        {
            Console.WriteLine("Work as Tester");
        }
    }
}
