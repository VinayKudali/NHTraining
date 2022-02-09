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
        //Purpose Sum of two Matrices
        static void Main(string[] args)
        {
            int[,] x = new int[2, 2];
            int[,] y = new int[2, 2];
            int[,] sum = new int[2,2];

            //Read Data From User for x matrices
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine("Enter An Array Value 'a'  :");
                    x[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            //read Data from User for y matrices
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine("Enter An Array Value 'b' :");
                    y[i, j] = Convert.ToInt32(Console.ReadLine());
                    
                }
            }

            //Additon Of matrices
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    sum[i, j] = x[i, j] + y[i, j];


                    Console.Write(sum[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
