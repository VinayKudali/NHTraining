using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace Day20Project3

{

    //Author: Vinay Kudali 
    //Purpose: Out parameter



    class Program

    {

        public static void Add(out int x, out int y)

        {

            x = 79;

            y = 97;

            //x += y; 

            //y += y; 

        }

        static void Main(string[] args)

        {

            int a, b;

            Add(out a, out b);

            Console.WriteLine(a);

            Console.WriteLine(b);

            Console.ReadLine();



        }

    }

}