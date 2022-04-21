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


            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the shoe id to search for
            DB.AddParameter("@OrderID", OrderID);
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_FilterByOrderID");
            //if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members

                mOrderDate = Convert.ToDateTime(DB.DataTable.Rows[0]["OrderDate"]);
                mQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["Quantity"]);
                mCustomerUsername = Convert.ToString(DB.DataTable.Rows[0]["CustomerUsername"]);
                mNextDayDelivery = Convert.ToBoolean(DB.DataTable.Rows[0]["NextDayDelivery"]);
                mOrderID = Convert.ToInt32(DB.DataTable.Rows[0]["OrderID"]);
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

    }
}
