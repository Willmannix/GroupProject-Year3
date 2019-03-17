using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuisnessEntities
{
    public static class StockFactory
    {
        private static IStock addStock = null;

        public static IStock GetStock(string componentNo, string BatchNo, string name, string quantity)
        {
            if (addStock != null)
            {
                return addStock;
            }
            else
            {
                return new Stock(componentNo, BatchNo, name, quantity);
            }
        }
        public static IStock GetStockFull(string componentNo, string BatchNo, string name, string quantity)
        {
            if (addStock != null)
            {
                return addStock;
            }
            else
            {
                return new Stock(componentNo, BatchNo, name, quantity);
            }
        }

        public static IStock GetStockFull(string BatchNo, string name, string quantity)
        {
            if (addStock != null)
            {
                return addStock;
            }
            else
            {
                return new Stock(BatchNo, name, quantity);
            }
        }

        //public static void SetWorkOrder(IWorkOrder aworkorder)
        //{
        //    workorder = aworkorder;
        //}

    }
}
