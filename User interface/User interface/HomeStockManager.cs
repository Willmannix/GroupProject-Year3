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
    public partial class HomeStockManager : Form
    {
        #region Instance Attributes
        private FormContainer fc;
        private IModel Model;
        #endregion
        #region Constructors
        public HomeStockManager(FormContainer parent, IModel Model)
        {
            InitializeComponent();
            MdiParent = parent;
            fc = parent;
            this.Model = Model;
        }
        #endregion

        private void HomeStockManager_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void HomeStockManager_Load(object sender, EventArgs e)
        {
            Populate();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            CheckStock checkstock = new CheckStock(Model);
            checkstock.ShowDialog();
            
        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
        private void Populate()
        {
            Model.populateComponents();
            Model.populateRequestStock();
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;

            listView2.View = View.Details;
            listView2.GridLines = true;
            listView2.FullRowSelect = true;

            ColumnHeader colHead = new ColumnHeader();
          

            
            foreach (Components component in Model.ComponentList)
            {
                int quantity = Int32.Parse(component.Quantity);
                if (quantity < 100)
                {
                    string[] arr = new string[5];
                    ListViewItem itm;
                    arr[0] = component.ComponentName.ToString();
                    arr[1] = component.Quantity.ToString();
                    itm = new ListViewItem(arr);
                    listView1.ForeColor = Color.Red;
                    listView1.Items.Add(itm);
                }
            }

            foreach (BuisnessEntities.RequestStock component in Model.RequestList)
            {

                    string[] arr = new string[5];
                    ListViewItem itm;
                    arr[0] = component.Name;
                    arr[1] = component.Quantity.ToString();
                    itm = new ListViewItem(arr);
                    listView2.ForeColor = Color.Red;
                    listView2.Items.Add(itm);
                
            }



            //listView1.Columns[0].Width = Width - 4 - SystemInformation.VerticalScrollBarWidth;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ApproveStock ap = new ApproveStock(fc, Model);
            ap.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddStock add = new AddStock(fc, Model);
            add.Show();
        }
    }
}
