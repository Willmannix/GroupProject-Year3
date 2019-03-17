using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuisnessEntities
{
    public interface IWorkOrder
    {
        string WorkOrderNo { get; set; } 
        string Date { get; set; }
        string PDate { get; set; }
        string Quantity { get; set; }
        string Description { get; set; }
        string Sign { get; set; }
        string SignedDate { get; set; }
        string EmployeeNo { get; set; }
        string Process { get; set; }
        string FlaggedforQC { get; set; }
    }
}
