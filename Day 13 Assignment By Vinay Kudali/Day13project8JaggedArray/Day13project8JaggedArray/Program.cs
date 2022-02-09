using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13project8JaggedArray
{
    internal class Program
    {
        //Author : Vinay Kudali
        //Purpose: jagged array with printing values
        static void Main(string[] args)
        {
            char[][] names = new char[3][];
            names[0] = new char[] { 'o', 'n', 'e' };
            names[1] = new char[] { 'f', 'o', 'u', 'r' };
            names[2] = new char[] { 's', 'e', 'v', 'e', 'n' };

            for(int i=0; i<3; i++)
            {
                for(int j = 0; j<names[i].Length; j++)
                {
                    Console.Write(names[i][j]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
