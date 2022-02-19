using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day20Project4RefParameter
{
    internal class Program
    {
        //Author : Vinay Kudali
        //Purpose : Ref Parameter
        public static void Multi(ref int z)
        {
            z *= z;
            Console.WriteLine("Inside method:"+z);
        }

        static void Main(string[] args)
        { 
            int z = 24;
            Console.WriteLine("Before:"+z);
            Multi(ref z);
            Console.WriteLine("After:"+z);
            Console.ReadLine();
        }
    }
}
