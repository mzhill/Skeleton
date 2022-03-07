using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstShoeValue
    {
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
            Int32 TestData = 1;
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
            Int32 TestData = 1;
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
            Int32 TestData = 1;
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
            Int32 TestData = 1;
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
            Int32 TestData = 1;
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
        public void TestShoeVlaueFound()
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
    }
}
