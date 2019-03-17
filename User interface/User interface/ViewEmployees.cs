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
    public partial class ViewEmployees : Form
    {
        #region Instance Attributes
		FormContainer fc;		   
        private IModel Model;
        #endregion

        #region Instance Properties

        #endregion

        #region Constructors
        public ViewEmployees(FormContainer parent, IModel Model)
        {
            InitializeComponent();
			MdiParent = parent;		  
			fc = parent;   
            this.Model = Model;
            Model.populateEmployees();
        }
        #endregion


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ViewEmployees_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;


            ColumnHeader colHead = new ColumnHeader();
            colHead.Text = "Employee Number";
            colHead.Width = listView1.Width / 4;
            listView1.Columns.Add(colHead);
            colHead = new ColumnHeader();
            colHead.Text = "Position";
            listView1.Columns.Add(colHead);
            colHead.Width = listView1.Width / 4;
            colHead = new ColumnHeader();
            colHead.Text = "Full Name";
            colHead.Width = listView1.Width / 4;
            listView1.Columns.Add(colHead);
            colHead = new ColumnHeader();
            colHead.Text = "Contact Number";
            listView1.Columns.Add(colHead);
            colHead.Width = listView1.Width / 4;
            foreach (Employees employee in Model.EmployeeList)
            {
				switch (employee.Position)
                {
                    case "m":
                        employee.Position = "Floor Manager";
                        break;
                    case "s":
                        employee.Position = "Stock Manager";
                        break;
                    case "o":
                        employee.Position = "Operator";
                        break;
                    default:
                        break;
                }
                string[] arr = new string[5];
                ListViewItem itm;
                arr[0] = employee.EmployeeNumber.ToString();
                arr[1] = employee.Position;
                arr[2] = employee.FullName.ToString();
                arr[3] = employee.ContactNo.ToString();
                itm = new ListViewItem(arr);
                listView1.Items.Add(itm);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
