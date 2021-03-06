using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        private Boolean mCustomerMembership;
        public bool CustomerMembership
        {
            get
            {
                //return the private data
                return mCustomerMembership;
            }
            set
            {
                //set the private data
                mCustomerMembership = value;
            }
        }


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

        //private data member for the address no property
        private string mCustomerForename;
        public string CustomerForename
        {
            get
            {
                //this line of code sends data out the property
                return mCustomerForename;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerForename = value;
            }
        }

        //private data member for the address no property
        private string mCustomerSurname;
        public string CustomerSurname
        {
            get
            {
                //this line of code sends data out the property
                return mCustomerSurname;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerSurname = value;
            }
        }

        //private data member for the address no property
        private string mCustomerEmail;
        public string CustomerEmail
        {
            get
            {
                //this line of code sends data out the property
                return mCustomerEmail;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerEmail = value;
            }
        }

        //private data member for the address no property
        private string mCustomerTel;
        public string CustomerTel
        {
            get
            {
                //this line of code sends data out the property
                return mCustomerTel;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerTel = value;
            }
        }


        public bool Find(int CustomerID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the address not to search for
            DB.AddParameter("@CustomerID", CustomerID);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_FilterByCustomerID");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {

                //copy the data from the database to the private data members
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mCustomerDOB = Convert.ToDateTime(DB.DataTable.Rows[0]["CustomerDOB"]);
                mCustomerForename = Convert.ToString(DB.DataTable.Rows[0]["CustomerForename"]);
                mCustomerSurname = Convert.ToString(DB.DataTable.Rows[0]["CustomerSurname"]);
                mCustomerEmail = Convert.ToString(DB.DataTable.Rows[0]["CustomerEmail"]);
                mCustomerTel = Convert.ToString(DB.DataTable.Rows[0]["CustomerTel"]);
                mCustomerMembership = Convert.ToBoolean(DB.DataTable.Rows[0]["CustomerMembership"]);
                //return that everything worked OK
                return true;
            }
            //if no record was found
            else
            {
                //return false indication a problem
                return false;

            }
        }

        //function for the public validation method
        public string Valid(string CustomerForename, string CustomerSurname,string CustomerDOB, string CustomerEmail, string CustomerTel)
        {
            //create a string variable to store the error
            String Error = "";

            //create a temporary variable to store date values
            DateTime DateTemp;

            //if the CustomerForename is blank
            if (CustomerForename.Length == 0)
            {
                //record the error
                Error = Error + "The Customer Forename may not be blank :";
            }
            //if the CustomerForename is greater than 6 characters
            if (CustomerForename.Length > 6)
            {
                //RECORD THE ERROR
                Error = Error + "The CustomerID must be less than 6 characters : ";
            }

            try
            {
                //copy the CustomerDOB value to the DateTemp variable
                DateTemp = Convert.ToDateTime(CustomerDOB);
                if (DateTemp < DateTime.Now.Date)
                {
                    //record the error 
                    Error = Error + "The date cannot be in the past";
                }

                //check to see if the date is greater than todays date
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The date was not valid : ";
            }

            //if the surname is blank
            if (CustomerSurname.Length == 0)
            {
                //record the error
                Error = Error + "The Surname may not be blank : ";
            }
            
            //if the surname is too long
            if (CustomerSurname.Length > 9)
            {
                //record the error
                Error = Error + "The surname must be less than 9 characters";
            }

            //is the Email Blank
            if (CustomerEmail.Length == 0)
            {
                //record the error
                Error = Error + "The Email may not be blank : ";
            }

            //if the email is too long
            if  (CustomerEmail.Length > 50)
            {
                //record the error
                Error = Error + "The Email must be less than 50 Characters : ";
            }

            //is the Tel blank
            if (CustomerTel.Length == 0)
            {
                //record the error
                Error = Error + "The Surname may not be blank : ";
            }

            // if the Tel is too long 
            if (CustomerTel.Length > 50)
            {
                //record the error
                Error = Error + "The Tel must be less than 50 characters : ";
            }

            //return any error messages
            return Error;


        }
    }
}