using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstOrder
    {
        //good test data
        //create some test data to pass to the method
        string OrderDate = DateTime.Now.Date.ToString();
        string Quantity = "10";
        string CustomerUsername = "Testname";

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
        [TestMethod]
        public void FindmethodOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //Bollen variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 OrderID = 23;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestOrderIDFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //Boolean variable to store the results of the validation
            Boolean Found = false;
            //boolen variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderID = 23;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //check the address no 
            if (AnOrder.OrderID != 23)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestDateAddedFound()
        {
            //create an instance of the class you want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderID = 23;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //check the property
            if (AnOrder.OrderDate != Convert.ToDateTime("16/09/2018"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestCustomerUsernameFound()
        {
            //create an instance of the class you want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderID = 23;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //check the property
            if (AnOrder.CustomerUsername != ("Testname"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestNextDayDeliveryFound()
        {
            //create an instance of the class you want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderID = 23;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //check the property
            if (AnOrder.NextDayDelivery != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestQuantityFound()
        {
            //create an instance of the class you want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderID = 23;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //check the property
            if (AnOrder.Quantity != 5)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ValidMethodOK()

        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to stor any error message
            String Error = "";
            //invoke the method 
            Error = AnOrder.Valid(CustomerUsername, Quantity, OrderDate);
            //test to see that the resultis correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerUsernameMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string CustomerUsername = "";
            //invoke the method
            Error = AnOrder.Valid(CustomerUsername, Quantity, OrderDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerUsernameMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string CustomerUsername = "a";
            //invoke the method
            Error = AnOrder.Valid(CustomerUsername, Quantity, OrderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerUsernameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string CustomerUsername = "aa";
            //invoke the method
            Error = AnOrder.Valid(CustomerUsername, Quantity, OrderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerUsernameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string CustomerUsername = "";
            CustomerUsername = CustomerUsername.PadRight(49, 'a');
            //invoke the method
            Error = AnOrder.Valid(CustomerUsername, Quantity, OrderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerUsernameMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string CustomerUsername = "";
            CustomerUsername = CustomerUsername.PadRight(50, 'a');
            //invoke the method
            Error = AnOrder.Valid(CustomerUsername, Quantity, OrderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerUsernameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string CustomerUsername = "";
            CustomerUsername = CustomerUsername.PadRight(51, 'a');
            //invoke the method
            Error = AnOrder.Valid(CustomerUsername, Quantity, OrderDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerUsernameMid()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string CustomerUsername = "";
            CustomerUsername = CustomerUsername.PadRight(25, 'a');
            //invoke the method
            Error = AnOrder.Valid(CustomerUsername, Quantity, OrderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Quantity = "a"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(CustomerUsername, Quantity, OrderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Quantity = "aa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(CustomerUsername, Quantity, OrderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Quantity = "";
            Quantity = Quantity.PadRight(30, 'a'); //this should fail
            //invoke the method
            Error = AnOrder.Valid(CustomerUsername, Quantity, OrderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Quantity = "";
            Quantity = Quantity.PadRight(31, 'a'); //this should fail
            //invoke the method
            Error = AnOrder.Valid(CustomerUsername, Quantity, OrderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMid()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Quantity = "";
            Quantity = Quantity.PadRight(15, 'a'); //this should be ok
            //invoke the method
            Error = AnOrder.Valid(CustomerUsername, Quantity, OrderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Quantity = "";
            Quantity = Quantity.PadRight(32, 'a'); //this should fail
            //invoke the method
            Error = AnOrder.Valid(CustomerUsername, Quantity, OrderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateExtremeMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(CustomerUsername, Quantity, OrderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(CustomerUsername, Quantity, OrderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(CustomerUsername, Quantity, OrderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(CustomerUsername, Quantity, OrderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(CustomerUsername, Quantity, OrderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateInvalidData()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //set the order date to non date value
            string OrderDate = "this is not a date!";
            //invoke the method
            Error = AnOrder.Valid(CustomerUsername, Quantity, OrderDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
    } 
}

