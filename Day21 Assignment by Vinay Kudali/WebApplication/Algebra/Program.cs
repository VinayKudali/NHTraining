using Algebra.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algebra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WebService1SoapClient wssc = new WebService1SoapClient();
            Console.WriteLine(wssc.Factorial(7));
            Console.WriteLine(wssc.Add(7, 9));
            Console.WriteLine(wssc.Mul(9, 10));
            Console.WriteLine(wssc.Div(12, 2));
            Console.ReadLine();
        }
    }
}
