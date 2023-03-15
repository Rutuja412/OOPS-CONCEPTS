using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS_BasedProblems
{
    internal class OverlodingPoly
    {
        public static int add(int x, int y)
        {
            int z = x + y;
            return z;
           
        }
        public static int add(int x, int y, int z)
        {
            return x + y + x;
        }
    }
}
