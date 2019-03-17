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
    public partial class QCcheck : Form
    {
        #region Instance Attributes
        IModel Model;
        FormContainer fc;
        #endregion

        string wonum;
        string description;

        public QCcheck(FormContainer parent, IModel Model)
        {
            InitializeComponent();
            MdiParent = parent;
            fc = parent;
            this.Model = Model;
        }

        void populatelistview()
        {
            Model.populateWorkOrders();
            Model.populateWorkOrders2();


            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;


            ColumnHeader colHead = new ColumnHeader();
            colHead.Text = "Date";
            colHead.Width = listView1.Width / 4;
            listView1.Columns.Add(colHead);
            colHead = new ColumnHeader();
            colHead.Text = "Work Order Number";
            listView1.Columns.Add(colHead);
            colHead.Width = listView1.Width / 4;
            colHead = new ColumnHeader();
            colHead.Text = "Description";
            colHead.Width = listView1.Width / 4;
            listView1.Columns.Add(colHead);
            colHead = new ColumnHeader();
            colHead.Text = "Employee";
            listView1.Columns.Add(colHead);
            colHead.Width = listView1.Width / 4;



            foreach (BuisnessEntities.WorkOrder workorder in Model.WorkOrderList)
            {
                string[] arr = new string[4];
               
                ListViewItem itm;
                if (workorder.FlaggedforQC == "1")
                {
                    //listBox1.Items.Add(workorder.Date + "-" + workorder.WorkOrderNo  + "-" + workorder.Description);
                    string[] split = workorder.Date.Split(' ');
                    arr[0] = split[0];
                    
                    arr[1] = workorder.WorkOrderNo;
                    arr[2] = workorder.Description;
                    arr[3] = workorder.EmployeeNo;
                    itm = new ListViewItem(arr);
                    listView1.Items.Add(itm);

                }

            }


        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems[0].Text != null)
            {

                wonum = listView1.SelectedItems[0].SubItems[1].Text;
                description = listView1.SelectedItems[0].SubItems[2].Text;

                panel1.Hide();

                textBox5.Text = wonum;
                textBox7.Text = description;

            }
        }

        

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked && checkBox2.Checked && checkBox3.Checked)
            {
                string status = "Finished";
                Model.UpdateQCStatus(Int32.Parse(wonum), status);

                panel1.Show();


                listView1.Clear();
                populatelistview();




            }
            else
            {
                string status = "FailedQC";
                Model.UpdateQCStatus(Int32.Parse(wonum), status);

                //Box1.BringToFront();

                panel1.Show();
                listView1.Clear();
                populatelistview();

            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != 0)
            {
                if (listView1.SelectedItems[0].Text != null)
                {

                    wonum = listView1.SelectedItems[0].SubItems[1].Text;
                    description = listView1.SelectedItems[0].SubItems[2].Text;

                    panel1.Hide();

                    textBox5.Text = wonum;
                    textBox7.Text = description;

                }
            }
         

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Confirm Quality Control submission?", "Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                if (checkBox1.Checked && checkBox2.Checked && checkBox3.Checked)
                {
                    string status = "Finished";
                    Model.UpdateQCStatus(Int32.Parse(wonum), status);

                    panel1.Show();


                    listView1.Clear();
                    populatelistview();




                }
                else
                {
                    string status = "FailedQC";
                    Model.UpdateQCStatus(Int32.Parse(wonum), status);

                    //Box1.BringToFront();

                    panel1.Show();
                    listView1.Clear();
                    populatelistview();

                }
            }

            else if (dialogResult == DialogResult.No)
            { }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Show();
            listView1.Clear();
            populatelistview();
        }

        private void QCcheck_Load(object sender, EventArgs e)
        {
            populatelistview();
        }
    }
}
