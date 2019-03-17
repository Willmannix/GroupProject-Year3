using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuisnessEntities
{
    public static class ComponentFactory
    {
        private static IComponents component = null;

        public static IComponents GetComponent(string componentNum, string batchNum, string componentName, string quantity)
        {
            if (component != null)
            {
                return component;
            }
            else
            {
                return new Components(componentNum, batchNum, componentName, quantity);
            }
        }
        public static IComponents GetComponent(string componentNum, string batchNum, string componentName, string quantity, string workOrderNo, string quantityUsed, string broken)
        {
            if (component != null)
            {
                return component;
            }
            else
            {
                return new Components(componentNum, batchNum, componentName, quantity,workOrderNo,quantityUsed, broken);
            }
        }
        public static void SetComponent(IComponents aComponent)
        {
            component = aComponent;



        }

        public static IComponents GetComponent(string broken)
        {
            if (component != null)
            {
                return component;
            }
            else
            {
                return new Components(broken);
            }
        }


    }
}
