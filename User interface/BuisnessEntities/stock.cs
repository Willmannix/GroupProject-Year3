using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuisnessEntities
{
    public class Stock : BuisnessEntities.IStock
    {
        #region Instance Properties
        string componentNo;
        string batchNo;
        string name;
        string quantity;


        #endregion

        #region Instance Properties
        public string ComponentNo { get => componentNo; set => componentNo = value; }
        public string BatchNo { get => batchNo; set => batchNo = value; }
        public string Name { get => name; set => name = value; }
        public string Quantity { get => quantity; set => quantity = value; }
        #endregion

        #region Constructors
        public Stock()
        {
            this.ComponentNo = "";
            this.BatchNo = "";
            this.Name = "";
            this.Quantity = "";
        }
        public Stock(string componentNo, string batchNo, string name, string quantity)
        {
            this.ComponentNo = componentNo;
            this.BatchNo = batchNo;
            this.Name = name;
            this.Quantity = quantity;
        }
        public Stock(string batchNo, string name, string quantity)
        {
            this.BatchNo = batchNo;
            this.Name = name;
            this.Quantity = quantity;
        }
        #endregion


    }
}
