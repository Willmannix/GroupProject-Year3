using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuisnessEntities
{
    public static class WorkOrderFactory
    {
        private static IWorkOrder workorder = null;

        public static IWorkOrder GetWorkOrders(string workOrderNo, string description, string date, string pdate, string quantity)
        {
            if (workorder != null)
            {
                return workorder;
            }
            else
            {
                return new WorkOrder(workOrderNo, description, date, pdate, quantity);
            }
        }
        public static IWorkOrder GetWorkOrdersFull(string workOrderNo, string date, string pdate, string quantity, string description, string sign, string signedDate, string employeeNo, string process, string FlaggedforQC)
        {
            if (workorder != null)
            {
                return workorder;
            }
            else
            {
                return new WorkOrder(workOrderNo,  date, pdate, quantity, description, sign, signedDate, employeeNo, process, FlaggedforQC);
            }
        }

        public static void SetWorkOrder(IWorkOrder aworkorder)
        {
            workorder = aworkorder;
        }

    }
}
