using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        public bool CustomerMembership { get; set; }

        private DateTime mCustomerDOB;
        //CustomerDOB public property
        public DateTime CustomerDOB
        {
            get
            {
                return mCustomerDOB;
            }
            set
            {
                mCustomerDOB = value;
            }
        }

        //private data member for the address no property
        private Int32 mCustomerID;
        public Int32 CustomerID
        {
            get
            {    //this line of code sends data out of the property
                return mCustomerID;
            }
            set
            {   //this line of code allows data into the property
                mCustomerID = value;

            }
        }
        public string CustomerForename { get; set; }
        public string CustomerSurname { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerTel { get; set; }

        public bool Find(int CustomerID)
        {
            //set the private data members to the test data value
            mCustomerID = 3;
            mCustomerDOB = Convert.ToDateTime("12/03/2002");
            //always return true
            return true;
        }
    }
}