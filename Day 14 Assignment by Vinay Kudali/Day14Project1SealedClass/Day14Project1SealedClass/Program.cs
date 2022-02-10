using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14Project1SealedClass
{
    //Author: Vinay Kudali
    //Purpose:Creating sealed class
    sealed class Hotel
    {
        public int roomNo = 307;
        
        public string Message()
        {
            return "take care";
        }
    }

    
    internal class Program
    {
        static void Main(string[] args)
        {
            Hotel h = new Hotel();
            Console.WriteLine(h.Message());
            Console.WriteLine(h.roomNo);
            Console.ReadLine();
        }
    }
}
