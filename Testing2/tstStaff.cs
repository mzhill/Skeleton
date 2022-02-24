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
            Assert.AreEqual(AStaff.ShaffID, TestData);
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
            clsStock AStaff = new clsStaff();
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
            Assert.AreEqual(AStaff.CurrentlyWorking], TestData);
        }
        [TestMethod]
        public void DateJoinedPropertyOK()
        {
            clsStaff AStaff = new clsStaff();
            DateTime TestData = DateTime.Now.Date;
            AStaff.DateJoined = TestData;
            Assert.AreEqual(AStaff.DateJoined, TestData);
        }

    }
        
    }

   

}
