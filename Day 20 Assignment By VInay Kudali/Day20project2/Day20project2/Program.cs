using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day20project2
{
    //Author: Vinay Kudali
    //Purpose: writing C# Program using Delegate
    public class Program
    {
        public delegate void MyCaller(int m, int n);
        
        public static void Add(int m, int n)
        {
            Console.WriteLine(m+n);
        }
        public static void Mul(int m, int n)
        {
            Console.WriteLine(m*n);
        }
        public static void Div(int m, int n)
        {
            Console.WriteLine(m/n); 
        }
        static void Main(string[] args)
        {
            MyCaller mc = new MyCaller(Add);
            mc+=Mul;
            mc+=Div;

            mc(10, 20);
            mc(30, 40);
            mc(60, 30);
            Console.ReadLine();
        }
    }
}
