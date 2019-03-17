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
using System.Reflection;
namespace User_interface
{
    public partial class FormContainer : Form
    {
        #region Instance Attributes
        private IModel Model;
        #endregion

        #region Constructors
        public FormContainer(IModel _Model)
        {
            InitializeComponent();
            Model = _Model;
        }
        #endregion

        private void FormContainer_Shown(object sender, EventArgs e)
        {
            LogIn form1 = new LogIn(Model);
            form1.ShowDialog();
          
            switch (Model.getUserTypeForCurrentUser())
            {
                case "m":
                    FloorManager floorManager = new FloorManager(this, Model);
                    this.Text = this.Text + "-Manager";
                    floorManager.Dock = DockStyle.Fill;
                    floorManager.Show();
                    break;
                case "s":
                    HomeStockManager stockManager = new HomeStockManager(this, Model);
                    this.Text = this.Text + "-Stock Manager";
                    stockManager.Dock = DockStyle.Fill;
                    stockManager.Show();
                    
                    break;
                case "o":
                    Operator operatorForm = new Operator(this, Model);
                    this.Text = this.Text + "-Operator";
                    operatorForm.Dock = DockStyle.Fill;
                    operatorForm.Show();
                    break;
                default:
                    break;
            }
        }

        private void FormContainer_Load(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;

        }
    }
}
