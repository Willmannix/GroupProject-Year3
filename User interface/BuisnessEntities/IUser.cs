using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuisnessEntities
{
    public interface IUser
    {
        string FullName { get; set; }
        string UserID { get; set; }
        string Password { get; set; }
        string ContactNumber { get; set; }
        string Working { get; set; }
        string UserType { get; set; }
        int WorkOrderNo { get; set; }

    }
}
