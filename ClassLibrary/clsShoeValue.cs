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
        private Int32 mReleaseDate;

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

        public int ReleaseDate
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

        public bool Find(int shoeID)
        {
            //always return true
            return true;
        }
    }
}