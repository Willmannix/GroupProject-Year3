using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuisnessEntities
{
    public static class AssignToWorkOrderFactory
    {
        private static IAssignToWorkOrders assignToWorkOrder = null;

        public static IAssignToWorkOrders GetAssignToWorkOrder(string workOrderNo, string employeeNo)
        {
            if (assignToWorkOrder != null)
            {
                return assignToWorkOrder;
            }
            else
            {
                return new AssignToWorkOrders(workOrderNo,employeeNo);
            }
        }
        public static void SetAssignToWorkOrder(IAssignToWorkOrders aAssignToWorkOrder)
        {
            assignToWorkOrder = aAssignToWorkOrder;
        }
    }
}

