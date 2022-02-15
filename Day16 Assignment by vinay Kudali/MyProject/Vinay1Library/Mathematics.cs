using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vinay1Library
{
    //Author: Vinay Kudali
    //purpose: Windows application
    public static partial class Mathematics
    {
        

        public static int Addition(int a, int b)
        {
            return a+b;
        }

        public static int Subtraction(int a, int b)
        {
            return a-b;
        }
        public static int Fact(int n)
        {
            int fact = 1;
            for(int i=1;i<=n;i++)
            {
                fact=fact*i;
            }
            return fact;
        }
    }
}

    

