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
    public partial class CheckStock : Form
    {
        #region Instance Attributes
        private IModel Model;
        #endregion

        #region Instance Properties

        #endregion

        #region Constructors
        public CheckStock( IModel Model)
        {
            InitializeComponent();
            this.Model = Model;
            
        }
        #endregion


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CheckStock_Load(object sender, EventArgs e)
        {
            Populate();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

            foreach (Components component in Model.ComponentList)
            {

                listView1.Clear();
                Populate();

            }
        }
        private void Populate()
        {
            Model.populateComponents();
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;


            ColumnHeader colHead = new ColumnHeader();
            colHead.Text = "Component Number";
            colHead.Width = listView1.Width / 4;
            listView1.Columns.Add(colHead);
            colHead = new ColumnHeader();
            colHead.Text = "Batch Number";
            listView1.Columns.Add(colHead);
            colHead.Width = listView1.Width / 4;
            colHead = new ColumnHeader();
            colHead.Text = "Component Name";
            colHead.Width = listView1.Width / 4;
            listView1.Columns.Add(colHead);
            colHead = new ColumnHeader();
            colHead.Text = "Quantity";
            listView1.Columns.Add(colHead);
            colHead.Width = listView1.Width / 4;
            foreach (Components component in Model.ComponentList)
            {
                string[] arr = new string[5];
                ListViewItem itm;
                arr[0] = component.ComponentNum.ToString();
                arr[1] = component.BatchNum.ToString();
                arr[2] = component.ComponentName.ToString();
                arr[3] = component.Quantity.ToString();
                itm = new ListViewItem(arr);
                listView1.Items.Add(itm);
            }

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
