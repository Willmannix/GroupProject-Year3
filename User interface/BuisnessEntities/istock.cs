using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuisnessEntities
{
    public interface IStock
    {
        string ComponentNo { get; set; }
        string BatchNo { get; set; }
        string Name { get; set; }
        string Quantity { get; set; }
    }
}

