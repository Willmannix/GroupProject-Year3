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
    public partial class SignOutOperator : Form
    {

        #region Instance Attributes
        IModel Model;
        FormContainer fc;
        #endregion

        #region Instance Properties

        #endregion
        string employeeNo;
        string employeeName;
        string workOrderNo;
        #region Constructors
        public SignOutOperator(FormContainer parent, IModel Model)
        {
            InitializeComponent();
            MdiParent = parent;
            fc = parent;
            this.Model = Model;

        }
        #endregion




        private void SignOutOperator_Load(object sender, EventArgs e)
        {
            Populate();
           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

            foreach (WorkOrder workOrder in Model.WorkOrderList)
            {

                listView1.Clear();
                Populate();

            }
        }


        private void Populate()
        {
               
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;

            ColumnHeader colHead = new ColumnHeader();
            colHead.Text = "Employee No";
            colHead.Width = listView1.Width / 3;
            listView1.Columns.Add(colHead);
            colHead = new ColumnHeader();
            colHead.Text = "Employee Name";
            listView1.Columns.Add(colHead);
            colHead.Width = listView1.Width / 3;
            colHead = new ColumnHeader();
            colHead.Text = "Work Order No";
            listView1.Columns.Add(colHead);
            colHead.Width = listView1.Width / 3;


            foreach (User u in Model.UserList)
            {
                if (!u.WorkOrderNo.Equals(-1))
                {
                    string[] arr = new string[3];
                    ListViewItem itm;
                    arr[0] = u.UserID;
                    arr[1] = u.FullName;
                    arr[2] = u.WorkOrderNo.ToString();


                    itm = new ListViewItem(arr);
                    listView1.Items.Add(itm);
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click_1(object sender, EventArgs e)
        {

            try
            {
               
               
                    IUser temp = UserFactory.GetUser(employeeNo, "","","","","", Convert.ToInt32(workOrderNo));

                    if (Model.assignWorkOrder(temp))
                    {
                        foreach (User u in Model.UserList)
                        {
                            if (u.UserID == temp.UserID)
                            {
                                u.WorkOrderNo = -1;
                                employeeName = u.FullName;
                            }
                        }
                        MessageBox.Show(employeeName + " has been signed out of the Work Order");
                            listView1.SelectedItems[0].Remove();
                    }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
            Close();
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
             employeeNo = listView1.SelectedItems[0].SubItems[0].Text;
             workOrderNo = listView1.SelectedItems[0].SubItems[2].Text;
        }
    }
}
