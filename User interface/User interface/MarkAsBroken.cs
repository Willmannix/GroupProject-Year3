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
    public partial class MarkAsBroken : Form
    {
        IModel Model;
        FormContainer fc;




        public MarkAsBroken(FormContainer fc, IModel model)
        {
            this.fc = fc;
            Model = model;
            InitializeComponent();
        }

        private void MarkAsBroken_Load(object sender, EventArgs e)
        {

            if (Model.CurrentUser.WorkOrderNo != -1)
            {
                Model.populateWorkOrderComponents2();

                foreach (BuisnessEntities.Components components in Model.ComponentList)
                {
                    if (components.WorkOrderNo == Model.CurrentUser.WorkOrderNo.ToString())
                    {
                        listBox1.Items.Add(components.ComponentName);
                    }
                }

            }

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                if (Model.editBroke(listBox1.SelectedItem.ToString(), Model.CurrentUser.WorkOrderNo, Convert.ToInt32(txtbroken.Text)))
                {
                    MessageBox.Show("Broke Edited");
                    txtbroken.Text = "";
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtbroken.Text = listBox1.SelectedItem.ToString();
            Model.populateWorkOrderComponents();
            foreach (BuisnessEntities.Components c in Model.ComponentList)
            {
                if (c.ComponentName == txtbroken.Text)

                    txtbroken.Text = c.Broken.ToString();
            }
        }
    }
}