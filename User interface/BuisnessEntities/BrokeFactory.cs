using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuisnessEntities
{
    public static class BrokeFactory
    {
        private static Ibroke broke = null;

        public static Ibroke GetBroke(string compnentNo, string batchNo, string name, string quantity, string workOrder, string quantityUsed, string broken)
        {
            if (broke != null)
            {
                return broke;
            }
            else
            {
                return new broke(compnentNo, batchNo, name, quantity, workOrder, quantityUsed, broken);
            }
        }
        public static Ibroke GetBroke2(string broken)
        {
            if (broke != null)
            {
                return broke;
            }
            else
            {
                return new broke(broken);
            }
        }
        public static void SetBroke(Ibroke aBroke)
        {
            broke = aBroke;
        }
    }
}

