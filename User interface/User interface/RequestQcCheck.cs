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
    public partial class RequestQcCheck : Form
    {
        #region Instance Attributes
        IModel Model;
        FormContainer fc;
        #endregion

        #region Constructors
        public RequestQcCheck(FormContainer parent, IModel Model)
        {
            InitializeComponent();
            MdiParent = parent;
            fc = parent;
            this.Model = Model;
        }
        #endregion

        private void buttonRequestQcCheck_Click(object sender, EventArgs e)
        {
            bool done = Model.requestQcCheck(Convert.ToInt32(listBoxWorkOrders.SelectedItem.ToString()));
            if (done)
            {
                MessageBox.Show("QC Check has been requested.");
            }
            else
            {
                MessageBox.Show("There was an error requesting the Qc check");
            }
        }

        private void listBoxWorkOrders_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RequestQcCheck_Load(object sender, EventArgs e)
        {
            if (Model.CurrentUser.WorkOrderNo != -1)
            { 
                
                listBoxWorkOrders.Items.Add(Model.CurrentUser.WorkOrderNo);
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
