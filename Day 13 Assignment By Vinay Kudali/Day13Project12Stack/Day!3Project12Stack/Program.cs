using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13project7
{
    class Program
    {
        static void Main(string[] args)
        {
            
              //Author: Vinay Kudali
              //Purpose:performing operation by using stack
            

            Stack<int> data = new Stack<int>();
            data.Push(74);
            data.Push(91);
            data.Push(32);
            data.Push(53);
            Console.WriteLine(data.Count);
            Console.WriteLine(data.Peek());
            Console.WriteLine(data.Pop());
            Console.WriteLine(data.Count());
            Console.ReadLine();
        }
    }
}