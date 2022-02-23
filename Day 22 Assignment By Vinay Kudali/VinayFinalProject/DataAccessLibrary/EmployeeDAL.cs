using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public static class EmployeeDAL
    {
        public static string filePath = "D:\\VinayFinalProject\\Employee.txt";
        public static bool AddEmployee(int empId, string empName, int empSalary, int empAge)
        {
            //Code to Append Data
            try
            {
                string textContent = String.Concat(empId, ",", empName, ",", empSalary, ",", empAge);
                File.AppendAllText(filePath, textContent+Environment.NewLine);
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }
        /// <summary>
        /// This method is used to search by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static List<string> GetEmpById(int id)
        {
            var allEmployees = File.ReadAllLines(filePath);
            bool isFound = false;
            List<string> employeeFound = new List<string>();
            foreach (string employee in allEmployees)
            {
                var employeeDetails = employee.Split(',');
                if (Convert.ToInt32(employeeDetails[0]) == id)
                {
                    isFound = true;
                    employeeFound.Add(employee);
                    break;
                }
            }
            return employeeFound;
        }
        /// <summary>
        /// This method is used to search by name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static List<string> GetEmpByName(string name)
        {
            var allEmployees = File.ReadAllLines(filePath);
            List<string> employeeFound = new List<string>();
            foreach (string employee in allEmployees)
            {
                var employeeDetails = employee.Split(',');
                if ((employeeDetails[1]).Contains(name))
                {
                    employeeFound.Add(employee);
                    break;
                }
            }
            return employeeFound;
        }
        /// <summary>
        /// This method is used to Display All Employees
        /// </summary>
        /// <returns></returns>
        public static string [] DisplayAllEmployees()
        {
            var allEmployees = File.ReadAllLines(filePath);
            return allEmployees;    
        }
    } 
}
