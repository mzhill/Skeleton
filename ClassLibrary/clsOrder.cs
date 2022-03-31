using System;
namespace ClassLibrary
{
    public class clsOrder
    {
        //private member variables
        private Int32 mOrderID;
        private string mCustomerUsername;
        private bool mNextDayDelivery;
        private DateTime mOrderDate;
        private Int32 mQuantity;



        public clsOrder()
        {
        }


        public Int32 OrderID
        {
            get
            {
                //this line of code sends data out of the property
                return mOrderID;
            }
            set
            {
                //this line of code allows data into the property
                mOrderID = value;
            }
        }

        public string CustomerUsername
        {
            get
            {
                //this line of code sends data out of the property
                return mCustomerUsername;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerUsername = value;
            }
        }

        public bool NextDayDelivery
        {
            get
            {
                //this line of code sends data out of the property
                return mNextDayDelivery;
            }
            set
            {
                //this line of code allows data into the property
                mNextDayDelivery = value;
            }
        }
        public DateTime OrderDate
        {
            get
            {
                //return the private data 
                return mOrderDate;
            }
            set
            {
                //
                mOrderDate = value;

            }
        }
        public Int32 Quantity
        {
            get
            {
                //this line of code sends data out of the property 
                return mQuantity;
            }
            set
            {
                //this line of code allows data into the property
                mQuantity = value;

            }
        }
    }
}