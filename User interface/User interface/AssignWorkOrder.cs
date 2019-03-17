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
using BuisnessEntities;
namespace User_interface
{
    public partial class AssignWorkOrder : Form
    {
        #region Instance Attributes
		FormContainer fc;
        private IModel Model;
        string name;
        #endregion

        #region Instance Properties

        #endregion

        #region Constructors
        public AssignWorkOrder(FormContainer parent, IModel Model)
        {
            InitializeComponent();
			MdiParent = parent;
			fc = parent;
            this.Model = Model;
        }
        #endregion

        private void AssignWorkOrder_Load_1(object sender, EventArgs e)
        {
            this.Refresh();
            populate();
            
        }
		
		private void lstViewAssignWorkOrder_MouseClick(object sender, MouseEventArgs e)
        {
            string employeeNo = lstViewAssignWorkOrder.SelectedItems[0].SubItems[0].Text;
            
            txtAssignedOperator.Text = employeeNo;
        }
        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            
            string workOrder = listView1.SelectedItems[0].SubItems[0].Text;
            txtWorkOrderNo.Text = workOrder;
        }

        private void btnAssign_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtWorkOrderNo.Text))
                {
                    MessageBox.Show("Please enter a Work Order Number.");
                    txtWorkOrderNo.Focus();
                }
                else
                {
                    IUser temp = UserFactory.GetUser(txtAssignedOperator.Text, "", "", "", "", "", Convert.ToInt32(txtWorkOrderNo.Text));

                    if (Model.assignWorkOrder(temp))
                    {
                        foreach (User u in Model.UserList)
                        {
                            if (u.UserID == temp.UserID)
                            {
                                u.WorkOrderNo = temp.WorkOrderNo;
                                name = u.FullName;
                            }
                        }
                        MessageBox.Show(name + " has been assigned to Work Order " + txtWorkOrderNo.Text);
                        lstViewAssignWorkOrder.SelectedItems[0].Remove();
                    }
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        private void populate()
        {
            lstViewAssignWorkOrder.View = View.Details;
            lstViewAssignWorkOrder.GridLines = true;
            lstViewAssignWorkOrder.FullRowSelect = true;
            Model.populateWorkOrders2();
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;


            ColumnHeader colHead = new ColumnHeader();
            colHead.Text = "Available Operators";
            colHead.Width = lstViewAssignWorkOrder.Width;
            lstViewAssignWorkOrder.Columns.Add(colHead);

            foreach (User users in Model.UserList)
            {
                if (!users.UserType.Equals("m") && !users.UserType.Equals("s") && users.WorkOrderNo.Equals(-1))
                {
                    string[] arr = new string[2];
                    ListViewItem itm;
                    arr[0] = users.UserID.ToString();
                    itm = new ListViewItem(arr);
                    lstViewAssignWorkOrder.Items.Add(itm);
                }
            }

            ColumnHeader colHead1 = new ColumnHeader();
            colHead1.Text = "Work Orders";
            colHead1.Width = listView1.Width;
            listView1.Columns.Add(colHead1);

            foreach (IWorkOrder w in Model.WorkOrderList)
            {
                string[] arr1 = new string[2];
                ListViewItem itm1;
                arr1[0] = w.WorkOrderNo;
                itm1 = new ListViewItem(arr1);
                listView1.Items.Add(itm1);
            }
        }
        private void validateTextInteger(object sender, EventArgs e)
        {
                Exception X = new Exception();

                TextBox T = (TextBox)sender;

                try
                {
                    if (T.Text != "-")
                    {
                        int x = int.Parse(T.Text);
                    }
                }
                catch (Exception)
                {
                    try
                    {
                        int CursorIndex = T.SelectionStart - 1;
                        T.Text = T.Text.Remove(CursorIndex, 1);

                        //Align Cursor to same index
                        T.SelectionStart = CursorIndex;
                        T.SelectionLength = 0;
                    }
                    catch (Exception) { }
                }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Close();
        }
    }
}
