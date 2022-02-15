using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing5
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //test to see that it exists
            Assert.IsNotNull(AStock);
        }

        [TestMethod]
        public void ShoeIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data
            Int32 TestData = 1;
            //assign the data to the property
            AStock.ShoeID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.ShoeID, TestData);
        }

        [TestMethod]
        public void ShoeDescriptionPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data
            String TestData = "ExampleText";
            //assign the data to the property
            AStock.ShoeDescription = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.ShoeDescription, TestData);
        }

        [TestMethod]
        public void ShoeColourPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data
            String TestData = "White";
            //assign the data to the property
            AStock.ShoeColour = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.ShoeColour, TestData);
        }

        [TestMethod]
        public void QuantityPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data
            Int32 TestData = 1;
            //assign the data to the property
            AStock.Quantity = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.Quantity, TestData);
        }

        [TestMethod]
        public void AvailabilityPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data
            Boolean TestData = true;
            //assign the data to the property
            AStock.Availability = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.Availability, TestData);
        }

        [TestMethod]
        public void InitialReleaseDatePropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AStock.InitialReleaseDate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.InitialReleaseDate, TestData);
        }
    }
}
