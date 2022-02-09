using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13Project42_DArrayWithreadDataFromUser
{
    internal class Program
    {
        //Author: Vinay Kudali
        //Purpose: 2-D Array using Read Data And Print Data
        static void Main(string[] args)
        {
            int[,] data = new int[2,2];
            //Read Data From User
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine("Enter Array Value at: " + data [i,j]);
                    data[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            //Print data From User

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(data[i, j]+" ");
                }
                Console.WriteLine();

            }
            Console.ReadLine();



        }
    }
}
