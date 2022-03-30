using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstShoeValue
    {

        //good test data
        //create some test data to pass to theh method
        string ReleaseDate = DateTime.Now.Date.ToString();
        string RetailPrice = "100";
        string ResalePrice = "160";
        string Catergory = "New Balance";



        [TestMethod]
        public void InststanceOK()
        {
            //create an instance of the class we want to create
            clsShoeValue AnShoeValue = new clsShoeValue();
            //test to see that it exists
            Assert.IsNotNull(AnShoeValue);


        }

        [TestMethod]
        public void ShoeIDOK()
        {
            //create an instance of the class we want to create
            clsShoeValue AnShoeValue = new clsShoeValue();
            //create some test data
            Int32 TestData = 1;
            //assign the data to the property
            AnShoeValue.ShoeID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnShoeValue.ShoeID, TestData);
        }

        [TestMethod]
        public void RetailPriceOK()
        {
            //create an instance of the class we want to create
            clsShoeValue AnShoeValue = new clsShoeValue();
            //create some test data
            String TestData = "160";
            //assign the data to the property
            AnShoeValue.RetailPrice = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnShoeValue.RetailPrice, TestData);
        }

        [TestMethod]
        public void ResalePriceOK()
        {
            //create an instance of the class we want to create
            clsShoeValue AnShoeValue = new clsShoeValue();
            //create some test data
            String TestData = "1300";
            //assign the data to the property
            AnShoeValue.ResalePrice = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnShoeValue.ResalePrice, TestData);
        }

        [TestMethod]
        public void CatergoryOK()
        {
            //create an instance of the class we want to create
            clsShoeValue AnShoeValue = new clsShoeValue();
            //create some test data
            String TestData = "Jordan";
            //assign the data to the property
            AnShoeValue.Catergory = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnShoeValue.Catergory, TestData);
        }

        [TestMethod]
        public void ReleaseDateOK()
        {
            //create an instance of the class we want to create
            clsShoeValue AnShoeValue = new clsShoeValue();
            //create some test data
            DateTime TestData = Convert.ToDateTime("14/08/2002");
            //assign the data to the property
            AnShoeValue.ReleaseDate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnShoeValue.ReleaseDate, TestData);
        }

        [TestMethod]
        public void StockOK()
        {
            //create an instance of the class we want to create
            clsShoeValue AnShoeValue = new clsShoeValue();
            //create some test data
            Boolean TestData = true;
            //assign the data to the property
            AnShoeValue.Stock = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnShoeValue.Stock, TestData);
        }

        [TestMethod]
        public void FindmethodOK()
        {
            //create an instance of the class we want to create
            clsShoeValue AnShoeValue = new clsShoeValue();
            //Bollen variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 ShoeID = 3;
            //invoke the method
            Found = AnShoeValue.Find(ShoeID);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestShoeValueFound()
        {
            //create an instance of the class we want to create
            clsShoeValue AnShoeValue = new clsShoeValue();
            //Bollen variable to store the results of the validation
            Boolean Found = false;
            //boolen variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ShoeID = 3;
            //invoke the method
            Found = AnShoeValue.Find(ShoeID);
            //check the address no 
            if (AnShoeValue.ShoeID != 3)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestShoeIDFound()
        {
            //create an instance of the class we want to create
            clsShoeValue AnShoeValue = new clsShoeValue();
            //Bollen variable to store the results of the validation
            Boolean Found = false;
            //boolen variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ShoeID = 3;
            //invoke the method
            Found = AnShoeValue.Find(ShoeID);
            //check the address no 
            if (AnShoeValue.ShoeID != 3)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void RetailPriceFound()
        {
            //create an instance of the class we want to create
            clsShoeValue AnShoeValue = new clsShoeValue();
            //Bollen variable to store the results of the validation
            Boolean Found = false;
            //boolen variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ShoeID = 3;
            //invoke the method
            Found = AnShoeValue.Find(ShoeID);
            //check the address no 
            if (AnShoeValue.RetailPrice != "100")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ResalePriceFound()
        {
            //create an instance of the class we want to create
            clsShoeValue AnShoeValue = new clsShoeValue();
            //Bollen variable to store the results of the validation
            Boolean Found = false;
            //boolen variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ShoeID = 3;
            //invoke the method
            Found = AnShoeValue.Find(ShoeID);
            //check the address no 
            if (AnShoeValue.ResalePrice != "160")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CatergoryFound()
        {
            //create an instance of the class we want to create
            clsShoeValue AnShoeValue = new clsShoeValue();
            //Bollen variable to store the results of the validation
            Boolean Found = false;
            //boolen variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ShoeID = 3;
            //invoke the method
            Found = AnShoeValue.Find(ShoeID);
            //check the address no 
            if (AnShoeValue.Catergory != "New Balance")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ReleaseDateFound()
        {
            //create an instance of the class we want to create
            clsShoeValue AnShoeValue = new clsShoeValue();
            //Bollen variable to store the results of the validation
            Boolean Found = false;
            //boolen variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ShoeID = 3;
            //invoke the method
            Found = AnShoeValue.Find(ShoeID);
            //check the property
            if (AnShoeValue.ReleaseDate != Convert.ToDateTime("08/04/2022"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void StockFound()
        {
            //create an instance of the class we want to create
            clsShoeValue AnShoeValue = new clsShoeValue();
            //Boolen variable to store the results of the validation
            Boolean Found = false;
            //boolen variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ShoeID = 3;
            //invoke the method
            Found = AnShoeValue.Find(ShoeID);
            //check the address no 
            if (AnShoeValue.Stock != true)
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
            clsShoeValue AnShoeValue = new clsShoeValue();
            //string variable to stor any error message
            String Error = "";
            //invoke the method 
            Error = AnShoeValue.Valid(ReleaseDate, RetailPrice, ResalePrice, Catergory);
            //test to see that the resultis correct 
            Assert.AreEqual(Error, "");


        }

        [TestMethod]
        public void RetailPriceMinLessOne()

        {
            //ceate an isurance of the class we want to create
            clsShoeValue AnShoeValue = new clsShoeValue();
            //sring variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string RetailPrice = ""; //this should trigger an error 
            //invoke the method
            Error = AnShoeValue.Valid(ReleaseDate, RetailPrice, ResalePrice, Catergory);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");



        }
        [TestMethod]
        public void RetailPriceMin()

        {
            //ceate an isurance of the class we want to create
            clsShoeValue AnShoeValue = new clsShoeValue();
            //sring variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string RetailPrice = "a"; //this should trigger an error 
            //invoke the method
            Error = AnShoeValue.Valid(ReleaseDate, RetailPrice, ResalePrice, Catergory);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");


        }
        [TestMethod]
        public void RetailPricePlusOne()

        {
            //ceate an isurance of the class we want to create
            clsShoeValue AnShoeValue = new clsShoeValue();
            //sring variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string RetailPrice = "aa"; //this should trigger an error 
            //invoke the method
            Error = AnShoeValue.Valid(ReleaseDate, RetailPrice, ResalePrice, Catergory);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void RetailPriceLessOne()

        {
            //ceate an isurance of the class we want to create
            clsShoeValue AnShoeValue = new clsShoeValue();
            //sring variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string RetailPrice = "aa"; //this should trigger an error 
            //invoke the method
            Error = AnShoeValue.Valid(ReleaseDate, RetailPrice, ResalePrice, Catergory);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");


        }
        [TestMethod]
        public void RetailPriceMaxLessOne()

        {
            //ceate an isurance of the class we want to create
            clsShoeValue AnShoeValue = new clsShoeValue();
            //sring variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string RetailPrice = "aaaaa"; //this should trigger an error 
            //invoke the method
            Error = AnShoeValue.Valid(ReleaseDate, RetailPrice, ResalePrice, Catergory);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void RetailPriceMax()

        {
            //ceate an isurance of the class we want to create
            clsShoeValue AnShoeValue = new clsShoeValue();
            //sring variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string RetailPrice = "aaaaaa"; //this should trigger an error 
            //invoke the method
            Error = AnShoeValue.Valid(ReleaseDate, RetailPrice, ResalePrice, Catergory);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void RetailPriceMid()

        {
            //ceate an isurance of the class we want to create
            clsShoeValue AnShoeValue = new clsShoeValue();
            //sring variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string RetailPrice = "aaa"; //this should trigger an error 
            //invoke the method
            Error = AnShoeValue.Valid(ReleaseDate, RetailPrice, ResalePrice, Catergory);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void RetailPlussOne()

        {
            //ceate an isurance of the class we want to create
            clsShoeValue AnShoeValue = new clsShoeValue();
            //sring variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string RetailPrice = "aaaaaaa"; //this should trigger an error 
                                            //invoke the method
            Error = AnShoeValue.Valid(ReleaseDate, RetailPrice, ResalePrice, Catergory);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void ReleaseDateExtremeMin()

        {
            //ceate an isurance of the class we want to create
            clsShoeValue AnShoeValue = new clsShoeValue();
            //string variable to story any error message
            string Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totdays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string ReleaseDate = TestDate.ToString();
            //invoke the method
            Error = AnShoeValue.Valid(ReleaseDate, RetailPrice, ResalePrice, Catergory);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");


        }

        [TestMethod]
        public void ReleaseDateMinLessOne()

        {
            //ceate an isurance of the class we want to create
            clsShoeValue AnShoeValue = new clsShoeValue();
            //string variable to story any error message
            string Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totdays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-1);
            //convert the date variable to a string variable
            string ReleaseDate = TestDate.ToString();
            //invoke the method
            Error = AnShoeValue.Valid(ReleaseDate, RetailPrice, ResalePrice, Catergory);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void ReleaseDateMin()

        {
            //ceate an isurance of the class we want to create
            clsShoeValue AnShoeValue = new clsShoeValue();
            //string variable to story any error message
            string Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totdays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string ReleaseDate = TestDate.ToString();
            //invoke the method
            Error = AnShoeValue.Valid(ReleaseDate, RetailPrice, ResalePrice, Catergory);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void ReleaseDateMinPlusOne()

        {
            //ceate an isurance of the class we want to create
            clsShoeValue AnShoeValue = new clsShoeValue();
            //string variable to story any error message
            string Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totdays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(1);
            //convert the date variable to a string variable
            string ReleaseDate = TestDate.ToString();
            //invoke the method
            Error = AnShoeValue.Valid(ReleaseDate, RetailPrice, ResalePrice, Catergory);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ReleaseDateExtremeMax()

        {
            //ceate an isurance of the class we want to create
            clsShoeValue AnShoeValue = new clsShoeValue();
            //string variable to story any error message
            string Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totdays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string ReleaseDate = TestDate.ToString();
            //invoke the method
            Error = AnShoeValue.Valid(ReleaseDate, RetailPrice, ResalePrice, Catergory);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void ReleaseDateInvalidData()

        {
            //ceate an isurance of the class we want to create
            clsShoeValue AnShoeValue = new clsShoeValue();
            //string variable to story any error message
            string Error = "";
            //set the ReleaseDate to a non date value
            String ReleaseDate = "this is not a date!";
            //invoke the method
            Error = AnShoeValue.Valid(ReleaseDate, RetailPrice, ResalePrice, Catergory);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }
    }
}
