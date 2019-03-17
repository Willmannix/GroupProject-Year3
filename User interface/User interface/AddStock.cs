using System;
using System.Collections.Generic;
using BuisnessEntities;
using BuisnessLayer;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace User_interface
{
    public partial class AddStock : Form
    {

        public int GenerateRandomNo()
        {
            int _min = 1000;
            int _max = 9999;
            Random _rdm = new Random();
            return _rdm.Next(_min, _max);
        }



        #region Instance Attributes
        IModel Model;
        FormContainer fc;
        List<IStock> stockList = new List<IStock>();

        #endregion

        #region Constructors
        public AddStock(FormContainer parent, IModel Model)
        {
            InitializeComponent();
            MdiParent = parent;
            fc = parent;
            this.Model = Model;
        }
        #endregion



        public AddStock()
        {
            InitializeComponent();
        }

        private void AddStock_Load(object sender, EventArgs e)
        {
            int batchNo = GenerateRandomNo();
            txtBatch.Text = Convert.ToInt32(batchNo).ToString();
        }

        private void btnAddStock_Click(object sender, EventArgs e)
        {

            try
            {
                if (Model.addNewStock1(txtBatch.Text, txtName.Text, txtQuantity.Text))
                {
                    foreach (Stock stock in stockList)
                    {
                        Model.UpdateStock(stock, (getNextComponentNo() - 1).ToString());
                    }
                    MessageBox.Show("Stock has been Added");
                    txtBatch.Text = "";
                    txtName.Text = "";
                    txtQuantity.Text = "";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private int getNextComponentNo()
        {
            Model.populateComponents();
            int Num = 0;
            foreach (BuisnessEntities.Stock stocks in Model.StockList)
            {
                Num = Int32.Parse(stocks.ComponentNo);
            }
            Num++;

            return Num;
        }
    }
}
