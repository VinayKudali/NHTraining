using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mathematics.ServiceReference1;

namespace Mathematics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WebService1SoapClient wssc = new WebService1SoapClient();
            Console.WriteLine(wssc.Factorial(7));
            Console.ReadLine();
        }
    }
}
