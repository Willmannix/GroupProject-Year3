using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuisnessEntities
{
    public class Employees : BuisnessEntities.IEmployees
    {
        #region Instance Properties
        private string employeeNumber;
        private string position;
        private string fullName;
        private string contactNo;
        #endregion

        #region Instance Properties



        public string EmployeeNumber { get => employeeNumber; set => employeeNumber = value; }
        public string Position { get => position; set => position = value; }
        public string FullName { get => fullName; set => fullName = value; }
        public string ContactNo { get => contactNo; set => contactNo = value; }
        #endregion

        #region Constructors
        public Employees()
        {
            throw new System.NotImplementedException();
        }

        public Employees(string employeeNumber, string position, string fullName, string contactNo)
        {
            EmployeeNumber = employeeNumber;
            Position = position;
            FullName = fullName;
            ContactNo = contactNo;
        }


        #endregion
    }
}

