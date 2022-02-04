using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day9Project2
{
    internal class MathTask

    {
        //Author: Vinay Kudali 
        //Purpose: factorial, factors, primecheck 
            private int x;
            private int z;
        /// <summary>
        /// this method will readdata from user
        /// </summary>
            public void Readinput()
            {
                Console.WriteLine("Enter first number");
                x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Second Number");
                z = Convert.ToInt32(Console.ReadLine());
            }
        /// <summary>
        /// this method will add Two numbers
        /// </summary>
        /// <returns>sum</returns>
            public int Addnumbers()
            {
                return x + z;
            }
        /// <summary>
        /// this method will substract two numbers
        /// </summary>
        /// <returns>substract</returns>
            public int Subtractnumbers()
            {
                return x - z;
            }
        /// <summary>
        /// this method will multiply two numbers
        /// </summary>
        /// <returns>multiply</returns>
            public int Multiplynumbers()
            {
                return x * z;
            }
        /// <summary>
        /// this Method will divide two numbers
        /// </summary>
        /// <returns>divide</returns>
            public int Dividenumbers()
            {
                return x / z;
            }
     }
        class Program
        {
            static void Main(string[] args)
            {
                MathTask vk = new MathTask();
                vk.Readinput();
                Console.WriteLine(vk.Addnumbers());
                Console.WriteLine(vk.Subtractnumbers());
                Console.WriteLine(vk.Multiplynumbers());
                Console.WriteLine(vk.Dividenumbers());
                Console.ReadLine();
            }
        }
} 

