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
    public partial class RequestStock : Form
    {
        #region Instance Attributes
        private FormContainer fc;
        private IModel Model;
        List<BuisnessEntities.IRequestStock> listForReq = new List<BuisnessEntities.IRequestStock>();
        string num;
        #endregion
        public RequestStock(FormContainer parent, IModel model)
        {
            InitializeComponent();
            MdiParent = parent;
            fc = parent;
            this.Model = model;
        }

        public RequestStock()
        {
        }

        private void RequestStock_Load(object sender, EventArgs e)
        {

            if (Model.CurrentUser.WorkOrderNo != -1)
            {
                Model.populateWorkOrderComponents();

                foreach (BuisnessEntities.Components components in Model.ComponentList)
                {
                    if (components.WorkOrderNo == Model.CurrentUser.WorkOrderNo.ToString())
                    {
                        listBoxWorkOrders.Items.Add(components.ComponentName);
                    }
                }

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBoxWorkOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxWorkOrders.SelectedIndex != -1)
            {
                foreach (BuisnessEntities.Components components in Model.ComponentList)
                {
                    if (components.WorkOrderNo == Model.CurrentUser.WorkOrderNo.ToString() && listBoxWorkOrders.GetItemText(listBoxWorkOrders.SelectedItem).ToString() == components.ComponentName)
                    {

                        textBox1.Text = components.Quantity;
                    }
                }
            }
        }

        private void btnSubmitReq_Click(object sender, EventArgs e)
        {
            if (listBoxWorkOrders.SelectedIndex != -1)
            {
                if(!string.IsNullOrWhiteSpace(textBox2.Text))
                {

                IComponents component = new Components();

                foreach (BuisnessEntities.Components components in Model.ComponentList)
                {
                    if (components.WorkOrderNo == Model.CurrentUser.WorkOrderNo.ToString() && listBoxWorkOrders.GetItemText(listBoxWorkOrders.SelectedItem).ToString() == components.ComponentName)
                    {
                        component = components;
                    }
                }
                num = GetNextReqNum().ToString();
                IRequestStock rs = new BuisnessEntities.RequestStock(num, component.ComponentNum, component.BatchNum, component.ComponentName, textBox2.Text, Model.CurrentUser.UserID);
                listForReq.Add(rs);
                ListofComponents.Items.Add(rs.Name + "[" + rs.Quantity + "]");
                //Model.AddRequest();

                 }
            }
        }


        private void ListofComponents_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (listForReq.Count != 0)
            {
                if (listBoxWorkOrders.SelectedIndex != -1)
                {
                    foreach (BuisnessEntities.RequestStock rs in listForReq)
                    {
                        Model.AddRequest(rs);
                    }
                    MessageBox.Show("Request Added");
                    ListofComponents.Items.Clear();
                    listForReq.Clear();
                    num = GetNextReqNum().ToString();
                    textBox2.Text = "";

                }
            }
            else
            {
                MessageBox.Show("No Components Added to Request");
            }
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private int GetNextReqNum()
        {


            Model.populateRequestStock();
            int num = 0;
            foreach (BuisnessEntities.RequestStock rs in Model.RequestList)
            {
                num = Int32.Parse(rs.RequestNo);
            }
            num++;

            return num;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
