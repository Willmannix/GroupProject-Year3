using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using BuisnessEntities;

namespace DataAccessLayer
{
    public class DataLayer : IDataLayer
    {
        #region Instance Attributes
        private SqlConnection con;
        DataSet ds;
        SqlDataAdapter da;
        int maxRows;
        SqlCommandBuilder cb;
        #endregion

        #region Static Attributes
        public static IDataLayer dataLayerSingletonInstance;
        static readonly object padlock = new object();
        #endregion

        #region Constructors
        public static IDataLayer GetInstance()
        {
            lock (padlock)
            {
                if (dataLayerSingletonInstance == null)
                {
                    dataLayerSingletonInstance = new DataLayer();
                }
                return dataLayerSingletonInstance;
            }
        }
        public DataLayer()
        {
            openConnection();
        }
        #endregion
        public virtual void closeConnection()
        {
            con.Close();
        }

        public ArrayList GetAllUsers()
        {
            ArrayList userList = new ArrayList();
            try
            {
                ds = new DataSet();
                string sql = "SELECT * From Employees";
                da = new SqlDataAdapter(sql, con);
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "UsersData");
                maxRows = ds.Tables["UsersData"].Rows.Count;
                for (int i = 0; i < maxRows; i++)
                {
                    DataRow dRow = ds.Tables["UsersData"].Rows[i];
                    string workOrderNo = dRow.ItemArray.GetValue(6).ToString();
                    IUser user = UserFactory.GetUser(dRow.ItemArray.GetValue(0).ToString(),
                                                         dRow.ItemArray.GetValue(1).ToString(),
                                                         dRow.ItemArray.GetValue(2).ToString(),
                                                         dRow.ItemArray.GetValue(3).ToString(),
                                                         dRow.ItemArray.GetValue(4).ToString(),
                                                         dRow.ItemArray.GetValue(5).ToString(),
                                                         Convert.ToInt32(workOrderNo));
                    userList.Add(user);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (con.State.ToString() == "Open")
                {
                    con.Close();
                }
                Application.Exit();
            }
            return userList;
        }


        public ArrayList GetAllRequests()
        {
            ArrayList requestList = new ArrayList();
            try
            {
                ds = new DataSet();
                string sql = "SELECT * From RequestStock";
                da = new SqlDataAdapter(sql, con);
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "UsersData");
                maxRows = ds.Tables["UsersData"].Rows.Count;
                for (int i = 0; i < maxRows; i++)
                {
                    DataRow dRow = ds.Tables["UsersData"].Rows[i];

                    IRequestStock requestStock = RequestStockFactory.GetRequestStock(dRow.ItemArray.GetValue(0).ToString(),
                                                         dRow.ItemArray.GetValue(1).ToString(),
                                                         dRow.ItemArray.GetValue(2).ToString(),
                                                         dRow.ItemArray.GetValue(3).ToString(),
                                                         dRow.ItemArray.GetValue(4).ToString(),
                                                         dRow.ItemArray.GetValue(5).ToString()
                                                         );
                    requestList.Add(requestStock);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (con.State.ToString() == "Open")
                {
                    con.Close();
                }
                Application.Exit();
            }
            return requestList;
        }





        public List<IComponents> GetAllComponents()
        {
            List<IComponents> componentList = new List<IComponents>();
            try
            {
                ds = new DataSet();
                string sql = "SELECT * From Components";
                da = new SqlDataAdapter(sql, con);
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "ComponentData");
                maxRows = ds.Tables["ComponentData"].Rows.Count;
                for (int i = 0; i < maxRows; i++)
                {
                    DataRow dRow = ds.Tables["ComponentData"].Rows[i];
                    IComponents components = ComponentFactory.GetComponent(dRow.ItemArray.GetValue(0).ToString(),
                                                        dRow.ItemArray.GetValue(1).ToString(),
                                                        dRow.ItemArray.GetValue(2).ToString(),
                                                        dRow.ItemArray.GetValue(3).ToString());
                    componentList.Add(components);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (con.State.ToString() == "Open")
                {
                    con.Close();
                }
                Application.Exit();
            }
            return componentList;
        }


