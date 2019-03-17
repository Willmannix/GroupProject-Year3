using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuisnessEntities
{
    public class AssignToWorkOrders : BuisnessEntities.IAssignToWorkOrders
    {
        #region Instance Properties
        private string workOrderNo;
        private string employeeNo;
        #endregion

        #region Instance Properties

        public string WorkOrderNo { get => workOrderNo; set => workOrderNo = value; }
        public string EmployeeNo { get => employeeNo; set => employeeNo = value; }
        #endregion

        #region Constructors
        public AssignToWorkOrders()
        {
            throw new System.NotImplementedException();
        }

        public AssignToWorkOrders(string workOrderNo, string employeeNo)
        {
            WorkOrderNo = workOrderNo;
            EmployeeNo = employeeNo;
        }


        #endregion
    }
}

