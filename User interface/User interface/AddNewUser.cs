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
    public partial class AddNewUser : Form
    {
        #region Instance Attributes
        IModel Model;
        FormContainer fc;
        #endregion

        #region Constructors
        public AddNewUser(FormContainer parent, IModel Model)
        {
            InitializeComponent();
            MdiParent = parent;
            fc = parent;
            this.Model = Model;
        }
        #endregion



        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Close();
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            if (listBoxUserType.SelectedIndex != -1)
            {
                if (Model.addNewUser(listBoxUserType.SelectedIndex.ToString(), "0", textBoxUserName.Text, textBoxContactNumber.Text, Model.getMD5(textBoxPassword.Text)))
                {
                    MessageBox.Show(textBoxUserName.Text + " has been added to the system.");
                    textBoxUserName.Text = "";
                    textBoxContactNumber.Text = "";
                    textBoxPassword.Text = "";
                    listBoxUserType.SelectedIndex = -1;
                }
            }
            else
            {
                MessageBox.Show("You must select a user type!");
                listBoxUserType.SelectedIndex = -1;
            }
        }

        private void AddNewUser_Load(object sender, EventArgs e)
        {

        }

        private void validateTextCharacter(object sender, EventArgs e)
        {
                 TextBox T = (TextBox)sender;
                  try
                  {
                      //Not Allowing Numbers
                      char[] UnallowedCharacters = { '0', '1','2', '3','4', '5','6', '7','8', '9','`','¬','!','"','£',
                                                     '$','%','^','&','*','(',')','_','+','-','=','[',']','{','}',';',
                                                     ':','@',',','.','/','<','>','?','|','#','~','\\', '\''}; 

                      if (textContainsUnallowedCharacter(T.Text, UnallowedCharacters))
                      {
                          int CursorIndex = T.SelectionStart - 1;
                          T.Text = T.Text.Remove(CursorIndex, 1);

                          //Align Cursor to same index
                          T.SelectionStart = CursorIndex;
                          T.SelectionLength = 0;
                      }
                  }
                  catch (Exception) { } 
            }

         private bool textContainsUnallowedCharacter(string T, char[] UnallowedCharacters)
         {
             for (int i = 0; i < UnallowedCharacters.Length; i++)
                 if (T.Contains(UnallowedCharacters[i]))
                     return true;

             return false;
         }

        private void validateTextInteger(object sender, EventArgs e)
        {
            Exception X = new Exception();

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
