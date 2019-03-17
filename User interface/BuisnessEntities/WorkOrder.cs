using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuisnessEntities
{
   public class WorkOrder:BuisnessEntities.IWorkOrder
    {
        #region Instance Properties
        string workOrderNo;
        string date;
        string pdate;
        string quantity;
        string description;
        string sign;
        string signedDate;
        string employeeNo;
        string process;
        string flaggedforQC;

        #endregion

        #region Instance Properties
        public string WorkOrderNo { get => workOrderNo; set => workOrderNo = value; }        
        public string Date { get => date; set => date = value; }
        public string PDate { get => pdate; set => pdate = value; }
        public string Quantity { get => quantity; set => quantity = value; }
        public string Description { get => description; set => description = value; }
        public string Sign { get => sign; set => sign = value; }
        public string SignedDate { get => signedDate; set => signedDate = value; }
        public string EmployeeNo { get => employeeNo; set => employeeNo = value; }
        public string Process { get => process; set => process = value; }
        public string FlaggedforQC { get => flaggedforQC; set => flaggedforQC = value; }
        #endregion

        #region Constructors
        public WorkOrder()
        {
            this.WorkOrderNo = "";
            this.Description = "";
            this.Date = "";
            this.PDate = "";
            this.Quantity = "";
        }
        public WorkOrder(string workOrderNo, string description, string date, string pdate, string quantity)
        {
            this.WorkOrderNo = workOrderNo;
            this.Description = description;
            this.Date = date;
            this.PDate = pdate;
            this.Quantity = quantity;
        }
        public WorkOrder(string workOrderNo,  string date, string pdate, string quantity, string description, string sign, string signedDate, string employeeNo, string process, string FlaggedforQC)
        {
            this.WorkOrderNo = workOrderNo;
            this.Date = date;
            this.PDate = pdate;
            this.Quantity = quantity;
            this.Description = description;
            this.Sign = sign;
            this.SignedDate = signedDate;
            this.EmployeeNo = employeeNo;
            this.Process = process;
            this.FlaggedforQC = FlaggedforQC;
        }
        #endregion


    }
}
