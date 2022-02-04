using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9Project6
{
    class Employee
    {
        //Author: Vinay Kudali
        //Purpose: Creating a employee class with two constroctors
        public int id;
        public string name;
        public int salary;
        public static string company = "Deloitte";
        public Employee()
        {
            id = 0;
            name = "null";
            salary = 0;
        }
        public Employee(int eid, string ename, int esalary)
        {
            this.id = eid;
            this.name = ename;
            this.salary = esalary;
        }
        /// <summary>
        /// this method will read data from user
        /// </summary>
        public void ReadData()
        {
            Console.WriteLine("Enter Employee Id:");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Name:");
            name = Console.ReadLine();
            Console.WriteLine("Enter Employee Salary:");
            salary = Convert.ToInt32(Console.ReadLine());
        }
        /// <summary>
        /// This method will printdata 
        /// </summary>
        public void PrintData()
        {
            Console.WriteLine($"id={id},Name={name},salary={salary},company={company}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.PrintData();
            Console.ReadLine();
        }
    }
}