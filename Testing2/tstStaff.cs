using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStaff AStaff = new clsStaff();
            Assert.IsNotNull(AStaff);
        }

        [TestMethod]
        public void StaffIDPropertyOK()
        {
            clsStaff AStaff = new clsStaff();
            Int32 TestData = 1;
            AStaff.StaffID = TestData;
            Assert.AreEqual(AStaff.StaffID, TestData);
        }

        [TestMethod]
        public void StaffNamePropertyOK()
        {

            clsStaff AStaff = new clsStaff();
            String TestData = "ExampleText";
            AStaff.StaffName = TestData;
            Assert.AreEqual(AStaff.StaffName, TestData);
        }
        [TestMethod]
        public void PositionPropertyOK()
        {
            clsStaff AStaff = new clsStaff();
            String TestData = "Name";
            AStaff.Position = TestData;
            Assert.AreEqual(AStaff.Position, TestData);
        }

        [TestMethod]
        public void StaffTelPropertyOK()
        {
            clsStaff AStaff = new clsStaff();
            Int32 TestData = 1;
            AStaff.StaffTel = TestData;
            Assert.AreEqual(AStaff.StaffTel, TestData);
        }
        [TestMethod]
        public void StaffSalaryPropertyOK()
        {
            clsStaff AStaff = new clsStaff();
            Int32 TestData = 1;
            AStaff.StaffSalary = TestData;
            Assert.AreEqual(AStaff.StaffSalary, TestData);
        }
        [TestMethod]
        public void CurrentlyWorkingPropertyOK()
        {
            clsStaff AStaff = new clsStaff();
            Boolean TestData = true;
            AStaff.CurrentlyWorking = TestData;
            Assert.AreEqual(AStaff.CurrentlyWorking, TestData);
        }
        [TestMethod]
        public void DateJoinedPropertyOK()
        {
            clsStaff AStaff = new clsStaff();
            DateTime TestData = DateTime.Now.Date;
            AStaff.DateJoined = TestData;
            Assert.AreEqual(AStaff.DateJoined, TestData);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            clsStaff AStaff = new clsStaff();
            Boolean Found = false;
            Int32 StaffID = 5;
            Found = AStaff.Find(StaffID);
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestStaffIDFound()
        {
            clsStaff AStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffID = 5;
            Found = AStaff.Find(StaffID);
            if (AStaff.StaffID != 5)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        public void TestCurrentlyWorkingFound()
        {
            clsStaff AStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffID = 5;
            Found = AStaff.Find(StaffID);
            if (AStaff.CurrentlyWorking != true )
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        public void TestPositionFound()
        {
            clsStaff AStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffID = 5;
            Found = AStaff.Find(StaffID);
            if (AStaff.Position != "Test Position")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestDateJoinedFound()
        {
            clsStaff AStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffID = 5;
            Found = AStaff.Find(StaffID);
            if (AStaff.DateJoined != Convert.ToDateTime("16/09/2015");
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestStaffNameFound()
        {
            clsStaff AStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffID = 5;
            Found = AStaff.Find(StaffID);
            if (AStaff.StaffName!= "Test Name");
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        public void TestStaffTelFound()
        {
            clsStaff AStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffID = 5;
            Found = AStaff.Find(StaffID);
            if (AStaff.StaffTel != 5)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        public void TestStaffSalaryFound()
        {
            clsStaff AStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffID = 5;
            Found = AStaff.Find(StaffID);
            if (AStaff.StaffSalary != 5)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }


    }
        
}
