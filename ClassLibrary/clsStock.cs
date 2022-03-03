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
            //set the private data members to the test data value
            mShoeID = 5;
            mShoeDesc = "Air Force 1";
            mShoeColour = "White";
            mQuantity = 10;
            mInitialReleaseDate = Convert.ToDateTime("14/08/2002");
            mAvailability = true;

            //always return true
            return true;
        }
    }
}