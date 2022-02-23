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
        string TestData = Stevejob@gmail.com;
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
}