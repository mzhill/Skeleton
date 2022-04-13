using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing5
{
    [TestClass]
    public class tstStockCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();
            //test to see that it exists
            Assert.IsNotNull(AllStock);
        }

        [TestMethod]
        public void StockListOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsStock> TestList = new List<clsStock>();
            //add an item to the list
            //create some test data for the item
            clsStock TestItem = new clsStock();
            //set its properties
            TestItem.ShoeID = 1;
            TestItem.ShoeDescription = "Air Force 1";
            TestItem.ShoeColour = "White";
            TestItem.Quantity = 10;
            TestItem.InitialReleaseDate = DateTime.Now.Date;
            TestItem.Availability = true;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStock.StockList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStock.StockList, TestList);
        }

        [TestMethod]
        public void ThisStockPropertyOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();
            //create some test data to assign to the property
            clsStock TestStock = new clsStock();
            //set the properties of the test object
            TestStock.ShoeID = 1;
            TestStock.ShoeDescription = "Air Force 1";
            TestStock.ShoeColour = "White";
            TestStock.Quantity = 10;
            TestStock.InitialReleaseDate = DateTime.Now.Date;
            TestStock.Availability = true;
            //assign the data to the property
            AllStock.ThisStock = TestStock;
            //test to see that the two values are the same
            Assert.AreEqual(AllStock.ThisStock, TestStock);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsStock> TestList = new List<clsStock>();
            //add an item to the list
            //create the item of test data
            clsStock TestItem = new clsStock();
            //set its properties
            TestItem.ShoeID = 1;
            TestItem.ShoeDescription = "Air Force 1";
            TestItem.ShoeColour = "White";
            TestItem.Quantity = 10;
            TestItem.InitialReleaseDate = DateTime.Now.Date;
            TestItem.Availability = true;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStock.StockList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStock.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();
            //create some test data to assign to the property
            clsStock TestItem = new clsStock();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.ShoeID = 1;
            TestItem.ShoeDescription = "Air Force 1";
            TestItem.ShoeColour = "White";
            TestItem.Quantity = 10;
            TestItem.InitialReleaseDate = DateTime.Now.Date;
            TestItem.Availability = true;
            //set ThisStock to the test data
            AllStock.ThisStock = TestItem;
            //add the record
            PrimaryKey = AllStock.Add();
            //set the primary key of the test data
            TestItem.ShoeID = PrimaryKey;
            //find the record
            AllStock.ThisStock.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllStock.ThisStock, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();
            //create some test data to assign to the property
            clsStock TestItem = new clsStock();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.ShoeID = 1;
            TestItem.ShoeDescription = "Air Force 1";
            TestItem.ShoeColour = "White";
            TestItem.Quantity = 10;
            TestItem.InitialReleaseDate = DateTime.Now.Date;
            TestItem.Availability = true;
            //set ThisStock to the test data
            AllStock.ThisStock = TestItem;
            //add the record
            PrimaryKey = AllStock.Add();
            //set the primary key of the test data
            TestItem.ShoeID = PrimaryKey;
            //modify the test data
            TestItem.ShoeID = 2;
            TestItem.ShoeDescription = "Air Max BW";
            TestItem.ShoeColour = "Cream";
            TestItem.Quantity = 3;
            TestItem.InitialReleaseDate = DateTime.Now.Date;
            TestItem.Availability = true;
            //set ThisStock to the test data
            AllStock.ThisStock = TestItem;
            //update the record
            AllStock.Update();
            //find the record
            AllStock.ThisStock.Find(PrimaryKey);
            //test to see ThisStock matches the test data
            Assert.AreEqual(AllStock.ThisStock, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();
            //create some test data to assign to the property
            clsStock TestItem = new clsStock();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.ShoeID = 1;
            TestItem.ShoeDescription = "Air Force 1";
            TestItem.ShoeColour = "White";
            TestItem.Quantity = 10;
            TestItem.InitialReleaseDate = DateTime.Now.Date;
            TestItem.Availability = true;
            //set ThisStock to the test data
            AllStock.ThisStock = TestItem;
            //add the record
            PrimaryKey = AllStock.Add();
            //set the primary key of the test data
            TestItem.ShoeID = PrimaryKey;
            //find the record
            AllStock.ThisStock.Find(PrimaryKey);
            //delete the record
            AllStock.Delete();
            //now find the record
            Boolean Found = AllStock.ThisStock.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }
    }
}
