using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        private Int32 mStaffID;
        private DateTime mDateJoined;
        private Boolean mCurrentlyWorking;
        private string mPosition;
        private string mStaffName;
        private Int32 mStaffTel;
        private Int32 mStaffSalary;

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

        public Int32 StaffID
        {
            get
            {
                return mStaffID;
            }
            set
            {
                mStaffID = value;
            }
        }

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

        public Int32 StaffSalary
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
        public Int32 StaffTel
        {
            get
            {
                return mStaffTel;
            }
            set
            {
                mStaffTel = value;
            }
        }

        public bool Find(int staffID)
        {
            mStaffID = 5;
            mCurrentlyWorking = true;
            mPosition = "Test Position";
            mDateJoined = Convert.ToDateTime("16/09/2015");
            mStaffName = "Test Name";
            mStaffTel = 5;
            mStaffSalary = 5; 
            return true;
        }
        /*public bool Find(int staffID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StaffID", staffID);
            DB.Execute("sproc_tblStaff_FilterByStaffID");
            if (DB.Count == 1)
            {
                mStaffID = Convert.ToInt32(DB.DataTable.Rows[0]["StaffID"]); 
                mCurrentlyWorking = Convert.ToBoolean(DB.DataTable.Rows[0]["CurrentlyWorking"]);
                mPosition = Convert.ToString(DB.DataTable.Rows[0]["Position"]);
                mDateJoined = Convert.ToDateTime(DB.DataTable.Rows[0]["DateJoined"]);
                mStaffName = Convert.ToString(DB.DataTable.Rows[0]["StaffName"]);
                mStaffTel = Convert.ToInt32(DB.DataTable.Rows[0]["StaffTel"]);
                mStaffSalary = Convert.ToInt32(DB.DataTable.Rows[0]["StaffSalary"]);
                return true;
             
            }
            else
            {
                return false;
            }
        }*/
    }
}