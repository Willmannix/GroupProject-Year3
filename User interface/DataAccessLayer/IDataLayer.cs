using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BuisnessEntities;

namespace DataAccessLayer
{
    public interface IDataLayer
    {
        bool deleteUserFromDB(BuisnessEntities.IUser user);
        bool editUserInDB(BuisnessEntities.IUser user);
        bool editBrokeInDB(string compNo, int workOrderNo, int qty);
        bool MarkBrokenInDB(BuisnessEntities.IComponents component);

        bool signIn(string userID);

        bool signOut(string userID);
        bool assignToWorkOrder(BuisnessEntities.IUser user);
        void closeConnection();
        System.Collections.ArrayList GetAllUsers();
        System.Collections.ArrayList GetAllRequests();
        List<IComponents> GetAllComponents();
		List<IComponents> GetAllWOComponents();
        List<IComponents> GetBrokenWOComponent();
        List<IWorkOrder> GetAllWorkOrdersFull();
        List<IWorkOrder> GetAllWorkOrders();
        List<IEmployees> GetAllEmployees();
        List<IStock> GetAllStock();
        System.Data.SqlClient.SqlConnection getConnection();
        void openConnection();
        void addNewUserToDB(string userID,string userType,string  working,string fullName,string contactNumber,string password,int workOrderNo);
        bool requestQcCheck(int workOrderNo);
		bool signoutoperator(int workOrderNo);
		void addNewWOToDB(string workOrderNo, string description, string date, string pdate, string quantity, string sign, string signedDate, string employeeNo, string process, string FlaggedforQC);
        void addNewStockToDB(string componentNo, string batchNo, string name, string quantity);
        void addNewStockToDB1(string batchNo, string name, string quantity);
        void AddRequest(IRequestStock rs);
        void UpdateStock(IStock stock, string Num);
        bool UpdatePrintDateWO(string woNum);
        bool UpdateComponent(IComponents component);
        bool DeleteComponent(IComponents component);
        void UpdateWorkOrderComponents(IComponents component, string woNum);
        void updateStageInDB(int workOrderNo, string stage);
        void UpdateQCStatus(int workordernum, string process);
        bool deleteRequest(string requestNo);
        bool updateComponents(string compID, string qty);

    }
}
