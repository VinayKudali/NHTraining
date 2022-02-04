using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10Project1
{
    //Author: Vinay Kudali
    //Purpose: Multi Level inheritance
    class AddSub

    { 
        /// <summary>
        ///This method will perform addition
        /// </summary>
        /// <param name="p"></param>
        /// <param name="q"></param>
        /// <returns>Add</returns>
        public int Add(int p, int q)
        {
            return p + q;
        }
        /// <summary>
        /// This method will perform Substraction
        /// </summary>
        /// <param name="p"></param>
        /// <param name="q"></param>
        /// <returns>Substract</returns>
        public int Substract(int p, int q)
        {
            return p - q;
        }

    }
    class Multiply : AddSub
    {
        /// <summary>
        /// This method will perform Multiplication 
        /// </summary>
        /// <param name="p"></param>
        /// <param name="q"></param>
        /// <returns>mul</returns>
        public int Mul(int p, int q)
        {
            return p * q;
        }
    }
    class Division : Multiply
    {
        /// <summary>
        /// this method will perform Division
        /// </summary>
        /// <param name="p"></param>
        /// <param name="q"></param>
        /// <returns>Div</returns>
        public int Div(int p, int q)
        {
            return p / q;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Division n1 = new Division();
            Console.WriteLine(n1.Add(12, 8));
            Console.WriteLine(n1.Substract(9, 7));
            Console.WriteLine(n1.Mul(6, 3));
            Console.WriteLine(n1.Div(9, 3));
            Console.ReadLine();
        }
    }
}