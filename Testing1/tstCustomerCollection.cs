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

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
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
            //set ThisStock to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.CustomerID = PrimaryKey;
            //modify the test data
            TestItem.CustomerID = 1;
            TestItem.CustomerForename = "Adil";
            TestItem.CustomerSurname = "Alarakhia";
            TestItem.CustomerEmail = "adilalarakhia@gmail.com";
            TestItem.CustomerTel = "07921553844";
            TestItem.CustomerDOB = DateTime.Now.Date;
            TestItem.CustomerMembership = false;
            //set ThisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //update the record
            AllCustomers.Update();
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see ThisCustomer matches the test data
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
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
            //delete the record 
            AllCustomers.Delete();
            //now find the record
            Boolean Found = AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByCustomerSurnameMethodOK()
        {
            //create an instance of the class containing unfiltered results
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create an instance of the filtered data
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //apply a blank string 
            FilteredCustomers.ReportByCustomerSurname("");
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.Count, FilteredCustomers.Count);
        }

        [TestMethod]
        public void ReportByCustomerSurnameNoneFound()
        {
            //create an instance of the filtered data
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //apply a surname that does not exist
            FilteredCustomers.ReportByCustomerSurname("xxxxxxxxxx");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredCustomers.Count);
        }

        [TestMethod]
        public void ReportByCustomerSurnameTestDataFound()
        {
            //create an instance of the filtered data
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //var to store outcome
            Boolean OK = true;
            //apply a surname that does not exist
            FilteredCustomers.ReportByCustomerSurname("Smith");
            //check that the correct number of records are found
            if (FilteredCustomers.Count == 2)
            {
                //check that the first record is ID 4
                if (FilteredCustomers.CustomerList[0].CustomerID != 4)
                {
                    OK = false;
                }
                //Check that the first record is ID 5
                if (FilteredCustomers.CustomerList[1].CustomerID != 5)
                {
                    OK = false;

                }
            }
            else
            {
                OK = false;

            }
            //test to see that there are no records
            Assert.IsTrue(OK);

        }
    }


}
