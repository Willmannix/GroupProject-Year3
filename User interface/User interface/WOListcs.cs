using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BuisnessLayer;
using BuisnessEntities;

namespace User_interface
{
    public partial class WOListcs : Form
    {
        FormContainer fc;
        #region Instance Attributes
        private IModel Model;
        #endregion
        public WOListcs(FormContainer parent, IModel Model)
        {
            InitializeComponent();
            MdiParent = parent;
            fc = parent;
            this.Model = Model;
        }

        private void WOListcs_Load(object sender, EventArgs e)
        {
            Model.populateWorkOrders();
            foreach (BuisnessEntities.WorkOrder workorder in Model.WorkOrderList)
            {
                listBox1.Items.Add(workorder.WorkOrderNo);
            }
        }

        private void Print_Click(object sender, EventArgs e)
        {
            PrintWO printWO = new PrintWO(listBox1.GetItemText(listBox1.SelectedItem),Model);
            printWO.Show();
        }
    }
}
