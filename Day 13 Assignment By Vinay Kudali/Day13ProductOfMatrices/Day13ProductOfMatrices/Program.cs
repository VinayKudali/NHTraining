using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13Project5SumOfMatrices
{
    internal class Program
    {
        //Author: Vinay Kudali
        //Purpose: Product of two Matrices
        static void Main(string[] args)
        {
            int[,] p = new int[2, 2];
            int[,] q = new int[2, 2];
            int[,] prd = new int[2, 2];

            //Read Data From User for p matrices
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine("Enter An Array Value 'p'  :");
                    p[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            //read Data from User for q matrices
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine("Enter An Array Value 'q' :");
                    q[i, j] = Convert.ToInt32(Console.ReadLine());

                }
            }

            //Additon Of matrices
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    prd[i, j] = p[i, j] * q[i, j];


                    Console.Write(prd[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
