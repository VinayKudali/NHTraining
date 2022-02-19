using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day20Project3
{
    internal class Program
    {
        //Author : Vinay Kudali
        //Purpose: using Nullable Types
        static void Main(string[] args)
        {
            byte? data = null;
            if(data.HasValue)
                Console.WriteLine(data*data);
            else
                Console.WriteLine("No Data");
                Console.ReadLine();
        }
    }
}
