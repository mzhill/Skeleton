using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //test to see that it exists 
            Assert.IsNotNull(AnCustomer);
        }

        [TestMethod]

        public void CustomerIDPropertyOK()
        {
            //create an instance for a class that needs to be created 
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to property 
            Int32 TestData = 1;
            //assign data to the property
            AnCustomer.CustomerID = TestData;
            //test to see that two values are the same
            Assert.AreEqual(AnCustomer.CustomerID, TestData);
        }

        [TestMethod]

        public void CustomerForenamePropertyOK()
        {
            //create an instance for a class that needs to be created
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to property
            String TestData = "Steve";
            //assing data to the property
            AnCustomer.CustomerForename = TestData;
            //test to see that two values are the same
            Assert.AreEqual(AnCustomer.CustomerForename, TestData);

        }

        [TestMethod]

        public void CustomerSurnamePropertyOK()
        {
            //create an instance for a class that needs to be created
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to property
            String TestData = "Jobs";
            //assing data to the property
            AnCustomer.CustomerSurname = TestData;
            //test to see that two values are the same
            Assert.AreEqual(AnCustomer.CustomerSurname, TestData);
        }

        [TestMethod]

        public void CustomerEmailPropertyOK()
        {
            //create an instance for a class that needs to be created
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to property
            string TestData = "Stevejob@gmail.com";
            //assing data to the property
            AnCustomer.CustomerEmail = TestData;
            //test to see that two values are the same
            Assert.AreEqual(AnCustomer.CustomerEmail, TestData);

        }

        [TestMethod]

        public void CustomerTelPropertyOK()
        {
            //create an instance for a class that needs to be created
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to property
            String TestData = "07561091607";
            //assing data to the property
            AnCustomer.CustomerTel = TestData;
            //test to see that two values are the same
            Assert.AreEqual(AnCustomer.CustomerTel, TestData);
        }

        [TestMethod]

        public void CustomerMembershipPropertyOK()
        {
            //create an instance for a class that needs to be created
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to property
            Boolean TestData = true;
            //assing data to the property
            AnCustomer.CustomerMembership = TestData;
            //test to see that two values are the same
            Assert.AreEqual(AnCustomer.CustomerMembership, TestData);
        }

        [TestMethod]

        public void CustomerDOBPropertyOK()
        {
            //create an instance for a class that needs to be created
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to property
            DateTime TestData = DateTime.Now.Date;
            //assing data to the property
            AnCustomer.CustomerDOB = TestData;
            //test to see that two values are the same
            Assert.AreEqual(AnCustomer.CustomerDOB, TestData);
        }

        [TestMethod]

        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 AddressNo = 21;
            //invoke the method
            Found = AnCustomer.Find(AddressNo);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]

        public void TestCustomerIDFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean vairable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 3;
            //invoke the method
            Found = AnCustomer.Find(CustomerID);
            //check the customer ID
            if (AnCustomer.CustomerID != 3)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerDOBFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean to record if data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 3;
            //invoke the method
            Found = AnCustomer.Find(CustomerID);
            //check the property
            if (AnCustomer.CustomerDOB != Convert.ToDateTime("12/03/2002"))
            {
                OK = false;
            }
            //test to see if resut is correct
            Assert.IsTrue(OK);
        }

    }
}