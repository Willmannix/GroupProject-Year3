using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuisnessEntities
{
    public interface Ibroke
    {

        string CompnentNo { get; set; }
        string BatchNo { get; set; }
        string Name { get; set; }
        string Quantity { get; set; }
        string WorkOrderNo { get; set; }
        string QuantityUsed { get; set; }
        string Broken { get; set; }
    }
}
