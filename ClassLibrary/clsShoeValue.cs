﻿using System;

namespace ClassLibrary
{
    public class clsShoeValue
    {
        //private data member for the address no property
        private Int32 mShoeID;
        private String mRetailPrice;
        private String mResalePrice;
        private String mCatergory;
        private DateTime mReleaseDate;
        private Boolean mStock;

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
        public String RetailPrice
        {
            get
            {
                //this line of code sends data out of the property
                return mRetailPrice;
            }
            set
            {
                //this line of code allows data into the property
                mRetailPrice = value;

            }
        }

        public String ResalePrice
        {
            get
            {
                //this line of code sends data out of the property
                return mResalePrice;
            }
            set
            {
                //this line of code allows data into the property
                mResalePrice = value;

            }
        }

        public String Catergory
        {
            get
            {
                //this line of code sends data out of the poproperty
                return mCatergory;
            }
            set
            {
                //this line of code allows data into the property
                mCatergory = value;

            }
        }


        //private date added data member
        private DateTime mDateAdded;
        //publix propertfor date added
        public DateTime ReleaseDate
        {
            get
            {
                //return the private data 
                return mReleaseDate;
            }
            set
            {
                //
                mReleaseDate = value;

            }
        }

        public Boolean Stock
        {
            get
            {
                //this line of code sends data out of the property
                return mStock;
            }
            set
            {
                //this line of code allows data into the property
                mStock = value;

            }
        }

        public bool Find(int ShoeID)
        {


        //create an instance of the data connection
        clsDataConnection DB = new clsDataConnection();
            //add the parameter for the shoe id to search for
            DB.AddParameter("@ShoeID", ShoeID);
            //execute the stored procedure
            DB.Execute("sproc_tblShoeValue_FilterByShoeID");
            //if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members

                mReleaseDate = Convert.ToDateTime(DB.DataTable.Rows[0]["ReleaseDate"]);
                mRetailPrice = Convert.ToString(DB.DataTable.Rows[0]["RetailPrice"]);
                mResalePrice = Convert.ToString(DB.DataTable.Rows[0]["ResalePrice"]);
                mCatergory = Convert.ToString(DB.DataTable.Rows[0]["Catergory "]);
                mStock = Convert.ToBoolean(DB.DataTable.Rows[0]["Stock"]);
                mShoeID = Convert.ToInt32(DB.DataTable.Rows[0]["ShoeID"]);
                //return that everything worked OK
                return true;

            }
            //if no record was found 
            else
            { 
               //return false indicating a problem
                return false;
            }

        }

        //function for the public validation method
        public string Valid(string ReleaseDate,
                            string RetailPrice,
                            string ResalePrice,
                            string Catergory)
        //thisfunction accepts 5 parameters for validation
        //the fuction returns a string containing any error message
        //if ni errors found thena blank string is returned

        {
            //create a string variable to store the error
            String Error = "";
            //if the RetailPrice is blank
            if (RetailPrice.Length == 0)
            {
                //record the error 
                Error = Error + "The RetailPrice may not be blank";
            }
            //if the RetailPrice is greater than 6 characters
            if (RetailPrice.Length > 6)
            {
                //record the error
                Error = Error + "The Retail Price must be less than 6 characters : ";

            }

            //return any error messages
            return Error;
        
            
        }



    }
}