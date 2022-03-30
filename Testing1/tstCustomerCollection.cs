using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing1
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //test to see that it exists
            Assert.IsNotNull(AllCustomers);
        }

        [TestMethod]
        public void CustomerListOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list ofobjects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an item to the list
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.CustomerID = 1;
            TestItem.CustomerForename = "Kush";
            TestItem.CustomerSurname = "Modessa";
            TestItem.CustomerEmail = "Kushmodessa@gmail.com";
            TestItem.CustomerTel = "07561091607";
            TestItem.CustomerDOB = DateTime.Now.Date;
            TestItem.CustomerMembership = true;
            //add items to the test list
            TestList.Add(TestItem);
            //asign the data to the property
            AllCustomers.CustomerList = TestList;
            //test to see that that two values are the same
            Assert.AreEqual(AllCustomers.CustomerList, TestList);
        }

        [TestMethod]
        public void CountPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            Int32 SomeCount = 0;
            //assign the data to the property
            AllCustomers.Count = SomeCount;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.Count, SomeCount);
        }

        [TestMethod]
        public void ThisCustomerPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            clsCustomer TestCustomer = new clsCustomer();
            //set its properties
            TestCustomer.CustomerID = 1;
            TestCustomer.CustomerForename = "Kush";
            TestCustomer.CustomerSurname = "Modessa";
            TestCustomer.CustomerEmail = "Kushmodessa@gmail.com";
            TestCustomer.CustomerTel = "07561091607";
            TestCustomer.CustomerDOB = DateTime.Now.Date;
            TestCustomer.CustomerMembership = true;
            //asign the data to the property
            AllCustomers.ThisCustomer = TestCustomer;
            //test to see that that two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list ofobjects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an item to the list
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.CustomerID = 1;
            TestItem.CustomerForename = "Kush";
            TestItem.CustomerSurname = "Modessa";
            TestItem.CustomerEmail = "Kushmodessa@gmail.com";
            TestItem.CustomerTel = "07561091607";
            TestItem.CustomerDOB = DateTime.Now.Date;
            TestItem.CustomerMembership = true;
            //add items to the test list
            TestList.Add(TestItem);
            //asign the data to the property
            AllCustomers.CustomerList = TestList;
            //test to see that that two values are the same
            Assert.AreEqual(AllCustomers.Count, TestList.Count);
        }

    }


}
