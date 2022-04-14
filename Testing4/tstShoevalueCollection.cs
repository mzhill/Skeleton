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
        public void ShoeValueInstanceOK()
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
        public void CountPropertyOK()
        {
            //create an instance of the class we want to create 
            clsShoeValueCollection AllShoeValue = new clsShoeValueCollection();
            //create some test dT to assign to the property
            Int32 SomeCount = 0;
            //assign the data to the property
            AllShoeValue.Count = SomeCount;
            //test to see that the values are the same
            Assert.AreEqual(AllShoeValue.Count, SomeCount);
        }
        [TestMethod]
        public void ShoeValuePropertyOK()
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

    }
}
