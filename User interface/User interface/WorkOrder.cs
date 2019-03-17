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
    public partial class WorkOrder : Form
    {

        #region Instance Attributes
        FormContainer fc;
        private IModel Model;
        List<IComponents> componentList = new List<IComponents>();
        #endregion

        #region Constructors

        public WorkOrder(FormContainer parent, IModel model)
        {
            InitializeComponent();
            MdiParent = parent;
            fc = parent;
            this.Model = model;
        }
        #endregion

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }
        public void WorkOrder_Load(object sender, EventArgs e)
        {
            
            getNextWONum();
            Populate();

        }
        private void WorkOrder_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBox5.Text) || string.IsNullOrWhiteSpace(textBox7.Text) || string.IsNullOrWhiteSpace(textBox1.Text)  || string.IsNullOrWhiteSpace(textBox28.Text) || string.IsNullOrWhiteSpace(textBox29.Text) || string.IsNullOrWhiteSpace(textBox30.Text))
                {
                    MessageBox.Show("All Information must be Entered and be in the correct formats");
                }
                else
                {

                    if (Model.addNewWorkOrder(textBox5.Text, textBox7.Text, textBox1.Text,"08/02/2019", textBox6.Text, textBox28.Text, textBox29.Text, textBox30.Text, "P0", "1"))
                    {
                        foreach (Components component in componentList)
                        {
                            Model.UpdateWorkOrderComponents(component, textBox5.Text);
                        }
                        MessageBox.Show("Work Order Added");
                        getNextWONum();
                        Populate();

                        listBox2.Items.Clear();

                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString() + "All Information must be Entered");
            }




        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {



        }
        private void Populate()
        {
            Model.populateComponents();
            foreach (Components component in Model.ComponentList)
            {
                listBox1.Items.Add(component.ComponentName);
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void deletecomponent()
        {
            if (listBox1.SelectedIndex != -1)
            {

                listBox2.Items.Add(listBox1.GetItemText(listBox1.SelectedItem));
                foreach (Components component in Model.ComponentList)
                {
                    if (component.ComponentName == listBox1.GetItemText(listBox1.SelectedItem))
                        Model.DeleteComponent(component);


                }
                listBox1.Items.Remove(listBox1.SelectedItem);

            }
        }
        private void getNextWONum()
        {

                Model.populateWorkOrders();
                int num = 0;
                foreach (BuisnessEntities.WorkOrder workorderss in Model.WorkOrderList)
                {
                    num = Int32.Parse(workorderss.WorkOrderNo);
                }

                num++;
                textBox5.Text = num.ToString();
                textBox6.Text = "";
                textBox1.Text = DateTime.Now.ToString("d/M/yyyy"); 
                textBox7.Text = "";
                textBox28.Text = Model.CurrentUser.FullName;
                textBox29.Text = DateTime.Now.ToString("d/M/yyyy"); 
                textBox30.Text = Model.CurrentUser.UserID;
                componentList.Clear();
                




        }

        private void btnSComponent_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (var form = new formEQuantity())
                {
                    var result = form.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        string qty = form.qty;
                        if (listBox1.SelectedIndex != -1)
                        {

                            listBox2.Items.Add(listBox1.GetItemText(listBox1.SelectedItem));
                            int index = -1;
                            for (int i = 0; i < Model.ComponentList.Count; i++)
                            {
                                if (Model.ComponentList[i].ComponentName == listBox1.GetItemText(listBox1.SelectedItem))
                                {
                                    index = i;
                                }
                            }

                            int componentQty = Convert.ToInt32(Model.ComponentList[index].Quantity);
                            int enteredqty = Convert.ToInt32(qty);


                            if (Model.ComponentList[index].ComponentName == listBox1.GetItemText(listBox1.SelectedItem))
                            {

                                componentQty = componentQty - enteredqty;
                                string newQty = componentQty.ToString();
                                Model.ComponentList[index].Quantity = newQty;
                                Model.ComponentList[index].Quantity = enteredqty.ToString();
                                componentList.Add(Model.ComponentList[index]);
                                listBox1.Items.Remove(listBox1.SelectedItem);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString()+ "All Information must be Entered");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex != -1)
            {
                listBox1.Items.Add(listBox2.SelectedItem);
                listBox2.Items.RemoveAt(listBox2.Items.Count - 1);
                componentList.RemoveAt(componentList.Count - 1);
            }
            else
                MessageBox.Show("No Item Selected");
        }

        private void listBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Close();
        }

        private void listBox2_SelectedIndexChanged_2(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}


//int componentQty = Convert.ToInt32(Model.ComponentList[index].Quantity);
//int enteredqty = Convert.ToInt32(qty);


//                            if (Model.ComponentList[index].ComponentName == listBox1.GetItemText(listBox1.SelectedItem) && componentQty == enteredqty)
//                            {
//                                Model.DeleteComponent(Model.ComponentList[index]);
//                                listBox1.Items.Remove(listBox1.SelectedItem);
//                            }
//                            else if (Model.ComponentList[index].ComponentName == listBox1.GetItemText(listBox1.SelectedItem) && componentQty > enteredqty)
//                            {
//                                componentQty = componentQty - enteredqty;
//                                string newQty = componentQty.ToString();
//Model.ComponentList[index].Quantity = newQty;
//                                Model.UpdateComponent(Model.ComponentList[index]);
//                                Model.ComponentList[index].Quantity = enteredqty.ToString();
//                                Model.UpdateWorkOrderComponents(Model.ComponentList[index], num.ToString());
//                                listBox1.Items.Remove(listBox1.SelectedItem);

//                            }
//                            else
//                            {
//                                MessageBox.Show("Not enough stock in Warehouse", "Error",
//                                MessageBoxButtons.OK, MessageBoxIcon.Error);
//                            }