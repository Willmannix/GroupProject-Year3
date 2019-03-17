using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BuisnessLayer;

namespace User_interface
{
    public partial class Home : Form
    {
        #region Instance Attributes
        private IModel Model;
        #endregion

        #region Instance Properties

        #endregion

        #region Constructors
        public Home(IModel Model)
        {
            InitializeComponent();
            this.Model = Model;
        }
        #endregion



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void Home_Paint(object sender, PaintEventArgs e)
        {
            Graphics l = e.Graphics;
            Pen p = new Pen(Color.Black, 5);
            l.DrawLine(p, 350, 100, 350, 500);
            l.Dispose();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool validUser = Model.login(userName.Text, password.Text);
            if (validUser)
            {
                Close();
            }
            else
            {
                MessageBox.Show("Invalid name or password");
                userName.Text = "";
                password.Text = "";
                userName.Select();
            }
        }
    }
}
