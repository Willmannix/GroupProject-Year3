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
using System.Drawing.Imaging;
using System.Diagnostics;

namespace User_interface
{
    public partial class PrintWO : Form
    {
        string WoNum;
        private IModel Model;
        public PrintWO(string woNum,IModel Model)
        {
            InitializeComponent();
            this.WoNum = woNum;
            this.Model = Model;

        }

        private void PrintWO_Load(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;

            Model.populateWorkOrders2();
            Model.populateWorkOrderComponents();
            foreach (BuisnessEntities.WorkOrder workorder in Model.WorkOrderList)
            {
                if(workorder.WorkOrderNo == WoNum)
                {
                    textBox1.Text = workorder.Date;
                    textBox5.Text = workorder.WorkOrderNo;
                    textBox6.Text = workorder.Quantity;
                    textBox7.Text = workorder.Description;
                    textBox2.Text = workorder.Sign;
                    textBox3.Text = workorder.SignedDate;
                    textBox4.Text = workorder.EmployeeNo;
                }
            }
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;

            foreach (BuisnessEntities.Components component in Model.ComponentList)
            {
                if (component.WorkOrderNo == WoNum)
                {
                    string[] row = { component.ComponentNum,component.BatchNum,component.ComponentName, component.Quantity };
                    var listViewItem = new ListViewItem(row);
                    listView1.Items.Add(listViewItem);
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (Model.updatePrintWO(WoNum))
                {
                Rectangle bounds = this.Bounds;

                using (Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height))
                {
                    using (Graphics g = Graphics.FromImage(bitmap))
                    {
                        g.CopyFromScreen(new Point(bounds.Left, bounds.Top), Point.Empty, bounds.Size);
                    }
                    bitmap.Save("WorkOrder.jpg", ImageFormat.Jpeg);
                }
                Process photoViewer = new Process();
                photoViewer.StartInfo.FileName = @"WorkOrder.jpg";
                photoViewer.StartInfo.Arguments = @"\\";
                photoViewer.Start();
                this.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
