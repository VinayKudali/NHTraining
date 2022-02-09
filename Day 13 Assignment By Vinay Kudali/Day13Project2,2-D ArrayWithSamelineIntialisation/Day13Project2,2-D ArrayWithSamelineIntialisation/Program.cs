using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13Project2_DArray
{
    internal class Program
    {
        //Author: Vinay Kudali
        //Purpose: Creating 2-D Array and initializing in same Line
        static void Main(string[] args)
        {
            int[,] data = new int[,] { { 7, 9 }, { 9, 7 }, { 8, 2 } };
            

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(data[i, j] + " ");
                }
                Console.WriteLine("\n");
            }
            Console.ReadLine();

        }
    }
}
