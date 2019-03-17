using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Data;
using DataAccessLayer;
using System.Threading.Tasks;
using BuisnessEntities;

namespace BuisnessLayer
{
    public class Model : IModel
    {
        #region Static Attributes
        private static IModel modelSingletonInstance;
        static readonly object padlock = new object();
        #endregion

        #region Instance Attributes
        private IDataLayer dataLayer;
        private User currentUser;
        private ArrayList userList;
        private List<IComponents> componentList;
        private List<IWorkOrder> workOrderList;
        private List<IEmployees> employeeList;
        private List<Ibroke> brokeList;
        private List<IStock> stockList;
        private ArrayList requestList;
        #endregion

        #region Instance Properties
        public IDataLayer DataLayer
        {
            get { return dataLayer; }
            set { dataLayer = value; }
        }
        public User CurrentUser
        {
            get
            {
                return currentUser;
            }
            set
            {
                currentUser = value;
            }
        }


        public ArrayList UserList
        {
            get
            {
                return userList;
            }
            //set
            //{
            //}
        }
        public ArrayList RequestList
        {
            get
            {
                return requestList;
            }
            //set
            //{
            //}
        }
        public List<IComponents> ComponentList
        {
            get { return componentList; }
            set { componentList = value; }
        }

        public List<Ibroke> BrokeList
        {
            get { return brokeList; }
            set { brokeList = value; }
        }
        public List<IStock> StockList
        {
            get { return stockList; }
            set { stockList = value; }
        }
        public List<IWorkOrder> WorkOrderList
        {
            get { return workOrderList; }
            set { workOrderList = value; }
        }
        public List<IEmployees> EmployeeList
        {
            get { return employeeList; }
            set { employeeList = value; }
        }
        #endregion

        #region Constructors/Deconstructors
        public static IModel GetInstance(IDataLayer _DataLayer)
        {
            lock (padlock)
            {
                if (modelSingletonInstance == null)
                {
                    modelSingletonInstance = new Model(_DataLayer);
                }
                return modelSingletonInstance;
            }
        }
        private Model(IDataLayer _DataLayer)
        {
            userList = new ArrayList();
            dataLayer = _DataLayer;
            userList = dataLayer.GetAllUsers();
        }
        ~Model()
        {
            tearDown();
        }
        #endregion

        public Boolean login(string userID, string password)
        {

            foreach (User u in userList)
            {
                if (userID == u.UserID)
                {
                    if (password == u.Password)
                    {
                        CurrentUser = u;
                        return true;
                    }
                }
            }
            return false;
        }
        public Boolean addNewUser(string userType, string working, string fullName, string contactNumber, string password)
        {
            try
            {
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
                int userID = 0;
                foreach (User user in UserList)
                {
                    if (Convert.ToInt32(user.UserID) >= userID)
                        userID = Convert.ToInt32(user.UserID) + 1;
                }
                IUser theUser = UserFactory.GetUser(userID.ToString(), userType, working, fullName, contactNumber, password, -1);
                UserList.Add(theUser);
                DataLayer.addNewUserToDB(userID.ToString(), userType, working, fullName, contactNumber, password, -1);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }
        public Boolean SignIn(string userID)
        {
            if (DataLayer.signIn(userID))
            {
                return true;
            }
            else return false;

        }

        public Boolean SignOut(string userID)
        {
            if (DataLayer.signOut(userID))
            {
                return true;
            }
            else return false;

        }
        public bool deleteUser(IUser user)
        {
            DataLayer.deleteUserFromDB(user);
            UserList.Remove(user);
            return true;
        }
        public bool editUser(IUser user)
        {
            DataLayer.editUserInDB(user);
            return true;
        }
        public bool editBroke(string compNo, int workOrderNo, int qty)
        {
            DataLayer.editBrokeInDB(compNo, workOrderNo, qty);
            return true;
        }
        public bool MarkBroken(IComponents component)
        {
            DataLayer.MarkBrokenInDB(component);
            return true;
        }
        public bool assignWorkOrder(IUser user) //// needs improving
        {
            DataLayer.assignToWorkOrder(user);
            return true;
        }
        public String getUserTypeForCurrentUser()
        {
            return currentUser.UserType;
        }

        public void populateComponents()
        {
            componentList = dataLayer.GetAllComponents(); // setup Models orderList
        }
        public void populateWorkOrderComponents()
        {
            componentList = dataLayer.GetAllWOComponents(); // setup Models orderList
        }
        public void populateWorkOrderComponents2()
        {
            componentList = dataLayer.GetBrokenWOComponent(); // setup Models orderList
        }
        public void populateWorkOrders()
        {
            workOrderList = dataLayer.GetAllWorkOrders(); // setup Models orderList
        }
        public void populateStock()
        {
            StockList = dataLayer.GetAllStock();
        }
        public void populateWorkOrders2()
        {
            workOrderList = dataLayer.GetAllWorkOrdersFull(); // setup Models orderList
        }
        public void populateEmployees()
        {
            employeeList = dataLayer.GetAllEmployees(); //  needs improving
        }
        public void populateRequestStock()
        {
            requestList = dataLayer.GetAllRequests(); //  needs improving
        }
        public void tearDown()
        {
            DataLayer.closeConnection();
        }

        public bool updatePrintWO(string WoNum)
        {
            return DataLayer.UpdatePrintDateWO(WoNum);
        }
        public bool requestQcCheck(int workOrderNo)
        {
            return DataLayer.requestQcCheck(workOrderNo);
        }
        public bool signoutoperator(int workOrderNo)
        {
            return DataLayer.signoutoperator(workOrderNo);
        }
        public Boolean addNewWorkOrder(string workOrderNo, string description, string date, string Pdate, string quantity, string sign, string signedDate, string employeeNo, string process, string flagforQc)
        {
            try
            {
                IWorkOrder workorder = WorkOrderFactory.GetWorkOrdersFull(workOrderNo, description, date, Pdate, quantity, sign, signedDate, employeeNo, process, flagforQc);
                workOrderList.Add(workorder);
                DataLayer.addNewWOToDB(workOrderNo, description, date, Pdate, quantity, sign, signedDate, employeeNo, process, flagforQc);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }
        public void DeleteComponent(IComponents component)
        {
            dataLayer.DeleteComponent(component); // setup Models orderList
        }
        public void UpdateComponent(IComponents component)
        {
            dataLayer.UpdateComponent(component); // setup Models orderList
        }
        public void UpdateStock(IStock stock, string Num)
        {
            dataLayer.UpdateStock(stock, Num); // setup Models orderList
        }
        public void UpdateWorkOrderComponents(IComponents component, string woNum)
        {
            dataLayer.UpdateWorkOrderComponents(component, woNum);
        }
        public void AddRequest(IRequestStock rs)
        {
            DataLayer.AddRequest(rs);
        }

        public void updateStage(int workOrderNo, string stage)
        {
            DataLayer.updateStageInDB(workOrderNo, stage);
        }

        public void UpdateQCStatus(int workordernum, string process)
        {
            DataLayer.UpdateQCStatus(workordernum, process);
        }

        public string getMD5(string password)
        {
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(password);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to hexadecimal string
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }


        public Boolean addNewStock1(string bathNo, string name, string quantity)
        {
            try
            {
                DataLayer.addNewStockToDB1(bathNo, name, quantity);

                componentList.Clear();
                populateComponents();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }

        public bool deleteRequest(string requestID)
        {
            return dataLayer.deleteRequest(requestID);
        }

        public bool updateComponents(string compID, string qty)
        {
            return dataLayer.updateComponents(compID, qty);
        }

     

     

    }
}