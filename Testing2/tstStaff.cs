using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing2
{
    [TestClass]
    public class tstStaff
    {
        //good test data
        string StaffName = "Hasan Namik";
        string Position = "Staff Member";
        string StaffSalary = "10";
        string DateJoined = DateTime.Now.Date.ToString();

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //test to see that it exists
            Assert.IsNotNull(AStaff);
        }

        [TestMethod]
        public void StaffIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data
            Int32 TestData = 1;
            //assign the data to the property
            AStaff.StaffID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.StaffID, TestData);
        }

        [TestMethod]
        public void StaffNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data
            String TestData = "ExampleText";
            //assign the data to the property
            AStaff.StaffName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.StaffName, TestData);
        }

        [TestMethod]
        public void PositionPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data
            String TestData = "Staff Member";
            //assign the data to the property
            AStaff.Position = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.Position, TestData);
        }

        [TestMethod]
        public void StaffSalaryPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data
            Int32 TestData = 1;
            //assign the data to the property
            AStaff.StaffSalary = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.StaffSalary, TestData);
        }

        [TestMethod]
        public void CurrentlyWorkingPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data
            Boolean TestData = true;
            //assign the data to the property
            AStaff.CurrentlyWorking = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.CurrentlyWorking, TestData);
        }

        [TestMethod]
        public void DateJoinedPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AStaff.DateJoined = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.DateJoined, TestData);
        }


        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 StaffID = 2;
            //invoke the method
            Found = AStaff.Find(StaffID);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestStaffIDFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 5;
            //invoke the method
            Found = AStaff.Find(StaffID);
            //check the shoe id
            if (AStaff.StaffID != 5)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateJoinedFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 5;
            //invoke the method
            Found = AStaff.Find(StaffID);
            //check the property
            if (AStaff.DateJoined != Convert.ToDateTime("03/01/2001"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffNameFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 1;
            //invoke the method
            Found = AStaff.Find(StaffID);
            //check the property
            if (AStaff.StaffName != "Hasan Namik")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPositionFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 1;
            //invoke the method
            Found = AStaff.Find(StaffID);
            //check the property
            if (AStaff.Position != "Staff Member")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffSalaryFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 5;
            //invoke the method
            Found = AStaff.Find(StaffID);
            //check the property
            if (AStaff.StaffSalary != 10)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCurrentlyWorkingFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 5;
            //invoke the method
            Found = AStaff.Find(StaffID);
            //check the property
            if (AStaff.CurrentlyWorking != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = AStaff.Valid(StaffName, Position, StaffSalary, DateJoined);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string StaffName = "";
            //invoke the method
            Error = AStaff.Valid(StaffName, Position, StaffSalary, DateJoined);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string StaffName = "a";
            //invoke the method
            Error = AStaff.Valid(StaffName, Position, StaffSalary, DateJoined);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string StaffName = "aa";
            //invoke the method
            Error = AStaff.Valid(StaffName, Position, StaffSalary, DateJoined);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string StaffName = "";
            StaffName = StaffName.PadRight(49, 'a');
            //invoke the method
            Error = AStaff.Valid(StaffName, Position, StaffSalary, DateJoined);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string StaffName = "";
            StaffName = StaffName.PadRight(50, 'a');
            //invoke the method
            Error = AStaff.Valid(StaffName, Position, StaffSalary, DateJoined);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string StaffName = "";
            StaffName = StaffName.PadRight(51, 'a');
            //invoke the method
            Error = AStaff.Valid(StaffName, Position, StaffSalary, DateJoined);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string StaffName = "";
            StaffName = StaffName.PadRight(25, 'a');
            //invoke the method
            Error = AStaff.Valid(StaffName, Position, StaffSalary, DateJoined);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PositionMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Position = "";
            //invoke the method
            Error = AStaff.Valid(StaffName, Position, StaffSalary, DateJoined);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PositionMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Position = "a";
            //invoke the method
            Error = AStaff.Valid(StaffName, Position, StaffSalary, DateJoined);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PositionMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Position = "aa";
            //invoke the method
            Error = AStaff.Valid(StaffName, Position, StaffSalary, DateJoined);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PositionMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Position = "";
            StaffName = Position.PadRight(49, 'a');
            //invoke the method
            Error = AStaff.Valid(StaffName, Position, StaffSalary, DateJoined);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PositionMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Position = "";
            StaffName = Position.PadRight(50, 'a');
            //invoke the method
            Error = AStaff.Valid(StaffName, Position, StaffSalary, DateJoined);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PositionMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Position = "";
            StaffName = Position.PadRight(51, 'a');
            //invoke the method
            Error = AStaff.Valid(StaffName, Position, StaffSalary, DateJoined);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PositionMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Position = "";
            StaffName = Position.PadRight(25, 'a');
            //invoke the method
            Error = AStaff.Valid(StaffName, Position, StaffSalary, DateJoined);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffSalaryMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffSalary = "a"; //this should be ok
            //invoke the method
            Error = AStaff.Valid(StaffName, Position, StaffSalary, DateJoined);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffSalaryMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffSalary = "aa"; //this should be ok
            //invoke the method
            Error = AStaff.Valid(StaffName, Position, StaffSalary, DateJoined);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffSalaryMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffSalary = "";
            StaffSalary = StaffSalary.PadRight(30, 'a'); //this should fail
            //invoke the method
            Error = AStaff.Valid(StaffName, Position, StaffSalary, DateJoined);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffSalaryMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffSalary = "";
            StaffSalary = StaffSalary.PadRight(31, 'a'); //this should fail
            //invoke the method
            Error = AStaff.Valid(StaffName, Position, StaffSalary, DateJoined);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffSalaryMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffSalary = "";
            StaffSalary = StaffSalary.PadRight(15, 'a'); //this should be ok
            //invoke the method
            Error = AStaff.Valid(StaffName, Position, StaffSalary, DateJoined);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffSalaryMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffSalary = "";
            StaffSalary = StaffSalary.PadRight(32, 'a'); //this should fail
            //invoke the method
            Error = AStaff.Valid(StaffName, Position, StaffSalary, DateJoined);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void InititalReleaseDateExtremeMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(StaffName, Position, StaffSalary, DateJoined);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void InititalReleaseDateMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(StaffName, Position, StaffSalary, DateJoined);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void InititalReleaseDateMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(StaffName, Position, StaffSalary, DateJoined);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void InititalReleaseDateMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(StaffName, Position, StaffSalary, DateJoined);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void InititalReleaseDateExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(StaffName, Position, StaffSalary, DateJoined);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateJoinedInvalidData()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //set the initial release date to non date value
            string DateJoined = "this is not a date!";
            //invoke the method
            Error = AStaff.Valid(StaffName, Position, StaffSalary, DateJoined);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
    }
}