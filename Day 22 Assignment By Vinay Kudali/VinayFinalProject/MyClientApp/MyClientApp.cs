using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicLibrary;

namespace MyClientApp
{
    public class Program
    {
        public static void AddEmployee()
        {
            //user input
            int empId, empSalary, empAge;
            string empName;
            Console.WriteLine("Enter empId:");
            empId =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter employee Name: ");
            empName= Console.ReadLine();
            Console.WriteLine("Enter Employee Salary:");
            empSalary= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee age:");
            empAge= Convert.ToInt32(Console.ReadLine());

            //call BLl
            var result = EmployeeBll.AddEmployee(empId, empName, empSalary, empAge);
            if(result)
                Console.WriteLine("Employee Details Saved");
            else
                Console.WriteLine("Error Occured");
        }
        public static void GetEmpById()
        {
            //user input
            int empId;
            Console.WriteLine("Enter emp id:");
            empId=Convert.ToInt32(Console.ReadLine());
            //Call BLL
            var result = EmployeeBll.GetEmpById(empId);
            if(result.Count==0)
            Console.WriteLine( " No data Found" );
            else
                result.ForEach(f => Console.WriteLine(f));
        }
        public static void GetEmpByName()
        {
            string empName;
            Console.WriteLine("enter name");
            empName = Console.ReadLine();
            var result = EmployeeBll.GetEmpByName(empName);
            if (result != null)
            result.ForEach(n => Console.WriteLine(n));
        }
        public static void DisplayAllEmployees()
        {
            var result = EmployeeBll.DisplayAllEmployees();
            result.ToList().ForEach(y => Console.WriteLine(y));
        }
        static void Main(string[] args)
        {
            int ch;
            string choice;
            do
            {
                Console.WriteLine("Employee Management");
                Console.WriteLine("1.Add Employee");
                Console.WriteLine("2. Search Employee By Id");
                Console.WriteLine("3.Search Employee By name");
                Console.WriteLine("4.Display All Employees");
                Console.WriteLine("Enter Choice:");
                ch= Convert.ToInt32(Console.ReadLine());    
                switch (ch)
                {
                    case 1: AddEmployee(); break;
                    case 2: GetEmpById(); break;
                    case 3: GetEmpByName(); break;
                    case 4: DisplayAllEmployees(); break;
                    default: Console.WriteLine("Invalid Input"); break;

                }
                Console.WriteLine("Do you want to continue (y/n)");
                choice = Console.ReadLine();
            }while (choice.Equals("y"));
            
                
            }
        }
    }   
