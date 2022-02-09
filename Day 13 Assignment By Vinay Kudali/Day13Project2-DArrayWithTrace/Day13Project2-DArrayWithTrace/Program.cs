using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13Project2_DArrayWithTrace
{
    internal class Program
    {
        //Author: Vinay Kudali
        //Purpose Creating 2-D Array With sum of trace (Diagnoal)
        static void Main(string[] args)
        {
            int sum = 0;
            int[,] data = new int[,] { { 1, 2, 3 }, { 3, 2, 1 }, { 2, 3, 1 } };
            for (int i = 0;i<3;i++)
            {
                for (int j=0;j<3;j++)
                {
                    if (i==j)
                    sum = sum+ data[i,j];
                }
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
