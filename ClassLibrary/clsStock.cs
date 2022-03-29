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
                mInitialReleaseDate = Convert.ToDateTime(DB.DataTable.Rows[0]["Initial Release Date"]);
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

        //function for the public validation method
        public string Valid(string ShoeDesc, string ShoeColour, string Quantity, string InitialReleaseDate)
        {
            //create a string variable to store the error
            String Error = "";
            //create a temporary variable to store date values
            DateTime DateTemp;

            //is the shoe desc blank
            if (ShoeDesc.Length == 0)
            {
                //record the error
                Error = Error + "The shoe description may not be blank: ";
            }

            //if the shoe desc is too long
            if (ShoeDesc.Length > 50)
            {
                //record the error
                Error = Error + "The shoe description must be less than 50 characters: ";
            }

            //is the shoe colour blank
            if (ShoeColour.Length == 0)
            {
                //record the error
                Error = Error + "The shoe colour may not be blank: ";
            }

            //if the shoe colour is too long
            if (ShoeColour.Length > 50)
            {
                //record the error
                Error = Error + "The shoe colour must be less than 50 characters: ";
            }

            //is the quantity blank
            if (Quantity.Length == 0)
            {
                //record the error
                Error = Error + "The quantity may not be blank: ";
            }

            //if the quantity is greater than 32 characters
            if (Quantity.Length > 32)
            {
                //record the error
                Error = Error + "The quantity may not be over 32 characters: ";
            }

            try
            {
                //copy the initial release date value to the DateTemp variable
                DateTemp = Convert.ToDateTime(InitialReleaseDate);
                if (DateTemp < DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the past: ";
                }

                //check to see if the date is greater than todays date
                DateTemp = Convert.ToDateTime(InitialReleaseDate);
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future: ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The date is not a valid date: ";
            }
            
            //return any error messages
            return Error;
        }
    }
}