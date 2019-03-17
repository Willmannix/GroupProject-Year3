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

namespace User_interface
{
    public partial class AdvanceWOstage : Form
    {
        #region Instance Attributes
        IModel Model;
        FormContainer fc;
        #endregion

        #region Constructors
        public AdvanceWOstage(FormContainer parent, IModel Model)
        {
            InitializeComponent();
            MdiParent = parent;
            fc = parent;
            this.Model = Model;
        }

        #endregion

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AdvanceWOstage_Load(object sender, EventArgs e)
        {
            Model.populateWorkOrders2();
            foreach (BuisnessEntities.WorkOrder work in Model.WorkOrderList)
            {
                listBoxWorkOrders.Items.Add(work.WorkOrderNo);
            }
        }

        private void listBoxWorkOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuisnessEntities.WorkOrder wo = new BuisnessEntities.WorkOrder();
            foreach (BuisnessEntities.WorkOrder work in Model.WorkOrderList)
            {
                if (work.WorkOrderNo == listBoxWorkOrders.SelectedItem.ToString())
                {
                    wo = work;
                }
            }

            if (wo.Process != "")
            {
                textBoxStage.Text = wo.Process;
            }
            buttonAdvance.Enabled = true;

        }

        private void buttonAdvance_Click(object sender, EventArgs e)
        {
            switch (textBoxStage.Text)
            {
                case "P0":
                    textBoxStage.Text = "P1";
                    break;
                case "P1":
                    textBoxStage.Text = "P2";
                    break;
                case "P2":
                    textBoxStage.Text = "P3";
                    break;
                case "P3":
                    MessageBox.Show("Work order is complete please use the complete work order button.");
                    break;
                default:
                    MessageBox.Show("Action cannot be completed.");
                    break;
            }
            string workOrderNo = "0";
            foreach (BuisnessEntities.WorkOrder wo in Model.WorkOrderList)
            {
                if (wo.WorkOrderNo == listBoxWorkOrders.SelectedItem.ToString())
                {
                    workOrderNo = wo.WorkOrderNo;
                    wo.Process = textBoxStage.Text;
                }
            }
            if (workOrderNo != "0")
            {
                Model.updateStage(Convert.ToInt32(workOrderNo), textBoxStage.Text);

            }
            buttonAdvance.Enabled = false;
        }

        private void buttonFinish_Click(object sender, EventArgs e)
        {
            switch (textBoxStage.Text)
            {
                case "P3":
                    textBoxStage.Text = "Complete";
                    break;
                default:
                    MessageBox.Show("Action cannot be completed.");
                    break;
            }
            string workOrderNo = "0";

            foreach (BuisnessEntities.WorkOrder wo in Model.WorkOrderList)
            {
                if (wo.WorkOrderNo == listBoxWorkOrders.SelectedItem.ToString())
                {
                    workOrderNo = wo.WorkOrderNo;
                    wo.Process = textBoxStage.Text;
                }
            }
            if (workOrderNo != "0")
            {
                Model.updateStage(Convert.ToInt32(workOrderNo), textBoxStage.Text);
            }
        }
    }
}
