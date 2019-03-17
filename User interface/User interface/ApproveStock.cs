using BuisnessEntities;
using BuisnessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace User_interface
{
    public partial class ApproveStock : Form
    {
        FormContainer fc;
        #region Instance Attributes
        private IModel Model;
        #endregion

        #region Instance Properties

        #endregion

        public ApproveStock(FormContainer fc, IModel Model)
        {
            InitializeComponent();
            this.Model = Model;
        }

        private void ApproveStock_Load(object sender, EventArgs e)
        {
            Model.populateRequestStock();
            foreach (BuisnessEntities.RequestStock r in Model.RequestList)
            {
                if (!StockRequestList.Items.Contains(r.RequestNo))
                {
                    StockRequestList.Items.Add(r.RequestNo);
                }
            }

        }

        private void StockRequestList_SelectedIndexChanged(object sender, EventArgs e)
        {
            StockApproveList.Items.Clear();
            foreach (BuisnessEntities.RequestStock r in Model.RequestList)
            {
                if (StockRequestList.SelectedItem.ToString() == r.RequestNo.ToString())
                {
                    StockApproveList.Items.Add(r.Name);
                }
            }
        }

        private void StockApproveList_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (BuisnessEntities.RequestStock r in Model.RequestList)
            {
                if (r.Name == StockApproveList.SelectedItem.ToString() && r.RequestNo == StockRequestList.SelectedItem.ToString())
                {
                    txtQuantity.Text = r.Quantity;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            foreach (BuisnessEntities.RequestStock r in Model.RequestList)
            {
                if (r.Name == StockApproveList.SelectedItem.ToString() && r.RequestNo == StockRequestList.SelectedItem.ToString())
                {
                    r.Quantity = txtQuantity.Text;
                }
            }
        }

        private void btnApproveAll_Click(object sender, EventArgs e)
        {
            Model.deleteRequest(StockRequestList.SelectedItem.ToString());
            foreach (BuisnessEntities.RequestStock r in Model.RequestList)
            {
                if (r.RequestNo == StockRequestList.SelectedItem.ToString())
                {
                    Model.updateComponents(r.CompnentNo, r.Quantity);
                }
            }

        }
    }
}