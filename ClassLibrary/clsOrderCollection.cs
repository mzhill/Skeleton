using System.Collections.Generic;
using System;

namespace ClassLibrary
{
    public class clsOrderCollection
    {

        //constructor for the class
        public clsOrderCollection()
        {
            //object for data collection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
        }
        //private data member for the list
        List<clsOrder> mOrderList = new List<clsOrder>();
        //private data member thisStock
        clsOrder mThisOrder = new clsOrder();

        //public property for the order list
        public List<clsOrder> OrderList
        {
            get
            {
                //return the private data
                return mOrderList;
            }
            set
            {
                //set the private data
                mOrderList = value;
            }
        }

        //public property for count
        public int Count
        {
            get
            {
                //return the count of the list
                return mOrderList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }

        public clsOrder ThisOrder
        {
            get
            {
                //return the private
                return mThisOrder;
            }
            set
            {
                //set the private data
                mThisOrder = value;
            }
        }

        public int Add()
        {
            //adds a new record to the database based on the values of this mThisOrder
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("CustomerUsername", mThisOrder.CustomerUsername);
            DB.AddParameter("Quantity", mThisOrder.Quantity);
            DB.AddParameter("Order Date", mThisOrder.OrderDate);
            DB.AddParameter("Next Day Delivery", mThisOrder.NextDayDelivery);
            //execute the query returning the primary key value
            return mThisOrder.OrderID;
        }
        public void Update()
        {
            //update an existing record based on the values of thisOrder
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@OrderID", mThisOrder.OrderID);
            DB.AddParameter("@CustomerUsername", mThisOrder.CustomerUsername);
            DB.AddParameter("@Quantity", mThisOrder.Quantity);
            DB.AddParameter("@OrderDate", mThisOrder.OrderDate);
            DB.AddParameter("@NextDayDelivery", mThisOrder.NextDayDelivery);
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_Update");
        }

        public void Delete()
        {
            //deletes the record pointed to by thisStock
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@OrderID", mThisOrder.OrderID);
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_Delete");
        }

        public void ReportByCustomerUsername(string CustomerUsername)
        {
            //filters the records based on a full or partial shoe colour
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the CustomerUsername parameter to the database
            DB.AddParameter("@CustomerUsername", CustomerUsername);
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_FilterByCustomerUsername");
            //populate the array list with the data table
            PopulateArray(DB);
        }
        void PopulateArray(clsDataConnection DB)
        {


        }
    }
}