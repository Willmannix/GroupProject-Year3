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
    public partial class WorkOrderTeams : Form
    {
        FormContainer fc;
        #region Instance Attributes
        private IModel Model;
        #endregion

        public WorkOrderTeams(FormContainer parent, IModel Model)
        {
            InitializeComponent();
            MdiParent = parent;
            fc = parent;
            this.Model = Model;
        }

        private void WorkOrderTeams_Load(object sender, EventArgs e)
        {
            Model.populateWorkOrders();
            listView2.View = View.Details;
            listView2.GridLines = true;
            listView2.FullRowSelect = true;


            foreach (BuisnessEntities.WorkOrder workorder in Model.WorkOrderList)
            {
                listBox1.Items.Add(workorder.WorkOrderNo);
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            listView2.Items.Clear();
            if (listBox1.SelectedIndex != -1)
            {
                foreach (User user in Model.UserList)
                {
                    if (user.WorkOrderNo.ToString() == listBox1.GetItemText(listBox1.SelectedItem))
                    {
                        string[] arr = new string[2];
                        ListViewItem itm;
                        arr[0] = user.UserID;
                        arr[1] = user.FullName;
                        itm = new ListViewItem(arr);
                        listView2.Items.Add(itm);
                    }
                }
            }
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        
    }
}
