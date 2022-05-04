using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsShoeValueCollection
    {
        //private data member for the list
        List<clsShoeValue> mShoeValueList = new List<clsShoeValue>();
        //private data member thisStock
        clsShoeValue mThisShoeValue = new clsShoeValue();

        public clsShoeValueCollection()
        {
            //object for data collection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblShoeValue_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        public List<clsShoeValue> ShoeValueList
        {
            get
            {
                //return the private data
                return mShoeValueList;
            }
            set
            {
                //set the private data
                mShoeValueList = value;
            }
        }
        public int Count
        {
            get
            {
                //return the count of the list
                return mShoeValueList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }

        public clsShoeValue ThisShoeValue
        {
            get
            {
                //return the private
                return mThisShoeValue;
            }
            set
            {
                //set the private data
                mThisShoeValue = value;
            }
        }

        public int Add()
        {
            //adds a new record to the database based on the values of this mThisStock
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("RetailPrice", mThisShoeValue.RetailPrice);
            DB.AddParameter("ResalePrice", mThisShoeValue.ResalePrice);
            DB.AddParameter("Catergory ", mThisShoeValue.Catergory);
            DB.AddParameter("ReleaseDate", mThisShoeValue.ReleaseDate);
            DB.AddParameter("Stock", mThisShoeValue.Stock);
            //execute the query returning the primary key value
            return mThisShoeValue.ShoeID;
        }

        public void Update()
        {
            //update an existing record based on the values of thisShoeValue
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@ShoeID", mThisShoeValue.ShoeID);
            DB.AddParameter("@RetailPrice", mThisShoeValue.RetailPrice);
            DB.AddParameter("@ResalePrice", mThisShoeValue.ResalePrice);
            DB.AddParameter("@Catergory ", mThisShoeValue.Catergory);
            DB.AddParameter("@ReleaseDate", mThisShoeValue.ReleaseDate);
            DB.AddParameter("@Stock", mThisShoeValue.Stock);
            //execute the stored procedure
            DB.Execute("sproc_tblShoeValue_Update");
        }

        public void Delete()
        {
            //deletes the record pointed to by thisShoeValue
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@ShoeID", mThisShoeValue.ShoeID);
            //execute the stored procedure
            DB.Execute("sproc_tblShoeValue_Delete");
        }

        public void ReportByCatergory(string Catergory)
        {
            //filters the records based on a full or partial category
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the Catergory parameter to the database
            DB.AddParameter("@Catergory", Catergory);
            //execute the stored procedure
            DB.Execute("sproc_tblShoeValue_FilterByCatergory");
            //populate the array list with the data lable
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mShoeValueList = new List<clsShoeValue>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank record
                clsShoeValue AnShoeValue = new clsShoeValue();
                //read in the fields from the current record
                AnShoeValue.ShoeID = Convert.ToInt32(DB.DataTable.Rows[Index]["ShoeID"]);
                AnShoeValue.RetailPrice = Convert.ToString(DB.DataTable.Rows[Index]["RetailPrice"]);
                AnShoeValue.ResalePrice = Convert.ToString(DB.DataTable.Rows[Index]["ResalePrice"]);
                AnShoeValue.Catergory = Convert.ToString(DB.DataTable.Rows[Index]["Catergory "]);
                AnShoeValue.ReleaseDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["ReleaseDate"]);
                AnShoeValue.Stock = Convert.ToBoolean(DB.DataTable.Rows[Index]["Stock"]);
                //add the record to the private data member
                mShoeValueList.Add(AnShoeValue);
                //point at the next record
                Index++;
            }
        }
    }
}