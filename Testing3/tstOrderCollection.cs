using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing3
{
    [TestClass]
    public class tstOrderCollection
    {

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //test to see that it exists
            Assert.IsNotNull(AllOrders);
        }

        [TestMethod]
        public void OrderListOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsOrder> TestList = new List<clsOrder>();
            //add an item to the list
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //set its properties
            TestItem.OrderID = 1;
            TestItem.CustomerUsername = "Testname";
            TestItem.Quantity = 5;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.NextDayDelivery = true;
            //add items to the test list
            TestList.Add(TestItem);
            //asign the data to the property
            AllOrders.OrderList = TestList;
            //test to see that that two values are the same
            Assert.AreEqual(AllOrders.OrderList, TestList);
        }
        
        [TestMethod]
        public void ThisOrderPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test data to assign to the property
            clsOrder TestOrder = new clsOrder();
            //set the properties of the test object
            TestOrder.OrderID = 1;
            TestOrder.CustomerUsername = "Testname";
            TestOrder.Quantity = 5;
            TestOrder.OrderDate = DateTime.Now.Date;
            TestOrder.NextDayDelivery = true;
            //asign the data to the property
            AllOrders.ThisOrder = TestOrder;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.ThisOrder, TestOrder);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsOrder> TestList = new List<clsOrder>();
            //add an item to the list
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //set its properties
            TestItem.OrderID = 1;
            TestItem.CustomerUsername = "Testname";
            TestItem.Quantity = 5;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.NextDayDelivery = true;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllOrders.OrderList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.Count, TestList.Count);
        }
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test data to assign to the property
            clsOrder TestItem = new clsOrder();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.OrderID = 1;
            TestItem.CustomerUsername = "Testname";
            TestItem.Quantity = 5;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.NextDayDelivery = true;
            //set ThisOrder to the test data
            AllOrders.ThisOrder = TestItem;
            //add the record
            PrimaryKey = AllOrders.Add();
            //set the primary key of the test data
            TestItem.OrderID = PrimaryKey;
            //find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test data to assign to the property
            clsOrder TestItem = new clsOrder();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.OrderID = 1;
            TestItem.CustomerUsername = "Testname";
            TestItem.Quantity = 5;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.NextDayDelivery = true;
            //set ThisStock to the test data
            AllOrders.ThisOrder = TestItem;
            //add the record
            PrimaryKey = AllOrders.Add();
            //set the primary key of the test data
            TestItem.OrderID = PrimaryKey;
            //modify the test data
            TestItem.OrderID = 2;
            TestItem.CustomerUsername = "john quadri";
            TestItem.Quantity = 4;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.NextDayDelivery = false;
            //set ThisOrder to the test data
            AllOrders.ThisOrder = TestItem;
            //update the record
            AllOrders.Update();
            //find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see ThisOrder matches the test data
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test data to assign to the property
            clsOrder TestItem = new clsOrder();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.OrderID = 1;
            TestItem.CustomerUsername = "Testname";
            TestItem.Quantity = 5;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.NextDayDelivery = true;
            //set ThisOrder to the test data
            AllOrders.ThisOrder = TestItem;
            //add the record
            PrimaryKey = AllOrders.Add();
            //set the primary key of the test data
            TestItem.OrderID = PrimaryKey;
            //find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            //delete the record
            AllOrders.Delete();
            //now find the record
            Boolean Found = AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }
        [TestMethod]
        public void ReportByCustomerUsernameMethodOK()
        {
            //create an instance of the class containing unfiltered results
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create an instance of the filtered data
            clsOrderCollection FilteredOrder = new clsOrderCollection();
            //apply a blank string (should return all records)
            FilteredOrder.ReportByCustomerUsername("");
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.Count, FilteredOrder.Count);
        }
        [TestMethod]
        public void ReportByCustomerUsernameNoneFound()
        {
            //create an instance of the filtered data
            clsOrderCollection FilteredOrder = new clsOrderCollection();
            //apply a blank string (should return all records)
            FilteredOrder.ReportByCustomerUsername("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredOrder.Count);
        }
        [TestMethod]
        public void ReportByCustomerUsernameTestDataFound()
        {
            //create an instance of the filtered data#
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            //var to store outcome
            Boolean OK = true;
            //apply a customer username that does not exist
            FilteredOrders.ReportByCustomerUsername("JamesSmith");
            //check that the correct number of records are found
            if (FilteredOrders.Count == 2)
            {
                //check that the first record is ID 27
                if (FilteredOrders.OrderList[0].OrderID != 27)
                {
                    OK = false;
                }
                //check that the first record is ID 28
                if (FilteredOrders.OrderList[1].OrderID != 28)
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
