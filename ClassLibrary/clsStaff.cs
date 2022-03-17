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
            return true;
        }
    }
}