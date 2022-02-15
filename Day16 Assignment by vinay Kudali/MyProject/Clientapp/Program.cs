using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vinay1Library;
using PublicLibrary;


namespace Clientapp
{
    //Author: Vinay Kudali
    //Purpose: Windows Application

    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine( Mathematics.Addition(7,8));
            Console.WriteLine( Mathematics.Subtraction(9,7));
            Console.WriteLine(Mathematics.Mul(6,2));
            Physics p = new Physics();
            Console.WriteLine(p.Velocity(7, 9));

          
             Console.ReadLine();

        }
    }
}
