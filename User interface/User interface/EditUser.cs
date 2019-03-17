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
    public partial class EditUser : Form
    {
        #region Instance Attributes
        IModel Model;
        FormContainer fc;
        #endregion

        #region Constructors
        public EditUser(FormContainer parent, IModel Model)
        {
            InitializeComponent();
            MdiParent = parent;
            fc = parent;
            this.Model = Model;
        }

        #endregion

        private void buttonEditUser_Click(object sender, EventArgs e)
        {
            if (listBoxUserType.SelectedIndex != -1)
            {
                string userType = listBoxUserType.SelectedIndex.ToString();
                switch (userType)
                {
                    case "0":
                        userType = "m";
                        break;
                    case "1":
                        userType = "o";
                        break;
                    case "2":
                        userType = "s";
                        break;
                    default:
                        break;
                }
                IUser temp = UserFactory.GetUser(textBoxUserID.Text, userType, "0", textBoxFullName.Text, textBoxContactNumber.Text, Model.getMD5(textBoxNewPassword.Text), -1);

                if (Model.editUser(temp))
                {
                    foreach (User u in Model.UserList)
                    {
                        if (u.UserID == temp.UserID)
                        {
                            u.ContactNumber = temp.ContactNumber;
                            u.FullName = temp.FullName;
                            u.Password = temp.Password;
                            u.UserID = temp.UserID;
                            u.UserType = temp.UserType;
                            u.Working = "0";
                        }
                    }
                    MessageBox.Show(textBoxFullName.Text + "'s details have been edited.");
                    textBoxFullName.Text = "";
                    textBoxUserID.Text = "";
                    textBoxContactNumber.Text = "";
                    textBoxNewPassword.Text = "";
                    listBoxUserType.SelectedIndex = -1;
                }
            }
            else
            {
                MessageBox.Show("You must select a user type!");
                listBoxUserType.SelectedIndex = -1;
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Close();
        }

        private void EditUser_Load(object sender, EventArgs e)
        {
            foreach (User user in Model.UserList)
            {
                listBoxUsers.Items.Add(user.FullName);
            }
        }

        private void listBoxUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxFullName.Text = listBoxUsers.SelectedItem.ToString();
            foreach (User user in Model.UserList)
            {
                if (user.FullName == textBoxFullName.Text)
                {
                    textBoxUserID.Text = user.UserID;
                    textBoxNewPassword.Text = user.Password;
                    textBoxContactNumber.Text = user.ContactNumber;
                    switch (user.UserType)
                    {
                        case "m":
                            listBoxUserType.SelectedIndex = 0;
                            break;
                        case "o":
                            listBoxUserType.SelectedIndex = 1;
                            break;
                        case "s":
                            listBoxUserType.SelectedIndex = 2;
                            break;
                        default:
                            break;
                    }

                }
            }
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
