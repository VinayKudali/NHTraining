using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9Project3
{
    class Employee
    {
        /***********************************************************************
        Author: Vinay kudali
        Program: Creating employee class and printing variables
        ***********************************************************************/
        private int id;
        private string name;
        private int salary;
        public static string company;

        /// <summary>
        /// this method will read data from user
        /// </summary>
        public void Readdata()
        {
            Console.WriteLine("Enter ID number");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter name ");
            name = Console.ReadLine();
            Console.WriteLine("Enter salary");
            salary = Convert.ToInt32(Console.ReadLine());
            company = "Amazon";
        }
        /// <summary>
        /// this method will print data 
        /// </summary>
        public void Printdata()
        {
            Console.WriteLine($"Id={id}, Name={name}, Salary={salary}, Company={company}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.Readdata();
            emp.Printdata();
            Employee emp2 = new Employee();
            emp2.Readdata();
            emp2.Printdata();
            Console.ReadLine();
        }

    }
}