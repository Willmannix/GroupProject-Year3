using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuisnessEntities
{
    public class User:BuisnessEntities.IUser
    {
        #region Instance Properties
        private string fullName;
        private string userID;
        private string password;
        private string contactNumber;
        private string working;
        private string userType;
        private int workOrderNo;
        #endregion

        #region Instance Properties
        public string FullName
        {
            get
            {
                return fullName;
            }
            set
            {
                fullName = value;
            }
        }
        public string UserID
        {
            get
            {
                return userID;
            }
            set
            {
                userID = value;
            }
        }
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }
        public string ContactNumber
        {
            get
            {
                return contactNumber;
            }
            set
            {
                contactNumber = value;
            }
        }
        public string Working
        {
            get
            {
                return working;
            }
            set
            {
                working = value;
            }
        }
        public string UserType
        {
            get
            {
                return userType;
            }
            set
            {
                userType = value;
            }
        }
        public int WorkOrderNo
        {
            get
            {
                return workOrderNo;
            }
            set
            {
                workOrderNo = value;
            }
        }
        #endregion

        #region Constructors
        public User()
        {
            this.FullName = "";
            this.UserID = "";
            this.Password = "";
            this.Working = "";
            this.ContactNumber = "";
            this.UserType = "";
            this.WorkOrderNo = -1;
        }

        public User(string userID, string userType, string working, string fullName, string contactNumber, string password, int workOrderNo)
        {
            this.FullName = fullName;
            this.UserID = userID;
            this.Password = password;
            this.Working = working;
            this.ContactNumber = contactNumber;
            this.UserType = userType;
            this.WorkOrderNo = workOrderNo;
        }
        #endregion

    }
}
