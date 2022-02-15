using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VinayLibrary;

namespace Day16Project3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Mathematics calss***");
            Mathematics m1 = new Mathematics();
            m1.ReadData();
            Console.WriteLine(m1.GetFactorial());
            Console.WriteLine("\n");
            Console.WriteLine("***Chemistry Class");
            Chemistry c = new Chemistry();
            Console.WriteLine(c.Carbondioxide());
            Console.WriteLine(c.Aluminuim());
            Console.WriteLine(c.Ammonium());
            Console.WriteLine("\n");
            Console.WriteLine("***Physics Class");
            Physics p=new Physics();
            Console.WriteLine(p.FinalVelocity(5,3,2));

            Console.ReadLine();

        }
    }
}
