using System;

namespace ClassLibrary
{
    public class clsStaff
    {

        //private member variables
        private Int32 mStaffID;
        private DateTime mDateJoined;
        private Boolean mCurrentlyWorking;
        private string mStaffName;
        private string mPosition;
        private Int32 mStaffSalary;

        //CurrentlyWorking public property
        public bool CurrentlyWorking
        {
            get
            {
                return mCurrentlyWorking;
            }
            set
            {
                mCurrentlyWorking = value;
            }
        }

        //DateJoined public property
        public DateTime DateJoined
        {
            get
            {
                return mDateJoined;
            }
            set
            {
                mDateJoined = value;
            }
        }

        //Staff ID public property
        public Int32 StaffID
        {
            get
            {
                //this line of code sends data out of the property
                return mStaffID;
            }
            set
            {
                //this line of code allows data into the property
                mStaffID = value;
            }
        }

        //Staff Name public property
        public string StaffName
        {
            get
            {
                return mStaffName;
            }
            set
            {
                mStaffName = value;
            }
        }

        //Position public property
        public string Position
        {
            get
            {
                return mPosition;
            }
            set
            {
                mPosition = value;
            }
        }

        //StaffSalary public property
        public int StaffSalary
        {
            get
            {
                return mStaffSalary;
            }
            set
            {
                mStaffSalary = value;
            }
        }

        public bool Find(int StaffID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the shoe id to search for
            DB.AddParameter("@StaffID", StaffID);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_FilterByStaffID");
            //if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mStaffID = Convert.ToInt32(DB.DataTable.Rows[0]["StaffID"]);
                mStaffName = Convert.ToString(DB.DataTable.Rows[0]["StaffName"]);
                mPosition = Convert.ToString(DB.DataTable.Rows[0]["Position"]);
                mStaffSalary = Convert.ToInt32(DB.DataTable.Rows[0]["StaffSalary"]);
                mDateJoined = Convert.ToDateTime(DB.DataTable.Rows[0]["DateJoined"]);
                mCurrentlyWorking = Convert.ToBoolean(DB.DataTable.Rows[0]["CurrentlyWorking"]);

                //return that everything worked OK
                return true;
            }
            //if no record is found
            else
            {
                //return false indicating a problem
                return false;
            }
        }

        //function for the public validation method
        public string Valid(string StaffName, string Position, string StaffSalary, string DateJoined)
        {
            //create a string variable to store the error
            String Error = "";
            //create a temporary variable to store date values
            DateTime DateTemp;

            //is the staff name blank
            if (StaffName.Length == 0)
            {
                //record the error
                Error = Error + "The staff name may not be blank\n";
            }

            //if the staff name is too long
            if (StaffName.Length > 50)
            {
                //record the error
                Error = Error + "The staff name must be less than 50 characters\n";
            }

            //is the Position blank
            if (Position.Length == 0)
            {
                //record the error
                Error = Error + "The Position may not be blank\n";
            }

            //if the Position is too long
            if (Position.Length > 50)
            {
                //record the error
                Error = Error + "The Position must be less than 50 characters\n";
            }

            //is the StaffSalary blank
            if (StaffSalary.Length == 0)
            {
                //record the error
                Error = Error + "The StaffSalary may not be blank\n";
            }

            //if the StaffSalary is greater than 32 characters
            if (StaffSalary.Length > 32)
            {
                //record the error
                Error = Error + "The StaffSalary may not be over 32 characters\n";
            }

            try
            {
                //copy the DateJoined value to the DateTemp variable
                DateTemp = Convert.ToDateTime(DateJoined);
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future\n";
                }

                //check to see if the date is greater than todays date
                DateTemp = Convert.ToDateTime(DateJoined);
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