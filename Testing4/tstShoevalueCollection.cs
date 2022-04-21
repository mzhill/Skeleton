using System;
using System.Collections.Generic;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Testing_Framework
{
    [TestClass]
    public class tstShoeValueCllection
    {

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsShoeValueCollection AllStock = new clsShoeValueCollection();
            //test to see that it exists
            Assert.IsNotNull(AllStock);
        }

        [TestMethod]
        public void ShoeValueListOK()
        {
            //create an instance of the class we want to create 
            clsShoeValueCollection AllShoeValue = new clsShoeValueCollection();
            //create some test dT to assign to the property
            //in thisw case the data needs to be a list of objects 
            List<clsShoeValue> TestList = new List<clsShoeValue>();
            //add an item to the list 
            //create the item of test data
            clsShoeValue TestItem = new clsShoeValue();
            //set its properties
            TestItem.ShoeID = 1;
            TestItem.RetailPrice = "160";
            TestItem.ResalePrice = "1300";
            TestItem.Catergory = "Jordan";
            TestItem.ReleaseDate = DateTime.Now.Date;
            TestItem.Stock = true;
            //add the item to the test list
            TestList.Add(TestItem);
            //Assign the data to the property
            AllShoeValue.ShoeValueList = TestList;
            //test to see that the two value are the same
            Assert.AreEqual(AllShoeValue.ShoeValueList, TestList);
            
        }

        [TestMethod]
        public void ThisShoeValuePropertyOK()
        {
            //create an instance of the class we want to create
            clsShoeValueCollection AllShoeValue = new clsShoeValueCollection();
            //create some test data to assign to the property
            clsShoeValue TestShoeValue = new clsShoeValue();
            //set the properties of the test object
            TestShoeValue.ShoeID = 1;
            TestShoeValue.RetailPrice = "160";
            TestShoeValue.ResalePrice = "1300";
            TestShoeValue.Catergory = "Jordan";
            TestShoeValue.ReleaseDate = DateTime.Now.Date;
            TestShoeValue.Stock = true;
            //assign the data to the property
            AllShoeValue.ThisShoeValue = TestShoeValue;
            //test to see that the two values are the same
            Assert.AreEqual(AllShoeValue.ThisShoeValue, TestShoeValue);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create 
            clsShoeValueCollection AllShoeValue = new clsShoeValueCollection();
            //create some test dT to assign to the property
            //in thisw case the data needs to be a list of objects 
            List<clsShoeValue> TestList = new List<clsShoeValue>();
            //add an item to the list 
            //create the item of test data
            clsShoeValue TestItem = new clsShoeValue();
            //set its properties
            TestItem.ShoeID = 1;
            TestItem.RetailPrice = "160";
            TestItem.ResalePrice = "1300";
            TestItem.Catergory = "Jordan";
            TestItem.ReleaseDate = DateTime.Now.Date;
            TestItem.Stock = true;
            //add the item to the test list
            TestList.Add(TestItem);
            //Assign the data to the property
            AllShoeValue.ShoeValueList = TestList;
            //test to see that the two value are the same
            Assert.AreEqual(AllShoeValue.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create 
            clsShoeValueCollection AllShoeValue = new clsShoeValueCollection();
            //create the item of test data
            clsShoeValue TestItem = new clsShoeValue();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.ShoeID = 1;
            TestItem.RetailPrice = "160";
            TestItem.ResalePrice = "1300";
            TestItem.Catergory = "Jordan";
            TestItem.ReleaseDate = DateTime.Now.Date;
            TestItem.Stock = true;
            //set ThisStock to the test data
            AllShoeValue.ThisShoeValue = TestItem;
            //add the record
            PrimaryKey = AllShoeValue.Add();
            //set the primary key of the test data
            TestItem.ShoeID = PrimaryKey;
            //find the record
            AllShoeValue.ThisShoeValue.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllShoeValue.ThisShoeValue, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsShoeValueCollection AllStock = new clsShoeValueCollection();
            //create some test data to assign to the property
            clsShoeValue TestItem = new clsShoeValue();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.ShoeID = 1;
            TestItem.RetailPrice = "160";
            TestItem.ResalePrice = "1300";
            TestItem.Catergory = "Jordan";
            TestItem.ReleaseDate = DateTime.Now.Date;
            TestItem.Stock = true;
            //set ThisShoeValue to the test data
            AllStock.ThisShoeValue = TestItem;
            //add the record
            PrimaryKey = AllStock.Add();
            //set the primary key of the test data
            TestItem.ShoeID = PrimaryKey;
            //modify the test data
            TestItem.ShoeID = 2;
            TestItem.RetailPrice = "200";
            TestItem.ResalePrice = "450";
            TestItem.Catergory = "Jordan";
            TestItem.ReleaseDate = DateTime.Now.Date;
            TestItem.Stock = true;
            //set ThisShoeValue to the test data
            AllStock.ThisShoeValue = TestItem;
            //update the record
            AllStock.Update();
            //find the record
            AllStock.ThisShoeValue.Find(PrimaryKey);
            //test to see ThisShoeValue matches the test data
            Assert.AreEqual(AllStock.ThisShoeValue, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create 
            clsShoeValueCollection AllShoeValue = new clsShoeValueCollection();
            //create the item of test data
            clsShoeValue TestItem = new clsShoeValue();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.ShoeID = 1;
            TestItem.RetailPrice = "160";
            TestItem.ResalePrice = "1300";
            TestItem.Catergory = "Jordan";
            TestItem.ReleaseDate = DateTime.Now.Date;
            TestItem.Stock = true;
            //set ThisStock to the test data
            AllShoeValue.ThisShoeValue = TestItem;
            //add the record
            PrimaryKey = AllShoeValue.Add();
            //set the primary key of the test data
            TestItem.ShoeID = PrimaryKey;
            //delete the record
            AllShoeValue.Delete();
            //find the record
            AllShoeValue.ThisShoeValue.Find(PrimaryKey);
            //now find the record
            Boolean Found = AllShoeValue.ThisShoeValue.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByCatergoryMethodOK()
        {
            //create an instance of the class containing unfiltered results
            clsShoeValueCollection AllShoeValue = new clsShoeValueCollection();
            //create an instance of the filtered data
            clsShoeValueCollection FilteredShoeValue = new clsShoeValueCollection();
            //apply a blank string (should return all records)
            FilteredShoeValue.ReportByCatergory("");
            //test to see that the two values are the same
            Assert.AreEqual(AllShoeValue.Count, FilteredShoeValue.Count);
        }

        public void ReportByCatergoryNoneFound()
        {
            //create an instance of the filtered data
            clsShoeValueCollection FilteredShoeValue = new clsShoeValueCollection();
            //apply a blank string (should return all records)
            FilteredShoeValue.ReportByCatergory("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredShoeValue.Count);
        }

        [TestMethod]
        public void ReportByCatergoryTestDataFound()
        {
            //create an instance of the class containing unfiltered results
            clsShoeValueCollection FilteredShoeValue = new clsShoeValueCollection();
            //var to store outcome
            Boolean OK = true;
            //apply a shoe colour that does not exist
            FilteredShoeValue.ReportByCatergory("Jordan");
            //check that the correct number of records are found
            if (FilteredShoeValue.Count == 2)
            {
                //check that the first record is ID 4
                if (FilteredShoeValue.ShoeValueList[0].ShoeID != 4)
                {
                    OK = false;
                }
                //check that the first record is ID 5
                if (FilteredShoeValue.ShoeValueList[1].ShoeID != 5)
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
