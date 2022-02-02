using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8Project1
{
    internal class Program
    {
        //Author: Vinay Kudali
        //Purpose: Declare & initialize a List With 8 values 
        static void Main(string[] args)
        {
            List<int> data = new List<int>() { 74, 87, 99, 96, 44, 85, 34 };

            //Even Numbers Using For Loop
            for (int i = 0; i < data.Count; i++)
            {
                if (data[i] % 2 == 0)
                    Console.WriteLine(data[i]);
            }

            //Even Numbers Using foreach loop
            foreach (var d in data)
            {
                if (d % 2 == 0)
                    Console.WriteLine(d);
            }
            //Even Numbers using Lambda Expression
            data.Where(x => x % 2 == 0).ToList().ForEach(x => Console.WriteLine(x));


            //Even numbers using LINQ Query
            var result = from v in data
                         where v % 2 == 0
                         select v;
            result.ToList().ForEach(x => Console.WriteLine(x));

            Console.ReadLine();
        }

    }
}
