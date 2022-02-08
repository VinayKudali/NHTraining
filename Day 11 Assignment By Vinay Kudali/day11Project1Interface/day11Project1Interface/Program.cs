using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11Project5
{
    //Author: Vinay Kudali
    //Purpose: id-get, set,name-get,set,designation-set(writeonly),salary-get(get with some functionality)
    class Employee
    {
        private int id;
        private string name;
        private string designation;
        private int salary;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return Name; }
            set { Name = value; }

        }
        public string Designation
        {
            set { designation = value; }
        }
        public int Salary
        {
            get
            {
                salary = (designation == "A") ? 40000 : 70000;
                return salary;

            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            e1.Designation = "T";
            Console.WriteLine(e1.Salary);
            Console.ReadLine();
        }
    }
}