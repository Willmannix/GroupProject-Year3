using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuisnessEntities
{
    public static class EmployeeFactory
    {
        private static IEmployees employee = null;

        public static IEmployees GetEmployee(string employeeNumber, string position, string fullName, string contactNo)
        {
            if (employee != null)
            {
                return employee;
            }
            else
            {
                return new Employees(employeeNumber, position, fullName, contactNo);
            }
        }
        public static void SetEmployee(IEmployees aEmployee)
        {
            employee = aEmployee;
        }
    }
}
