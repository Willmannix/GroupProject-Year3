using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuisnessEntities
{
    public interface IEmployees
    {
        string EmployeeNumber { get; set; }
        string Position { get; set; }
        string FullName { get; set; }
        string ContactNo { get; set; }

    }
}
