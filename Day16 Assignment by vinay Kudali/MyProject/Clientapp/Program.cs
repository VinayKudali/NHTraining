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
    //Purpose: Windows

    public class Program
    {
        static void Main(string[] args)
        {
            Mathematics m=new Mathematics();
            m.Addition();
            m.Subtraction();
            Physics p = new Physics();
            Console.WriteLine(p.Velocity(7, 9));

          
             Console.ReadLine();

        }
    }
}
