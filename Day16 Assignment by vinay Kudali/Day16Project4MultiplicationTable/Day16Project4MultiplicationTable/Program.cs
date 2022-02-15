using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16Project4MultiplicationTable
{
    internal class Multiplication
    {
        //Author: Vinay Kudali
        //Purpose: Writing Multplication Table  using OOps
        int input;
        /// <summary>
        /// This method will Read data
        /// </summary>
        public void ReadData()
        {
            Console.WriteLine("Enter A Number");
            input=Convert.ToInt32(Console.ReadLine());
        }
        /// <summary>
        /// This method will perform Multiplication Table
        /// </summary>
        public void GetMultiplication()
        {
            for (int i = 1; i <= input+1; i++)
            {
                Console.WriteLine(input+"x"+i+"="+input*i);
            }
        }

        static void Main(string[] args)
        {
            Multiplication m = new Multiplication();
            m.ReadData();
            m.GetMultiplication();
            Console.ReadLine();
        }
    }
}
