using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuisnessEntities
{
    public class broke : BuisnessEntities.Ibroke
    {
        #region Instance Properties

        private string compnentNo;
        private string batchNo;
        private string name;
        private string quantity;
        private string workOrderNo;
        private string quantityUsed;
        private string broken;

        #endregion

        #region Instance Properties

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

        public string WorkOrderNo
        {
            get
            {
                return workOrderNo;
            }
            set
            {
                workOrderNo = value;
            }
        }
        public string QuantityUsed
        {
            get
            {
                return quantityUsed;
            }
            set
            {
                quantityUsed = value;
            }
        }
        public string Broken
        {
            get
            {
                return broken;
            }
            set
            {
                broken = value;
            }
        }
        #endregion

        #region Constructors
        public broke()
        {

            this.CompnentNo = "";
            this.BatchNo = "";
            this.Name = "";
            this.Quantity = "";
            this.WorkOrderNo = "";
            this.QuantityUsed = "";
            this.Broken = "";
        }

        public broke(string compnentNo, string batchNo, string name, string quantity, string workOrderNo, string QuantityUsed, string broke)
        {

            this.CompnentNo = compnentNo;
            this.BatchNo = batchNo;
            this.Name = name;
            this.Quantity = quantity;
            this.WorkOrderNo = workOrderNo;
            this.QuantityUsed = quantityUsed;
            this.Broken = broken;
        }
        public broke(string broke)
        {


            this.Broken = broken;
        }
        #endregion

    }
}
