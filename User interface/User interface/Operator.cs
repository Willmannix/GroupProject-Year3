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
    public partial class Operator : Form
    {
        #region Instance Attributes
        private FormContainer fc;
        private IModel Model;
        #endregion

        #region Constructors
        public Operator(FormContainer parent, IModel model)
        {
            InitializeComponent();
            MdiParent = parent;
            fc = parent;
            this.Model = model;
        }
        #endregion

        private void Operator_Load(object sender, EventArgs e)
        {

        }

        private void btnRequestQC_Click(object sender, EventArgs e)
        {
            RequestQcCheck form1 = new RequestQcCheck(fc, Model);
            form1.Show();
        }
        private void btnRequestS_Click(object sender, EventArgs e)
        {
            RequestStock requestStock = new RequestStock(fc, Model);
            requestStock.Show();
        }

        private void btnMarkAF_Click(object sender, EventArgs e)
        {
            AdvanceWOstage form1 = new AdvanceWOstage(fc, Model);
            form1.Show();
        }

        private void btnCheckWO_Click(object sender, EventArgs e)
        {
            if (Model.CurrentUser.WorkOrderNo != -1)
            {
                CheckWorkOrder CWO = new CheckWorkOrder(fc, Model);
                CWO.Show();
            }
            else
            {
                MessageBox.Show("You are not assigned to a work order!", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MarkAsBroken markAsBroken = new MarkAsBroken(fc, Model);
            markAsBroken.Show();
                

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
