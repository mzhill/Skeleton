using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStockCollection
    {
        //private data member for the list
        List<clsStock> mStockList = new List<clsStock>();
        //private data member thisStock
        clsStock mThisStock = new clsStock();

        //constructor for the class
        public clsStockCollection()
        {
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for the data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblStock_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank stock
                clsStock AStock = new clsStock();
                //read in the fields from the current record
                AStock.ShoeID = Convert.ToInt32(DB.DataTable.Rows[Index]["ShoeID"]);
                AStock.ShoeDescription = Convert.ToString(DB.DataTable.Rows[Index]["ShoeDescription"]);
                AStock.ShoeColour = Convert.ToString(DB.DataTable.Rows[Index]["ShoeColour"]);
                AStock.Quantity = Convert.ToInt32(DB.DataTable.Rows[Index]["Quantity"]);
                AStock.InitialReleaseDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["Initial Release Date"]);
                AStock.Availability = Convert.ToBoolean(DB.DataTable.Rows[Index]["Availability"]);
                //add the record to the private data member
                mStockList.Add(AStock);
                //point at the next record
                Index++;
            }
        }

        //public property for the address list
        public List<clsStock> StockList
        {
            get
            {
                //return the private data
                return mStockList;
            }
            set
            {
                //set the private data
                mStockList = value;
            }
        }

        public int Count
        {
            get
            {
                //return the count of the list
                return mStockList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }

        public clsStock ThisStock
        {
            get
            {
                //return the private
                return mThisStock;
            }
            set
            {
                //set the private data
                mThisStock = value;
            }
        }

        public int Add()
        {
            //adds a new record to the database based on the values of this mThisStock
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("ShoeDescription", mThisStock.ShoeDescription);
            DB.AddParameter("ShoeColour", mThisStock.ShoeColour);
            DB.AddParameter("Quantity", mThisStock.Quantity);
            DB.AddParameter("Initial Release Date", mThisStock.InitialReleaseDate);
            DB.AddParameter("Availability", mThisStock.Availability);
            //execute the query returning the primary key value
            return mThisStock.ShoeID;
        }

        public void Update()
        {
            //update an existing record based on the values of thisStock
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@ShoeID", mThisStock.ShoeID);
            DB.AddParameter("@ShoeDescription", mThisStock.ShoeDescription);
            DB.AddParameter("@ShoeColour", mThisStock.ShoeColour);
            DB.AddParameter("@Quantity", mThisStock.Quantity);
            DB.AddParameter("@Initial Release Date", mThisStock.InitialReleaseDate);
            DB.AddParameter("@Availability", mThisStock.Availability);
            //execute the stored procedure
            DB.Execute("sproc_tblStock_Update");
        }
    }
}