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
using BuisnessLayer;
namespace User_interface
{
    public partial class ViewSignedIn : Form
    {

        #region Instance Attributes
        FormContainer fc;
        private IModel Model;
        #endregion


        public ViewSignedIn(FormContainer parent, IModel Model)
        {
            InitializeComponent();
            MdiParent = parent;
            fc = parent;
            this.Model = Model;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ViewSignedIn_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;

            foreach (User user in Model.UserList)
            {
                switch (user.UserType)
                {
                    case "m":
                        user.UserType = "Floor Manager";
                        break;
                    case "s":
                        user.UserType = "Stock Manager";
                        break;
                    case "o":
                        user.UserType = "Operator";
                        break;
                    default:
                        break;
                }

                if (user.Working == "1")
                {
                    string[] arr = new string[3];
                    ListViewItem itm;
                    arr[0] = user.FullName.ToString();
                    arr[1] = user.UserType;
                    if (user.WorkOrderNo == -1)
                        arr[2] = "NOT ASSIGNED";
                    else
                        arr[2] = user.WorkOrderNo.ToString();
                    itm = new ListViewItem(arr);
                    listView1.Items.Add(itm);
                }
            }
        }
    }
}
