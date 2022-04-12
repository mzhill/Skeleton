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
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.CustomerID = 1;
            TestItem.CustomerForename = "Kush";
            TestItem.CustomerSurname = "Modessa";
            TestItem.CustomerEmail = "Kushmodessa@gmail.com";
            TestItem.CustomerTel = "07561091607";
            TestItem.CustomerDOB = DateTime.Now.Date;
            TestItem.CustomerMembership = true;
            //set this customers to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of test data
            TestItem.CustomerID = PrimaryKey;
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }

        
    }


}
