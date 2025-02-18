using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace exceptionDemo
{
    internal class Employee
    {
        public string EmployeeId { get; set; }
        public string EmployeeName { get; set; } = string.Empty;

        public Employee(string employeeId, string employeeName)
        {
            if (!IsValidEmployeeId(employeeId))
            {
                throw new InvalidEmployeeIdException("Invalid Employee Id ");
            }
            EmployeeId = employeeId;
            EmployeeName = employeeName;
        }

        public bool IsValidEmployeeId(string employeeId)
        {

            return Regex.IsMatch(employeeId, @"^EMP\d+$");
        }
    }
}