        public List<IWorkOrder> GetAllWorkOrders()
        {
            List<IWorkOrder> workorderlist = new List<IWorkOrder>();
            try
            {
                ds = new DataSet();
                string sql = "SELECT * From WorkOrders";
                da = new SqlDataAdapter(sql, con);
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "WorkOrderData");
                maxRows = ds.Tables["WorkOrderData"].Rows.Count;
                for (int i = 0; i < maxRows; i++)
                {
                    DataRow dRow = ds.Tables["WorkOrderData"].Rows[i];
                    IWorkOrder workOrder = WorkOrderFactory.GetWorkOrders(dRow.ItemArray.GetValue(0).ToString(),
                                                        dRow.ItemArray.GetValue(1).ToString(),
                                                        dRow.ItemArray.GetValue(2).ToString(),
                                                        dRow.ItemArray.GetValue(3).ToString(),
                                                        dRow.ItemArray.GetValue(4).ToString());
                    workorderlist.Add(workOrder);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (con.State.ToString() == "Open")
                {
                    con.Close();
                }
                Application.Exit();
            }
            return workorderlist;
        }
        public List<IWorkOrder> GetAllWorkOrdersFull()
        {
            List<IWorkOrder> workorderlist = new List<IWorkOrder>();
            try
            {
                ds = new DataSet();
                string sql = "SELECT * From WorkOrders";
                da = new SqlDataAdapter(sql, con);
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "WorkOrderData");
                maxRows = ds.Tables["WorkOrderData"].Rows.Count;
                for (int i = 0; i < maxRows; i++)
                {
                    DataRow dRow = ds.Tables["WorkOrderData"].Rows[i];
                    IWorkOrder workOrder = WorkOrderFactory.GetWorkOrdersFull(dRow.ItemArray.GetValue(0).ToString(),
                                                        dRow.ItemArray.GetValue(1).ToString(),
                                                        dRow.ItemArray.GetValue(2).ToString(),
                                                        dRow.ItemArray.GetValue(3).ToString(),
                                                        dRow.ItemArray.GetValue(4).ToString(),
                                                        dRow.ItemArray.GetValue(5).ToString(),
                                                        dRow.ItemArray.GetValue(6).ToString(),
                                                        dRow.ItemArray.GetValue(7).ToString(),
                                                        dRow.ItemArray.GetValue(8).ToString(),
                                                        dRow.ItemArray.GetValue(9).ToString());
                    workorderlist.Add(workOrder);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (con.State.ToString() == "Open")
                {
                    con.Close();
                }
                Application.Exit();
            }
            return workorderlist;
        }
        public void AddRequest(IRequestStock rs)
        {
            try
            {
                DataSet ds = new DataSet();
                string sql = "Select * From RequestStock";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);
                da.Fill(ds, "RequestStockData");
                maxRows = ds.Tables["RequestStockData"].Rows.Count;
                DataRow dRow = ds.Tables["RequestStockData"].NewRow();
                dRow[0] = rs.RequestNo;
                dRow[1] = rs.CompnentNo;
                dRow[2] = rs.BatchNo;
                dRow[3] = rs.Name;
                dRow[4] = rs.Quantity;
                dRow[5] = rs.EmployeeNo;




                ds.Tables["RequestStockData"].Rows.Add(dRow);
                da.Update(ds, "RequestStockData");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (con.State.ToString() == "Open")
                {
                    con.Close();
                };
            }
        }
        public void addNewWOToDB(string workOrderNo, string description, string date, string pdate, string quantity, string sign, string signedDate, string employeeNo, string process, string FlaggedforQC)
        {
            try
            {
                DataSet ds = new DataSet();
                string sql = "Select * From WorkOrders";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);
                da.Fill(ds, "workOrderData");
                maxRows = ds.Tables["workOrderData"].Rows.Count;
                DataRow dRow = ds.Tables["workOrderData"].NewRow();
                dRow[0] = workOrderNo;
                dRow[1] = date;
                dRow[2] = pdate;
                dRow[3] = quantity;
                dRow[4] = description;
                dRow[5] = sign;
                dRow[6] = signedDate;
                dRow[7] = employeeNo;
                dRow[8] = process;
                dRow[9] = FlaggedforQC;



                ds.Tables["workOrderData"].Rows.Add(dRow);
                da.Update(ds, "workOrderData");
            }
            catch (Exception ex)
            {
                if (con.State.ToString() == "Open")
                    con.Close();
                Application.Exit();
            }

        }
        public List<IComponents> GetAllWOComponents()
        {
            List<IComponents> componentList = new List<IComponents>();
            try
            {
                ds = new DataSet();
                string sql = "SELECT * From WorkOrderComponent";
                da = new SqlDataAdapter(sql, con);
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "ComponentData");
                maxRows = ds.Tables["ComponentData"].Rows.Count;
                for (int i = 0; i < maxRows; i++)
                {
                    DataRow dRow = ds.Tables["ComponentData"].Rows[i];
                    IComponents components = ComponentFactory.GetComponent(dRow.ItemArray.GetValue(0).ToString(),
                                                        dRow.ItemArray.GetValue(1).ToString(),
                                                        dRow.ItemArray.GetValue(2).ToString(),
                                                        dRow.ItemArray.GetValue(3).ToString(),
                                                        dRow.ItemArray.GetValue(4).ToString(),
                                                        dRow.ItemArray.GetValue(5).ToString(),
                                                        dRow.ItemArray.GetValue(6).ToString());
                    componentList.Add(components);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (con.State.ToString() == "Open")
                {
                    con.Close();
                }
                Application.Exit();
            }
            return componentList;

        }
        public List<IEmployees> GetAllEmployees()
        {
            List<IEmployees> employeeList = new List<IEmployees>();
            try
            {
                ds = new DataSet();
                string sql = "SELECT * From Employees";
                da = new SqlDataAdapter(sql, con);
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "EmployeeData");
                maxRows = ds.Tables["EmployeeData"].Rows.Count;
                for (int i = 0; i < maxRows; i++)
                {
                    DataRow dRow = ds.Tables["EmployeeData"].Rows[i];
                    IEmployees employees = EmployeeFactory.GetEmployee(dRow.ItemArray.GetValue(0).ToString(),
                                                        dRow.ItemArray.GetValue(1).ToString(),
                                                        dRow.ItemArray.GetValue(3).ToString(),
                                                        dRow.ItemArray.GetValue(4).ToString());

                employeeList.Add(employees);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (con.State.ToString() == "Open")
                {
                    con.Close();
                }
                Application.Exit();
            }
            return employeeList;
        }

        public void addNewUserToDB(string userID, string userType, string working, string fullName, string contactNumber, string password, int workOrderNo)
        {
            try
            {
                DataSet ds = new DataSet();
                string sql = "Select * From Employees";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);
                da.Fill(ds, "UsersData");
                maxRows = ds.Tables["UsersData"].Rows.Count;
                DataRow dRow = ds.Tables["UsersData"].NewRow();
                dRow[0] = userID;
                dRow[1] = userType;
                dRow[2] = working;
                dRow[3] = fullName;
                dRow[4] = contactNumber;
                dRow[5] = password;
                dRow[6] = workOrderNo;

                ds.Tables["UsersData"].Rows.Add(dRow);
                da.Update(ds, "UsersData");
            }
            catch (Exception ex)
            {
                if (con.State.ToString() == "Open")
                    con.Close();
                Application.Exit();
            }

        }

        public bool deleteUserFromDB(BuisnessEntities.IUser user)
        {
            try
            {
                ds = new DataSet();
                string sql = "SELECT * From Employees";
                da = new SqlDataAdapter(sql, con);
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                cb = new SqlCommandBuilder(da);
                da.Fill(ds, "UsersData");
                DataRow findRow = ds.Tables["UsersData"].Rows.Find(user.UserID);
                if (findRow != null)
                {
                    findRow.Delete();
                }
                da.Update(ds, "UsersData");
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (getConnection().ToString() == "Open")
                    closeConnection();
                Application.Exit();
            }
            return true;
        }
        public bool editUserInDB(IUser user)
        {
            try
            {
                ds = new DataSet();
                string sql = "SELECT * From Employees";
                da = new SqlDataAdapter(sql, con);
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "UsersData");
                DataRow findRow = ds.Tables["UsersData"].Rows.Find(user.UserID);
                if (findRow != null)
                {
                    findRow[1] = user.UserType;
                    findRow[2] = user.Working;
                    findRow[3] = user.FullName;
                    findRow[4] = user.ContactNumber;
                    findRow[5] = user.Password;

                }
                da.Update(ds, "UsersData"); //remove row from database table
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (getConnection().ToString() == "Open")
                    closeConnection();
                Application.Exit();
            }
            return true;
        }




        public bool editBrokeInDB(string compNo, int workOrderNo, int qty)
        {
            try
            {
                ds = new DataSet();
                string sql = "SELECT * From WorkOrderComponent";
                da = new SqlDataAdapter(sql, con);
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "brokeData");
                DataRow findRow = ds.Tables["brokedata"].Rows.Find(workOrderNo);
                if (findRow != null)
                {
                    if (findRow[2].ToString() == compNo)
                    {
                        int currQty = Convert.ToInt32(findRow[3]) - qty;
                        findRow[3] = currQty;
                        findRow[6] = qty;
                    }
                    da.Update(ds, "brokeData"); //remove row from database table
                }
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (getConnection().ToString() == "Open")
                    closeConnection();
                Application.Exit();
            }
            return true;
        }













        public bool signIn(string userID)
        {
            try
            {
                ds = new DataSet();
                string sql = "SELECT * From Employees";
                da = new SqlDataAdapter(sql, con);
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "UsersData");
                DataRow findRow = ds.Tables["UsersData"].Rows.Find(userID);
                if (findRow != null)
                {
                    findRow[2] = "1";
                }
                da.Update(ds, "UsersData"); //remove row from database table
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (getConnection().ToString() == "Open")
                    closeConnection();
                Application.Exit();
            }
            return true;
        }

        public bool signOut(string userID)
        {
            try
            {
                ds = new DataSet();
                string sql = "SELECT * From Employees";
                da = new SqlDataAdapter(sql, con);
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "UsersData");
                DataRow findRow = ds.Tables["UsersData"].Rows.Find(userID);
                if (findRow != null)
                {
                    findRow[2] = "0";
                }
                da.Update(ds, "UsersData"); //remove row from database table
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (getConnection().ToString() == "Open")
                    closeConnection();
                Application.Exit();
            }
            return true;
        }
        public bool assignToWorkOrder(IUser user)
        {
            try
            {
                ds = new DataSet();
                string sql = "SELECT * From Employees";
                da = new SqlDataAdapter(sql, con);
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "UsersData");
                DataRow findRow = ds.Tables["UsersData"].Rows.Find(user.UserID);
                if (findRow != null)
                {
                    findRow[6] = user.WorkOrderNo;
                }
                da.Update(ds, "UsersData"); //remove row from database table
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (getConnection().ToString() == "Open")
                    closeConnection();
                Application.Exit();
            }
            return true;
        }

        public virtual SqlConnection getConnection()
        {
            return con;
        }

        public virtual void openConnection()
        {
            con = new SqlConnection();
            con.ConnectionString = "Server=tcp:team3dbv3.database.windows.net,1433;Initial Catalog=team3db;Persist Security Info=False;User ID=team3admin1974;Password=zH799MI9;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=true;Connection Timeout=30;";
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public bool requestQcCheck(int workOrderNo)
        {
            try
            {
                ds = new DataSet();
                string sql = "SELECT * From WorkOrders";
                da = new SqlDataAdapter(sql, con);
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "WorkOrderData");
                DataRow findRow = ds.Tables["WorkOrderData"].Rows.Find(workOrderNo);
                if (findRow != null)
                {
                    findRow[9] = "1";
                }
                da.Update(ds, "WorkOrderData"); //remove row from database table
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (getConnection().ToString() == "Open")
                    closeConnection();
                Application.Exit();
            }
            return true;
        }
        public bool signoutoperator(int workOrderNo)
        {
            try
            {
                ds = new DataSet();
                string sql = "SELECT * From WorkOrders";
                da = new SqlDataAdapter(sql, con);
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "WorkOrderData");
                DataRow findRow = ds.Tables["WorkOrderData"].Rows.Find(workOrderNo);
                if (findRow != null)
                {
                    findRow[7] += "-";
                }
                da.Update(ds, "WorkOrderData"); //remove row from database table
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (getConnection().ToString() == "Open")
                    closeConnection();
                Application.Exit();
            }
            return true;
        }
        bool IDataLayer.UpdateComponent(IComponents component)
        {
            try
            {
                ds = new DataSet();
                string sql = "SELECT * From Components";
                da = new SqlDataAdapter(sql, con);
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "ComponentData");
                DataRow findRow = ds.Tables["ComponentData"].Rows.Find(component.ComponentNum);
                if (findRow != null)
                {
                    findRow[0] = component.ComponentNum;
                    findRow[2] = component.ComponentName;
                    findRow[3] = component.Quantity;
                }
                da.Update(ds, "ComponentData"); //remove row from database table
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (getConnection().ToString() == "Open")
                    closeConnection();

            }
            return true;


        }

        bool IDataLayer.DeleteComponent(IComponents component)
        {
            try
            {
                ds = new DataSet();
                string sql = "SELECT * From Components";
                da = new SqlDataAdapter(sql, con);
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "ComponentData");
                DataRow findRow = ds.Tables["ComponentData"].Rows.Find(component.ComponentNum);
                if (findRow != null)
                {
                    findRow.Delete(); //mark row as deleted
                }
                da.Update(ds, "ComponentData"); //remove row from database table
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (getConnection().ToString() == "Open")
                    closeConnection();

            }
            return true;


        }


        void IDataLayer.UpdateWorkOrderComponents(IComponents component, string woNum)
        {
            try
            {
                DataSet ds = new DataSet();
                string sql = "Select * From WorkOrderComponent";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);
                da.Fill(ds, "workOrderComponents");
                maxRows = ds.Tables["workOrderComponents"].Rows.Count;
                DataRow dRow = ds.Tables["workOrderComponents"].NewRow();
                dRow[0] = component.ComponentNum;
                dRow[1] = component.BatchNum;
                dRow[2] = component.ComponentName;
                dRow[3] = component.Quantity;
                dRow[4] = woNum;
                dRow[5] = 0;


                ds.Tables["workOrderComponents"].Rows.Add(dRow);
                da.Update(ds, "workOrderComponents");
            }
            catch (Exception ex)
            {
                if (con.State.ToString() == "Open")
                    con.Close();
                Application.Exit();
            }
        }

        /////////////////////////////////////
        public bool MarkBrokenInDB(IComponents component)
        {
            try
            {
                ds = new DataSet();

                string sql = "SELECT * From WorkOrderComponent";
                da = new SqlDataAdapter(sql, con);
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "brokedata");
                DataRow findRow = ds.Tables["brokedata"].Rows.Find(component.ComponentNum);
                if (findRow != null)
                {
                    findRow[1] = component.BatchNum;
                    findRow[2] = component.ComponentName;
                    findRow[3] = component.Quantity;
                    findRow[4] = component.WorkOrderNo;
                    findRow[5] = component.QuantityUsed;
                    findRow[6] = component.Broken;

                }
                da.Update(ds, "brokedata"); //remove row from database table

            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (getConnection().ToString() == "Open")
                    closeConnection();
                Application.Exit();
            }
            return true;
        }

        /////////////////brokem
        public List<IComponents> GetBrokenWOComponent()
        {
            List<IComponents> componentList = new List<IComponents>();
            try
            {
                ds = new DataSet();
                string sql = "SELECT * From WorkOrderComponent";
                da = new SqlDataAdapter(sql, con);
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "ComponentData");
                maxRows = ds.Tables["ComponentData"].Rows.Count;
                for (int i = 0; i < maxRows; i++)
                {
                    DataRow dRow = ds.Tables["ComponentData"].Rows[i];
                    IComponents components = ComponentFactory.GetComponent(dRow.ItemArray.GetValue(0).ToString(),
                                                        dRow.ItemArray.GetValue(1).ToString(),
                                                        dRow.ItemArray.GetValue(2).ToString(),
                                                        dRow.ItemArray.GetValue(3).ToString(),
                                                        dRow.ItemArray.GetValue(4).ToString(),
                                                        dRow.ItemArray.GetValue(5).ToString(),
                                                        dRow.ItemArray.GetValue(6).ToString());

                    componentList.Add(components);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (con.State.ToString() == "Open")
                {
                    con.Close();
                }
                Application.Exit();
            }
            return componentList;
        }
        //////////////////////
        public void addNewStockToDB(string componentNo, string batchNo, string name, string quantity)
        {
            try
            {
                DataSet ds = new DataSet();
                string sql = "Select * From Components";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);
                da.Fill(ds, "StockData");
                maxRows = ds.Tables["StockData"].Rows.Count;
                DataRow dRow = ds.Tables["StockData"].NewRow();
                dRow[0] = componentNo;
                dRow[1] = batchNo;
                dRow[2] = name;
                dRow[3] = quantity;

                ds.Tables["StockData"].Rows.Add(dRow);
                da.Update(ds, "StockData");
            }
            catch (Exception ex)
            {
                if (con.State.ToString() == "Open")
                    con.Close();
                Application.Exit();
            }

        }


        public void addNewStockToDB1(string batchNo, string name, string quantity)
        {
            try
            {
                DataSet ds = new DataSet();
                string sql = "Select * From Components";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);
                da.Fill(ds, "StockData");
                maxRows = ds.Tables["StockData"].Rows.Count;
                DataRow dRow = ds.Tables["StockData"].NewRow();

                dRow[1] = batchNo;
                dRow[2] = name;
                dRow[3] = quantity;

                ds.Tables["StockData"].Rows.Add(dRow);
                da.Update(ds, "StockData");
            }
            catch (Exception ex)
            {
                if (con.State.ToString() == "Open")
                    con.Close();
                Application.Exit();
            }

        }

        public bool UpdatePrintDateWO(string woNum)
        {
            try
            {
                ds = new DataSet();
                string sql = "SELECT * From WorkOrders";
                da = new SqlDataAdapter(sql, con);
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "WorkOrders");
                DataRow findRow = ds.Tables["WorkOrders"].Rows.Find(woNum);
                if (findRow != null)
                {
                    findRow[2] = DateTime.Now.ToString("d/M/yyyy");

                }
                da.Update(ds, "WorkOrders"); //remove row from database table
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (getConnection().ToString() == "Open")
                    closeConnection();
                Application.Exit();
            }
            return true;
        }

        ////////////////////////////////////////
       public void UpdateStock(IStock stock, string Num)
        {
            try
            {
                ds = new DataSet();
                string sql = "SELECT * From Components";
                da = new SqlDataAdapter(sql, con);
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "stockData");
                DataRow findRow = ds.Tables["stockData"].Rows.Find(stock.ComponentNo);
                if (findRow != null)
                {
                    findRow[0] = stock.ComponentNo;
                    findRow[1] = stock.BatchNo;
                    findRow[2] = stock.Name;
                    findRow[3] = stock.Quantity;
                }
                da.Update(ds, "stockData"); //remove row from database table
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (getConnection().ToString() == "Open")
                    closeConnection();

            }


        }

        public List<IStock> GetAllStock()
        {
            List<IStock> componentList = new List<IStock>();
            try
            {
                ds = new DataSet();
                string sql = "SELECT * From Components";
                da = new SqlDataAdapter(sql, con);
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "StockData");
                maxRows = ds.Tables["StockData"].Rows.Count;
                for (int i = 0; i < maxRows; i++)
                {
                    DataRow dRow = ds.Tables["StockData"].Rows[i];
                    IStock components = StockFactory.GetStock(dRow.ItemArray.GetValue(0).ToString(),
                                                        dRow.ItemArray.GetValue(1).ToString(),
                                                        dRow.ItemArray.GetValue(2).ToString(),
                                                        dRow.ItemArray.GetValue(3).ToString());
                    componentList.Add(components);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (con.State.ToString() == "Open")
                {
                    con.Close();
                }
                Application.Exit();
            }
            return componentList;
        }

        public void UpdateQCStatus(int workordernum, string process)
        {
            try
            {
                ds = new DataSet();
                string sql = "SELECT * From WorkOrders";
                da = new SqlDataAdapter(sql, con);
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "WorkOrderData");
                DataRow findRow = ds.Tables["WorkOrderData"].Rows.Find(workordernum);
                if (findRow != null)
                {
                    findRow[9] = 0;
                    findRow[8] = process;
                }
                da.Update(ds, "WorkOrderData"); //remove row from database table
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (getConnection().ToString() == "Open")
                    closeConnection();
                Application.Exit();
            }
        }


        public void updateStageInDB(int workOrderNo, string stage)
        {
            try
            {
                ds = new DataSet();
                string sql = "SELECT * From WorkOrders";
                da = new SqlDataAdapter(sql, con);
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "WorkOrderData");
                DataRow findRow = ds.Tables["WorkOrderData"].Rows.Find(workOrderNo);
                if (findRow != null)
                {
                    findRow[8] = stage;
                }
                da.Update(ds, "WorkOrderData"); //remove row from database table
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (getConnection().ToString() == "Open")
                    closeConnection();
                Application.Exit();
            }
        }

        public bool deleteRequest(string requestNo)
        {
            try
            {
                ds = new DataSet();
                string sql = "SELECT * From RequestStock";
                da = new SqlDataAdapter(sql, con);
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                cb = new SqlCommandBuilder(da);
                da.Fill(ds, "requestData");
                DataRow findRow = ds.Tables["requestData"].Rows.Find(requestNo);
                if (findRow != null)
                {
                    findRow.Delete();
                }
                da.Update(ds, "requestData");
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (getConnection().ToString() == "Open")
                    closeConnection();
                Application.Exit();
            }
            return true;
        }

        public bool updateComponents(string compID, string qty)
        {
            try
            {
                ds = new DataSet();
                string sql = "SELECT * From Components";
                da = new SqlDataAdapter(sql, con);
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "ComponentData");
                DataRow findRow = ds.Tables["ComponentData"].Rows.Find(compID);
                if (findRow != null)
                {
                    findRow[3] = Convert.ToInt32(findRow[3]) - Convert.ToInt32(qty);
                }
                da.Update(ds, "ComponentData"); //remove row from database table
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (getConnection().ToString() == "Open")
                    closeConnection();

            }
            return true;
        }

    }



}
    ///////////////////




