using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing5
{
    [TestClass]
    public class tstStock
    {
        //good test data
        string ShoeDesc = "Air Force 1";
        string ShoeColour = "White";
        string Quantity = "10";
        string InitialReleaseDate = DateTime.Now.Date.ToString();

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


        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 ShoeID = 5;
            //invoke the method
            Found = AStock.Find(ShoeID);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestShoeIDFound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ShoeID = 5;
            //invoke the method
            Found = AStock.Find(ShoeID);
            //check the shoe id
            if (AStock.ShoeID != 5)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestInitialReleaseDateFound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ShoeID = 5;
            //invoke the method
            Found = AStock.Find(ShoeID);
            //check the property
            if (AStock.InitialReleaseDate != Convert.ToDateTime("14/08/2002"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestShoeDescFound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ShoeID = 5;
            //invoke the method
            Found = AStock.Find(ShoeID);
            //check the property
            if (AStock.ShoeDescription != "Air Force 1")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestShoeColourFound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ShoeID = 5;
            //invoke the method
            Found = AStock.Find(ShoeID);
            //check the property
            if (AStock.ShoeColour != "White")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestQuantityFound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ShoeID = 5;
            //invoke the method
            Found = AStock.Find(ShoeID);
            //check the property
            if (AStock.Quantity != 10)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAvailabilityFound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ShoeID = 5;
            //invoke the method
            Found = AStock.Find(ShoeID);
            //check the property
            if (AStock.Availability != true)
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
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = AStock.Valid(ShoeDesc, ShoeColour, Quantity, InitialReleaseDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ShoeDescMinLessOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string ShoeDesc = "";
            //invoke the method
            Error = AStock.Valid(ShoeDesc, ShoeColour, Quantity, InitialReleaseDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ShoeDescMin()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string ShoeDesc = "a";
            //invoke the method
            Error = AStock.Valid(ShoeDesc, ShoeColour, Quantity, InitialReleaseDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ShoeDescMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string ShoeDesc = "aa";
            //invoke the method
            Error = AStock.Valid(ShoeDesc, ShoeColour, Quantity, InitialReleaseDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ShoeDescMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string ShoeDesc = "";
            ShoeDesc = ShoeDesc.PadRight(49, 'a');
            //invoke the method
            Error = AStock.Valid(ShoeDesc, ShoeColour, Quantity, InitialReleaseDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ShoeDescMax()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string ShoeDesc = "";
            ShoeDesc = ShoeDesc.PadRight(50, 'a');
            //invoke the method
            Error = AStock.Valid(ShoeDesc, ShoeColour, Quantity, InitialReleaseDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ShoeDescMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string ShoeDesc = "";
            ShoeDesc = ShoeDesc.PadRight(51, 'a');
            //invoke the method
            Error = AStock.Valid(ShoeDesc, ShoeColour, Quantity, InitialReleaseDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ShoeDescMid()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string ShoeDesc = "";
            ShoeDesc = ShoeDesc.PadRight(25, 'a');
            //invoke the method
            Error = AStock.Valid(ShoeDesc, ShoeColour, Quantity, InitialReleaseDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ShoeColourMinLessOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string ShoeColour = "";
            //invoke the method
            Error = AStock.Valid(ShoeDesc, ShoeColour, Quantity, InitialReleaseDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ShoeColourMin()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string ShoeColour = "a";
            //invoke the method
            Error = AStock.Valid(ShoeDesc, ShoeColour, Quantity, InitialReleaseDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ShoeColourMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string ShoeColour = "aa";
            //invoke the method
            Error = AStock.Valid(ShoeDesc, ShoeColour, Quantity, InitialReleaseDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ShoeColourMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string ShoeColour = "";
            ShoeDesc = ShoeColour.PadRight(49, 'a');
            //invoke the method
            Error = AStock.Valid(ShoeDesc, ShoeColour, Quantity, InitialReleaseDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ShoeColourMax()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string ShoeColour = "";
            ShoeDesc = ShoeColour.PadRight(50, 'a');
            //invoke the method
            Error = AStock.Valid(ShoeDesc, ShoeColour, Quantity, InitialReleaseDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ShoeColourMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string ShoeColour = "";
            ShoeDesc = ShoeColour.PadRight(51, 'a');
            //invoke the method
            Error = AStock.Valid(ShoeDesc, ShoeColour, Quantity, InitialReleaseDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ShoeColourMid()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string ShoeColour = "";
            ShoeDesc = ShoeColour.PadRight(25, 'a');
            //invoke the method
            Error = AStock.Valid(ShoeDesc, ShoeColour, Quantity, InitialReleaseDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMin()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Quantity = "a"; //this should be ok
            //invoke the method
            Error = AStock.Valid(ShoeDesc, ShoeColour, Quantity, InitialReleaseDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Quantity = "aa"; //this should be ok
            //invoke the method
            Error = AStock.Valid(ShoeDesc, ShoeColour, Quantity, InitialReleaseDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Quantity = "";
            Quantity = Quantity.PadRight(30, 'a'); //this should fail
            //invoke the method
            Error = AStock.Valid(ShoeDesc, ShoeColour, Quantity, InitialReleaseDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMax()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Quantity = "";
            Quantity = Quantity.PadRight(31, 'a'); //this should fail
            //invoke the method
            Error = AStock.Valid(ShoeDesc, ShoeColour, Quantity, InitialReleaseDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMid()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Quantity = "";
            Quantity = Quantity.PadRight(15, 'a'); //this should be ok
            //invoke the method
            Error = AStock.Valid(ShoeDesc, ShoeColour, Quantity, InitialReleaseDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Quantity = "";
            Quantity = Quantity.PadRight(32, 'a'); //this should fail
            //invoke the method
            Error = AStock.Valid(ShoeDesc, ShoeColour, Quantity, InitialReleaseDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void InititalReleaseDateExtremeMin()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
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
            Error = AStock.Valid(ShoeDesc, ShoeColour, Quantity, InitialReleaseDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void InititalReleaseDateMinLessOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
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
            Error = AStock.Valid(ShoeDesc, ShoeColour, Quantity, InitialReleaseDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void InititalReleaseDateMin()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AStock.Valid(ShoeDesc, ShoeColour, Quantity, InitialReleaseDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void InititalReleaseDateMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
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
            Error = AStock.Valid(ShoeDesc, ShoeColour, Quantity, InitialReleaseDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void InititalReleaseDateExtremeMax()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
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
            Error = AStock.Valid(ShoeDesc, ShoeColour, Quantity, InitialReleaseDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void InitialReleaseDateInvalidData()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //set the initial release date to non date value
            string InitialReleaseDate = "this is not a date!";
            //invoke the method
            Error = AStock.Valid(ShoeDesc, ShoeColour, Quantity, InitialReleaseDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
    }
}
