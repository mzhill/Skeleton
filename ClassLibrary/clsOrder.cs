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
        //function for the public validation method
        public string Valid(string CustomerUsername, string Quantity, string OrderDate)
        {
            //create a string variable to store the error
            String Error = "";
            //create a temporary variable to store date values
            DateTime DateTemp;

            //is the customer username blank
            if (CustomerUsername.Length == 0)
            {
                //record the error
                Error = Error + "The customer username may not be blank\n";
            }

            //if the customer username is too long
            if (CustomerUsername.Length > 50)
            {
                //record the error
                Error = Error + "The customer username must be less than 50 characters\n";
            }


            //is the quantity blank
            if (Quantity.Length == 0)
            {
                //record the error
                Error = Error + "The quantity may not be blank\n";
            }

            //if the quantity is greater than 32 characters
            if (Quantity.Length > 32)
            {
                //record the error
                Error = Error + "The quantity may not be over 32 characters\n";
            }

            try
            {
                //copy the order date value to the DateTemp variable
                DateTemp = Convert.ToDateTime(OrderDate);
                if (DateTemp < DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the past\n";
                }

                //check to see if the date is greater than todays date
                DateTemp = Convert.ToDateTime(OrderDate);
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future\n";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The date is not a valid date\n";
            }

            //return any error messages
            return Error;
        }



    }
}
