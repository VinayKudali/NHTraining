using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16Project1
{
    //Author: Vinay Kudali
    //Purpose: Printing Hello World Program In Object Oriented 
    public class Message
    {
        /// <summary>
        /// This method will Print "Hello"
        /// </summary>
        public void PrintHello()
        {
            Console.WriteLine("Hello");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Message message = new Message();    
            message.PrintHello();
            Console.ReadLine();
        }
    }
}
