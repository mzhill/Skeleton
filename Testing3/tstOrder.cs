using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstOrder
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to creat
            clsOrder AnOrder = new clsOrder();
            //test to see that it exsits
            Assert.IsNotNull(AnOrder);
        }

        [TestMethod]
        public void OrderIDOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data
            Int32 TestData = 1;
            //assign the data to the property
            AnOrder.OrderID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderID, TestData);
        }

        [TestMethod]
        public void CustomerUsernameOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data
            String TestData = "ExampleText123";
            //assign the data to the property
            AnOrder.CustomerUsername = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.CustomerUsername, TestData);
        }
        [TestMethod]
        public void NextDayDeliveryOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data
            Boolean TestData = true;
            //assign the data to the property
            AnOrder.NextDayDelivery = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.NextDayDelivery, TestData);
        }

        [TestMethod]
        public void OrderDateOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data
            DateTime TestData = Convert.ToDateTime("14/08/2002");
            //assign the data to the property
            AnOrder.OrderDate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderDate, TestData);
        }
        public void QuantityOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data
            Int32 TestData = 1;
            //assign the data to the property
            AnOrder.Quantity = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.Quantity, TestData);
        }
    } 
}

