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
        private Int32 mResaleDate;

        //private data member for the address no popperty
        private Int32 mCatergory;

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

            }
        }
        public int ResalePrice 


        public int Catergory { get; set; }
        public int ReleaseDate { get; set; }
        public int Stock { get; set; }

        public bool Find(int shoeID)
        {
            //always return true
            return true;
        }
    }
}