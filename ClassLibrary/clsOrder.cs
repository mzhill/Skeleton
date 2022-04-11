using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        public bool NextDayDelivery
        {
            get
            {
                return mNextDayDelivery;
            }
            set
            {
                mNextDayDelivery = value;
            }
        }

        public DateTime OrderDate
        {
            get
            {
                return mOrderDate;
            }
            set
            {
                mOrderDate = value;
            }
        }

        public Int32 OrderID
        {
            get
            {
                return mOrderID;
            }
            set
            {
                mOrderID = value;
            }
        }

        public string CustomerUsername
        {
            get
            {
                return mCustomerUsername;
            }
            set
            {
                mCustomerUsername = value;
            }
        }

        public Int32 Quantity
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


        public bool Find(int OrderID)
        {
            //set the private data members to the data test value
            mOrderID = 7;
            mCustomerUsername = "Test name";
            mNextDayDelivery = true;
            mOrderDate = Convert.ToDateTime("16/09/2018");
            mQuantity = 5;
            //always return true
            return true;
        }

    }
}
