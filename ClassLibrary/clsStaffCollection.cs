using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStaffCollection
    {
        //private data member for the list
        List<clsStaff> mStaffList = new List<clsStaff>();
        //private data member ThisStaff
        clsStaff mThisStaff = new clsStaff();

        //constructor for the class
        public clsStaffCollection()
        {
            //object for data collection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        //public property for the address list
        public List<clsStaff> StaffList
        {
            get
            {
                //return the private data
                return mStaffList;
            }
            set
            {
                //set the private data
                mStaffList = value;
            }
        }

        public int Count
        {
            get
            {
                //return the count of the list
                return mStaffList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }

        public clsStaff ThisStaff
        {
            get
            {
                //return the private
                return mThisStaff;
            }
            set
            {
                //set the private data
                mThisStaff = value;
            }
        }

        public int Add()
        {
            //adds a new record to the database based on the values of this mThisStaff
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("StaffName", mThisStaff.StaffName);
            DB.AddParameter("Position", mThisStaff.Position);
            DB.AddParameter("StaffSalary", mThisStaff.StaffSalary);
            DB.AddParameter("Initial Release Date", mThisStaff.DateJoined);
            DB.AddParameter("CurrentlyWorking", mThisStaff.CurrentlyWorking);
            //execute the query returning the primary key value
            return mThisStaff.StaffID;
        }

        public void Update()
        {
            //update an existing record based on the values of ThisStaff
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@StaffID", mThisStaff.StaffID);
            DB.AddParameter("@StaffName", mThisStaff.StaffName);
            DB.AddParameter("@Position", mThisStaff.Position);
            DB.AddParameter("@StaffSalary", mThisStaff.StaffSalary);
            DB.AddParameter("@DateJoined", mThisStaff.DateJoined);
            DB.AddParameter("@CurrentlyWorking", mThisStaff.CurrentlyWorking);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_Update");
        }

        public void Delete()
        {
            //deletes the record pointed to by ThisStaff
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@StaffID", mThisStaff.StaffID);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_Delete");
        }

        public void ReportByPosition(string Position)
        {
            //filters the records based on a full or partial shoe colour
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the Position parameter to the database
            DB.AddParameter("@Position", Position);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_FilterByPosition");
            //populate the array list with the data lable
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mStaffList = new List<clsStaff>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank Staff
                clsStaff AStaff = new clsStaff();
                //read in the fields from the current record
                AStaff.StaffID = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffID"]);
                AStaff.StaffName = Convert.ToString(DB.DataTable.Rows[Index]["StaffName"]);
                AStaff.Position = Convert.ToString(DB.DataTable.Rows[Index]["Position"]);
                AStaff.StaffSalary = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffSalary"]);
                AStaff.DateJoined = Convert.ToDateTime(DB.DataTable.Rows[Index]["Initial Release Date"]);
                AStaff.CurrentlyWorking = Convert.ToBoolean(DB.DataTable.Rows[Index]["CurrentlyWorking"]);
                //add the record to the private data member
                mStaffList.Add(AStaff);
                //point at the next record
                Index++;
            }
        }
    }
}
