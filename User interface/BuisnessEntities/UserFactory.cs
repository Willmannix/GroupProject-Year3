using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuisnessEntities
{
    public static class UserFactory
    {
        private static IUser user = null;

        public static IUser GetUser(string userID, string userType, string working, string fullName, string contactNumber, string password,int workOrderNo)
        {
            if (user != null)
            {
                return user;
            }
            else
            {
                return new User(userID, userType,working,fullName,contactNumber,password, workOrderNo);
            }
        }
        public static void SetUser(IUser aUser)
        {
            user = aUser;
        }
    }
}
