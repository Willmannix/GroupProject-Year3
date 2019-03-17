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

namespace User_interface
{
    public partial class LogIn : Form
    {
        #region Instance Attributes
        private IModel Model;
        #endregion

        #region Instance Properties

        #endregion

        #region Constructors
        public LogIn(IModel Model)
        {
            InitializeComponent();
            this.Model = Model;
        }
        #endregion

        private void loginButton_Click(object sender, EventArgs e)
        {

            bool validUser = Model.login(userName.Text, Model.getMD5(password.Text));
            if (validUser && Model.SignIn(userName.Text))
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

        private void LogIn_Load(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void validateTextInteger(object sender, EventArgs e)
        {
            TextBox T = (TextBox)sender;

            try
            {
                if (T.Text != "-")
                {
                    int x = int.Parse(T.Text);
                }
            }
            catch (Exception)
            {
                try
                {
                    int CursorIndex = T.SelectionStart - 1;
                    T.Text = T.Text.Remove(CursorIndex, 1);

                    //Align Cursor to same index
                    T.SelectionStart = CursorIndex;
                    T.SelectionLength = 0;
                }
                catch (Exception) { }
            }
        }
    }
}
