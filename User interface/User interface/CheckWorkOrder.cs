using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BuisnessEntities;
using BuisnessLayer;

namespace User_interface
{
    public partial class CheckWorkOrder : Form
    {
        #region Instance Attributes
        FormContainer fc;
        private IModel Model;
        #endregion
        public CheckWorkOrder(FormContainer parent, IModel model)
        {
            InitializeComponent();
            MdiParent = parent;
            fc = parent;
            this.Model = model;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CheckWorkOrder_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;

            listView2.View = View.Details;
            listView2.GridLines = true;
            listView2.FullRowSelect = true;
            Model.populateWorkOrderComponents();
            Model.populateWorkOrders2();

            foreach (BuisnessEntities.WorkOrder workorder in Model.WorkOrderList)
            {
                if (workorder.WorkOrderNo == Model.CurrentUser.WorkOrderNo.ToString())
                {
                    string[] row = { workorder.WorkOrderNo,workorder.Quantity, workorder.Description, workorder.Sign, workorder.Process };
                    var listViewItem = new ListViewItem(row);
                    listView1.Items.Add(listViewItem);
                }
            }


            foreach (BuisnessEntities.Components component in Model.ComponentList)
            {
                if (component.WorkOrderNo == Model.CurrentUser.WorkOrderNo.ToString())
                {
                    string[] row = { component.ComponentName, component.Quantity};
                    var listViewItem = new ListViewItem(row);
                    listView2.Items.Add(listViewItem);
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
