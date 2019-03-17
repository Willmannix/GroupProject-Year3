using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuisnessEntities
{
    public static class RequestStockFactory
    {
        private static IRequestStock requestStock = null;

        public static IRequestStock GetRequestStock(string requestNo, string componentNo, string batchNo, string name, string quantity, string employeeNo)
        {
            if (requestStock != null)
            {
                return requestStock;
            }
            else
            {
                return new RequestStock(requestNo,  componentNo,  batchNo,  name,  quantity,  employeeNo);
            }
        }
        public static void SetUser(RequestStock aRequestStock)
        {
            requestStock = aRequestStock;
        }
    }
}
