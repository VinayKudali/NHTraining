using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13project8
{
    class Program
    {
        static void Main(string[] args)
        {
           
              //Author:Vinay Kudali
              //Purpose:performing operation by using queue
          
            Queue<int> data = new Queue<int>();
            data.Enqueue(17);
            data.Enqueue(19);
            data.Enqueue(21);
            data.Enqueue(97);
            Console.WriteLine(data.Count);
            Console.WriteLine(data.Peek());
            Console.WriteLine(data.Dequeue());
            Console.WriteLine(data.Count());
            Console.ReadLine();
        }
    }
}
   