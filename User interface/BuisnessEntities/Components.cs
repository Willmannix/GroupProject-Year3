using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuisnessEntities
{
    public class Components : BuisnessEntities.IComponents
    {
        #region Instance Properties
        private string componentNum;
        private string batchNum;
        private string componentName;
        private string quantity;
        private string workOrderNo;
        private string quantityUsed;
        private string broken;
        #endregion

        #region Instance Properties



        public string ComponentNum { get => componentNum; set => componentNum = value; }
        public string BatchNum { get => batchNum; set => batchNum = value; }
        public string ComponentName { get => componentName; set => componentName = value; }
        public string Quantity { get => quantity; set => quantity = value; }
        public string WorkOrderNo { get => workOrderNo; set => workOrderNo = value; }
        public string QuantityUsed { get => quantityUsed; set => quantityUsed = value; }
        public string Broken { get => broken; set => broken = value; }
        #endregion

        #region Constructors
        public Components()
        {
           
        }

        public Components(string componentNum, string batchNum, string componentName, string quantity)
        {
            ComponentNum = componentNum;
            BatchNum = batchNum;
            ComponentName = componentName;
            Quantity = quantity;
            
        }
        public Components(string componentNum, string batchNum, string componentName, string quantity,string workOrderNo,string quantityUsed, string broken)
        {
            ComponentNum = componentNum;
            BatchNum = batchNum;
            ComponentName = componentName;
            Quantity = quantity;
            WorkOrderNo = workOrderNo;
            QuantityUsed = quantityUsed;
            Broken = broken;
        }

        public Components(string broken)
        {
          
            Broken = broken;
        }
        #endregion
    }
}

