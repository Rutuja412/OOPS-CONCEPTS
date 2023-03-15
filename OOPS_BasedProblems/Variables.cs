using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS_BasedProblems
{
    public class Variables
    {
       public static double Salary;//static variables
       public static string Name = "Riya";
        public string EmployeeName;//Instance or Non Static Variables
       public  int EmployeeId;
        public const float Monthlysalary=20000;
       public readonly string LastName;//ReadOnly
        public Variables()
        {
            this.LastName = "Kadam";
        }
        public void EmployeeAge()
        {
            int age = 20;//Local Variables
            Console.WriteLine(" Marks of Student :" + age);
            
        }

    }
}
