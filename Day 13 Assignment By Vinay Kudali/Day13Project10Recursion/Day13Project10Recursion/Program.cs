using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13Project10Recursion
{
    internal class Program
    {
        //Author: Vinay Kudali
        //Purpose: Factorial using Recursion
        public static int Factorial(int n)
        {
            if (n == 0)
                return 1;
            else
                return n * Factorial(n - 1);
        }
        public static void Print(int n)
        {
            Console.WriteLine("factorial {0} is {1}", n,Factorial(n));
        }
        static void Main(string[]args)
        {
            int n = 7;
            Print(n);
            Console.ReadLine();
        }
        
    }
}
