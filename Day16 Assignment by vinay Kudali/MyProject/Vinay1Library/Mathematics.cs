using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vinay1Library
{
    //Author: Vinay Kudali
    //purpose: Windows application
    public class Mathematics
    {
        int a = 5;
        int b = 4;
        public static int n;

        public void Addition()
        {
            Console.WriteLine(a+b);
        }

        public int Subtraction()
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

    

