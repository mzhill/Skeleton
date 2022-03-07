using System;

namespace ClassLibrary
{
    public class clsStock
    {

        //private member variables
        private Int32 mShoeID;
        private DateTime mInitialReleaseDate;
        private Boolean mAvailability;
        private string mShoeDesc;
        private string mShoeColour;
        private Int32 mQuantity;

        //availability public property
        public bool Availability
        {
            get
            {
                return mAvailability;
            }
            set
            {
                mAvailability = value;
            }
        }

        //initial release date public property
        public DateTime InitialReleaseDate
        {
            get
            {
                return mInitialReleaseDate;
            }
            set
            {
                mInitialReleaseDate = value;
            }
        }

        //shoe id public property
        public Int32 ShoeID
        {
            get
            {
                //this line of code sends data out of the property
                return mShoeID;
            }
            set
            {
                //this line of code allows data into the property
                mShoeID = value;
            }
        }

        //shoe desciption public property
        public string ShoeDescription
        {
            get
            {
                return mShoeDesc;
            }
            set
            {
                mShoeDesc = value;
            }
        }

        //shoe colour public property
        public string ShoeColour
        {
            get
            {
                return mShoeColour;
            }
            set
            {
                mShoeColour = value;
            }
        }

        //quantity public property
        public int Quantity
        {
            get
            {
                return mQuantity;
            }
            set
            {
                mQuantity = value;
            }
        }

        public bool Find(int ShoeID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the shoe id to search for
            DB.AddParameter("@ShoeID", ShoeID);
            //execute the stored procedure
            DB.Execute("sproc_tblStock_FilterByShoeID");
            //if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mShoeID = Convert.ToInt32(DB.DataTable.Rows[0]["ShoeID"]);
                mShoeDesc = Convert.ToString(DB.DataTable.Rows[0]["ShoeDescription"]);
                mShoeColour = Convert.ToString(DB.DataTable.Rows[0]["ShoeColour"]);
                mQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["Quantity"]);
                mInitialReleaseDate = Convert.ToDateTime(DB.DataTable.Rows[0]["InitialReleaseDate"]);
                mAvailability = Convert.ToBoolean(DB.DataTable.Rows[0]["Availability"]);

                //return that everything worked OK
                return true;
            }
            //if no record is found
            else
            {
                //return false indicating a problem
                return false;
            }
        }
    }
}