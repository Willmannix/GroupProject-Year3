using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuisnessEntities
{
    public class RequestStock:BuisnessEntities.IRequestStock
    {
        #region Instance Properties
        private string requestNo;
        private string compnentNo;
        private string batchNo;
        private string name;
        private string quantity;
        private string employeeNo;

        #endregion

        #region Instance Properties
        public string RequestNo
        {
            get
            {
                return requestNo;
            }
            set
            {
                requestNo = value;
            }
        }
        public string CompnentNo
        {
            get
            {
                return compnentNo;
            }
            set
            {
                compnentNo = value;
            }
        }
        public string BatchNo
        {
            get
            {
                return batchNo;
            }
            set
            {
                batchNo = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                quantity = value;
            }
        }
        public string EmployeeNo
        {
            get
            {
                return employeeNo;
            }
            set
            {
                employeeNo = value;
            }
        }
        #endregion

        #region Constructors
        public RequestStock()
        {
            this.RequestNo = "";
            this.CompnentNo = "";
            this.BatchNo = "";
            this.Name = "";
            this.Quantity = "";
            this.EmployeeNo = "";
        }

        public RequestStock(string requestNo, string compnentNo, string batchNo, string name, string quantity, string employeeNo)
        {
            this.RequestNo = requestNo;
            this.CompnentNo = compnentNo;
            this.BatchNo = batchNo;
            this.Name = name;
            this.Quantity = quantity;
            this.EmployeeNo = employeeNo;
        }
        #endregion

    }
}
