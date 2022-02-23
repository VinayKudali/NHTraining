using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLibrary;

namespace BusinessLogicLibrary
{
    public static class EmployeeBll
    {
        public static bool AddEmployee(int empId, string empName, int empSalary, int empAge)
        {
            //To do

            var result = EmployeeDAL.AddEmployee(empId, empName, empSalary, empAge);
            return result;
        }
        public static List<string> GetEmpById (int empId)
        {
            var result = EmployeeDAL.GetEmpById(empId);
            return result;
        }
        public static List<string> GetEmpByName(string empName)
        {
            var result = EmployeeDAL.GetEmpByName(empName);
            return result;
        }
        public static string[] DisplayAllEmployees()
        {
            var result = EmployeeDAL.DisplayAllEmployees();
            return result;
        }
    }
}
