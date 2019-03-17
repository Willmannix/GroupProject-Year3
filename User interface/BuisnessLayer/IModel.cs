using System;
using System.Collections.Generic;
using BuisnessEntities;
using System.Linq;
using System.Text;

namespace BuisnessLayer
{
    public interface IModel
    {
        bool addNewUser(string userType, string working, string fullName, string contactNumber, string password);
		bool addNewWorkOrder(string workOrderNo, string description, string date, string Pdate, string quantity, string sign, string signedDate, string employeeNo, string process, string flaggedForQC);
      
        bool addNewStock1(string batchNo, string name, string quantity);
        BuisnessEntities.User CurrentUser { get; set; }
        DataAccessLayer.IDataLayer DataLayer { get; set; }
        string getUserTypeForCurrentUser();
        bool deleteUser(BuisnessEntities.IUser user);
        bool editUser(BuisnessEntities.IUser user);
        bool editBroke(string compNo, int workOrderNo, int qty);
        bool MarkBroken(BuisnessEntities.IComponents component);
        bool assignWorkOrder(BuisnessEntities.IUser user);
        bool login(string name, string password);
        bool updatePrintWO(string WoNum);
        void tearDown();
        System.Collections.ArrayList UserList { get; }
        System.Collections.ArrayList RequestList { get; }
        void populateWorkOrderComponents();
        void populateWorkOrderComponents2();
        List<IComponents> ComponentList { get; set; }
        List<Ibroke> BrokeList { get; set; }
        List<IEmployees> EmployeeList { get; set; }
        void populateComponents();
        void DeleteComponent(IComponents component);
        void UpdateComponent(IComponents component);
        void UpdateStock(IStock stock, string Num);
        void UpdateWorkOrderComponents(IComponents component, string woNum);
        void AddRequest(IRequestStock rs);
        List<IWorkOrder> WorkOrderList { get; set; }
        List<IStock> StockList { get; set; }
        void populateWorkOrders();
        void populateWorkOrders2();
        void populateEmployees();
        bool requestQcCheck(int workOrderNo);
		bool signoutoperator(int workOrderNo);
        void updateStage(int workOrderNo, string stage);
        void populateRequestStock();
        string getMD5(string password);
        void UpdateQCStatus(int workordernum, string process);
        bool deleteRequest(string requestID);
        bool updateComponents(string compID, string qty);


        Boolean SignIn(string userID);

        Boolean SignOut(string userID);
    }
}
