using System;

namespace ClassLibrary
{
    public class clsShoeValue
    {
        //private data member for the address no popperty
        private Int32 mShoeID;

        //private data member for the address no popperty
        private Int32 mRetailPrice;

        //private data member for the address no popperty
        private Int32 mResalePrice;

        //private data member for the address no popperty
        private Int32 mCatergory;

        //private data member for the address no popperty
        private DateTime mReleaseDate;

        //private data member for the address no popperty
        private Int32 mStock;

        public int ShoeID
        {
            get
            {
                //this line of code sends data out of the poperty
                return mShoeID;
            }
            set
            {
                //this line of code allows data into the poperty
                mShoeID = value;
            }
        }
        public int RetailPrice
        {
            get
            {
                //this line of code sends data out of the poperty
                return mRetailPrice;
            }
            set
            {
                //this line of code allows data into the poperty
                mRetailPrice = value;

            }
        }

        public int ResalePrice
        {
            get
            {
                //this line of code sends data out of the poperty
                return mResalePrice;
            }
            set
            {
                //this line of code allows data into the poperty
                mResalePrice = value;

            }
        }

        public int Catergory
        {
            get
            {
                //this line of code sends data out of the poperty
                return mCatergory;
            }
            set
            {
                //this line of code allows data into the poperty
                mCatergory = value;

            }
        }

        public DateTime ReleaseDate
        {
            get
            {
                //this line of code sends data out of the poperty
                return mReleaseDate;
            }
            set
            {
                //this line of code allows data into the poperty
                mReleaseDate = value;

            }
        }

        public int Stock
        {
            get
            {
                //this line of code sends data out of the poperty
                return mStock;
            }
            set
            {
                //this line of code allows data into the poperty
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

                mReleaseDate = Convert.ToDateTime(DB.DataTable.Rows[0][ReleaseDate]);


                //return that everything worked OK
                return true;

                //return false indicating a problem
                return false;
            }
        }
    }
}