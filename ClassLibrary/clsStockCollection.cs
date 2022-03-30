using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStockCollection
    {
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

        //private data member for the list
        List<clsStock> mStockList = new List<clsStock>();

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

        public clsStock ThisStock { get; set; }

    }
}