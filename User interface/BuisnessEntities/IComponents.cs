using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuisnessEntities
{
    public interface IComponents
    {
        string ComponentNum { get; set; }
        string BatchNum { get; set; }
        string ComponentName { get; set; }
        string Quantity { get; set; }
        string WorkOrderNo { get; set; }
        string QuantityUsed { get; set; }
        string Broken { get; set; }

    }
}
