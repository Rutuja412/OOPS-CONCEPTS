using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS_BasedProblems
{
    internal class ReferenceType
    {
        public static void TestRefType()
        {
            Student student = new Student();
            student.id = 1;
            student.Name = "Rutuja";
            Console.WriteLine("Before Modify :Name : " +student.Name + "ID: " + student.id);
            ChangeRefType(student);
            Console.WriteLine("After modify :Name : " + student.Name + "Id: " + student.id);
            
        }
        public static void ChangeRefType(Student s)
        {
            s.id= 100;
            s.Name = "Sara";
            Console.WriteLine("Within Method : Name : " +s.Name + "ID: " + s.id);
        }

    }
    public class Student
    {
        public int id;
        public string Name;
    }
}
