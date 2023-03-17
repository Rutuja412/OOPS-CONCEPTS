using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace OOPS_BasedProblems
{
    public class ValueType
    {
        public static void TestValueType()
        {
            int i = 100;
            Console.WriteLine("Before modifying value of X= " +i);
            ChangeValueType(i);
            Console.WriteLine("After Modifying value of x = " + i);
            
        }
        public static void ChangeValueType(int x)
        {
            x = x + 10;
            Console.WriteLine("Within method value of X=" + x);
        }
    }
}
