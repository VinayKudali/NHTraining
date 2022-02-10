using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14project6UsingBreak
{
    class Program
    {
        
         //Author:Vinay Kudali
         //Purpose: Find the first number later 1000 which is divisible by 97 using for loop and break
       
        static void Main(string[] args)
        {
            int n = 97;
            for (int i = 1000; i <= 1097; i++)
            {
                if (i % n == 0)
                {
                    Console.WriteLine(i);
                    break;
                }

            }
            Console.ReadLine();
        }
    }
}