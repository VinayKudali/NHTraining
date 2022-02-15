using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16Project2
{
    public class Mathematics
    { 
        //Author : Vinay Kudali
        //Purpose: Reading and Printing Factorial Using Object Oriented
       int input;
        /// <summary>
        /// This method will Read Data 
        /// </summary>
        public void ReadData()
        {
            Console.WriteLine("Enter input");
            input=Convert.ToInt32(Console.ReadLine());
        }
        /// <summary>
        /// This Method will Print Data
        /// </summary>
        /// <returns>fact</returns>
        public int PrintData()
        { 
            int fact =1;
            for (int i = 1; i<=input; i++)
            {
                fact= fact*i;
            }
            return fact;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Mathematics m1 = new Mathematics();
            m1.ReadData();
            Console.WriteLine(m1.PrintData());
            Console.ReadLine();

        }
    }
}
