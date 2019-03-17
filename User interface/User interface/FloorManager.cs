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
    public partial class FloorManager : Form
    {
        #region Instance Attributes
        private FormContainer fc;
        private IModel Model;
        #endregion

        #region Constructors
        public FloorManager(FormContainer parent, IModel model)
        {
            InitializeComponent();
            MdiParent = parent;
            fc = parent;
            this.Model = model;
        }
        #endregion

        private void FloorManager_Load(object sender, EventArgs e)
        {

        }

        private void FloorManager_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addNewUser_Click(object sender, EventArgs e)
        {
            AddNewUser newUserForm = new AddNewUser(fc, Model);
            newUserForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WorkOrder workorder = new WorkOrder(fc, Model);
            workorder.Show();
        }

        private void ButtonEditUser_Click(object sender, EventArgs e)
        {
            EditUser editUserForm = new EditUser(fc, Model);
            editUserForm.Show();
        }

        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            DeleteUser delUser = new DeleteUser(fc, Model);
            delUser.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ViewEmployees viewemployees = new ViewEmployees(fc,Model);
            viewemployees.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AssignWorkOrder assignWorkOrder = new AssignWorkOrder(fc,Model);
            assignWorkOrder.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SignOutOperator signOutOperator = new SignOutOperator(fc,Model);
            signOutOperator.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            QCcheck qCcheck = new QCcheck(fc, Model);
            qCcheck.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Statistics statistics = new Statistics(fc, Model);
            statistics.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(Model.SignOut(Model.CurrentUser.UserID.ToString()))
            Application.Restart();
            else
                MessageBox.Show("Error Signing Out");
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            ViewSignedIn viewSignedIn = new ViewSignedIn(fc, Model);
            viewSignedIn.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            WorkOrderTeams workOrderTeams = new WorkOrderTeams(fc, Model);
            workOrderTeams.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            WOListcs woList = new WOListcs(fc, Model);
            woList.Show();
        }
    }
}
