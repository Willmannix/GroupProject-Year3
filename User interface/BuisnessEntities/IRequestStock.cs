using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuisnessEntities
{
    public interface IRequestStock
    {
        string RequestNo { get; set; }
        string CompnentNo { get; set; }
        string BatchNo { get; set; }
        string Name { get; set; }
        string Quantity { get; set; }
        string EmployeeNo { get; set; }

    }
}
