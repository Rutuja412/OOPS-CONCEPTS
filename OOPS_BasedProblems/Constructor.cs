using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS_BasedProblems
{
    public class Constructor
    {
       public int a;
        public Constructor()
        {
            Console.WriteLine("Parameterless constructor !!!!");
        }
    }
    public class Constructor2
    {
        int Id;
        string Name;
        public Constructor2(int i, String n) 
        {
        this.Id = i;
            this.Name = n;
        }
        public void Display()
        {
            Console.WriteLine("Id = " + Id + "Name= " + Name);
        }
    
    }
}
