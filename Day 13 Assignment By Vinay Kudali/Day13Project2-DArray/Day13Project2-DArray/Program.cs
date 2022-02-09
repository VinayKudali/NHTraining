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
        //Purpose: Creating 2-D Array
        static void Main(string[] args)
        {
            int[,] data = new int[2,2];
            data[0, 0] = 7;
            data[0, 1] = 9;
            data[1, 0] = 9;
            data[1, 1] = 7;

            for(int i=0;i<2;i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(data[i,j] +" ");
                }
                Console.WriteLine("\n");
            }
            Console.ReadLine();

        }
    }
}
